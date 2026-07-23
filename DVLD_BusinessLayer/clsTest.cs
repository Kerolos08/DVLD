using DVLD_DataAccessLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DVLD_BusinessLayer
{
    public class clsTest
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }

        public clsTest()
        {
            _Mode = enMode.AddNew;
        }

        private clsTest(dtoTest dto)
        {
            _Mode = enMode.Update;
            this.TestID = dto.TestID;
            this.TestAppointmentID = dto.TestAppointmentID;
            this.TestResult = dto.TestResult;
            this.Notes = dto.Notes;
            this.CreatedByUserID = dto.CreatedByUserID;
        }

        private dtoTest _ToDTO()
        {
            return new dtoTest
            {
                TestID = this.TestID,
                TestAppointmentID = this.TestAppointmentID,
                TestResult = this.TestResult,
                Notes = this.Notes,
                CreatedByUserID = this.CreatedByUserID
            };
        }

        private bool _AddTest()
        {
            int? TestID = clsTestDataAccess.AddNewTest(_ToDTO());
            if (TestID.HasValue)
            {
                this.TestID = TestID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? Result = clsTestDataAccess.UpdateTest(_ToDTO());
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
                    if (_AddTest())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static int GetPassedTestsCount(int LocalDrivingLicenseApplicationID)
        {
            int? Result = clsTestDataAccess.GetPassedTestsForLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID);
            if (Result.HasValue)
                return Result.Value;
            else
                return 0;
        }

        public static clsTest GetLastTestResultForRequest (int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            dtoTest dto = clsTestDataAccess.FindLastTest(LocalDrivingLicenseApplicationID, TestTypeID);
            if (dto != null)
                return new clsTest(dto);
            else
                return null;
        }

        public static DataTable ListAllTests ()
        {
            return clsTestDataAccess.GetAllTestsResults();
        }

        public static bool PassedAllTests (int LocalDrivingLicenseApplicationID)
        {
            return clsTestDataAccess.GetPassedTestsForLocalDrivingLicenseApplicationID(LocalDrivingLicenseApplicationID) == 3;
        }
    }

}
