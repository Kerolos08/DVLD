using DVLD.Applications.Application_Types;
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

namespace DVLD.Applications.ApplicationTypes
{
    public partial class frmListApplicationTypes : Form
    {
        private DataTable dtTypes;
        public frmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void RefreshGridView()
        {
            dtTypes = clsApplicationType.ListApplicationTypes();
            dgvTypes.DataSource = dtTypes;
            lblRecordCount.Text = $"Records:{dtTypes.Rows.Count}";
        }
        private void frmListApplicationTypes_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            if (dgvTypes.Rows.Count > 0)
            {
                dgvTypes.Columns["ApplicationTypeID"].HeaderText = "ID";
                dgvTypes.Columns["ApplicationTypeID"].Width = 55;
                dgvTypes.Columns["ApplicationTypeTitle"].HeaderText = "Title";
                dgvTypes.Columns["ApplicationTypeTitle"].Width = 400;
                dgvTypes.Columns["ApplicationFees"].HeaderText = "Fees";
                dgvTypes.Columns["ApplicationFees"].Width = 100;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EdittoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEditApplicationType frmEdit = new frmEditApplicationType((int)dgvTypes.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();
            RefreshGridView();
        }

    }
}
