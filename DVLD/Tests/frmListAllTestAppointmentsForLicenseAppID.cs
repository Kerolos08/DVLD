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
using System.Windows.Forms.VisualStyles;

namespace DVLD.Tests
{
    public partial class frmListAllTestAppointmentsForLicenseAppID : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        private clsTestType.enTestType _TestTypeID;
        private DataTable _dtAppointments;
        public frmListAllTestAppointmentsForLicenseAppID(int LocalDrivingLicenseAppID, clsTestType.enTestType TestTypeID)
        {
            InitializeComponent();
            _TestTypeID = TestTypeID;
            _LocalDrivingLicenseApplicationID = LocalDrivingLicenseAppID;
        }

        private void RefreshList ()
        {
            _dtAppointments = clsTestAppointment.FindAllTestAppointmentsForTestAndLocalDrivingLicenseApplicationID(_LocalDrivingLicenseApplicationID, (int)_TestTypeID);
            dgvAppointments.DataSource = _dtAppointments;
            lblRecordCount.Text = $"Records: {_dtAppointments.Rows.Count}";
        }

        private void LoadFormImageAndLabels ()
        {
            switch (_TestTypeID)
            {
                case clsTestType.enTestType.VisionTest:
                    picImage.Image = Resources.Vision_Test;
                    lblTitle.Text = "Vision Test Appointments";
                    this.Text = lblTitle.Text;
                    break;

                case clsTestType.enTestType.WrittenTest:
                    picImage.Image = Resources.Writen_Test;
                    lblTitle.Text = "Written Test Appointments";
                    this.Text = lblTitle.Text;
                    break;

                case clsTestType.enTestType.StreetTest:
                    picImage.Image = Resources.Street_Test;
                    lblTitle.Text = "Street Test Appointments";
                    this.Text = lblTitle.Text;
                    break;
            }
        }

        private void clsListAllTestAppointmentsForLicenseAppID_Test_Load(object sender, EventArgs e)
        {
            LoadFormImageAndLabels();
            ctrlLocalDrivingLicenseAppInfo1.LoadLocalLicenseApplicationInfo(_LocalDrivingLicenseApplicationID);
            RefreshList();
            if (dgvAppointments.Rows.Count > 0)
            {
                dgvAppointments.Columns["TestAppointmentID"].HeaderText = "Appointment ID";
                dgvAppointments.Columns["AppointmentDate"].HeaderText = "Appointment Date";
                dgvAppointments.Columns["PaidFees"].HeaderText = "Paid Fees";
                dgvAppointments.Columns["IsLocked"].HeaderText = "Is Locked";
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmTakeTest frmTake = new frmTakeTest(TestAppointmentID, _TestTypeID);
            frmTake.ShowDialog();
            RefreshList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestAppointmentID = (int)dgvAppointments.CurrentRow.Cells[0].Value;
            frmScheduleTest frmEdit = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID, TestAppointmentID);
            frmEdit.ShowDialog();
            RefreshList();
        }

        private void btnAddAppointment_Click(object sender, EventArgs e)
        {
            if (clsLocalDrivingLicenseApplication.HasOpenTestAppointment(_LocalDrivingLicenseApplicationID, _TestTypeID))
            {
                MessageBox.Show("Person already have and active test appointment for this test, You can not add new appointment", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmScheduleTest frm = new frmScheduleTest(_LocalDrivingLicenseApplicationID, _TestTypeID);
            frm.ShowDialog();
            RefreshList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
