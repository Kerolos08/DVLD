using DVLD.Global_Classes;
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

namespace DVLD.Licenses.Local_Licenses
{
    public partial class frmIssueLicenseFirstTime : Form
    {
        private int _LocalDrivingLicenseApplicationID;
        clsLocalDrivingLicenseApplication LocalApplication;
        public frmIssueLicenseFirstTime(int LDLappID)
        {
            InitializeComponent();
            _LocalDrivingLicenseApplicationID = LDLappID;
        }

        private void frmIssueLicenseFirstTime_Load(object sender, EventArgs e)
        {
            ctrlLocalDrivingLicenseAppInfo1.LoadLocalLicenseApplicationInfo(_LocalDrivingLicenseApplicationID);

            LocalApplication = ctrlLocalDrivingLicenseAppInfo1.LocalDrivingLicenseAppInfo;
            if (!LocalApplication.DoesPassAllTests())
            {
                MessageBox.Show("Applicant does not passed the Tests!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (LocalApplication.GetActiveLicenseID() != 0)
            {
                MessageBox.Show("Applicant Already have this License!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (LocalApplication.IssueLicenseForFirstTime(clsGlobal.CurrentUser.UserID, txtNotes.Text))
            {
                MessageBox.Show("Successfull, License Issued For The First Time", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("License Not Issued Due to An Error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
