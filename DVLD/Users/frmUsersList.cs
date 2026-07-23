using DVLD.Global_Classes;
using DVLD.People;
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

namespace DVLD.Users
{
    public partial class frmUsersList : Form
    {
        private DataTable _dtUsers;

        private Dictionary<string, string> FilteringColumnHeadersWithNames = new Dictionary<string, string>()
        {
            {"User ID", "UserID"},
            {"UserName", "UserName"},
            {"Person ID", "PersonID"},
            {"Full Name", "FullName"},
            {"Is Active", "IsActive"}
        };

        public frmUsersList()
        {
            InitializeComponent();
        }

        private void RefreshGridView()
        {
            _dtUsers = clsUser.ListUsers();
            dgvUsers.DataSource = _dtUsers;
            lblRecordCount.Text = $"Records:{_dtUsers.Rows.Count}";
        }
        private void frmUserListing_Load(object sender, EventArgs e)
        {
            RefreshGridView();
            cmbFilterBy.SelectedIndex = 0;
            cmbActiveFilters.Visible = false;
            txtSearch.Visible = false;

            if (dgvUsers.Rows.Count > 0)
            {
                dgvUsers.Columns["UserID"].Width = 80;
                dgvUsers.Columns["UserID"].HeaderText = "User ID";

                dgvUsers.Columns["PersonID"].Width = 155;
                dgvUsers.Columns["PersonID"].HeaderText = "Person ID";

                dgvUsers.Columns["FullName"].Width = 385;
                dgvUsers.Columns["FullName"].HeaderText = "Full Name";

                dgvUsers.Columns["UserName"].Width = 155;
                dgvUsers.Columns["UserName"].HeaderText = "UserName";

                dgvUsers.Columns["IsActive"].Width = 100;
                dgvUsers.Columns["IsActive"].HeaderText = "Is Active";
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (cmbFilterBy.Text == "None" || string.IsNullOrEmpty(cmbFilterBy.Text) || !FilteringColumnHeadersWithNames.ContainsKey(cmbFilterBy.Text))
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records:{_dtUsers.Rows.Count}";
                return;
            }

            string FilterColumn = FilteringColumnHeadersWithNames[cmbFilterBy.Text];

            if (FilterColumn == "PersonID")
            {
                if (int.TryParse(txtSearch.Text, out int ID))
                    _dtUsers.DefaultView.RowFilter = $"{FilterColumn} = {ID}";
            }

            else if (FilterColumn == "FullName" || FilterColumn == "UserName")
            {
                _dtUsers.DefaultView.RowFilter = $"{FilterColumn} LIKE '{txtSearch.Text.Trim()}%'";
            }

            lblRecordCount.Text = $"Records:{_dtUsers.Rows.Count}";
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbActiveFilters.Visible = cmbFilterBy.Text == "Is Active";
            txtSearch.Visible = (cmbFilterBy.Text != "None" && !(cmbFilterBy.Text == "Is Active"));

            if (cmbActiveFilters.Visible)
            {
                cmbActiveFilters.SelectedIndex = 0;
                cmbActiveFilters.Focus();
            }
            else if (txtSearch.Visible)
            {

                txtSearch.Text = "";
                txtSearch.Focus();
            }
            else
            {
                _dtUsers.DefaultView.RowFilter = "";
                lblRecordCount.Text = $"Records: {_dtUsers.Rows.Count}";
            }
        }

        private void cmbActiveFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbActiveFilters.Text == "Yes")
                _dtUsers.DefaultView.RowFilter = "IsActive = 1";
            else if (cmbActiveFilters.Text == "No")
                _dtUsers.DefaultView.RowFilter = "IsActive = 0";
            else
                _dtUsers.DefaultView.RowFilter = "";


            lblRecordCount.Text = $"Records:{_dtUsers.Rows.Count}";

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Person ID" || cmbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmShowUserInfo frmInfo = new frmShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmInfo.ShowDialog();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmAdd = new frmAddEditUser();
            frmAdd.ShowDialog();
            RefreshGridView();
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frmEdit = new frmAddEditUser((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmEdit.ShowDialog();
            RefreshGridView();
        }

        private void ChangePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword frmAdd = new frmChangePassword((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this User Permanently", "Are you sure", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if ((int)dgvUsers.CurrentRow.Cells[0].Value == clsGlobal.CurrentUser.UserID)
                {
                    MessageBox.Show("Current User cannot be Deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (clsUser.Delete((int)dgvUsers.CurrentRow.Cells[0].Value))
                {
                    MessageBox.Show("User Deleted Successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dgvUsers_DoubleClick(object sender, EventArgs e)
        {
            frmShowUserInfo frmInfo = new frmShowUserInfo((int)dgvUsers.CurrentRow.Cells[0].Value);
            frmInfo.ShowDialog();
        }

        private void SendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Adde Yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void PhoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Adde Yet!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
