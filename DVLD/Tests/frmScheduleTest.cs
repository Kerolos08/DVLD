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

namespace DVLD.Tests
{
    public partial class frmScheduleTest : Form
    {
        private int LocalDrivinglicenseApplicationID;
        private clsTestType.enTestType TestType;
        private int AppointmentID;
        public frmScheduleTest(int LocalDrivinglicenseApplicationID, clsTestType.enTestType TestType, int AppointmentID = -1)
        {
            InitializeComponent();

            this.LocalDrivinglicenseApplicationID = LocalDrivinglicenseApplicationID;
            this.TestType = TestType;
            this.AppointmentID = AppointmentID;
        }

        private void frmScheduleTest_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.LoadInfo(LocalDrivinglicenseApplicationID, TestType, AppointmentID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
