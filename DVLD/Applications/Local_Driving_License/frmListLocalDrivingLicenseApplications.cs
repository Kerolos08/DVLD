using DVLD.Licenses;
using DVLD.Licenses.Local_Licenses;
using DVLD.Tests;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmListLocalDrivingLicenseApplications : Form
    {
        private DataTable _dtApplications;
        public frmListLocalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> _FilteringColumnHeaderNames = new Dictionary<string, string>()
        {
            {"LDL.App ID", "LocalDrivingLicenseApplicationID"},
            {"National No.", "NationalNo"},
            {"Full Name",  "FullName"},
            {"Status", "Status"}
        };
        private void RefreshList()
        {
            _dtApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();
            lblRecordCount.Text = $"Records: {_dtApplications.Rows.Count}";
            dgvApplications.DataSource = _dtApplications;
        }

        private void frmListLocalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshList();
            cmbFilterBy.SelectedIndex = 0;
            txtSearch.Visible = false;
            if (dgvApplications.Rows.Count > 0)
            {
                dgvApplications.Columns["LocalDrivingLicenseApplicationID"].HeaderText = "LDL.App ID";
                dgvApplications.Columns["ClassName"].HeaderText = "Driving Class";
                dgvApplications.Columns["NationalNo"].HeaderText = "National No.";
                dgvApplications.Columns["FullName"].HeaderText = "Full Name";
                dgvApplications.Columns["ApplicationDate"].HeaderText = "Application Date";
                dgvApplications.Columns["PassedTestCount"].HeaderText = "Passed Tests";
                dgvApplications.Columns["Status"].HeaderText = "Status";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "None" || string.IsNullOrEmpty(cmbFilterBy.Text.Trim()) || !_FilteringColumnHeaderNames.ContainsKey(cmbFilterBy.Text))
            {
                _dtApplications.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtApplications.Rows.Count}";
                return;
            }

            string FilterColumn = _FilteringColumnHeaderNames[cmbFilterBy.Text];

            if (FilterColumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtSearch.Text.Trim(), out int ID))
                    _dtApplications.DefaultView.RowFilter = $"[{FilterColumn}] = {ID}";
            }

            else
            {
                _dtApplications.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtSearch.Text.Trim()}%'";
            }

            lblRecordCount.Text = $"Records: {_dtApplications.Rows.Count}";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "LDL.App ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cmbFilterBy.Text != "None");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                _dtApplications.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtApplications.Rows.Count}";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenceApplicaiton frmAdd = new frmAddUpdateLocalDrivingLicenceApplicaiton();
            frmAdd.ShowDialog();
            RefreshList();
        }

        private void ScheduleTest(clsTestType.enTestType TestTypeID)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            frmListAllTestAppointmentsForLicenseAppID ListAppointments = new frmListAllTestAppointmentsForLicenseAppID(LicenseApplicationID, TestTypeID);
            ListAppointments.ShowDialog();
            RefreshList();
        }

        private void visionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsTestType.enTestType.VisionTest);
        }

        private void writenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsTestType.enTestType.WrittenTest);
        }

        private void streetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleTest(clsTestType.enTestType.StreetTest);
        }

        private void EditApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            frmAddUpdateLocalDrivingLicenceApplicaiton frmEdit = new frmAddUpdateLocalDrivingLicenceApplicaiton(LicenseApplicationID);
            frmEdit.ShowDialog();
            RefreshList();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            frmLocalDrivingLicenseApplicationInfo frmInfo = new frmLocalDrivingLicenseApplicationInfo(LicenseApplicationID);
            frmInfo.ShowDialog();
        }

        private void CancelApplicationtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication licenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(LicenseApplicationID);
            if (licenseApplication == null)
            {
                return;
            }

            if (licenseApplication.Cancel())
            {
                MessageBox.Show("License Application Set as Cancelled Successfully", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Error, Can not Cancel the Application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Request", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication licenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(LicenseApplicationID);
            if (licenseApplication == null)
            {
                return;
            }

            if (licenseApplication.DeleteLocalDrivingLicenseApplication())
            {
                MessageBox.Show("License Application Deleted Successfully", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshList();
            }
            else
            {
                MessageBox.Show("Error, Can not be deleted to ensure data integrity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmsOptions_Opening(object sender, CancelEventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            clsLocalDrivingLicenseApplication licenseApplication = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(LicenseApplicationID);

            int PassedTests = (int)dgvApplications.CurrentRow.Cells["PassedTestCount"].Value;

            bool LicenseExist = licenseApplication.IsLicenseIssued();

            EditApplicationToolStripMenuItem.Enabled = !LicenseExist && (licenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);

            deleteToolStripMenuItem.Enabled = licenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New;

            CancelApplicationtoolStripMenuItem.Enabled = licenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New;

            ScheduleTeststoolStripMenuItem.Enabled = !LicenseExist;

            IssueLicensetoolStripMenuItem.Enabled = PassedTests == 3 && !LicenseExist;

            ShowLicensetoolStripMenuItem.Enabled = LicenseExist;

            PersonLicenseHistorytoolStripMenuItem.Enabled = LicenseExist;

            bool PassVisionTest = licenseApplication.DoesPassedLastTestType(clsTestType.enTestType.VisionTest);
            bool PassWrittenTest = licenseApplication.DoesPassedLastTestType(clsTestType.enTestType.WrittenTest);
            bool PassStreetTest = licenseApplication.DoesPassedLastTestType(clsTestType.enTestType.StreetTest);

            ScheduleTeststoolStripMenuItem.Enabled = (!PassVisionTest || !PassWrittenTest || !PassStreetTest) && licenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New;

            if (ScheduleTeststoolStripMenuItem.Enabled)
            {
                visionTestToolStripMenuItem.Enabled = !PassVisionTest;
                writenTestToolStripMenuItem.Enabled = PassVisionTest && !PassWrittenTest;
                streetTestToolStripMenuItem.Enabled = PassVisionTest && PassWrittenTest && !PassStreetTest;
            }
        }

        private void IssueLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;
            frmIssueLicenseFirstTime frmIssue = new frmIssueLicenseFirstTime(LicenseApplicationID);
            frmIssue.ShowDialog();
            RefreshList();
        }

        private void ShowLicensetoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            int LicenseID = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(LicenseApplicationID).GetActiveLicenseID();


            if (LicenseID != 0)
            {
                frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("No License Found!", "No License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void PersonLicenseHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseApplicationID = (int)dgvApplications.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication LDLAppID = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(LicenseApplicationID);

            frmShowPersonLicensesHistory frmHistory = new frmShowPersonLicensesHistory(LDLAppID.ApplicantPersonID);
            frmHistory.ShowDialog();
        }
    }
}
