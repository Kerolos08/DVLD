using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BusinessLayer
{
    public class clsApplication
    {
        public enum enApplicationType
        {
            NewLocalDrivingLicense = 1, RenewDrivingLicense = 2, ReplacementForLostLicense = 3, ReplacementForDamageLicense = 4,
            ReleaseDetainedLicense = 5, NewInternationalLicense = 6, RetakeTest = 7
        };

        public enum enApplicationStatus { New = 1, Cancelled = 2, Complete = 3 };
        protected enum enMode { AddNew = 0, Update = 1 };

        protected enMode _Mode;
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public enApplicationType ApplicationType { set; get; }
        public enApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }

        public clsApplication()
        {
            _Mode = enMode.AddNew;
        }

        private clsApplication(dtoApplication dto)
        {
            _Mode = enMode.Update;

            this.ApplicationID = dto.ApplicationID;
            this.ApplicantPersonID = dto.ApplicantPersonID;
            this.ApplicationDate = dto.ApplicationDate;
            this.ApplicationType = (enApplicationType)dto.ApplicationTypeID;
            this.ApplicationStatus = (enApplicationStatus)dto.ApplicationStatus;
            this.LastStatusDate = dto.LastStatusDate;
            this.PaidFees = dto.PaidFees;
            this.CreatedByUserID = dto.CreatedByUserID;
        }

        public static clsApplication FindByBaseApplicationID (int ID)
        {
            dtoApplication App = clsApplicationDataAccess.FindApplicationByID(ID);
            if (App != null)
                return new clsApplication(App);
            else
                return null;
        }
        private dtoApplication _ToDTO()
        {
            return new dtoApplication
            {
                ApplicationID = this.ApplicationID,
                ApplicantPersonID = this.ApplicantPersonID,
                ApplicationDate = this.ApplicationDate,
                ApplicationTypeID = (byte)this.ApplicationType,
                ApplicationStatus = (byte)this.ApplicationStatus,
                LastStatusDate = this.LastStatusDate,
                PaidFees = this.PaidFees,
                CreatedByUserID = this.CreatedByUserID
            };
        }

        private bool _AddNewApplication()
        {
            int? NewApplicationID = clsApplicationDataAccess.AddNewApplicationRecord(_ToDTO());
            if (NewApplicationID.HasValue)
            {
                this.ApplicationID = NewApplicationID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _UpdateApplication()
        {
            bool? Result = clsApplicationDataAccess.UpdateAnApplication(_ToDTO());
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public virtual bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateApplication();
            }
            return false;
        }

        public bool Cancel ()
        {
            bool? Result = clsApplicationDataAccess.UpdateStatus(this.ApplicationID, 2);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool SetAsComplete()
        {
            bool? Result = clsApplicationDataAccess.UpdateStatus(this.ApplicationID, 3);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool Delete()
        {
            bool? Result = clsApplicationDataAccess.Delete(this.ApplicationID);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public static bool HaveActiveApplicationRequest(int PersonID, enApplicationType AppType)
        {
            bool? Result = clsApplicationDataAccess.HaveActiveRequest(PersonID, (int)AppType);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }
    }
}
