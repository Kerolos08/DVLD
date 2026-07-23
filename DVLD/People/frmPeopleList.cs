using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Internal;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD.People;
using DVLD_BusinessLayer;

namespace DVLD
{
    public partial class frmPeopleList : Form
    {
        private DataTable _dtPeople;
        private Dictionary<string, string> _FilteringColumnHeaderNames = new Dictionary<string, string>()
        {
            {"Person ID", "PersonID"},
            {"National No.", "NationalNo"},
            {"First Name", "FirstName"},
            {"Second Name", "SecondName"},
            {"Third Name",  "ThirdName"},
            {"Last Name", "LastName"},
            {"Country", "Nationality"},
            {"Gender",  "Gender"},
            {"Phone", "Phone"},
            {"Email", "Email" }
        };
        public frmPeopleList()
        {
            InitializeComponent();
        }

        private void RefreshGridView()
        {
            _dtPeople = clsPerson.ListPeople();
            dgvPeople.DataSource = _dtPeople;
            lblRecordCount.Text = $"Records: {_dtPeople.Rows.Count}";
        }

        private void frmManagePeople_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            cmbFilterBy.SelectedIndex = 0;
            txtSearch.Visible = false;
            if (dgvPeople.Rows.Count > 0)
            {
                dgvPeople.Columns["PersonID"].HeaderText = "Person ID";
                dgvPeople.Columns["NationalNo"].HeaderText = "National No.";
                dgvPeople.Columns["FirstName"].HeaderText = "First Name";
                dgvPeople.Columns["SecondName"].HeaderText = "Second Name";
                dgvPeople.Columns["ThirdName"].HeaderText = "Third Name";
                dgvPeople.Columns["LastName"].HeaderText = "Last Name";
                dgvPeople.Columns["Gender"].HeaderText = "Gender";
                dgvPeople.Columns["DateOfBirth"].HeaderText = "Date Of Birth";
                dgvPeople.Columns["Nationality"].HeaderText = "Country";
                dgvPeople.Columns["Phone"].HeaderText = "Phone";
                dgvPeople.Columns["Email"].HeaderText = "Email";
            }
        }


        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form EditFrm = new frmAddEditPerson((int)dgvPeople.CurrentRow.Cells[0].Value);
            EditFrm.ShowDialog();
            RefreshGridView();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form EditFrm = new frmAddEditPerson();
            EditFrm.ShowDialog();
            RefreshGridView();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            Form EditFrm = new frmAddEditPerson();
            EditFrm.ShowDialog();
            RefreshGridView();
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Visible = (cmbFilterBy.Text != "None");

            if (txtSearch.Visible)
            {
                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtPeople.Rows.Count}";
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "None" || string.IsNullOrEmpty(cmbFilterBy.Text.Trim()) || !_FilteringColumnHeaderNames.ContainsKey(cmbFilterBy.Text))
            {
                _dtPeople.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtPeople.Rows.Count}";
                return;
            }

            string FilterColumn = _FilteringColumnHeaderNames[cmbFilterBy.Text];

            if (FilterColumn == "PersonID")
            {
                if (int.TryParse(txtSearch.Text.Trim(), out int ID))
                    _dtPeople.DefaultView.RowFilter = $"[{FilterColumn}] = {ID}";

            }
            else
            {
                _dtPeople.DefaultView.RowFilter = $"[{FilterColumn}] LIKE '{txtSearch.Text.Trim()}%'";
            }

            lblRecordCount.Text = $"Records: {_dtPeople.Rows.Count}";
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form DetailsFrm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            DetailsFrm.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this Person Permanently", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (clsPerson.Delete((int)dgvPeople.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("Person Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridView();
                }
                else
                    MessageBox.Show("An Error Occured Data is not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvPeople_DoubleClick(object sender, EventArgs e)
        {
            Form DetailsFrm = new frmShowPersonInfo((int)dgvPeople.CurrentRow.Cells[0].Value);
            DetailsFrm.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Adde Yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Adde Yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
