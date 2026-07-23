using DVLD.Licenses.International_Licenses;
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

namespace DVLD.Licenses
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _DriverID;
        private DataTable _dtLocal;
        private DataTable _dtInternational;
        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadLocalLicenses ()
        {
            _dtLocal = clsDriver.GetAllDriverLocalLicenses(_DriverID);
            dgvLocal.DataSource = _dtLocal;
            lblRecordCount.Text = $"Records: {_dtLocal.Rows.Count}";

            if (_dtLocal.Rows.Count > 0)
            {
                dgvLocal.Columns["LicenseID"].HeaderText = "Lic.ID";
                dgvLocal.Columns["ApplicationID"].HeaderText = "App.ID";
                dgvLocal.Columns["ClassName"].HeaderText = "Class Name";
                dgvLocal.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvLocal.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvLocal.Columns["IsActive"].HeaderText = "Is Active";
            }
        }

        private void _LoadInternationalLicenses()
        {
            _dtInternational = clsDriver.GetAllDriverInternationalLicenses(_DriverID);
            dgvInternational.DataSource = _dtInternational;
            lblRecordCount.Text = $"Records: {_dtInternational.Rows.Count}";

            if (_dtInternational.Rows.Count > 0)
            {
                dgvInternational.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
                dgvInternational.Columns["ApplicationID"].HeaderText = "Application ID";
                dgvInternational.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
                dgvInternational.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvInternational.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvInternational.Columns["IsActive"].HeaderText = "Is Active";
            }
        }

        public void LoadLicensesbyDriverID (int DriverID)
        {
            _DriverID = DriverID;
            _LoadLocalLicenses();
            _LoadInternationalLicenses();
        }

        public void LoadLicensesbyPersonID (int PersonID)
        {
            clsDriver Driver = clsDriver.FindDriverByPersonID(PersonID);

            if (Driver != null)
            {
                _DriverID = Driver.DriverID;
                _LoadLocalLicenses();
                _LoadInternationalLicenses();
            }
        }

        private void LicenseInfotoolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LicenseID = (int)dgvLocal.CurrentRow.Cells[0].Value;
            frmShowLicenseInfo frm = new frmShowLicenseInfo(LicenseID);
            frm.ShowDialog();
        }

        private void InternationalLicenseInfotoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int IntLicenseID = (int)dgvInternational.CurrentRow.Cells[0].Value;
            frmShowDriverInternationalLicenseInfo frmInt = new frmShowDriverInternationalLicenseInfo(IntLicenseID);
            frmInt.ShowDialog();
        }
    }
}
