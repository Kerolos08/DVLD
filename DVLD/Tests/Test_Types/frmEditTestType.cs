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
using static System.Net.Mime.MediaTypeNames;

namespace DVLD.Tests.Test_Types
{
    public partial class frmEditTestType : Form
    {
        private clsTestType.enTestType _TestID;
        private clsTestType _TestType;
        public frmEditTestType(clsTestType.enTestType ID)
        {
            InitializeComponent();
            _TestID = ID;
        }

        private void frmEditTestType_Load(object sender, EventArgs e)
        {
            _TestType = clsTestType.GetTestTypeObj((int)_TestID);
            if (_TestType != null)
            {
                lblTestTypeIDValue.Text = ((int)_TestType.TestTypeID).ToString();
                txtTestTypeTitle.Text = _TestType.TestTypeTitle;
                txtDescription.Text = _TestType.TestTypeDescription;
                txtFeesValue.Text = _TestType.TestTypeFees.ToString();
            }
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

        private void txtFeesValue_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFeesValue.Text))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtFeesValue, "New Fees Value is required!");
            }
            else
            {
                epErrorProvider.SetError(txtFeesValue, null);
            }

            if (!decimal.TryParse(txtFeesValue.Text.Trim(), out decimal fees) || fees <= 0)
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtFeesValue, "Fees Value Must be a Number!");
            }
            else
            {
                epErrorProvider.SetError(txtFeesValue, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Some Feilds Should not be Blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _TestType.TestTypeTitle = txtTestTypeTitle.Text.Trim();
            _TestType.TestTypeDescription = txtDescription.Text.Trim();
            _TestType.TestTypeFees = Decimal.Parse(txtFeesValue.Text.Trim());

            if (_TestType.Save())
            {
                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
