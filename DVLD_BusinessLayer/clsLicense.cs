using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicense
    {
        public enum enIssueReason { FirstTime = 1, Renew = 2, DamagedReplacement = 3, LostReplacement = 4 };
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClassID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsActive { set; get; }
        public enIssueReason IssueReason { set; get; }
        public int CreatedByUserID { set; get; }

        private clsDetainedLicense _detainedInfo;

        public clsDetainedLicense DetainedInfo
        {
            get
            {
                if (_detainedInfo == null)
                    _detainedInfo = clsDetainedLicense.FindByLicenseID(this.LicenseID);

                return _detainedInfo;
            }
        }
        public clsLicense()
        {
            _Mode = enMode.AddNew;
        }

        private clsLicense(dtoLicense dto)
        {
            _Mode = enMode.Update;

            this.LicenseID = dto.LicenseID;
            this.ApplicationID = dto.ApplicationID;
            this.DriverID = dto.DriverID;
            this.LicenseClassID = dto.LicenseClassID;
            this.IssueDate = dto.IssueDate;
            this.ExpirationDate = dto.ExpirationDate;
            this.Notes = dto.Notes;
            this.PaidFees = dto.PaidFees;
            this.IsActive = dto.IsActive;
            this.IssueReason = (enIssueReason)dto.IssueReason;
            this.CreatedByUserID = dto.CreatedByUserID;
        }

        private dtoLicense _ToDTO()
        {
            return new dtoLicense
            {
                LicenseID = this.LicenseID,
                ApplicationID = this.ApplicationID,
                DriverID = this.DriverID,
                LicenseClassID = this.LicenseClassID,
                IssueDate = this.IssueDate,
                ExpirationDate = this.ExpirationDate,
                Notes = this.Notes,
                PaidFees = this.PaidFees,
                IsActive = this.IsActive,
                IssueReason = (byte)this.IssueReason,
                CreatedByUserID = this.CreatedByUserID,
            };
        }
        public static clsLicense GetLicenseObj(int LicenseID)
        {
            dtoLicense license = clsLicenseDataAccess.FindLicenseByID(LicenseID);

            if (license != null)
            {
                return new clsLicense(license);
            }
            else
                return null;
        }

        private bool _IssueNewLicense()
        {
            int? NewID = clsLicenseDataAccess.IssueNewLicense(_ToDTO());
            if (NewID.HasValue)
            {
                this.LicenseID = NewID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? Result = clsLicenseDataAccess.UpdateIssuedLicense(_ToDTO());
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
                        if (_IssueNewLicense())
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

        public static string GetIssueReasonText(enIssueReason IssueReason)
        {

            switch (IssueReason)
            {
                case enIssueReason.FirstTime:
                    return "First Time";
                case enIssueReason.Renew:
                    return "Renew";
                case enIssueReason.DamagedReplacement:
                    return "Replacement for Damaged";
                case enIssueReason.LostReplacement:
                    return "Replacement for Lost";
                default:
                    return "First Time";
            }
        }
        public static DataTable ShowAllLicenses ()
        {
            return clsLicenseDataAccess.GetAllLicenses();
        }

        public static DataTable ShowAllLicensesForDriver(int DriverID)
        {
            return clsLicenseDataAccess.GetDriverLicenses(DriverID);
        }

        public static int GetActiveLicenseIDbyPersonID(int LicenseID, int LicenseClassID)
        {
            int? ID = clsLicenseDataAccess.GetActiveLicenseIDbyPersonID(LicenseID, LicenseClassID);
            if (ID.HasValue)
            {
                return ID.Value;
            }
            else
                return 0;
        }
        
        public bool IsLicenseExpired ()
        {
            return ExpirationDate < DateTime.Now;
        }

        public bool Deactivate ()
        {
            bool? Result = clsLicenseDataAccess.DeactivateLicense(this.LicenseID);

            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public clsLicense RenewLicense(int UserID, string Notes)
        {
            clsLicenseClass ClassInfo = clsLicenseClass.GetLicenseClassObj(this.LicenseClassID);

            clsApplication ReplaceApplication = new clsApplication();

            ReplaceApplication.ApplicantPersonID = clsDriver.FindDriverByDriverID(this.DriverID).PersonID;
            ReplaceApplication.ApplicationDate = DateTime.Now;
            ReplaceApplication.ApplicationType = clsApplication.enApplicationType.RenewDrivingLicense;
            ReplaceApplication.ApplicationStatus = clsApplication.enApplicationStatus.Complete;
            ReplaceApplication.LastStatusDate = DateTime.Now;
            ReplaceApplication.PaidFees = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.RenewDrivingLicense).ApplicationFees;
            ReplaceApplication.CreatedByUserID = UserID;

            if (!ReplaceApplication.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = ReplaceApplication.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(ClassInfo.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = ClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicense.enIssueReason.Renew;
            NewLicense.CreatedByUserID = UserID;

            if (!NewLicense.Save())
            {
                return null;
            }

            Deactivate();

            return NewLicense;
        }

        public clsLicense Replace (enIssueReason IssueReason, int UserID)
        {
            clsLicenseClass ClassInfo = clsLicenseClass.GetLicenseClassObj(this.LicenseClassID);

            clsApplication.enApplicationType ApplicationType = IssueReason == enIssueReason.DamagedReplacement ? clsApplication.enApplicationType.ReplacementForDamageLicense : clsApplication.enApplicationType.ReplacementForLostLicense;

            clsApplication ReplaceApplication = new clsApplication();

            ReplaceApplication.ApplicantPersonID = clsDriver.FindDriverByDriverID(this.DriverID).PersonID;
            ReplaceApplication.ApplicationDate = DateTime.Now;
            ReplaceApplication.ApplicationType = ApplicationType;
            ReplaceApplication.ApplicationStatus = clsApplication.enApplicationStatus.Complete;
            ReplaceApplication.LastStatusDate = DateTime.Now;
            ReplaceApplication.PaidFees = clsApplicationType.GetApplicationTypeObj((int)ApplicationType).ApplicationFees;
            ReplaceApplication.CreatedByUserID = UserID;

            if (!ReplaceApplication.Save())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationID = ReplaceApplication.ApplicationID;
            NewLicense.DriverID = this.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(ClassInfo.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = 0;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = IssueReason;
            NewLicense.CreatedByUserID = UserID;

            if (!NewLicense.Save())
            {
                return null;
            }

            Deactivate();

            return NewLicense;
        }

        public clsDetainedLicense DetainLicense(decimal FineFees, int CreatedByUserID)
        {
            clsDetainedLicense NewDetainedLicense = new clsDetainedLicense();

            NewDetainedLicense.LicenseID = this.LicenseID;
            NewDetainedLicense.DetainDate = DateTime.Now;
            NewDetainedLicense.FineFees = FineFees;
            NewDetainedLicense.CreatedByUserID = CreatedByUserID;
            NewDetainedLicense.IsReleased = false;

            if (!NewDetainedLicense.Save())
                return null;

            return NewDetainedLicense;
        }

        public bool ReleaseDetainedLicense (int ReleasedByUserID)
        {

            if (DetainedInfo == null)
                return false;

            //create application
            clsApplication ReleaseApplication = new clsApplication();

            ReleaseApplication.ApplicantPersonID = clsDriver.FindDriverByDriverID(this.DriverID).PersonID;
            ReleaseApplication.ApplicationDate = DateTime.Now;
            ReleaseApplication.ApplicationType = clsApplication.enApplicationType.ReleaseDetainedLicense;
            ReleaseApplication.ApplicationStatus = clsApplication.enApplicationStatus.Complete;
            ReleaseApplication.LastStatusDate = DateTime.Now;
            ReleaseApplication.PaidFees = clsApplicationType.GetApplicationTypeObj((int)clsApplication.enApplicationType.ReleaseDetainedLicense).ApplicationFees;
            ReleaseApplication.CreatedByUserID = CreatedByUserID;

            if (!ReleaseApplication.Save())
                return false;

            return DetainedInfo.ReleaseDetainLicense(ReleasedByUserID, ReleaseApplication.ApplicationID);

        }

        public bool IsDetained()
        {
            return clsDetainedLicense.IsLicenseDetained(this.LicenseID);
        }

        public static bool IsDetained(int LicenseID)
        {
            return clsDetainedLicense.IsLicenseDetained(LicenseID);

        }
    }
}