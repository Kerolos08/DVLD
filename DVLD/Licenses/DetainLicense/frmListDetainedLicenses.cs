using DVLD.Applications.Release_Detained_License;
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

namespace DVLD.Licenses.DetainLicense
{
    public partial class frmListDetainedLicenses : Form
    {
        private DataTable _dtLicenses;
        public frmListDetainedLicenses()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> FilteringColumnHeadersWithNames = new Dictionary<string, string>()
        {
            {"Detain ID", "DetainID"},
            {"Is Released", "IsReleased"},
            {"National No.", "NationalNo"},
            {"Full Name", "FullName"},
            {"Release Application ID", "ReleaseApplicationID"}
        };

        private void RefreshGridView()
        {
            _dtLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtLicenses;
            lblRecordCount.Text = $"Records:{_dtLicenses.Rows.Count}";
        }

        private void frmListDetainedLicenses_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            cmbFilterBy.SelectedIndex = 0;
            cmbReleasedFilters.Visible = false;
            txtSearch.Visible = false;

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns["DetainID"].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns["LicenseID"].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns["DetainDate"].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns["IsReleased"].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns["FineFees"].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns["ReleaseDate"].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns["NationalNo"].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns["FullName"].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns["ReleaseApplicationID"].HeaderText = "Rlease App.ID";
            }
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbReleasedFilters.Visible = cmbFilterBy.Text == "Is Released";
            txtSearch.Visible = (cmbFilterBy.Text != "None" && !(cmbFilterBy.Text == "Is Released"));

            if (cmbReleasedFilters.Visible)
            {
                cmbReleasedFilters.SelectedIndex = 0;
                cmbReleasedFilters.Focus();
            }
            else if (txtSearch.Visible)
            {

                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                _dtLicenses.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtLicenses.Rows.Count}";
            }
        }

        private void cmbActiveFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbReleasedFilters.Text == "Yes")
                _dtLicenses.DefaultView.RowFilter = "IsReleased = 1";
            else if (cmbReleasedFilters.Text == "No")
                _dtLicenses.DefaultView.RowFilter = "IsReleased = 0";
            else
                _dtLicenses.DefaultView.RowFilter = "";


            lblRecordCount.Text = $"Records:{_dtLicenses.Rows.Count}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "None" || string.IsNullOrEmpty(cmbFilterBy.Text) || !FilteringColumnHeadersWithNames.ContainsKey(cmbFilterBy.Text))
            {
                _dtLicenses.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records:{_dtLicenses.Rows.Count}";
                return;
            }

            string FilterColumn = FilteringColumnHeadersWithNames[cmbFilterBy.Text];

            if (FilterColumn == "DetainID" || FilterColumn == "ReleaseApplicationID")
            {
                if (int.TryParse(txtSearch.Text, out int ID))
                    _dtLicenses.DefaultView.RowFilter = $"{FilterColumn} = {ID}";
            }

            else if (FilterColumn == "FullName" || FilterColumn == "NationalNo")
            {
                _dtLicenses.DefaultView.RowFilter = $"{FilterColumn} LIKE '{txtSearch.Text.Trim()}%'";
            }

            lblRecordCount.Text = $"Records:{_dtLicenses.Rows.Count}";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Detain ID" || cmbFilterBy.Text == "Release Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnDetainLicense_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            RefreshGridView();
        }

        private void btnReleaseLicense_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication();
            frm.ShowDialog();
            RefreshGridView();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = clsLicense.GetLicenseObj((int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value).DriverID;
            int PersonID = clsDriver.FindDriverByDriverID(DriverID).PersonID;

            frmShowPersonInfo frm = new frmShowPersonInfo(PersonID);
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo((int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value);
            frm.ShowDialog();
        }

        private void showPersonLicensesHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = clsLicense.GetLicenseObj((int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value).DriverID;
            int PersonID = clsDriver.FindDriverByDriverID(DriverID).PersonID;

            frmShowPersonLicensesHistory frm = new frmShowPersonLicensesHistory(PersonID);
            frm.ShowDialog();
        }

        private void releasedDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells["LicenseID"].Value;
            frmReleaseDetainedLicenseApplication frm = new frmReleaseDetainedLicenseApplication(LicenseID);
            frm.ShowDialog();
            RefreshGridView();
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            releasedDetainedLicenseToolStripMenuItem.Enabled = !(bool)dgvDetainedLicenses.CurrentRow.Cells["IsReleased"].Value;
        }
    }
}
