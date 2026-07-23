using DVLD.People.UserControls;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Licenses.Local_Licenses.UserControls
{
    public partial class ctrlDriverLicenseInfoWithFilter : UserControl
    {
        public event Action<int> OnLicenseSelected;
        public ctrlDriverLicenseInfoWithFilter()
        {
            InitializeComponent();
        }

        private bool _FilterEnabled = true;
        public bool FilterEnabled
        {
            get
            {
                return _FilterEnabled;
            }

            set
            {
                _FilterEnabled = value;
                pnlToolbar.Enabled = _FilterEnabled;
            }
        }

        public int LicenseID { get { return ctrlDriverLicenseInfo1.LocalDrivingLicenseID; } }

        public clsLicense LicenseInfo { get { return ctrlDriverLicenseInfo1.LicenseInfo; } }

        public clsPerson PersonInfo { get { return ctrlDriverLicenseInfo1.PersonInfo; } }

        public clsDriver DriverInfo { get { return ctrlDriverLicenseInfo1.DriverInfo; } }

        public void LoadLicenseInfo(int LicenseID)
        {
            txtSearch.Text = LicenseID.ToString();
            FindNow();
        }

        private void FindNow(bool RaiseEvent = true)
        {
            int.TryParse(txtSearch.Text.Trim(), out int LicenseID);
            ctrlDriverLicenseInfo1.LoadLicenseData(LicenseID == 0 ? -1 : LicenseID);

            OnLicenseSelected?.Invoke(ctrlDriverLicenseInfo1.LocalDrivingLicenseID);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are Empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
        }

        public void FilterFocus()
        {
            txtSearch.Focus();
        }

        public void ResetControl()
        {
            _FilterEnabled = true;
            ctrlDriverLicenseInfo1.ResetControl();
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
