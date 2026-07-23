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
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1};
        private enMode _Mode;
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int? RetakeTestApplicationID { set; get; }

        public int? TestID
        {
            get { return GetTestID(); }
        }

        public clsTestAppointment ()
        {
            _Mode = enMode.AddNew;
        }

        private clsTestAppointment (dtoTestAppointment dto)
        {
            _Mode = enMode.Update;
            TestAppointmentID = dto.TestAppointmentID;
            TestTypeID = dto.TestTypeID;
            LocalDrivingLicenseApplicationID = dto.LocalDrivingLicenseApplicationID;
            AppointmentDate = dto.AppointmentDate;
            PaidFees = dto.PaidFees;
            CreatedByUserID = dto.CreatedByUserID;
            IsLocked = dto.IsLocked;
            RetakeTestApplicationID = dto.RetakeTestApplicationID;
        }

        private dtoTestAppointment _ToDTO()
        {
            return new dtoTestAppointment 
            {
                TestAppointmentID = this.TestAppointmentID,
                TestTypeID = this.TestTypeID,
                LocalDrivingLicenseApplicationID = this.LocalDrivingLicenseApplicationID,
                AppointmentDate = this.AppointmentDate,
                PaidFees = this.PaidFees,
                CreatedByUserID = this.CreatedByUserID,
                IsLocked = this.IsLocked,
                RetakeTestApplicationID = this.RetakeTestApplicationID,
            };
        }

        public static clsTestAppointment FindScheduledTestAppointment (int TestAppointmentID)
        {
            dtoTestAppointment TestAppointment = clsTestAppointmentDataAccess.FindTestAppointmentObj(TestAppointmentID);
            if (TestAppointment != null)
                return new clsTestAppointment(TestAppointment);
            else
                return null;
        }

        private bool _AddNewTestAppointment()
        {
            int? NewID = clsTestAppointmentDataAccess.ScheduleNewTestAppointment(_ToDTO());
            if (NewID.HasValue)
            {
                this.TestAppointmentID = NewID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _UpdateAppointment()
        {
            bool? Result = clsTestAppointmentDataAccess.EditScheduledTestAppointment(_ToDTO());
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
                    if (_AddNewTestAppointment())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    else
                        return false;

                case enMode.Update:
                    return _UpdateAppointment();
            }
            return false;
        }

        public static DataTable FindAllTestAppointmentsForTestAndLocalDrivingLicenseApplicationID (int LDLappID, int TestTypeID)
        {
            return clsTestAppointmentDataAccess.GetAllTestAppointmentsForTestTypeAndLocalDrivingLicenseID(LDLappID, TestTypeID);
        }
        
        private int? GetTestID ()
        {
            return clsTestAppointmentDataAccess.GetTestIDforTestAppointment(this.TestAppointmentID);
        }
    }
}
