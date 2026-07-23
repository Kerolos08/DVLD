using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDriver
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }
        public clsDriver()
        {
            _Mode = enMode.AddNew;
        }

        private clsDriver(dtoDriver dto)
        {
            _Mode = enMode.Update;

            this.DriverID = dto.DriverID;
            this.PersonID = dto.PersonID;
            this.CreatedByUserID = dto.CreatedByUserID;
            this.CreatedDate = dto.CreatedDate;
        }

        private dtoDriver _ToDTO()
        {
            return new dtoDriver
            {
                DriverID = this.DriverID,
                PersonID = this.PersonID,
                CreatedByUserID = this.CreatedByUserID,
                CreatedDate = this.CreatedDate,

            };
        }
        public static clsDriver FindDriverByDriverID(int DriverID)
        {
            dtoDriver Driver = clsDriverDataAccess.FindDriverByDriverID(DriverID);

            if (Driver != null)
            {
                return new clsDriver(Driver);
            }
            else
                return null;
        }
        public static clsDriver FindDriverByPersonID(int PersonID)
        {
            dtoDriver Driver = clsDriverDataAccess.FindDriverByPersonID(PersonID);

            if (Driver != null)
            {
                return new clsDriver(Driver);
            }
            else
                return null;
        }
        private bool AddNewDriver()
        {
            int? NewID = clsDriverDataAccess.AddNewDriver(_ToDTO());
            if (NewID.HasValue)
            {
                this.DriverID = NewID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? Result = clsDriverDataAccess.UpdateDriver(_ToDTO());
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (AddNewDriver())
                        {
                            this._Mode = enMode.Update;
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

        public static DataTable GetAllDrivers()
        {
            return clsDriverDataAccess.GetAllDrivers();
        }

        public static DataTable GetAllDriverLocalLicenses (int DriverID)
        {
            return clsLicense.ShowAllLicensesForDriver(DriverID);
        }

        public static DataTable GetAllDriverInternationalLicenses (int DriverID)
        {
            return clsInternationalLicenseApplication.GetDriverInternationalLicenses(DriverID);
        }
    }
}
