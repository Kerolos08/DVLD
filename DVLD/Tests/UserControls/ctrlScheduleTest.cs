using DVLD.Global_Classes;
using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DVLD.Tests.UserControls
{
    public partial class ctrlScheduleTest : UserControl
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enum enCreationReason { FirstTime = 0, Retake = 1 };

        private enMode _Mode;
        private enCreationReason _creationReason;

        private int _TestAppointmentID;
        private clsTestAppointment _TestAppointment;
        private clsLocalDrivingLicenseApplication _LocalDrivingLicenseAppliacaiton;

        private clsTestType.enTestType _TestType = clsTestType.enTestType.VisionTest;

        public ctrlScheduleTest()
        {
            InitializeComponent();
        }

        public void LoadInfo(int AppicationID, clsTestType.enTestType TestTypeID, int TestAppointment = -1)
        {
            _TestType = TestTypeID;
            _TestAppointmentID = TestAppointment;
            _LocalDrivingLicenseAppliacaiton = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(AppicationID);

            if (_LocalDrivingLicenseAppliacaiton == null)
            {
                MessageBox.Show($"License Application ID {AppicationID} Does not match any Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SetFormApperance();
            SetFormModes();
            LoadLocalDrivingLicenceApplicationData();

            if (_Mode == enMode.AddNew)
            {
                _TestAppointment = new clsTestAppointment();

                if (_creationReason == enCreationReason.FirstTime)
                {
                    lblTitle.Text = "Schedule New Test";
                    pnlRetakeTest.Enabled = false;
                    dtpDate.MinDate = DateTime.Today;
                    lblRetakeTestAppIDValue.Text = "N/A";
                    lblRetakeTestFeesValue.Text = "0";
                    lblTotalFeesValue.Text = "N/A";
                }
                else
                {
                    lblTitle.Text = "Schedule Retake Test";
                    pnlRetakeTest.Enabled = true;
                    dtpDate.MinDate = DateTime.Today;
                    lblRetakeTestAppIDValue.Text = "N/A";
                    lblRetakeTestFeesValue.Text = clsApplicationType.GetApplicationTypeObj(7).ApplicationFees.ToString();
                    lblTotalFeesValue.Text = (Convert.ToDecimal(lblFees.Text) + Convert.ToDecimal(lblRetakeTestFeesValue.Text)).ToString();
                }
            }
            else
            {
                LoadTestAppointment();
            }


            if (!CheckForActiveAppointment())
                return;

            if (!CheckForPassingPreviousTest())
                return;

            if (!CheckIfTestAlreadyPassed())
                return;

            if (!CheckIfAppointmentLocked())
                return;
        }

        private void SetFormApperance()
        {
            switch (_TestType)
            {
                case clsTestType.enTestType.VisionTest:
                    {
                        picImage.Image = Resources.Vision_Test;
                        lblTitle.Text = "Schedule Vision Test";
                        break;
                    }

                case clsTestType.enTestType.WrittenTest:
                    {
                        picImage.Image = Resources.Writen_Test;
                        lblTitle.Text = "Schedule Written Test";
                        break;
                    }

                case clsTestType.enTestType.StreetTest:
                    {
                        picImage.Image = Resources.Street_Test;
                        lblTitle.Text = "Schedule Street Test";
                        break;
                    }
            }
        }

        private void SetFormModes()
        {
            if (_TestAppointmentID == -1)
                _Mode = enMode.AddNew;
            else
                _Mode = enMode.Update;

            if (!_LocalDrivingLicenseAppliacaiton.DoesAttendTestType(_TestType))
                _creationReason = enCreationReason.FirstTime;
            else
                _creationReason = enCreationReason.Retake;
        }

        private void LoadLocalDrivingLicenceApplicationData()
        {
            lblDLAppID.Text = _LocalDrivingLicenseAppliacaiton.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClassValue.Text = clsLicenseClass.GetLicenseClassObj(_LocalDrivingLicenseAppliacaiton.LicenseClassID).ClassName;
            lblNameValue.Text = clsPerson.Find(_LocalDrivingLicenseAppliacaiton.ApplicantPersonID).FullName;
            lblTrailsValue.Text = clsLocalDrivingLicenseApplication.TotalTrialsForTest(_LocalDrivingLicenseAppliacaiton.LocalDrivingLicenseApplicationID, _TestType).ToString();
            lblFees.Text = clsTestType.GetTestTypeObj((int)_TestType).TestTypeFees.ToString();
        }
        private void LoadTestAppointment()
        {
            _TestAppointment = clsTestAppointment.FindScheduledTestAppointment(_TestAppointmentID);

            if (_TestAppointment == null)
            {
                MessageBox.Show("Error: No Appointment with ID = " + _TestAppointmentID.ToString(),
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }


            dtpDate.Value = _TestAppointment.AppointmentDate;
            lblFees.Text = _TestAppointment.PaidFees.ToString();

            if (_TestAppointment.RetakeTestApplicationID == null)
            {
                pnlRetakeTest.Enabled = false;
                lblRetakeTestAppIDValue.Text = "N/A";
                lblRetakeTestFeesValue.Text = "0";
                lblTotalFeesValue.Text = "[????]";
            }
            else
            {
                pnlRetakeTest.Enabled = true;
                lblRetakeTestAppIDValue.Text = _TestAppointment.RetakeTestApplicationID.Value.ToString();
                lblRetakeTestFeesValue.Text = (clsApplication.FindByBaseApplicationID(_TestAppointment.RetakeTestApplicationID.Value).PaidFees).ToString();
                lblTotalFeesValue.Text = (Convert.ToDecimal(lblFees.Text) + Convert.ToDecimal(lblRetakeTestFeesValue.Text)).ToString();
            }
        }

        private void BlockScheduling(string message)
        {
            lblErrorMessage.Visible = true;
            lblErrorMessage.Text = message;

            btnSave.Enabled = false;
            dtpDate.Enabled = false;
        }

        private bool CheckForActiveAppointment()
        {
            if (_Mode == enMode.AddNew && clsLocalDrivingLicenseApplication.HasOpenTestAppointment(_LocalDrivingLicenseAppliacaiton.LocalDrivingLicenseApplicationID, _TestType))
            {
                BlockScheduling("Applicant has an open/active appointment for this test");
                return false;
            }
            return true;
        }

        private bool CheckForPassingPreviousTest()
        {
            if (_Mode == enMode.AddNew && !_LocalDrivingLicenseAppliacaiton.DoesPassPerviousTestType(_TestType))
            {
                BlockScheduling("Previous test should be passed before Schedule an appointment for this test");
                return false;
            }
            return true;
        }

        private bool CheckIfTestAlreadyPassed()
        {
            if (_Mode != enMode.AddNew)
            {
                return true;
            }

            clsTest LastTest = _LocalDrivingLicenseAppliacaiton.GetLastTestResult(_TestType);

            if (LastTest != null && LastTest.TestResult)
            {
                BlockScheduling("Cannot be Scheduled, Applicant already passed this test");
                return false;
            }

            return true;
        }

        private bool CheckIfAppointmentLocked ()
        {
            if (_Mode == enMode.Update && _TestAppointment.IsLocked)
            {
                BlockScheduling("Person already sat for this test, Appointment loacked");
                return false;
            }
            return true;
        }

        private bool HandleRetakeTest()
        {
            if (_Mode == enMode.AddNew && _creationReason == enCreationReason.Retake)
            {
                clsApplication RetakeApplication = new clsApplication();

                RetakeApplication.ApplicantPersonID = _LocalDrivingLicenseAppliacaiton.ApplicantPersonID;
                RetakeApplication.ApplicationDate = DateTime.Now;
                RetakeApplication.ApplicationStatus = clsApplication.enApplicationStatus.New;
                RetakeApplication.ApplicationType = clsApplication.enApplicationType.RetakeTest;
                RetakeApplication.LastStatusDate = DateTime.Now;
                RetakeApplication.PaidFees = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.RetakeTest).ApplicationFees;
                RetakeApplication.CreatedByUserID = clsGlobal.CurrentUser.UserID;

                if (RetakeApplication.Save())
                {
                    _TestAppointment.RetakeTestApplicationID = RetakeApplication.ApplicationID;
                    //TestAppointment fees = 0 so += new retake test fees
                    _TestAppointment.PaidFees += RetakeApplication.PaidFees;
                    lblRetakeTestAppIDValue.Text = _TestAppointment.RetakeTestApplicationID.ToString();
                    return true;
                }
                else
                {
                    MessageBox.Show("Failed to save the retake application for this appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!HandleRetakeTest())
                return;

            _TestAppointment.TestTypeID = (int)_TestType;
            _TestAppointment.LocalDrivingLicenseApplicationID = _LocalDrivingLicenseAppliacaiton.LocalDrivingLicenseApplicationID;
            _TestAppointment.AppointmentDate = dtpDate.Value;
            //TestAppointment fees = 0 or the retake test application fees so += the test fees
            if (_Mode == enMode.AddNew)
            {
                _TestAppointment.PaidFees += Convert.ToDecimal(lblFees.Text);
            }
            _TestAppointment.CreatedByUserID = clsGlobal.CurrentUser.UserID;
            _TestAppointment.IsLocked = false;

            if (_TestAppointment.Save())
            {
                _Mode = enMode.Update;
                MessageBox.Show($"New Appintment Saved Successfully With ID: {_TestAppointment.TestAppointmentID}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Failed to save the new appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
