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
    public class dtoInternationalLicense
    {
        public int InternationalLicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int IssuedUsingLocalLicenseID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public bool IsActive { set; get; }
        public int CreatedByUserID { set; get; }
    }

    public class clsInternationalLicenseApplicationDataAccess
    {
        public static dtoInternationalLicense FindLicenseByID(int ID)
        {
            string Query = @"SELECT ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive, CreatedByUserID
                            FROM InternationalLicenses
                            WHERE InternationalLicenseID = @InternationalLicenseID";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoInternationalLicense
                        {
                            InternationalLicenseID = ID,
                            ApplicationID = (int)Reader["ApplicationID"],
                            DriverID = (int)Reader["DriverID"],
                            IssuedUsingLocalLicenseID = (int)Reader["IssuedUsingLocalLicenseID"],
                            IssueDate = (DateTime)Reader["IssueDate"],
                            ExpirationDate = (DateTime)Reader["ExpirationDate"],
                            IsActive = (bool)Reader["IsActive"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"],
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

        public static int? IssueNewLicense(dtoInternationalLicense dto)
        {
            string Query = @"UPDATE InternationalLicenses 
                             SET IsActive = 0
                             WHERE DriverID = @DriverID;

                             INSERT INTO InternationalLicenses (ApplicationID, DriverID, IssuedUsingLocalLicenseID,
                             IssueDate, ExpirationDate, IsActive, CreatedByUserID)
                             Values (@ApplicationID, @DriverID, @IssuedUsingLocalLicenseID, @IssueDate,@ExpirationDate, @IsActive, @CreatedByUserID);

                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
                command.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = dto.IssuedUsingLocalLicenseID;
                command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
                command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
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

        public static bool? UpdateIssuedLicense(dtoInternationalLicense dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE InternationalLicenses
                             SET ApplicationID = @ApplicationID,
                                 DriverID = @DriverID,
                                 IssuedUsingLocalLicenseID = @IssuedUsingLocalLicenseID,
                                 IssueDate = @IssueDate,
                                 ExpirationDate = @ExpirationDate,
                                 IsActive = @IsActive,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE InternationalLicenseID = @InternationalLicenseID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@InternationalLicenseID", SqlDbType.Int).Value = dto.InternationalLicenseID;
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
                command.Parameters.Add("@IssuedUsingLocalLicenseID", SqlDbType.Int).Value = dto.IssuedUsingLocalLicenseID;
                command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
                command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;

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

        public static DataTable GetAllInternationalLicenses()
        {

            DataTable dtLicneses = new DataTable();
            string Query = @"SELECT InternationalLicenseID, ApplicationID, DriverID, IssuedUsingLocalLicenseID, IssueDate, ExpirationDate, IsActive
                             FROM InternationalLicenses
                             ORDER BY IsActive, ExpirationDate DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    dtLicneses.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtLicneses;
                }

                return dtLicneses;

            }
        }

        public static DataTable GetDriverInternationalLicenses(int DriverID)
        {

            DataTable dtLicneses = new DataTable();
            string Query = @"SELECT InternationalLicenseID, ApplicationID, IssuedUsingLocalLicenseID , IssueDate, ExpirationDate, IsActive
		                     FROM InternationalLicenses WHERE DriverID = @DriverID
                             ORDER BY ExpirationDate DESC";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = DriverID;
                try
                {
                    Connection.Open();
                    dtLicneses.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtLicneses;
                }

                return dtLicneses;

            }
        }

        public static int? GetActiveInternationalLicenseIDbyDriverID(int PersonID)
        {
            string Query = @"SELECT TOP 1 InternationalLicenseID
                            FROM InternationalLicenses 
                            WHERE DriverID = @DriverID AND GETDATE() BETWEEN IssueDate AND ExpirationDate 
                            ORDER BY ExpirationDate DESC;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@DriverID", SqlDbType.Int).Value = PersonID;
                try
                {
                    Connection.Open();
                    object result = Command.ExecuteScalar();
                    if (result == null)
                        return null;

                    return (int)result;
                }
                catch
                {
                    return null;
                }
            }
        }
    }
}
