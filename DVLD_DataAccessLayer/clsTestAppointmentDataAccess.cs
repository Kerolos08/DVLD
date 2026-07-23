using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class dtoTestAppointment
    {
        public int TestAppointmentID { set; get; }
        public int TestTypeID { set; get; }
        public int LocalDrivingLicenseApplicationID { set; get; }
        public DateTime AppointmentDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsLocked { set; get; }
        public int? RetakeTestApplicationID { set; get; }
    }

    public class clsTestAppointmentDataAccess
    {
        public static dtoTestAppointment FindTestAppointmentObj(int TestAppointmentID)
        {
            string Query = @"SELECT TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID
                            FROM TestAppointments
                            WHERE TestAppointmentID = @TestAppointmentID";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoTestAppointment
                        {
                            TestAppointmentID = TestAppointmentID,
                            TestTypeID = (int)Reader["TestTypeID"],
                            LocalDrivingLicenseApplicationID = (int)Reader["LocalDrivingLicenseApplicationID"],
                            AppointmentDate = (DateTime)Reader["AppointmentDate"],
                            PaidFees = (decimal)Reader["PaidFees"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"],
                            IsLocked = (bool)Reader["IsLocked"],
                            RetakeTestApplicationID = Reader["RetakeTestApplicationID"] as int?
                        };
                    }
                }
                catch
                {
                    return null;
                }

                return null;
            }
        }

        public static DataTable GetAllTestAppointmentsForTestTypeAndLocalDrivingLicenseID(int LDLappID, int TestTypeID)
        {
            DataTable dtAppointments = new DataTable();
            string Query = @"SELECT TestAppointmentID, AppointmentDate, PaidFees, IsLocked
                             FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLappID;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
                try
                {
                    Connection.Open();
                    dtAppointments.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtAppointments;
                }

                return dtAppointments;
            }
        }

        public static int? ScheduleNewTestAppointment(dtoTestAppointment dto)
        {
            string Query = @"INSERT INTO TestAppointments (TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked, RetakeTestApplicationID)
                             VALUES (@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked, @RetakeTestApplicationID);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";
            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = dto.TestTypeID;
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = dto.LocalDrivingLicenseApplicationID;
                Command.Parameters.Add("@AppointmentDate", SqlDbType.DateTime).Value = dto.AppointmentDate;
                Command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = dto.PaidFees;
                Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                Command.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = dto.IsLocked;
                Command.Parameters.Add("@RetakeTestApplicationID", SqlDbType.Int).Value = (object)dto.RetakeTestApplicationID ?? DBNull.Value;
                try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();
                    return (int)Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? EditScheduledTestAppointment(dtoTestAppointment dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE TestAppointments
                             SET TestTypeID = @TestTypeID,
                                 LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID,
                                 AppointmentDate = @AppointmentDate,
                                 PaidFees = @PaidFees,
                                 CreatedByUserID = @CreatedByUserID,
                                 IsLocked = @IsLocked,
                                 RetakeTestApplicationID = @RetakeTestApplicationID
                             WHERE TestAppointmentID = @TestAppointmentID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = dto.TestAppointmentID;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = dto.TestTypeID;
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = dto.LocalDrivingLicenseApplicationID;
                Command.Parameters.Add("@AppointmentDate", SqlDbType.DateTime).Value = dto.AppointmentDate;
                Command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = dto.PaidFees;
                Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                Command.Parameters.Add("@IsLocked", SqlDbType.Bit).Value = dto.IsLocked;
                Command.Parameters.Add("@RetakeTestApplicationID", SqlDbType.Int).Value = (object)dto.RetakeTestApplicationID ?? DBNull.Value;
                try
                {
                    Connection.Open();
                    AffectedRows = Command.ExecuteNonQuery();
                    return AffectedRows > 0;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static int? GetTestIDforTestAppointment(int TestAppointmentID)
        {
            string Query = @"select TestID from Tests where TestAppointmentID=@TestAppointmentID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = TestAppointmentID;
                try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();
                    if (Result == null || Result == DBNull.Value)
                        return null;

                    return Convert.ToInt32(Result);
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
