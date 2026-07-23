using DVLD.Global_Classes;
using DVLD.Licenses.Local_Licenses;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.DetainLicense
{
    public partial class frmDetainLicense : Form
    {
        private int _LicenseID;
        private clsLicense _License;
        public frmDetainLicense()
        {
            InitializeComponent();
        }

        private void frmDetainLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.FilterFocus();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            lblDetainID.Text = "N/A";
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblLicenseIDValue.Text = "N/A";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            lbShowLicenseInfo.Enabled = false;
        }

        private void OnLicenseSelected(int LicenseID)
        {
            _License = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;

            if (_License == null)
            {
                return;
            }

            lbShowLicensesHistory.Enabled = (_License != null);
            lbShowLicenseInfo.Enabled = true;
            lblLicenseIDValue.Text = _License.LicenseID.ToString();

            if (!_License.IsActive)
            {
                MessageBox.Show("License Should Be Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (_License.IsDetained())
            {
                MessageBox.Show("Selected License Already Detained, Please Choose Another One", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
        }

        private void txtFineFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFineFees.Text))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtFineFees, "New Fees Value is required!");
            }
            else
            {
                epErrorProvider.SetError(txtFineFees, null);
            }

            if (!decimal.TryParse(txtFineFees.Text.Trim(), out decimal fees) || fees <= 0)
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtFineFees, "Fees Value Must be a Number!");
            }
            else
            {
                epErrorProvider.SetError(txtFineFees, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Fine Fees Should not be Blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Detain this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            clsDetainedLicense _DetainedLicense = _License.DetainLicense(Convert.ToDecimal(txtFineFees.Text), clsGlobal.CurrentUser.UserID);

            if (_DetainedLicense == null)
            {
                MessageBox.Show("Faild to Detain this License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            MessageBox.Show($"License Detained Successfully with ID = {_DetainedLicense.DetainID.ToString()}", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnSave.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void lbShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frmLicenses = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.PersonInfo.PersonID);
            frmLicenses.ShowDialog();
        }

        private void lbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_License.LicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
