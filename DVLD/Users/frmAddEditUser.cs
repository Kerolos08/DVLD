using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmAddEditUser : Form
    {
        private enum enMode { AddNew = 0, Update = 1 };

        private enMode _FormMode;
        private int _UserID;
        private clsUser _User;

        public frmAddEditUser()
        {
            InitializeComponent();
            _UserID = -1;
            _FormMode = enMode.AddNew;
        }

        public frmAddEditUser(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
            _FormMode = enMode.Update;
        }

        private void OnPersonSelected(int PersonID)
        {
            btnNext.Enabled = false;
            if (clsUser.IsConnectedToPerson(PersonID))
            {
                MessageBox.Show("There is another user connected to this person please select another one!", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonCardWithFilters1.ResetControl();
                return;
            }

            btnNext.Enabled = true;
        }

        private void ResetFormData()
        {
            if (_FormMode == enMode.AddNew)
            {
                lblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new clsUser();

                ctrlPersonCardWithFilters1.FilterFocus();
                tpLoginInfo.Enabled = false;
                btnNext.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                lblTitle.Text = "Update a User";
                this.Text = "Update a User";
                btnNext.Enabled = true;
                btnSave.Enabled = true;
            }
            ctrlPersonCardWithFilters1.ResetControl();
            lblUserIDValue.Text = "N/A";
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            chkIsActive.Checked = true;
        }

        private void LoadUserData()
        {
            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show($"No User is found matching UserID {_UserID}", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            ctrlPersonCardWithFilters1.ShowAddPerson = false;
            ctrlPersonCardWithFilters1.FilterEnabled = false;
            lblUserIDValue.Text = _User.UserID.ToString();
            txtUserName.Text = _User.UserName.ToString();
            txtPassword.Text = _User.Password;
            txtConfirmPassword.Text = _User.Password;
            chkIsActive.Checked = _User.IsActive;
            ctrlPersonCardWithFilters1.LoadPersonInfo(_User.PersonID);
        }

        private void frmAddEditUser_Load(object sender, EventArgs e)
        {
            ResetFormData();
            if (_FormMode == enMode.AddNew)
                ctrlPersonCardWithFilters1.OnPersonSelected += OnPersonSelected;

            else
                LoadUserData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            tpLoginInfo.Enabled = true;
            tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpLoginInfo"];
        }
        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {
            Control ctrl = (Control)sender;
            if (string.IsNullOrEmpty(ctrl.Text))
            {
                e.Cancel = true;
                epErrorProvider.SetError(ctrl, "This field is required!");
            }
            else
            {
                epErrorProvider.SetError(ctrl, null);
            }
        }
        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text.Trim()))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtUserName, "This field is required!");
                return;
            }
            else
            {
                epErrorProvider.SetError(txtUserName, null);
            }

            //Handle any change in username
            if (_FormMode == enMode.AddNew)
            {

                if (clsUser.IsUserExists(txtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    epErrorProvider.SetError(txtUserName, "username is used by another user");
                }
                else
                {
                    epErrorProvider.SetError(txtUserName, null);
                }
            }
            else
            {
                //incase update make sure not to use anothers user name
                if (_User.UserName != txtUserName.Text.Trim())
                {
                    if (clsUser.IsUserExists(txtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        epErrorProvider.SetError(txtUserName, "username is used by another user");
                        return;
                    }
                    else
                    {
                        epErrorProvider.SetError(txtUserName, null);
                    }
                }
            }
        }

        private void txtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtConfirmPassword, "Please confirm your password!");
                return;
            }
            else
            {
                epErrorProvider.SetError(txtConfirmPassword, null);
            }

            if (txtConfirmPassword.Text.Trim() != txtPassword.Text.Trim())
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtConfirmPassword, "Password should match!");
                return;
            }
            else
            {
                epErrorProvider.SetError(txtConfirmPassword, null);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            tcUserInfo.SelectedTab = tcUserInfo.TabPages["tpPersonalInfo"];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.PersonID = ctrlPersonCardWithFilters1.PersonID;
            _User.UserName = txtUserName.Text.Trim();
            _User.Password = txtPassword.Text.Trim();
            _User.IsActive = chkIsActive.Checked;

            if (_User.Save())
            {
                _FormMode = enMode.Update;
                lblTitle.Text = "Update A User";
                this.Text = "Update A User";
                lblUserIDValue.Text = _User.UserID.ToString();

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("Data is not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmAddEditUser_Activated(object sender, EventArgs e)
        {
            ctrlPersonCardWithFilters1.FilterFocus();
        }
    }
}