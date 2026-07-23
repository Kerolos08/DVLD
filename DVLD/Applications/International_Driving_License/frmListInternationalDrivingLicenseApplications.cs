using DVLD.Licenses;
using DVLD.Licenses.International_Licenses;
using DVLD.Licenses.Local_Licenses;
using DVLD.People;
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

namespace DVLD.Applications.International_Driving_License
{
    public partial class frmListInternationalDrivingLicenseApplications : Form
    {
        private DataTable _dtApplications;
        public frmListInternationalDrivingLicenseApplications()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> FilteringColumnHeadersWithNames = new Dictionary<string, string>()
        {
            {"International License ID", "InternationalLicenseID"},
            {"Application ID", "ApplicationID"},
            {"Driver ID", "DriverID"},
            {"Local License ID", "IssuedUsingLocalLicenseID"},
            {"Is Active", "IsActive"}
        };

        private void RefreshGridView()
        {
            _dtApplications = clsInternationalLicenseApplication.GetAllInternationalLicenses();
            dgvApplications.DataSource = _dtApplications;
            lblRecordCount.Text = $"Records:{_dtApplications.Rows.Count}";
        }

        private void frmListInternationalDrivingLicenseApplications_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            cmbFilterBy.SelectedIndex = 0;
            cmbActiveFilters.Visible = false;
            txtSearch.Visible = false;

            if (dgvApplications.Rows.Count > 0)
            {

                dgvApplications.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
                dgvApplications.Columns["ApplicationID"].HeaderText = "Application ID";
                dgvApplications.Columns["DriverID"].HeaderText = "Driver ID";
                dgvApplications.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
                dgvApplications.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvApplications.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvApplications.Columns["IsActive"].HeaderText = "Is Active";
            }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbActiveFilters.Visible = cmbFilterBy.Text == "Is Active";
            txtSearch.Visible = (cmbFilterBy.Text != "None" && !(cmbFilterBy.Text == "Is Active"));

            if (cmbActiveFilters.Visible)
            {
                cmbActiveFilters.SelectedIndex = 0;
                cmbActiveFilters.Focus();
            }
            else if (txtSearch.Visible)
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

        private void cmbActiveFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActiveFilters.Text == "Yes")
                _dtApplications.DefaultView.RowFilter = "IsActive = 1";
            else if (cmbActiveFilters.Text == "No")
                _dtApplications.DefaultView.RowFilter = "IsActive = 0";
            else
                _dtApplications.DefaultView.RowFilter = "";


            lblRecordCount.Text = $"Records:{_dtApplications.Rows.Count}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "None" || string.IsNullOrEmpty(cmbFilterBy.Text) || !FilteringColumnHeadersWithNames.ContainsKey(cmbFilterBy.Text))
            {
                _dtApplications.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records:{_dtApplications.Rows.Count}";
                return;
            }

            string FilterColumn = FilteringColumnHeadersWithNames[cmbFilterBy.Text];

            if (FilterColumn != "IsActive")
            {
                if (int.TryParse(txtSearch.Text, out int ID))
                    _dtApplications.DefaultView.RowFilter = $"{FilterColumn} = {ID}";
            }

            lblRecordCount.Text = $"Records:{_dtApplications.Rows.Count}";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text != "IsActive")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvApplications.CurrentRow.Cells["DriverID"].Value;
            int PersonID = clsDriver.FindDriverByDriverID(DriverID).PersonID;

            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowDriverInternationalLicenseInfo frm = new frmShowDriverInternationalLicenseInfo((int)dgvApplications.CurrentRow.Cells["InternationalLicenseID"].Value);
            frm.ShowDialog();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvApplications.CurrentRow.Cells["DriverID"].Value;
            int PersonID = clsDriver.FindDriverByDriverID(DriverID).PersonID;

            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(PersonID);
            frm.ShowDialog();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            frmNewInternationalDrivingLicenseApplication frm = new frmNewInternationalDrivingLicenseApplication();
            frm.ShowDialog();
            RefreshGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
