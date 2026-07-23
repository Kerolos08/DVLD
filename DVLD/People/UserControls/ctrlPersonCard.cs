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
using System.IO;
using DVLD.Properties;
using DVLD.Global_Classes;

namespace DVLD.People.UserControls
{
    public partial class ctrlPersonCard : UserControl
    {
        private clsPerson _Person;
        private int _PersonID;

        public int PersonID
        {
            get { return _PersonID; }
        }

        public clsPerson SelectedPersonInfo
        {
            get { return _Person; }
        }

        public ctrlPersonCard()
        {
            InitializeComponent();
        }

        public void LoadPersonInfo(int PersonID)
        {
            _Person = clsPerson.Find(PersonID);

            if (_Person == null)
            {
                MessageBox.Show("Error: Person is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonInfo();
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(string NationalNo)
        {
            _Person = clsPerson.Find(NationalNo);

            if (_Person == null)
            {
                MessageBox.Show("Error: Person is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonInfo();
                return;
            }

            _FillPersonInfo();
        }

        public void LoadPersonInfo(clsPerson Person)
        {
            if (Person == null)
            {
                MessageBox.Show("Error: Person is not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ResetPersonInfo();
                return;
            }

            _Person = Person;
            _FillPersonInfo();
        }

        private void _LoadImage ()
        {
            string ImagePath = _Person.ImagePath;
            if (string.IsNullOrEmpty(ImagePath))
            {
                if (_Person.Gender == 0)
                    pbPersonImage.Image = Resources.man;
                else
                    pbPersonImage.Image = Resources.woman;
            }
            else
            {
                if(File.Exists(ImagePath))
                
                    pbPersonImage.ImageLocation = ImagePath;
                
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void _FillPersonInfo()
        {
            _PersonID = _Person.PersonID;
            llEditPersonInfo.Enabled = true;

            lblPersonID.Text = _Person.PersonID.ToString();
            lblName.Text = _Person.FullName;
            lblNationalNo.Text = _Person.NationalNo;
            lblGender.Text = _Person.Gender == 0 ? "Male" : "Female";
            lblEmail.Text = _Person.Email;
            lblAddress.Text = _Person.Address;
            lblDateOfBirth.Text = _Person.DateOfBirth.ToShortDateString();
            lblCountry.Text = clsCountry.Find(_Person.CountryID).CountryName;
            lblPhone.Text = _Person.Phone;

            _LoadImage();
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            lblPersonID.Text = "[????]";
            lblName.Text = "[????]";
            lblNationalNo.Text = "[????]";
            lblGender.Text = "[????]";
            lblEmail.Text = "[????]";
            lblAddress.Text = "[????]";
            lblDateOfBirth.Text = "[????]";
            lblCountry.Text = "[????]";
            lblPhone.Text = "[????]";
            pbPersonImage.Image = Resources.man;
        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frmEdit = new frmAddEditPerson(_PersonID);
            frmEdit.ShowDialog();

            //Refresh
            LoadPersonInfo(_PersonID);
        }

    }
}
