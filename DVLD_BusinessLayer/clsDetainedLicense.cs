using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsDetainedLicense
    {
        private enum enMode { AddNew = 0, Update = 1}
        private enMode _Mode;
        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }
        public DateTime? ReleaseDate { set; get; }
        public int? ReleasedByUserID { set; get; }
        public int? ReleaseApplicationID { set; get; }

        private dtoDetainedLicense _ToDTO()
        {
            return new dtoDetainedLicense 
            {
                DetainID = this.DetainID,
                LicenseID = this.LicenseID,
                DetainDate = this.DetainDate,
                FineFees = this.FineFees,
                CreatedByUserID = this.CreatedByUserID,
                IsReleased = this.IsReleased,
                ReleaseDate = this.ReleaseDate,
                ReleasedByUserID = this.ReleasedByUserID,
                ReleaseApplicationID = this.ReleaseApplicationID
            };

        }

        public clsDetainedLicense ()
        {
            _Mode = enMode.AddNew;
        }

        private clsDetainedLicense (dtoDetainedLicense dto)
        {
            _Mode = enMode.Update;

            this.DetainID = dto.DetainID;
            this.LicenseID = dto.LicenseID;
            this.DetainDate = dto.DetainDate;
            this.FineFees = dto.FineFees;
            this.CreatedByUserID = dto.CreatedByUserID;
            this.IsReleased = dto.IsReleased;
            this.ReleaseDate = dto.ReleaseDate;
            this.ReleasedByUserID = dto.ReleasedByUserID;
            this.ReleaseApplicationID = dto.ReleaseApplicationID;
        }

        private bool _AddNewDetainedLicense ()
        {
            int? NewDetainID = clsDetainedLicenseDataAccess.DetainNewLicense(_ToDTO());
            if (NewDetainID.HasValue)
            {
                this.DetainID = NewDetainID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _UpdateDetainedLicense()
        {
            bool? Result = clsDetainedLicenseDataAccess.UpdateDetainedLicense(_ToDTO());
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public static clsDetainedLicense FindByDetainID (int DetainID)
        {
           dtoDetainedLicense dto = clsDetainedLicenseDataAccess.FindDetainedLicenseByDetainID(DetainID);
            if (dto != null)
                return new clsDetainedLicense(dto);
            else
                return null;
        }

        public static clsDetainedLicense FindByLicenseID (int LicenseID)
        {
            dtoDetainedLicense dto = clsDetainedLicenseDataAccess.FindDetainedLicenseByLicenseID(LicenseID);
            if (dto != null)
                return new clsDetainedLicense(dto);
            else
                return null;
        }

        public static DataTable GetAllDetainedLicenses ()
        {
            return clsDetainedLicenseDataAccess.GetAllDetainedLicenses();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:
                    return _UpdateDetainedLicense();
            }

            return false;
        }

        public static bool IsLicenseDetained (int LicneseID)
        {
            bool? Result = clsDetainedLicenseDataAccess.IsLicenseDetained(LicneseID);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool ReleaseDetainLicense (int ReleasedByUserID, int ReleaseApplicationID)
        {
            bool? Result = clsDetainedLicenseDataAccess.ReleaseDetainLicense(this.DetainID, ReleasedByUserID, ReleaseApplicationID);
            if (Result == true)
            {
                this.IsReleased = true;
                this.ReleaseDate = DateTime.Now;
                this.ReleasedByUserID = ReleasedByUserID;
                this.ReleaseApplicationID = ReleaseApplicationID;
            }

            return Result ?? false;
        }
    }
}
