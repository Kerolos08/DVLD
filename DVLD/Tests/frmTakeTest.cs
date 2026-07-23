using DVLD.Global_Classes;
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

namespace DVLD.Tests
{
    public partial class frmTakeTest : Form
    {
        private int _TestAppointmentID;
        private clsTestType.enTestType _TestType;

        private clsTest _Test;
        public frmTakeTest(int TestAppointmentID, clsTestType.enTestType TestType)
        {
            InitializeComponent();

            _TestAppointmentID = TestAppointmentID;
            _TestType = TestType;
        }

        private void frmTakeTest_Load(object sender, EventArgs e)
        {
            ctrlSecheduledTest1.LoadInfo(_TestAppointmentID, _TestType);
            if (ctrlSecheduledTest1.TestAppointmentID == -1)
            {
                MessageBox.Show("Test Appointment ID does not match any active test appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (ctrlSecheduledTest1.TestAppointmentInfo.IsLocked == true)
            {
                MessageBox.Show("This test has already been taken.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                return;
            }

            rbFail.Checked = false;
            rbPass.Checked = true;
            txtNotes.Text = string.Empty;

            _Test = new clsTest();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure you want to save? After that you cannot change the Pass/Fail results after you save?.","Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = rbPass.Checked;
            _Test.Notes = txtNotes.Text.Trim();
            _Test.CreatedByUserID = clsGlobal.CurrentUser.UserID;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = false;

            }
            else
                MessageBox.Show("Error: Data Is not Saved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
