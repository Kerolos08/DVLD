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

namespace DVLD.Applications.Local_Driving_License.UserControl
{
    public partial class ctrlLocalDrivingLicenseAppInfo : System.Windows.Forms.UserControl
    {
        private int _LDLAPPID;
        private clsLocalDrivingLicenseApplication _LDLAppObj;
        public int LocalDrivingLicenseAppID { get { return _LDLAPPID; } }
        public clsLocalDrivingLicenseApplication LocalDrivingLicenseAppInfo { get { return _LDLAppObj; } }

        public ctrlLocalDrivingLicenseAppInfo()
        {
            InitializeComponent();
        }

        public void ResetApplication()
        {
            _LDLAPPID = -1;
            _LDLAppObj = null;
            ctrlApplicationBasicInfo1.ResetApplicationInfo();
            lblDLAppID.Text = "[????]";
            lblLicenseClassValue.Text = "[????]";
            lblPassedTests.Text = "[????]";
        }

        private void _FillWithData()
        {
            _LDLAPPID = _LDLAppObj.LocalDrivingLicenseApplicationID;
            lblDLAppID.Text = _LDLAppObj.LocalDrivingLicenseApplicationID.ToString();
            lblLicenseClassValue.Text = clsLicenseClass.GetLicenseClassObj(_LDLAppObj.LicenseClassID).ClassName;
            lblPassedTests.Text = clsLocalDrivingLicenseApplication.GetPassedTestsForLicenseApplication(_LDLAppObj.LocalDrivingLicenseApplicationID).ToString();
        }

        public void LoadLocalLicenseApplicationInfo(int LDLID)
        {
            _LDLAppObj = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(LDLID);

            if (_LDLAppObj == null)
            {
                MessageBox.Show("Error: Application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetApplication();
                return;
            }

            _FillWithData();
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LDLAppObj.ApplicationID);
        }

        public void LoadLocalLicenseApplicationInfo (clsLocalDrivingLicenseApplication LDLObJ)
        {
            _LDLAppObj = LDLObJ;

            if (_LDLAppObj == null)
            {
                MessageBox.Show("Error: Application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetApplication();
                return;
            }

            _FillWithData();
            ctrlApplicationBasicInfo1.LoadApplicationInfo(_LDLAppObj);
        }

        private void llViewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowLicenseInfo frm = new frmShowLicenseInfo(_LDLAppObj.GetActiveLicenseID());
            frm.ShowDialog();
        }
    }
}
