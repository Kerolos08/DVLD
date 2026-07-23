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

namespace DVLD.Users
{
    public partial class frmChangePassword : Form
    {
        private int _UserID = -1;
        private clsUser _User;
        public frmChangePassword(int UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void ResetFormData ()
        {
            txtCurrentPassword.Text = "";
            txtNewPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtCurrentPassword.Focus();
        }
        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            ResetFormData();

            _User = clsUser.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + _UserID ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();

                return;
            }

            ctrlUserCard1.LoadUserInfo(_User);
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

            if (txtConfirmPassword.Text.Trim() != txtNewPassword.Text.Trim())
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

        private void txtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtCurrentPassword, "Please Enter your password!");
                return;
            }
            else
            {
                epErrorProvider.SetError(txtCurrentPassword, null);
            }

            if (txtCurrentPassword.Text.Trim() != _User.Password)
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtCurrentPassword, "Wrong Password!");
                return;
            }
            else
            {
                epErrorProvider.SetError(txtCurrentPassword, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some fields are not valid! Put the mouse over the red icon(s) to see the error.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User.Password = txtNewPassword.Text.Trim();

            if (_User.Save())
            {
                MessageBox.Show("New Password Set Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
                MessageBox.Show("Data is not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
