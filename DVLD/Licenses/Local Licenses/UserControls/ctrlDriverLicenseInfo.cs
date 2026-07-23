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
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace DVLD.Licenses.Local_Licenses.UserControls
{
    public partial class ctrlDriverLicenseInfo : UserControl
    {
        private int _LocalDrivingLicenseID;
        private clsLicense _License;
        private clsDriver _DriverInfo;
        private clsPerson _PersonInfo;

        public int LocalDrivingLicenseID { get { return _LocalDrivingLicenseID; } }

        public clsLicense LicenseInfo { get { return _License; } }

        public clsDriver DriverInfo { get { return _DriverInfo; } }

        public clsPerson PersonInfo { get { return _PersonInfo; } }

        public ctrlDriverLicenseInfo()
        {
            InitializeComponent();
        }

        private void HandleImage()
        {
            string ImagePath = _PersonInfo.ImagePath;
            pbPersonImage.Image = (_PersonInfo.Gender == 0 ? Resources.man : Resources.woman);

            if (!string.IsNullOrEmpty(ImagePath))
            {
                if (File.Exists(ImagePath))
                {
                    pbPersonImage.Load(ImagePath);
                }
            }
        }

        private void FillWithData()
        {
            _LocalDrivingLicenseID = _License.LicenseID;
            lblClassValue.Text = clsLicenseClass.GetLicenseClassObj(_License.LicenseClassID).ClassName;
            lblName.Text = _PersonInfo.FullName;
            lblLicenseIDValue.Text = _License.LicenseID.ToString();
            lblNationalNo.Text = _PersonInfo.NationalNo;
            lblGender.Text = _PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblIssueReason.Text = clsLicense.GetIssueReasonText(_License.IssueReason);
            lblNotes.Text = string.IsNullOrEmpty(_License.Notes) ? "No Notes" : _License.Notes;
            lblIsActiveValue.Text = _License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = _PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverIDValue.Text = _License.DriverID.ToString();
            lblExpDateValue.Text = _License.ExpirationDate.ToShortDateString();
            lblIsDetainedValue.Text = _License.IsDetained() ? "Yes" : "No";
        }

        public void LoadLicenseData (int LicenseID)
        { 
            _License = clsLicense.GetLicenseObj(LicenseID);
            if (_License == null)
            {
                MessageBox.Show("This Local Driving License ID Does Not Match Any Driving License", "Could not be found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverInfo = clsDriver.FindDriverByDriverID(_License.DriverID);
            _PersonInfo = clsPerson.Find(_DriverInfo.PersonID);

            FillWithData();
            HandleImage();
        }

        public void LoadLicenseObj (clsLicense License)
        {
            _License = License;
            if (_License == null)
            {
                MessageBox.Show("This Local Driving License ID Does Not Match Any Driving License", "Could not be found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _DriverInfo = clsDriver.FindDriverByDriverID(_License.DriverID);
            _PersonInfo = clsPerson.Find(_DriverInfo.PersonID);

            FillWithData();
            HandleImage();
        }

        public void ResetControl ()
        {
            lblClassValue.Text = "[????]";
            lblName.Text = "[????]";
            lblLicenseIDValue.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGender.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblIssueReason.Text = "[????]";
            lblNotes.Text = "[????]";
            lblIsActiveValue.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblDriverIDValue.Text = "[????]";
            lblExpDateValue.Text = "[????]";
            lblIsDetainedValue.Text = "[????]";
        }

    }
}
