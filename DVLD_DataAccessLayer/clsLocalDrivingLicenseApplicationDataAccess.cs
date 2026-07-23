using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class dtoLDLapplication
    {
        public int ApplicationID { set; get; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public int LicenseClassID { get; set; }
    }

    public class clsLocalDrivingLicenseApplicationDataAccess
    {
        public static dtoLDLapplication FindLocalDrivingLicenseApplicationWithID(int LDLID)
        {
            string Query = @"SELECT ApplicationID, LicenseClassID FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";


            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoLDLapplication
                        {
                            LocalDrivingLicenseApplicationID = LDLID,
                            LicenseClassID = (int)Reader["LicenseClassID"],
                            ApplicationID = (int)Reader["ApplicationID"],
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

        public static int? SubmitNewDrivingLicenseRequest(dtoLDLapplication dtoLDL)
        {
            string Query = @"INSERT INTO LocalDrivingLicenseApplications (LicenseClassID, ApplicationID)
                             VALUES (@LicenseClassID, @ApplicationID);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dtoLDL.LicenseClassID;
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dtoLDL.ApplicationID;
                try
                {
                    connection.Open();
                    object Result = command.ExecuteScalar();
                    return (int?)Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? UpdateLocalDrivingApplication(dtoLDLapplication dtoLDL)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE LocalDrivingLicenseApplications
                             SET LicenseClassID = @LicenseClassID,
                                 ApplicationID = @ApplicationID
                              WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dtoLDL.LicenseClassID;
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dtoLDL.ApplicationID;
                command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = dtoLDL.LocalDrivingLicenseApplicationID;
                try
                {
                    connection.Open();
                    AffectedRows = command.ExecuteNonQuery();
                    return AffectedRows > 0;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? IsApplicantHaveLicenseRequestWithTheSameClass (int PersonID, int ClassTypeID)
        {
            string Query = @"SELECT FOUND = 1 FROM 
                             LocalDrivingLicenseApplications l INNER JOIN Applications a ON l.ApplicationID = a.ApplicationID
                             WHERE a.ApplicantPersonID = @ApplicantPersonID AND l.LicenseClassID = @LicenseClassID AND a.ApplicationStatus in (1, 3);";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = PersonID;
                Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = ClassTypeID;
                try
                {
                    Connection.Open();
                    object Qresult = Command.ExecuteScalar();
                    return Qresult != null;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? DeleteLocalDrivingApplication(int LocalDrivingLicenseID)
        {
            int RowsAffected = 0;
            string Query = @"DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LocalDrivingLicenseID;
                try
                {
                    Connection.Open();
                    RowsAffected = Command.ExecuteNonQuery();
                    return RowsAffected > 0;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static DataTable GetAllLocalDrivingLicenseApplications ()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT LocalDrivingLicenseApplicationID, ClassName, NationalNo,
                             FullName, ApplicationDate, PassedTestCount, Status
                             FROM LocalDrivingLicenseApplicationRequestsShort_View
                             ORDER BY ApplicationDate DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    dt.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dt;
                }

                return dt;
            }
        }

        public static byte? TotalTrialsPerTest(int LDLid, int TestTypeID)
        {
            string Query = @"SELECT COUNT(t.TestID)
                             FROM Tests t INNER JOIN TestAppointments tp ON t.TestAppointmentID = tp.TestAppointmentID
                             WHERE tp.TestTypeID = @TestTypeID AND tp.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLid;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;

                try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();
                    return (byte)Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? IsThereActiveScheduledTest(int LDLid, int TestTypeID)
        {
            string Query = @"SELECT TOP(1) found = 1 FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID AND IsLocked = 0;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLid;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
                try
                {
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    return result != null;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? GetLastTestResult (int LDLid, int TestTypeID)
        {
            string Query = @"SELECT TOP(1) t.TestResult 
                             FROM TestAppointments tp INNER JOIN Tests t ON t.TestAppointmentID = tp.TestAppointmentID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND TestTypeID = @TestTypeID 
                             ORDER BY tp.TestAppointmentID DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLid;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
                try
                {
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    if (result == null)
                        return null;

                    return (bool)result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? HasAttendedTestType(int LDLid, int TestTypeID)
        {
            string Query = @"SELECT TOP (1) found = 1 
                            FROM TestAppointments tp INNER JOIN Tests t ON t.TestAppointmentID = tp.TestAppointmentID
                            WHERE tp.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID AND tp.TestTypeID = @TestTypeID
                            ORDER BY tp.TestAppointmentID DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLid;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
                try
                {
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    return result != null;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? HasOpenTestAppointment(int LDLAppID, int TestTypeID)
        {
            string Query = @"SELECT TOP(1) found = 1 FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
                             AND TestTypeID = @TestTypeID AND IsLocked = 0;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@LocalDrivingLicenseApplicationID", SqlDbType.Int).Value = LDLAppID;
                Command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = TestTypeID;
                try
                {
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    return result != null;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
