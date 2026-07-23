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

namespace DVLD.Applications.International_Driving_License.UserControls
{
    public partial class ctrlInternationalLicenseInfo : UserControl
    {
        public ctrlInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private int _InternationalLicenseID;
        private clsInternationalLicenseApplication _License;
        private clsDriver _DriverInfo;
        private clsPerson _PersonInfo;

        public int LocalDrivingLicenseID { get { return _InternationalLicenseID; } }

        public clsInternationalLicenseApplication LicenseInfo { get { return _License; } }

        public clsDriver DriverInfo { get { return _DriverInfo; } }

        public clsPerson PersonInfo { get { return _PersonInfo; } }

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
            _InternationalLicenseID = _License.InternationalLicenseID;
            lblName.Text = _PersonInfo.FullName;
            lblIntLicenseIDValue.Text = _License.InternationalLicenseID.ToString();
            lblLicenseIDValue.Text = _License.IssuedUsingLocalLicenseID.ToString();
            lblNationalNo.Text = _PersonInfo.NationalNo;
            lblGender.Text = _PersonInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _License.IssueDate.ToShortDateString();
            lblAppID.Text = _License.ApplicationID.ToString();
            lblIsActiveValue.Text = _License.IsActive ? "Yes" : "No";
            lblDateOfBirth.Text = _PersonInfo.DateOfBirth.ToShortDateString();
            lblDriverIDValue.Text = _License.DriverID.ToString();
            lblExpDateValue.Text = _License.ExpirationDate.ToShortDateString();
        }

        public void LoadLicenseData(int IntLicenseID)
        {
            _License = clsInternationalLicenseApplication.GetInternationalDrivingLicenseApplicationObj(IntLicenseID);
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

        public void LoadLicenseObj(clsInternationalLicenseApplication License)
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

        public void ResetControl()
        {
            lblIntLicenseIDValue.Text = "[????]";
            lblName.Text = "[????]";
            lblLicenseIDValue.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGender.Text = "[????]";
            lblIssueDate.Text = "[????]";
            lblAppID.Text = "[????]";
            lblIsActiveValue.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblDriverIDValue.Text = "[????]";
            lblExpDateValue.Text = "[????]";
        }
    }
}
