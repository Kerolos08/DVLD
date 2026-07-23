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

namespace DVLD.Licenses.International_Licenses
{
    public partial class frmShowDriverInternationalLicenseInfo : Form
    {
        private int _IntLicenseID;
        private clsInternationalLicenseApplication _IntLicense;
        public frmShowDriverInternationalLicenseInfo(int IntLicenseID)
        {
            InitializeComponent();
            _IntLicenseID = IntLicenseID;
        }

        private void frmShowDriverInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlInternationalLicenseInfo1.LoadLicenseData(_IntLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
