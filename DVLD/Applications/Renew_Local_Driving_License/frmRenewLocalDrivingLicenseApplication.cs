using DVLD.Global_Classes;
using DVLD.Licenses;
using DVLD.Licenses.Local_Licenses;
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

namespace DVLD.Applications.Renew_Local_Driving_License
{
    public partial class frmRenewLocalDrivingLicenseApplication : Form
    {
        private int NewLicenseID;
        private clsLicense _License;
        public frmRenewLocalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmRenewLocalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.FilterFocus();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            lblAppID.Text = "N/A";
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblAppFees.Text = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees.ToString();
            lblLicenseFeesValue.Text = "[????]";
            lblRenewedLicenseIDValue.Text = "N/A";
            lblOldLicenseIDValue.Text = "N/A";
            lblExpDateValue.Text = "[????]";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lblTotalFeesValue.Text = "[????]";

            lbShowNewLicenseInfo.Enabled = false;
        }

        private void OnLicenseSelected(int LicenseID)
        {
            _License = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;

            if (_License == null)
            {
                return;
            }

            lbShowLicensesHistory.Enabled = (_License != null);
            lblOldLicenseIDValue.Text = _License.LicenseID.ToString();
            lblExpDateValue.Text = _License.ExpirationDate.ToShortDateString();
            lblLicenseFeesValue.Text = clsLicenseClass.GetLicenseClassObj(_License.LicenseClassID).ClassFees.ToString();
            lblTotalFeesValue.Text = Convert.ToDecimal(Convert.ToDecimal(lblLicenseFeesValue.Text) + Convert.ToDecimal(lblAppFees.Text)).ToString();
            lblNotes.Text = _License.Notes;

            if (!_License.IsLicenseExpired())
            {
                MessageBox.Show($"Selected License is not Expired, It will Expire on {_License.ExpirationDate.ToShortDateString()}", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (!_License.IsActive)
            {
                MessageBox.Show("License Should Be Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to renew this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            clsLicense NewLicense = _License.RenewLicense(clsGlobal.CurrentUser.UserID, txtNotes.Text.Trim());

            if (NewLicense == null)
            {

                MessageBox.Show($"License not renewed due to an issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewLicenseID = NewLicense.LicenseID;
            lblAppID.Text = _License.ApplicationID.ToString();
            lblRenewedLicenseIDValue.Text = NewLicense.LicenseID.ToString();
            lblExpDateValue.Text = NewLicense.ExpirationDate.ToShortDateString();
            lbShowNewLicenseInfo.Enabled = true;
            btnSave.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

            MessageBox.Show($"License Renewed Successfully with ID = {NewLicense.LicenseID}", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void lbShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(NewLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frmLicenses = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.PersonInfo.PersonID);
            frmLicenses.ShowDialog();
        }
    }
}
