using DVLD.Classes;
using DVLD.Global_Classes;
using DVLD.Properties;
using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmAddEditPerson : Form
    {
        public event Action<int> OnPersonAddedOrUpdated;
        private enum enMode { AddNew = 0, Update = 1 };
        public enum enGender { Male = 0, Female = 1};

        private enMode _FormMode;
        private int _ID;
        private clsPerson _Person;

        public frmAddEditPerson(int ID)
        {
            InitializeComponent();
            _ID = ID;
            _FormMode = enMode.Update;
        }

        public frmAddEditPerson()
        {
            InitializeComponent();
            _ID = -1;
            _FormMode = enMode.AddNew;
        }

        private void _FillCountriesComboBox()
        {
            DataTable dtCountries = clsCountry.ListCountries();
            foreach (DataRow row in dtCountries.Rows)
            {
                cmbCountry.Items.Add(row["CountryName"]);
            }
        }

        private void _ResetEmptyFormData ()
        {
            //Filling countries combo box
            cmbCountry.Items.Clear();
            _FillCountriesComboBox();

            //Changing the form Title depending on the form Mode
            if (_FormMode == enMode.AddNew)
            {
                lblTitle.Text = "Add New Person";
                lblPersonIDValue.Text = "N/A";
                _Person = new clsPerson();
            }
            else
            {
                lblTitle.Text = "Update A Person";
            }

            //Making the Male Radio button as default with its image and hiding RemoveImage Link
            rbMale.Checked = true;
            picPersonImage.Image = Resources.man;
            llRemoveImage.Visible = false;

            //Putting the dtp value dinamicly with every form load call

            dtpDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            dtpDateOfBirth.Value = dtpDateOfBirth.MaxDate;
            dtpDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            //Set Default country
            cmbCountry.SelectedIndex = cmbCountry.FindString("Egypt");

            //Set All TextBoxes
            txtFirstName.Text = "";
            txtSecondName.Text = "";
            txtThirdName.Text = "";
            txtLastName.Text = "";
            txtNationalNo.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtAddress.Text = "";
        }

        private void _LoadPersonData()
        {
            _Person = clsPerson.Find(_ID);

            if (_Person == null)
            {
                MessageBox.Show($"Person With ID {_ID} Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblPersonIDValue.Text = _Person.PersonID.ToString();

            cmbCountry.SelectedIndex = cmbCountry.FindString(clsCountry.Find(_Person.CountryID).CountryName);
            txtFirstName.Text = _Person.FirstName;
            txtSecondName.Text = _Person.SecondName;
            txtThirdName.Text = _Person.ThirdName;
            txtLastName.Text = _Person.LastName;
            txtNationalNo.Text = _Person.NationalNo;
            dtpDateOfBirth.Value = _Person.DateOfBirth;

            rbMale.Checked = _Person.Gender == 0;
            rbFemale.Checked = _Person.Gender == 1;

            txtPhone.Text = _Person.Phone;
            txtEmail.Text = _Person.Email;
            txtAddress.Text = _Person.Address;

            if (!string.IsNullOrEmpty(_Person.ImagePath))
            {
                picPersonImage.ImageLocation = _Person.ImagePath;
                llRemoveImage.Visible = true;
            }
        }

        private bool _HandleImage()
        {
            //checking for any change on loaded image
            if (picPersonImage.ImageLocation != _Person.ImagePath)
            {
                //checking if the their is an image for this perosn already
                if (!string.IsNullOrEmpty(_Person.ImagePath))
                {
                    //delete any old image that person have
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException iox)
                    {
                        MessageBox.Show(iox.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                //check if their is any new image loaded
                if (!string.IsNullOrEmpty(picPersonImage.ImageLocation))
                {
                    //handling this change
                    string ImageSourceFile = picPersonImage.ImageLocation;
                    if (clsUtil.CopyImageToProjectImageDirectory(ref ImageSourceFile))
                    {
                        //loading the new image from the new location
                        picPersonImage.ImageLocation = ImageSourceFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
            }

            //reaching this point mean that the loaded image never changed
            return true;
        }

        private void frmAddEditPerson_Load(object sender, EventArgs e)
        {
            _ResetEmptyFormData();
            if (_FormMode == enMode.Update)
            {
                _LoadPersonData();
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide or empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!_HandleImage())
                return;

            _Person.FirstName = txtFirstName.Text.Trim();
            _Person.SecondName = txtSecondName.Text.Trim();
            _Person.ThirdName = txtThirdName.Text.Trim();
            _Person.LastName = txtLastName.Text.Trim();
            _Person.NationalNo = txtNationalNo.Text.Trim();
            _Person.DateOfBirth = dtpDateOfBirth.Value;
            _Person.Phone = txtPhone.Text.Trim();
            _Person.Email = txtEmail.Text.Trim();
            _Person.Address = txtAddress.Text.Trim();

            _Person.CountryID = clsCountry.Find(cmbCountry.Text).CountryID;

            if (rbMale.Checked)
                _Person.Gender = (byte)enGender.Male;
            else
                _Person.Gender = (byte)enGender.Female;

            if (picPersonImage.ImageLocation != null)
                _Person.ImagePath = picPersonImage.ImageLocation;
            else
                _Person.ImagePath = string.Empty;

            if (_Person.Save())
            {
                _FormMode = enMode.Update;
                lblTitle.Text = "Update A Person";
                lblPersonIDValue.Text = _Person.PersonID.ToString();

                MessageBox.Show("Data Saved Successfully", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OnPersonAddedOrUpdated?.Invoke(_Person.PersonID);
            }
            else
                MessageBox.Show("Data is not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtNationalNo, "This field is required!");
                return;
            }
            else
            {
                epErrorProvider.SetError(txtNationalNo, null);
            }

            //Handling if National Number changed and not
            if (txtNationalNo.Text.Trim() != _Person.NationalNo && clsPerson.IsPersonExists(txtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtNationalNo, "There is anther person with the same National No!");
            }
            else
            {
                epErrorProvider.SetError(txtNationalNo, "");
            }
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
                return;

            if (!clsValidatoin.ValidateEmail(txtEmail.Text.Trim()))
            {
                e.Cancel = true;
                epErrorProvider.SetError(txtEmail, "Invalid Email Format!");
            }
            else
            {
                epErrorProvider.SetError(txtEmail, null);
            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (picPersonImage.ImageLocation == null)
                picPersonImage.Image = Resources.man;
        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (picPersonImage.ImageLocation == null)
                picPersonImage.Image = Resources.woman;
        }


        private void llSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ofdSelectPersonImage.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            ofdSelectPersonImage.FilterIndex = 1;
            ofdSelectPersonImage.RestoreDirectory = true;

            if (ofdSelectPersonImage.ShowDialog() == DialogResult.OK)
            {
                string SelectedFilePath = ofdSelectPersonImage.FileName;
                picPersonImage.ImageLocation = SelectedFilePath;
                llRemoveImage.Visible = true;
            }
        }

        private void llRemoveImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            picPersonImage.ImageLocation = null;

            if (rbMale.Checked)
                picPersonImage.Image = Resources.man;
            else
                picPersonImage.Image = Resources.woman;

            llRemoveImage.Visible = false;
        }
    }
}
