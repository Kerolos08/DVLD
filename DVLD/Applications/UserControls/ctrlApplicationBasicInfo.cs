using DVLD.People;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.UserControls
{
    public partial class ctrlApplicationBasicInfo : UserControl
    {
        private int _BaseApplicationID;

        private clsApplication _AppObj;

        public int BaseApplicationID
        {
            get { return _BaseApplicationID; }
        }

        public clsApplication BaseApplicationInfo
        {
            get { return _AppObj; }
        }

        public ctrlApplicationBasicInfo()
        {
            InitializeComponent();
        }

        public void ResetApplicationInfo ()
        {
            _BaseApplicationID = -1;
            _AppObj = null;
            lblAppID.Text = "[????]";
            lblStatus.Text = "[????]";
            lblFees.Text = "[????]";
            lblAppType.Text = "[????]";
            lblApplication.Text = "[????]";
            lblDate.Text = "[????]";
            lblStatusDate.Text = "[????]";
            lblCreatedBy.Text = "[????]";
        }

        private void _LoadAppInfo ()
        {
            _BaseApplicationID = _AppObj.ApplicationID;
            lblAppID.Text = _AppObj.ApplicationID.ToString();
            lblStatus.Text = _GetApplicationStatusString(_AppObj.ApplicationStatus);
            lblFees.Text = _AppObj.PaidFees.ToString();
            lblAppType.Text = clsApplicationType.GetApplicationTypeObj((int)_AppObj.ApplicationType).ApplicationTypeTitle;
            lblApplication.Text = clsPerson.Find(_AppObj.ApplicantPersonID).FullName;
            lblDate.Text = _AppObj.ApplicationDate.ToShortDateString();
            lblStatusDate.Text = _AppObj.LastStatusDate.ToShortDateString();
            lblCreatedBy.Text = clsUser.Find(_AppObj.CreatedByUserID).UserName;
        }

        public void LoadApplicationInfo (int AppID)
        {
            _AppObj = clsApplication.FindByBaseApplicationID(AppID);

            if (_AppObj == null)
            {
                MessageBox.Show("Error: Application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetApplicationInfo();
                return;
            }

            _LoadAppInfo();
        }

        public void LoadApplicationInfo(clsApplication Application)
        {
            _AppObj = Application;
            if (_AppObj == null)
            {
                MessageBox.Show("Error: Application is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetApplicationInfo();
                return;
            }

            _LoadAppInfo();
        }

        private string _GetApplicationStatusString (clsApplication.enApplicationStatus Status)
        {
            switch (Status)
            {
                case clsApplication.enApplicationStatus.New:
                    return "New";

                case clsApplication.enApplicationStatus.Cancelled:
                    return "Cancelled";

                case clsApplication.enApplicationStatus.Complete:
                    return "Completed";
            }
            return "";
        }

        private void llViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowPersonInfo frm = new frmShowPersonInfo(_AppObj.ApplicantPersonID);
            frm.ShowDialog();
        }
    }
}
