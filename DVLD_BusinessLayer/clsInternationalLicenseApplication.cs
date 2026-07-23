using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsInternationalLicenseApplication : clsApplication
    {
        public int InternationalLicenseID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }

        public clsInternationalLicenseApplication()
        {
            _Mode = enMode.AddNew;
        }

        private clsInternationalLicenseApplication(dtoApplication dtoApp, dtoInternationalLicense dtoIlicense)
        {
            this.ApplicationID = dtoApp.ApplicationID;
            this.ApplicantPersonID = dtoApp.ApplicantPersonID;
            this.ApplicationDate = dtoApp.ApplicationDate;
            this.ApplicationType = (enApplicationType)dtoApp.ApplicationTypeID;
            this.ApplicationStatus = (enApplicationStatus)dtoApp.ApplicationStatus;
            this.LastStatusDate = dtoApp.LastStatusDate;
            this.PaidFees = dtoApp.PaidFees;
            this.CreatedByUserID = dtoApp.CreatedByUserID;

            this.InternationalLicenseID = dtoIlicense.InternationalLicenseID;
            this.DriverID = dtoIlicense.DriverID;
            this.IssuedUsingLocalLicenseID = this.IssuedUsingLocalLicenseID;
            this.IssueDate = dtoIlicense.IssueDate;
            this.ExpirationDate = dtoIlicense.ExpirationDate;
            this.IsActive = dtoIlicense.IsActive;
        }

        public static clsInternationalLicenseApplication GetInternationalDrivingLicenseApplicationObj(int InternationalLicenseID)
        {
            dtoInternationalLicense dtoIlicense = clsInternationalLicenseApplicationDataAccess.FindLicenseByID(InternationalLicenseID);
            if (dtoIlicense != null)
            {
                dtoApplication dtoBase = clsApplicationDataAccess.FindApplicationByID(dtoIlicense.ApplicationID);
                if (dtoBase != null)
                {
                    return new clsInternationalLicenseApplication(dtoBase, dtoIlicense);
                }
                else
                    return null;
            }
            return null;
        }

        private dtoInternationalLicense ToDTO()
        {
            return new dtoInternationalLicense
            {
                InternationalLicenseID = this.InternationalLicenseID,
                ApplicationID = this.ApplicationID,
                DriverID = this.DriverID,
                IssuedUsingLocalLicenseID = this.IssuedUsingLocalLicenseID,
                IssueDate = this.IssueDate,
                ExpirationDate = this.ExpirationDate,
                IsActive = this.IsActive,
                CreatedByUserID = this.CreatedByUserID
            };
        }

        private bool _Add()
        {
            int? NewID = clsInternationalLicenseApplicationDataAccess.IssueNewLicense(ToDTO());
            if (NewID.HasValue)
            {
                this.InternationalLicenseID= NewID.Value;
                return true;
            }
            else
                return false;
        }
        private bool _Update()
        {
            bool? Result = clsInternationalLicenseApplicationDataAccess.UpdateIssuedLicense(ToDTO());
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }


        public override bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (!base.Save())
                        return false;

                    if (!_Add())
                        return false;

                    _Mode = enMode.Update;
                    return true;

                case enMode.Update:
                    if (!base.Save())
                        return false;

                    if (!_Update())
                        return false;

                    return true;
            }
            return false;
        }

        public static int GetActiveInternationalLicenseIDByDriverID(int DriverID)
        {

            int? ID = clsInternationalLicenseApplicationDataAccess.GetActiveInternationalLicenseIDbyDriverID(DriverID);
            if (ID.HasValue)
            {
                return ID.Value;
            }
            else
                return 0;
        }
        
        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {
            return clsInternationalLicenseApplicationDataAccess.GetDriverInternationalLicenses(DriverID);
        }

        public static DataTable GetAllInternationalLicenses ()
        {
            return clsInternationalLicenseApplicationDataAccess.GetAllInternationalLicenses();
        }
    }
}
