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

namespace DVLD.Applications.International_Driving_License
{
    public partial class frmNewInternationalDrivingLicenseApplication : Form
    {
        private clsLicense _LocalLicense;
        private int _InternationalLicenseID;
        public frmNewInternationalDrivingLicenseApplication()
        {
            InitializeComponent();
        }

        private void frmNewInternationalDrivingLicenseApplication_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoWithFilter1.FilterFocus();
            ctrlDriverLicenseInfoWithFilter1.OnLicenseSelected += OnLicenseSelected;

            lblAppID.Text = "N/A";
            lblDate.Text = DateTime.Now.ToShortDateString();
            lblIssueDate.Text = DateTime.Now.ToShortDateString();
            lblAppFees.Text = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.NewInternationalLicense).ApplicationFees.ToString();
            lblInternationalLicenseIDValue.Text = "N/A";
            lblLocalLicenseIDValue.Text = "N/A";
            lblExpDateValue.Text = "[????]";
            lblCreatedBy.Text = clsGlobal.CurrentUser.UserName;

            lbShowNewLicenseInfo.Enabled = false;
        }

        private void OnLicenseSelected(int LicenseID)
        {
            _LocalLicense = ctrlDriverLicenseInfoWithFilter1.LicenseInfo;

            if (_LocalLicense == null)
            {
                return;
            }

            lbShowLicensesHistory.Enabled = (_LocalLicense != null);
            lblLocalLicenseIDValue.Text = _LocalLicense.LicenseID.ToString();
            lblExpDateValue.Text = _LocalLicense.ExpirationDate.AddYears(1).ToShortDateString();

            if (_LocalLicense.LicenseClassID != 3)
            {
                MessageBox.Show("Selected License should be Class 3, select another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            if (!_LocalLicense.IsActive)
            {
                MessageBox.Show("License Should Be Active", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                return;
            }

            int ActiveInternaionalLicenseID = clsInternationalLicenseApplication.GetActiveInternationalLicenseIDByDriverID(_LocalLicense.DriverID);

            if (ActiveInternaionalLicenseID != 0)
            {
                MessageBox.Show("Person already have an active international license with ID = " + ActiveInternaionalLicenseID.ToString(), "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbShowNewLicenseInfo.Enabled = true;
                _InternationalLicenseID = ActiveInternaionalLicenseID;
                btnSave.Enabled = false;
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Issue this license?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                return;
            }

            clsInternationalLicenseApplication _InternationalLicense = new clsInternationalLicenseApplication();

            _InternationalLicense.ApplicantPersonID = ctrlDriverLicenseInfoWithFilter1.PersonInfo.PersonID;
            _InternationalLicense.ApplicationDate = DateTime.Now;
            _InternationalLicense.ApplicationType = clsApplication.enApplicationType.NewInternationalLicense;
            _InternationalLicense.ApplicationStatus = clsApplication.enApplicationStatus.Complete;
            _InternationalLicense.LastStatusDate = DateTime.Now;
            _InternationalLicense.PaidFees = Convert.ToDecimal(lblAppFees.Text);
            _InternationalLicense.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            _InternationalLicense.DriverID = ctrlDriverLicenseInfoWithFilter1.DriverInfo.DriverID;
            _InternationalLicense.IssuedUsingLocalLicenseID = _LocalLicense.LicenseID;
            _InternationalLicense.IssueDate = DateTime.Now;
            _InternationalLicense.ExpirationDate = DateTime.Now.AddYears(1);
            _InternationalLicense.IsActive = true;

            if (!_InternationalLicense.Save())
            {
                MessageBox.Show("Faild to Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _InternationalLicenseID = _InternationalLicense.InternationalLicenseID;
            lblAppID.Text = _InternationalLicense.ApplicationID.ToString();
            lblInternationalLicenseIDValue.Text = _InternationalLicenseID.ToString();

            MessageBox.Show($"International License Issued Successfully with ID = {_InternationalLicenseID.ToString()}", "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            lbShowNewLicenseInfo.Enabled = true;
            btnSave.Enabled = false;
            ctrlDriverLicenseInfoWithFilter1.FilterEnabled = false;
        }

        private void lbShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_InternationalLicenseID);
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
