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

namespace DVLD.People.UserControls
{
    public partial class ctrlPersonCardWithFilters : UserControl
    {
        public event Action<int> OnPersonSelected;

        public ctrlPersonCardWithFilters()
        {
            InitializeComponent();
        }

        private int _PersonID = -1;
        public int PersonID
        {
            get { return ctrlPersonCard1.PersonID; }
        }

        public clsPerson PersonInfo
        {
            get { return ctrlPersonCard1.SelectedPersonInfo; }
        }

        private bool _ShowAddPerson = true;

        public bool ShowAddPerson
        {
            get { return _ShowAddPerson; }

            set
            {
                _ShowAddPerson = value;
                btnAdd.Visible = _ShowAddPerson;
            }
        }

        private bool _FilterEnabled = true;

        public bool FilterEnabled
        {
            get { return _FilterEnabled; }

            set
            {
                _FilterEnabled = value;
                pnlToolbar.Enabled = _FilterEnabled;
            }
        }

        public void LoadPersonInfo(int PersonID)
        {
            cmbFilterBy.SelectedIndex = 1;
            txtSearch.Text = PersonID.ToString();
            FindNow(RaiseEvent: false);
        }

        private void FindNow(bool RaiseEvent = true)
        {
            switch (cmbFilterBy.Text)
            {
                case "Person ID":
                    int.TryParse(txtSearch.Text.Trim(), out int personID);
                    ctrlPersonCard1.LoadPersonInfo(personID == 0 ? -1 : personID);
                    break;

                case "National No.":
                    ctrlPersonCard1.LoadPersonInfo(txtSearch.Text);
                    break;

                default:
                    break;
            }

            //firing the event to send personID to the parent
            if (RaiseEvent)
                OnPersonSelected?.Invoke(ctrlPersonCard1.PersonID);
        }

        private void ReturnAddedPersonID(int PersonID)
        {
            cmbFilterBy.SelectedIndex = 1;
            txtSearch.Text = PersonID.ToString();
            ctrlPersonCard1.LoadPersonInfo(PersonID);
        }

        private void cmbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = " ";
            txtSearch.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are Empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FindNow(RaiseEvent: true);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditPerson frm1 = new frmAddEditPerson();
            frm1.OnPersonAddedOrUpdated += ReturnAddedPersonID;
            frm1.ShowDialog();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

            if (e.KeyChar == (char)13)
                btnSearch.PerformClick();
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
        private void PersonCardWithFilters_Load(object sender, EventArgs e)
        {
            cmbFilterBy.SelectedIndex = 1;
            txtSearch.Focus();
        }

        public void FilterFocus()
        {
            txtSearch.Focus();
        }

        public void ResetControl ()
        {
            _FilterEnabled = true;
            _ShowAddPerson = true;
            ctrlPersonCard1.ResetPersonInfo();
        }
    }
}
