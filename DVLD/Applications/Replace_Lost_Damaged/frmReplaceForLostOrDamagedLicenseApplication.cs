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

namespace DVLD.Applications.Replace_Lost_Damaged
{
    public partial class frmReplaceForLostOrDamagedLicenseApplication : Form
    {
        private int NewLicenseID;
        private clsLicense _License;
        private decimal DamagedFees;
        private decimal LostFees;
        public frmReplaceForLostOrDamagedLicenseApplication()
        {
            InitializeComponent();

            LostFees = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.ReplacementForLostLicense).ApplicationFees;
            DamagedFees = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.ReplacementForDamageLicense).ApplicationFees;
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

            if (!_License.IsActive)
            {
                MessageBox.Show("License Should Be Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }
        }

        private void frmReplaceForLostOrDamagedLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.FilterFocus();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            lblAppID.Text = "N/A";
            rbDamaged.Checked = true;
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblAppFees.Text = "[????]";
            lblReplacedLicenseIDValue.Text = "N/A";
            lblOldLicenseIDValue.Text = "N/A";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;
            lbShowNewLicenseInfo.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Replace this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            clsLicense.enIssueReason IssueReason = rbLost.Checked ? clsLicense.enIssueReason.LostReplacement : clsLicense.enIssueReason.DamagedReplacement;

            clsLicense NewLicense = _License.Replace(IssueReason, clsGlobal.CurrentUser.UserID);

            if (NewLicense == null)
            {

                MessageBox.Show($"License not Replaced due to an issue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewLicenseID = NewLicense.LicenseID;
            lblAppID.Text = _License.ApplicationID.ToString();
            lblReplacedLicenseIDValue.Text = NewLicense.LicenseID.ToString();
            lbShowNewLicenseInfo.Enabled = true;
            btnSave.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;

            MessageBox.Show($"License Replaced Successfully with ID = {NewLicense.LicenseID}", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lbShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(NewLicenseID);
            frm.ShowDialog();
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            lblAppFees.Text = DamagedFees.ToString();
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            lblAppFees.Text = LostFees.ToString();
        }

        private void lbShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonLicensesHistory frmLicenses = new frmShowPersonLicensesHistory(ctrlDriverLicenseInfoWithFilter1.PersonInfo.PersonID);
            frmLicenses.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
