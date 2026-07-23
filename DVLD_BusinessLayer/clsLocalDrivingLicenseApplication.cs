using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static DVLD_BusinessLayer.clsApplication;

namespace DVLD_BusinessLayer
{
    public class clsLocalDrivingLicenseApplication : clsApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }

        public clsLocalDrivingLicenseApplication()
        {
            _Mode = enMode.AddNew;
        }

        private clsLocalDrivingLicenseApplication(dtoApplication dtoApp, dtoLDLapplication dtoLDL)
        {
            this.ApplicationID = dtoApp.ApplicationID;
            this.ApplicantPersonID = dtoApp.ApplicantPersonID;
            this.ApplicationDate = dtoApp.ApplicationDate;
            this.ApplicationType = (enApplicationType)dtoApp.ApplicationTypeID;
            this.ApplicationStatus = (enApplicationStatus)dtoApp.ApplicationStatus;
            this.LastStatusDate = dtoApp.LastStatusDate;
            this.PaidFees = dtoApp.PaidFees;
            this.CreatedByUserID = dtoApp.CreatedByUserID;

            this.LocalDrivingLicenseApplicationID = dtoLDL.LocalDrivingLicenseApplicationID;
            this.LicenseClassID = dtoLDL.LicenseClassID;
            this._Mode = enMode.Update;
        }

        public static clsLocalDrivingLicenseApplication GetLocalDrivingLicenseApplicationObj(int LocalDrivingLicenseApplicationID)
        {
            dtoLDLapplication dtoLDLapp = clsLocalDrivingLicenseApplicationDataAccess.FindLocalDrivingLicenseApplicationWithID(LocalDrivingLicenseApplicationID);
            if (dtoLDLapp != null)
            {
                dtoApplication dtoBase = clsApplicationDataAccess.FindApplicationByID(dtoLDLapp.ApplicationID);
                if (dtoBase != null)
                {
                    return new clsLocalDrivingLicenseApplication(dtoBase, dtoLDLapp);
                }
                else
                    return null;
            }
            return null;
        }

        private dtoLDLapplication ToDTO()
        {
            return new dtoLDLapplication
            {
                LocalDrivingLicenseApplicationID = this.LocalDrivingLicenseApplicationID,
                LicenseClassID = this.LicenseClassID,
                ApplicationID = this.ApplicationID
            };
        }

        private bool _Add()
        {
            int? NewID = clsLocalDrivingLicenseApplicationDataAccess.SubmitNewDrivingLicenseRequest(ToDTO());
            if (NewID.HasValue)
            {
                this.LocalDrivingLicenseApplicationID = NewID.Value;
                return true;
            }
            else
                return false;
        }
        private bool _Update()
        {
            bool? Result = clsLocalDrivingLicenseApplicationDataAccess.UpdateLocalDrivingApplication(ToDTO());
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool DeleteLocalDrivingLicenseApplication()
        {
            bool? Result = clsLocalDrivingLicenseApplicationDataAccess.DeleteLocalDrivingApplication(this.LocalDrivingLicenseApplicationID);
            if (Result.HasValue && Result.Value)
            {
                return base.Delete();
            }
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

        public static bool IsApplicantHaveActiveLicenseRequestWithSameClass(int PersonID, int ClassID)
        {
            bool? Result = clsLocalDrivingLicenseApplicationDataAccess.IsApplicantHaveLicenseRequestWithTheSameClass(PersonID, ClassID);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            return clsLocalDrivingLicenseApplicationDataAccess.GetAllLocalDrivingLicenseApplications();
        }

        public static int GetPassedTestsForLicenseApplication(int ID)
        {
            return clsTest.GetPassedTestsCount(ID);
        }

        public int GetPassedTestsForLicenseApplication()
        {
            return clsTest.GetPassedTestsCount(this.LocalDrivingLicenseApplicationID);
        }

        public static bool DoesPassAllTests (int ID)
        {
            return clsTest.PassedAllTests(ID);
        }

        public bool DoesPassAllTests()
        {
            return clsTest.PassedAllTests(this.LocalDrivingLicenseApplicationID);
        }

        public static clsTest GetLastTestResult(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            return clsTest.GetLastTestResultForRequest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public clsTest GetLastTestResult(clsTestType.enTestType TestTypeID)
        {
            return clsTest.GetLastTestResultForRequest(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
        }

        public static int TotalTrialsForTest(int LocalDrivingLicenseApplicationID, clsTestType.enTestType TestTypeID)
        {
            int? Trails = clsLocalDrivingLicenseApplicationDataAccess.TotalTrialsPerTest(LocalDrivingLicenseApplicationID, (int)TestTypeID);
            if (Trails.HasValue)
                return Trails.Value;
            else
                return 0;
        }

        public bool DoesPassedLastTestType(clsTestType.enTestType TestTypeID)
        {
            bool? LastTestResult = clsLocalDrivingLicenseApplicationDataAccess.GetLastTestResult(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
            if (LastTestResult.HasValue)
                return LastTestResult.Value;
            else
                return false;
        }

        public static bool HasOpenTestAppointment(int LDLApplicationID, clsTestType.enTestType TestTypeID)
        {
            bool? Result = clsLocalDrivingLicenseApplicationDataAccess.HasOpenTestAppointment(LDLApplicationID, (int)TestTypeID);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool DoesAttendTestType(clsTestType.enTestType TestTypeID)
        {
            bool? Result = clsLocalDrivingLicenseApplicationDataAccess.HasAttendedTestType(this.LocalDrivingLicenseApplicationID, (int)TestTypeID);
            if (Result.HasValue)
                return Result.Value;
            else
                return false;
        }

        public bool DoesPassPerviousTestType(clsTestType.enTestType TestTypeID)
        {
            switch (TestTypeID)
            {
                //doesn't need any pervious tests to be passed
                case clsTestType.enTestType.VisionTest:
                    return true;

                case clsTestType.enTestType.WrittenTest:
                    return this.DoesPassedLastTestType(clsTestType.enTestType.VisionTest);


                case clsTestType.enTestType.StreetTest:
                    return this.DoesPassedLastTestType(clsTestType.enTestType.WrittenTest);

            }
            return false;
        }

        public bool IssueLicenseForFirstTime(int CreatedByUserID, string Notes)
        {
            clsLicenseClass ClassType = clsLicenseClass.GetLicenseClassObj(this.LicenseClassID);
            clsDriver Driver = clsDriver.FindDriverByPersonID(this.ApplicantPersonID);

            if (Driver == null)
            {
                Driver = new clsDriver();
                Driver.PersonID = this.ApplicantPersonID;
                Driver.CreatedByUserID = CreatedByUserID;
                Driver.CreatedDate = DateTime.Now;
                if (!Driver.Save())
                {
                    return false;
                }
            }

            clsLicense NewLicense = new clsLicense();
            NewLicense.ApplicationID = this.ApplicationID;
            NewLicense.DriverID = Driver.DriverID;
            NewLicense.LicenseClassID = this.LicenseClassID;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = DateTime.Now.AddYears(ClassType.DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = ClassType.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = clsLicense.enIssueReason.FirstTime;
            NewLicense.CreatedByUserID = CreatedByUserID;

            if (NewLicense.Save())
            {
                this.SetAsComplete();
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsLicenseIssued()
        {
            return clsLicense.GetActiveLicenseIDbyPersonID(this.ApplicantPersonID, this.LicenseClassID) != 0;
        }

        public int GetActiveLicenseID ()
        {
            return clsLicense.GetActiveLicenseIDbyPersonID(this.ApplicantPersonID, this.LicenseClassID);
        }
    }
}
