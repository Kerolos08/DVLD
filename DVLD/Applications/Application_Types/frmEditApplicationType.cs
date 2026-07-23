using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD.Applications.Application_Types
{
    public partial class frmEditApplicationType : Form
    {
        private int _AppTypeID;
        private clsApplicationType _Application;
        public frmEditApplicationType(int ID)
        {
            InitializeComponent();
            _AppTypeID = ID;
        }
        private void frmEditApplicationType_Load(object sender, EventArgs e)
        {
            _Application = clsApplicationType.GetApplicationTypeObj(_AppTypeID);
            if (_Application != null)
            {
                lblApplicationIDValue.Text = _Application.ApplicationTypeID.ToString();
                txtApplicationTitle.Text = _Application.ApplicationTypeTitle;
                txtFeesValue.Text = _Application.ApplicationFees.ToString();
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

            _Application.ApplicationTypeTitle = txtApplicationTitle.Text.Trim();
            _Application.ApplicationFees = decimal.Parse(txtFeesValue.Text.Trim());

            if (_Application.Save())
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
