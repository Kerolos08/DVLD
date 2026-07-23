using DVLD.Global_Classes;
using DVLD.People.UserControls;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DVLD.Applications.Local_Driving_License
{
    public partial class frmAddUpdateLocalDrivingLicenceApplicaiton : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _LDLid;
        private clsLocalDrivingLicenseApplication _LDLobj;
        public frmAddUpdateLocalDrivingLicenceApplicaiton()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public frmAddUpdateLocalDrivingLicenceApplicaiton(int LDLAppID)
        {
            InitializeComponent();
            _LDLid = LDLAppID;
            _Mode = enMode.Update;
        }
        private void _FillLicenseClassesComboBox()
        {
            DataTable dtLicenseClasses = clsLicenseClass.ListLicenseClasses();
            foreach (DataRow row in dtLicenseClasses.Rows)
            {
                cmbClass.Items.Add(row["ClassName"]);
            }
        }
        private void ResetForm()
        {
            cmbClass.Items.Clear();
            _FillLicenseClassesComboBox();

            if (_Mode == enMode.AddNew)
            {
                _LDLobj = new clsLocalDrivingLicenseApplication();

                lblTitle.Text = "New Local Driving license Application";
                this.Text = "New LDL Application";

                ctrlPersonCardWithFilters1.FilterFocus();
                btnNext.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Edit Local Driving license Application";
                this.Text = "Edit LDL Application";
                tpPersonalInfo.Enabled = false;
                btnNext.Enabled = true;
                btnSave.Enabled = true;
            }

            ctrlPersonCardWithFilters1.ResetControl();
            lblDLApplicationValue.Text = "N/A";
            lblApplicationDateValue.Text = DateTime.Now.ToShortDateString();
            cmbClass.SelectedIndex = 2;
            lblApplicationFeesValue.Text = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.NewLocalDrivingLicense).ApplicationFees.ToString();
            lblCreatedByUserValue.Text = clsGlobal.CurrentUser.UserName;
        }

        private void LoadApplicationData()
        {
            _LDLobj = clsLocalDrivingLicenseApplication.GetLocalDrivingLicenseApplicationObj(_LDLid);

            if (_LDLobj == null)
            {
                MessageBox.Show($"Application With ID {_LDLid} Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilters1.ShowAddPerson = false;
            ctrlPersonCardWithFilters1.FilterEnabled = false;
            ctrlPersonCardWithFilters1.LoadPersonInfo(_LDLobj.ApplicantPersonID);

            lblDLApplicationValue.Text = _LDLobj.LocalDrivingLicenseApplicationID.ToString();
            lblApplicationDateValue.Text = _LDLobj.ApplicationDate.ToShortDateString();
            cmbClass.SelectedIndex = cmbClass.FindString(clsLicenseClass.GetLicenseClassObj(_LDLobj.LicenseClassID).ClassName);
            lblApplicationFeesValue.Text = _LDLobj.PaidFees.ToString();
            lblCreatedByUserValue.Text = clsUser.Find(_LDLobj.CreatedByUserID).UserName.ToString();
        }

        private bool IsLicenseClassMatchingApplicantAge(int LicenseMinAge)
        {
            int Age = DateTime.Now.Year - ctrlPersonCardWithFilters1.PersonInfo.DateOfBirth.Year;
            if (DateTime.Now.DayOfYear < ctrlPersonCardWithFilters1.PersonInfo.DateOfBirth.DayOfYear)
                Age--;
            return Age >= LicenseMinAge;
        }

        private void OnPersonSelected(int ID)
        {
            btnNext.Enabled = true;
        }
        private void frmAddUpdateLocalDrivingLicenceApplicaiton_Load(object sender, EventArgs e)
        {
            ResetForm();
            if (_Mode == enMode.AddNew)
                ctrlPersonCardWithFilters1.OnPersonSelected += OnPersonSelected;
            else
                LoadApplicationData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ctrlPersonCardWithFilters1.PersonID == -1)
            {
                MessageBox.Show("Appicant should be selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ctrlPersonCardWithFilters1.Enabled = false;
            btnSave.Enabled = true;
            tpApplicationInfo.Enabled = true;
            tcAppInfo.SelectedTab = tcAppInfo.TabPages["tpApplicationInfo"];
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcAppInfo.SelectedTab = tcAppInfo.TabPages["tpPersonalInfo"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsLicenseClass LicenseClass = clsLicenseClass.GetLicenseClassObj(cmbClass.Text);

            if (_Mode == enMode.AddNew)
            {
                if (!IsLicenseClassMatchingApplicantAge(LicenseClass.MinimumAllowedAge))
                {
                    MessageBox.Show("License Class that you trying to submit an Application for Does not Matching Applicant Age", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (clsLocalDrivingLicenseApplication.IsApplicantHaveActiveLicenseRequestWithSameClass(ctrlPersonCardWithFilters1.PersonID, LicenseClass.LicenseClassID))
                {
                    MessageBox.Show("This person already has an Application for the Same Local Driving License Class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (clsLicense.GetActiveLicenseIDbyPersonID(ctrlPersonCardWithFilters1.PersonID, LicenseClass.LicenseClassID) != 0)
                {
                    MessageBox.Show("This person already has an Active License from the same class", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _LDLobj.ApplicationDate = DateTime.Now;
                _LDLobj.LicenseClassID = LicenseClass.LicenseClassID;
                _LDLobj.ApplicationType = clsApplication.enApplicationType.NewLocalDrivingLicense;
                _LDLobj.ApplicantPersonID = ctrlPersonCardWithFilters1.PersonID;
                _LDLobj.ApplicationStatus = clsLocalDrivingLicenseApplication.enApplicationStatus.New;
                _LDLobj.PaidFees = Convert.ToDecimal(lblApplicationFeesValue.Text);
                _LDLobj.CreatedByUserID = clsGlobal.CurrentUser.UserID;
                _LDLobj.LastStatusDate = DateTime.Now;
            }
            else
            {
                _LDLobj.LicenseClassID = LicenseClass.LicenseClassID;
                _LDLobj.LastStatusDate = DateTime.Now;
                _LDLobj.ApplicationStatus = clsLocalDrivingLicenseApplication.enApplicationStatus.New;
            }

            if (_LDLobj.Save())
            {
                lblTitle.Text = "Edit Local Driving license Application";
                this.Text = "Edit LDL Application";
                _Mode = enMode.Update;
                lblDLApplicationValue.Text = _LDLobj.LocalDrivingLicenseApplicationID.ToString();
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddUpdateLocalDrivingLicenceApplicaiton_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilters1.FilterFocus();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
