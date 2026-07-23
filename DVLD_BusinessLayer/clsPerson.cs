using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsPerson
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int CountryID { set; get; }
        public string ImagePath { set; get; }

        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }

        private dtoPerson _ToDTO()
        {
            return new dtoPerson
            {
                PersonID = this.PersonID,
                NationalNo = this.NationalNo,
                FirstName = this.FirstName,
                SecondName = this.SecondName,
                ThirdName = this.ThirdName,
                LastName = this.LastName,
                DateOfBirth = this.DateOfBirth,
                Gender = this.Gender,
                Address = this.Address,
                Phone = this.Phone,
                Email = this.Email,
                CountryID = this.CountryID,
                ImagePath = this.ImagePath
            };
        }

        public clsPerson()
        {
            this.Mode = enMode.AddNew;
        }

        private clsPerson(dtoPerson PassingPerson)
        {
            this.Mode = enMode.Update;
            this.PersonID = PassingPerson.PersonID;
            this.NationalNo = PassingPerson.NationalNo;
            this.FirstName = PassingPerson.FirstName;
            this.SecondName = PassingPerson.SecondName;
            this.ThirdName = PassingPerson.ThirdName;
            this.LastName = PassingPerson.LastName;
            this.DateOfBirth = PassingPerson.DateOfBirth;
            this.Gender = PassingPerson.Gender;
            this.Address = PassingPerson.Address;
            this.Phone = PassingPerson.Phone;
            this.Email = PassingPerson.Email;
            this.CountryID = PassingPerson.CountryID;
            this.ImagePath = PassingPerson.ImagePath;
        }

        private bool _Add()
        {
            int? NewID = clsPersonDataAccess.AddNewPerson(_ToDTO());

            if (NewID.HasValue)
            {
                this.PersonID = NewID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? UpdateResult = clsPersonDataAccess.UpdatePerson(_ToDTO());

            if (UpdateResult.HasValue)
            {
                return UpdateResult.Value;
            }
            else
            {
                return false;
            }
        }

        public static clsPerson Find(int ID)
        {
            dtoPerson dto = clsPersonDataAccess.FindPersonbyPersonID(ID);
            if (dto != null)
                return new clsPerson(dto);
            else
                return null;
        }

        public static clsPerson Find(string NationalNumber)
        {
            dtoPerson dto = clsPersonDataAccess.FindPersonbyNationalNO(NationalNumber);
            if (dto != null)
                return new clsPerson(dto);
            else
                return null;
        }

        public static DataTable ListPeople()
        {
            return clsPersonDataAccess.GetAllPeopleInSystem();
        }

        public static bool IsPersonExists(string NationalNo)
        {
            bool? Result = clsPersonDataAccess.IsPersonExist(NationalNo);
            if (Result.HasValue)
            {
                return Result.Value;
            }
            else
                return false;
        }

        public static bool Delete (int PersonID)
        {
            bool? Result = clsPersonDataAccess.DeletePerson(PersonID);
            if (Result.HasValue)
            {
                return Result.Value;
            }
            else
                return false;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_Add())
                        {
                            this.Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }

                case enMode.Update:
                    return _Update();
            }

            return false;
        }
    }
}
