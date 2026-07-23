using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DVLD.Licenses
{
    public partial class frmShowPersonLicensesHistory : Form
    {
        private int _PersonID;
        private clsPerson Person;
        public frmShowPersonLicensesHistory(int PersonID)
        {
            InitializeComponent();
            _PersonID = PersonID;
        }

        private void frmShowPersonLicensesHistory_Load(object sender, EventArgs e)
        {
            Person = clsPerson.Find(_PersonID);

            if (Person == null)
            {
                MessageBox.Show($"Cannot find Person with ID: {_PersonID}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            ctrlPersonCard1.LoadPersonInfo(Person);
            ctrlDriverLicenses1.LoadLicensesbyPersonID(_PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
