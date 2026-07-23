using DVLD.Licenses;
using DVLD.People;
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

namespace DVLD.Drivers
{
    public partial class frmListDrivers : Form
    {
        private DataTable _dtDrivers;
        public frmListDrivers()
        {
            InitializeComponent();
        }

        private Dictionary<string, string> _FilteringColumnHeaderNames = new Dictionary<string, string>()
        {
            {"Driver ID", "DriverID"},
            {"Person ID", "PersonID"},
            {"National No.", "NationalNo"},
            {"Full Name", "FullName"},
        };

        private void RefreshList ()
        {
            _dtDrivers = clsDriver.GetAllDrivers();
            lblRecordCount.Text = $"Records: {_dtDrivers.Rows.Count}";
            dgvDrivers.DataSource = _dtDrivers;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "None" || string.IsNullOrEmpty(cmbFilterBy.Text.Trim()) || !_FilteringColumnHeaderNames.ContainsKey(cmbFilterBy.Text))
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtDrivers.Rows.Count}";
                return;
            }

            string FilterColumn = _FilteringColumnHeaderNames[cmbFilterBy.Text];

            if (FilterColumn == "PersonID" || FilterColumn == "DriverID")
            {
                if (int.TryParse(txtSearch.Text.Trim(), out int ID))
                    _dtDrivers.DefaultView.RowFilter = $"[{FilterColumn}] = {ID}";
            }
            else
            {
                _dtDrivers.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtSearch.Text.Trim()}%'";
            }

            lblRecordCount.Text = $"Records: {_dtDrivers.Rows.Count}";

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
                _dtDrivers.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtDrivers.Rows.Count}";
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Person ID" || cmbFilterBy.Text == "Driver ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmListDrivers_Load(object sender, EventArgs e)
        {
            RefreshList();
            cmbFilterBy.SelectedIndex = 0;
            txtSearch.Visible = false;
            if (_dtDrivers.Rows.Count > 0)
            {
                dgvDrivers.Columns["DriverID"].HeaderText = "Driver ID";
                dgvDrivers.Columns["PersonID"].HeaderText = "Person ID";
                dgvDrivers.Columns["NationalNo"].HeaderText = "National No.";
                dgvDrivers.Columns["FullName"].HeaderText = "Full Name";
                dgvDrivers.Columns["CreatedDate"].HeaderText = "Created Date";
                dgvDrivers.Columns["NumberOfActiveLicenses"].HeaderText = "Active Licenses";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PersonInfotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            frmShowPersonInfo frmPerson = new frmShowPersonInfo(PersonID);
            frmPerson.ShowDialog();
        }

        private void LicensesHistorytoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvDrivers.CurrentRow.Cells[1].Value;
            frmShowPersonLicensesHistory frmLicenses = new frmShowPersonLicensesHistory(PersonID);
            frmLicenses.ShowDialog();
        }
    }
}
