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

namespace DVLD.Users.UserControls
{
    public partial class ctrlUserCard : UserControl
    {
        private int _UserID;
        private clsUser _User;

        public int UserID
        {
            get { return _UserID; }
        }
        public clsUser UserInfo
        {
            get { return _User; }
        }
        public ctrlUserCard()
        {
            InitializeComponent();
        }
        public void ResetUserInfo()
        {
            _UserID = -1;
            ctrlPersonCard1.ResetPersonInfo();
            lblUserID.Text = "[????]";
            lblUsername.Text = "[????]";
            lblIsActive.Text = "[????]";
        }

        public void LoadUserInfo (int ID)
        {
            _UserID = ID;
            _User = clsUser.Find(ID);

            if (_User == null)
            {
                MessageBox.Show("Error: User is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetUserInfo();
                return;
            }

            FillUserInfo();
        }

        public void LoadUserInfo(string Username)
        {
            _User = clsUser.Find(Username);

            if (_User == null)
            {
                MessageBox.Show("Error: User is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetUserInfo();
                return;
            }

            FillUserInfo();
        }

        public void LoadUserInfo (clsUser LoadedUser)
        {
            _User = LoadedUser;
            FillUserInfo();
        }

        private void FillUserInfo ()
        {
            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            lblUserID.Text = _User.UserID.ToString();
            lblUsername.Text = _User.UserName;
            lblIsActive.Text = _User.IsActive == true ? "Yes" : "No";
        }

    }
}
