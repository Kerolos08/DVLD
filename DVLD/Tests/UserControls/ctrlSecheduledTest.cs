using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DVLD_BusinessLayer.clsTestType;

namespace DVLD.Tests.UserControls
{
    public partial class ctrlSecheduledTest : UserControl
    {
        private int _TestAppointmentID;
        private clsTestType.enTestType _TestType;
        private int _LocalDrivingLicenseApplicationID;
        clsTestAppointment _TestAppointment;
        public int TestAppointmentID
        {
            get
            {
                return _TestAppointmentID;
            }
        }

        public clsTestAppointment TestAppointmentInfo
        {
            get
            {
                return _TestAppointment;
            }
        }

        public ctrlSecheduledTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int TestAppointmentID, clsTestType.enTestType TestType)
        {
            _TestAppointmentID = TestAppointmentID;
            _TestType = TestType;

            SetFormApperance();

            _TestAppointment = clsTestAppointment.FindScheduledTestAppointment(_TestAppointmentID);
            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No  Appointment ID = " + _TestAppointmentID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LocalDrivingLicenseApplicationID = _TestAppointment.LocalDrivingLicenseApplicationID;

            clsLocalDrivingLicenseApplication LocalDrivingLicenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(_LocalDrivingLicenseApplicationID);
            if (LocalDrivingLicenseApplication == null)
            {
                MessageBox.Show("Error: No Local Driving License Application with ID = " + _LocalDrivingLicenseApplicationID.ToString(),"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDLAppID.Text = LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClassValue.Text = clsLicenseClass.GetLicenseClassObj(LocalDrivingLicenseApplication.LicenseClassID).ClassName;
            lblNameValue.Text = clsPerson.Find(LocalDrivingLicenseApplication.ApplicantPersonID).FullName;
            lblTrailsValue.Text = clsLocalDrivingLicenseApplication.TotalTrialsForTest(LocalDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _TestType).ToString();
            lblFees.Text = _TestAppointment.PaidFees.ToString();
            lblDataValue.Text = _TestAppointment.AppointmentDate.ToShortDateString();
            lblTestIDValue.Text = _TestAppointment.TestAppointmentID.ToString();
            lblTestIDValue.Text = (_TestAppointment.TestID == null ? "Test Not Taken Yet" : _TestAppointment.TestID.ToString());
        }

        private void SetFormApperance()
        {
            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        picImage.Image = Resources.Vision_Test;
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        picImage.Image = Resources.Writen_Test;
                        break;
                    }

                case clsTestType.enTestType.StreetTest:
                    {
                        picImage.Image = Resources.Street_Test;
                        break;
                    }
            }
        }
    }
}
