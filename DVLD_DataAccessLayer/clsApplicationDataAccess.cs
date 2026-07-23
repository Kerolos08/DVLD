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
    public class dtoApplication
    {
        public int ApplicationID { set; get; }
        public int ApplicantPersonID { set; get; }
        public DateTime ApplicationDate { set; get; }
        public int ApplicationTypeID { set; get; }
        public byte ApplicationStatus { set; get; }
        public DateTime LastStatusDate { set; get; }
        public decimal PaidFees { set; get; }
        public int CreatedByUserID { set; get; }
    }

    public class clsApplicationDataAccess
    {
        public static dtoApplication FindApplicationByID(int AppID)
        {
            string Query = @"SELECT ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID
                            FROM Applications
                            WHERE ApplicationID = @ApplicationID";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = AppID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoApplication
                        {
                            ApplicationID = AppID,
                            ApplicantPersonID = (int)Reader["ApplicantPersonID"],
                            ApplicationDate = (DateTime)Reader["ApplicationDate"],
                            ApplicationTypeID = (int)Reader["ApplicationTypeID"],
                            ApplicationStatus = (Byte)Reader["ApplicationStatus"],
                            LastStatusDate = (DateTime)Reader["LastStatusDate"],
                            PaidFees = (decimal)Reader["PaidFees"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"]
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

        public static int? AddNewApplicationRecord(dtoApplication dto)
        {
            string Query = @"INSERT INTO Applications (ApplicantPersonID, ApplicationDate, ApplicationTypeID,
                             ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID)
                             Values (@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus,@LastStatusDate, @PaidFees, @CreatedByUserID);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = dto.ApplicantPersonID;
                command.Parameters.Add("@ApplicationDate", SqlDbType.DateTime).Value = dto.ApplicationDate;
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = dto.ApplicationTypeID;
                command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = dto.ApplicationStatus;
                command.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = dto.LastStatusDate;
                command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = dto.PaidFees;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
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

        public static bool? UpdateAnApplication(dtoApplication dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE Applications
                             SET ApplicantPersonID = @ApplicantPersonID,
                                 ApplicationDate = @ApplicationDate,
                                 ApplicationTypeID = @ApplicationTypeID,
                                 ApplicationStatus = @ApplicationStatus,
                                 LastStatusDate = @LastStatusDate,
                                 PaidFees = @PaidFees,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = dto.ApplicantPersonID;
                command.Parameters.Add("@ApplicationDate", SqlDbType.DateTime).Value = dto.ApplicationDate;
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = dto.ApplicationTypeID;
                command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = dto.ApplicationStatus;
                command.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = dto.LastStatusDate;
                command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = dto.PaidFees;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;

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

        public static DataTable ListAllApplications()
        {
            DataTable dtUsers = new DataTable();
            string Query = "SELECT * FROM ApplicationsList_View ORDER BY ApplicationDate DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    dtUsers.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtUsers;
                }

                return dtUsers;
            }
        }

        public static bool? Delete(int ID)
        {
            int AffectedRows = 0;
            string Query = @"DELETE FROM Applications WHERE ApplicationID = @ApplicationID;";
            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {

                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ID;

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

        public static bool? UpdateStatus (int ApplicationID, byte status)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE Applications
                             SET ApplicationStatus = @ApplicationStatus,
                                 LastStatusDate = @LastStatusDate
                             WHERE ApplicationID = @ApplicationID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationStatus", SqlDbType.TinyInt).Value = status;
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = ApplicationID;
                command.Parameters.Add("@LastStatusDate", SqlDbType.DateTime).Value = DateTime.Now;

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

        public static bool? HaveActiveRequest(int PersonID, int ApplicationTypeID)
        {
            string Query = @"SELECT FOUND = 1 
                             FROM Applications
                             WHERE ApplicantPersonID = @ApplicantPersonID AND ApplicationTypeID = @ApplicationTypeID AND ApplicationStatus = 1;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@ApplicantPersonID", SqlDbType.Int).Value = PersonID;
                Command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ApplicationTypeID;
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
    }
}