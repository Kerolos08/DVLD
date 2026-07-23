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

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmReleaseDetainedLicenseApplication : Form
    {
        private int _LicenseID = 0;
        private clsLicense _License;
        clsDetainedLicense _DetainedLicense;
        public frmReleaseDetainedLicenseApplication()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicenseApplication(int LicenseID)
        {
            InitializeComponent();

            _LicenseID = LicenseID;
        }
        private void frmReleaseDetainedLicenseApplication_Load(object sender, EventArgs e)
        {
            lblDetainID.Text = "N/A";
            lblLicenseIDValue.Text = "N/A";
            lbShowLicenseInfo.Enabled = false;

            lblAppFees.Text = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.ReleaseDetainedLicense).ApplicationFees.ToString();

            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            if (_LicenseID != 0)
            {
                ctrlDriverLicenseInfoWithFilter1.LoadLicenseInfo(_LicenseID);
                ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
            }
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

            _DetainedLicense = _License.DetainedInfo;

            if (_DetainedLicense == null)
            {
                MessageBox.Show("Selected License Is Not Detained Detained, Please Choose Another One", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            lblDetainID.Text = _DetainedLicense.DetainID.ToString();
            lblDetainDate.Text = _DetainedLicense.DetainDate.ToShortDateString();
            lblFineFees.Text = _DetainedLicense.FineFees.ToString();
            lblTotalFees.Text = (Convert.ToDecimal(lblFineFees.Text) + Convert.ToDecimal(lblAppFees.Text)).ToString();
            lblCreatedBy.Text = clsUser.Find(_DetainedLicense.CreatedByUserID).UserName;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Release this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            if (!_License.ReleaseDetainedLicense(clsGlobal.CurrentUser.UserID))
            {
                MessageBox.Show("Faild to Release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblAppID.Text = _DetainedLicense.ReleaseApplicationID.ToString();
            MessageBox.Show("This License Is Released Successfully", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
