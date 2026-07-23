using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_DataAccessLayer
{
    public class dtoTest
    {
        public int TestID { set; get; }
        public int TestAppointmentID { set; get; }
        public bool TestResult { set; get; }
        public string Notes { set; get; }
        public int CreatedByUserID { set; get; }
    }



    public class clsTestDataAccess
    {
        public static dtoTest GetTestByID (int ID)
        {
            string Query = @"SELECT TestAppointmentID, TestResult, Notes, CreatedByUserID FROM Tests
                             WHERE TestID = @TestID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@TestID", SqlDbType.Int).Value = ID;
                try
                {
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoTest
                        {
                            TestID = (int)Reader["TestID"],
                            TestAppointmentID = (int)Reader["TestAppointmentID"],
                            TestResult = (bool)Reader["TestResult"],
                            Notes = (string)Reader["Notes"] ?? string.Empty,
                            CreatedByUserID = (int)Reader["CreatedByUserID"]
                        };
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static int? AddNewTest (dtoTest dto)
        {
            string Query = @"INSERT INTO Tests (TestAppointmentID, TestResult, Notes, CreatedByUserID)
                             VALUES (@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID);
                             
                             UPDATE TestAppointments SET IsLocked = 1 WHERE TestAppointmentID = @TestAppointmentID;

                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = dto.TestAppointmentID;
                Command.Parameters.Add("@TestResult", SqlDbType.Bit).Value = dto.TestResult;
                Command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = string.IsNullOrEmpty(dto.Notes) ? DBNull.Value : (object)dto.Notes;
                Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
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

        public static bool? UpdateTest(dtoTest dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE Tests SET TestResult = @TestResult,
                                              TestAppointmentID = @TestAppointmentID,
                                              Notes = @Notes,
                                              CreatedByUserID = @CreatedByUserID
                             WHERE TestID = @TestID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@TestAppointmentID", SqlDbType.Int).Value = dto.TestAppointmentID;
                Command.Parameters.Add("@TestResult", SqlDbType.Bit).Value = dto.TestResult;
                Command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = string.IsNullOrEmpty(dto.Notes) ? DBNull.Value : (object)dto.Notes;
                Command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                Command.Parameters.Add("@TestID", SqlDbType.Int).Value = dto.TestID;
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
            
        public static int? GetPassedTestsForLocalDrivingLicenseApplicationID(int LocalDrivingLicenseID)
        {
            string Query = @"SELECT COUNT(*) FROM Tests t INNER JOIN TestAppointments tp ON t.TestAppointmentID = tp.TestAppointmentID
                             WHERE tp.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND t.TestResult = 1;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LocalDrivingLicenseID;
                try
                {
                    Connection.Open();
                    object Qresult = Command.ExecuteScalar();
                    return (int)Qresult;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static dtoTest FindLastTest (int LocalDrivingLicenseApplicationID, int TestTypeID)
        {
            string Query = @"SELECT TOP(1) t.TestID, t.TestAppointmentID, t.TestResult, t.Notes, t.CreatedByUserID 
                            FROM Tests t INNER JOIN TestAppointments tp ON t.TestAppointmentID = tp.TestAppointmentID
                            WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID
                            ORDER BY t.TestAppointmentID DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LocalDrivingLicenseApplicationID;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
                try
                {
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoTest
                        {
                            TestID = (int)Reader["TestID"],
                            TestAppointmentID = (int)Reader["TestAppointmentID"],
                            TestResult = (bool)Reader["TestResult"],
                            Notes = (string)Reader["Notes"] ?? string.Empty,
                            CreatedByUserID = (int)Reader["CreatedByUserID"]
                        };
                    }
                }
                catch
                {
                    return null;
                }
            }
            return null;
        }

        public static DataTable GetAllTestsResults()
        {
            DataTable dtTests = new DataTable();
            string Query = @"SELECT TestID, TestAppointmentID, TestResult, Notes, CreatedByUserID
                             FROM Tests";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    dtTests.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtTests;
                }

                return dtTests;
            }
        }
    }
}
