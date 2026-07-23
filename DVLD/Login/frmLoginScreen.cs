using DVLD.Global_Classes;
using DVLD_BusinessLayer;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class frmLoginScreen : Form
    {
        private clsUser _User;
        public frmLoginScreen()
        {
            InitializeComponent();
        }
        private void frmLoginScreen_Load(object sender, EventArgs e)
        {
            string Username = string.Empty;
            string Password = string.Empty;
            if (clsGlobal.GetStoredUsernameAndPassword(ref Username, ref Password))
            {
                txtUsername.Text = Username;
                txtPassword.Text = Password;
                chkRememberMe.Checked = true;
            }
            else
            {
                txtUsername.Text = string.Empty;
                txtPassword.Text = string.Empty;
                chkRememberMe.Checked = false;
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Username and Password should not be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _User = clsUser.FindUserByUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());

            if (_User == null)
            {
                MessageBox.Show("Invalid Username or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_User.IsActive)
            {
                MessageBox.Show("User is not Active Please Contact your Admin!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chkRememberMe.Checked == true)

                clsGlobal.RememberUsernameAndPassword(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            else

                clsGlobal.RememberUsernameAndPassword(string.Empty, string.Empty);

            clsGlobal.CurrentUser = _User;
            this.Hide();
            frmMainScreen frmMain = new frmMainScreen();
            frmMain.ShowDialog();
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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


    }
}
