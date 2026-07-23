using DVLD.Applications.ApplicationTypes;
using DVLD.Applications.International_Driving_License;
using DVLD.Applications.Local_Driving_License;
using DVLD.Applications.Release_Detained_License;
using DVLD.Applications.Renew_Local_Driving_License;
using DVLD.Applications.Replace_Lost_Damaged;
using DVLD.Drivers;
using DVLD.Global_Classes;
using DVLD.Licenses.DetainLicense;
using DVLD.Login;
using DVLD.Tests.Test_Types;
using DVLD.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmMainScreen : Form
    {
        public frmMainScreen()
        {
            InitializeComponent();
        }
        private void peopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmPeopleList();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsersList frmUsers = new frmUsersList();
            frmUsers.ShowDialog();
        }

        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListApplicationTypes AppList = new frmListApplicationTypes();
            AppList.ShowDialog();
        }

        private void manageTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListTestTypes TestList = new frmListTestTypes();
            TestList.ShowDialog();
        }

        private void changeUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmEditUser = new frmAddEditUser(clsGlobal.CurrentUser.UserID);
            frmEditUser.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frmPass = new frmChangePassword(clsGlobal.CurrentUser.UserID);
            frmPass.ShowDialog();
        }

        private void siToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.CurrentUser = null;
            this.Hide();
            frmLoginScreen frmLogin = new frmLoginScreen();
            frmLogin.ShowDialog();
            this.Close();
        }

        private void manageLocalDrivingLIcenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frmldllist = new frmListLocalDrivingLicenseApplications();
            frmldllist.ShowDialog();
        }

        private void newLocalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdateLocalDrivingLicenceApplicaiton frm = new frmAddUpdateLocalDrivingLicenceApplicaiton();
            frm.ShowDialog();
        }

        private void RetaketoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListLocalDrivingLicenseApplications frmldllist = new frmListLocalDrivingLicenseApplications();
            frmldllist.ShowDialog();
        }

        private void RenewtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewLocalDrivingLicenseApplication frmR = new frmRenewLocalDrivingLicenseApplication();
            frmR.ShowDialog();
        }

        private void ReplacmenttoolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceForLostOrDamagedLicenseApplication frmReplace = new frmReplaceForLostOrDamagedLicenseApplication();
            frmReplace.ShowDialog();
        }

        private void newInternationalDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalDrivingLicenseApplication frmInternational = new frmNewInternationalDrivingLicenseApplication();
            frmInternational.ShowDialog();
        }

        private void driverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDrivers frmDlist = new frmListDrivers();
            frmDlist.ShowDialog();
        }

        private void manageInternationalDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalDrivingLicenseApplications frmInternational = new frmListInternationalDrivingLicenseApplications();
            frmInternational.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frmDetain = new frmDetainLicense();
            frmDetain.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicenseApplication frmRelease = new frmReleaseDetainedLicenseApplication();
            frmRelease.ShowDialog();       
        }

        private void manageDetainedLicencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListDetainedLicenses frmDetained = new frmListDetainedLicenses();
            frmDetained.ShowDialog();
        }
    }
}