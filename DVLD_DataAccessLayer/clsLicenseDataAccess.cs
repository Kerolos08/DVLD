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
    public class dtoLicense
    {
        public int LicenseID { set; get; }
        public int ApplicationID { set; get; }
        public int DriverID { set; get; }
        public int LicenseClassID { set; get; }
        public DateTime IssueDate { set; get; }
        public DateTime ExpirationDate { set; get; }
        public string Notes { set; get; }
        public decimal PaidFees { set; get; }
        public bool IsActive { set; get; }
        public byte IssueReason { set; get; }
        public int CreatedByUserID { set; get; }
    }

    public class clsLicenseDataAccess
    {
        public static dtoLicense FindLicenseByID(int ID)
        {
            string Query = @"SELECT ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID
                            FROM Licenses
                            WHERE LicenseID = @LicenseID";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoLicense
                        {
                            LicenseID = ID,
                            ApplicationID = (int)Reader["ApplicationID"],
                            DriverID = (int)Reader["DriverID"],
                            LicenseClassID = (int)Reader["LicenseClassID"],
                            IssueDate = (DateTime)Reader["IssueDate"],
                            ExpirationDate = (DateTime)Reader["ExpirationDate"],
                            Notes = Reader["ApplicationID"] as string ?? string.Empty,
                            PaidFees = (decimal)Reader["PaidFees"],
                            IsActive = (bool)Reader["IsActive"],
                            IssueReason = (byte)Reader["IssueReason"],
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

        public static int? IssueNewLicense(dtoLicense dto)
        {
            string Query = @"INSERT INTO Licenses (ApplicationID, DriverID, LicenseClassID,
                             IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID)
                             Values (@ApplicationID, @DriverID, @LicenseClassID, @IssueDate,@ExpirationDate, @Notes, @PaidFees, @IsActive, @IssueReason, @CreatedByUserID);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dto.LicenseClassID;
                command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
                command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;
                command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = String.IsNullOrEmpty(dto.Notes) ? DBNull.Value : (Object)dto.Notes;
                command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = dto.PaidFees;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
                command.Parameters.Add("@IssueReason", SqlDbType.TinyInt).Value = dto.IssueReason;
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

        public static bool? UpdateIssuedLicense(dtoLicense dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE Licenses
                             SET ApplicationID = @ApplicationID,
                                 DriverID = @DriverID,
                                 LicenseClassID = @LicenseClassID,
                                 IssueDate = @IssueDate,
                                 ExpirationDate = @ExpirationDate,
                                 Notes = @Notes,
                                 PaidFees = @PaidFees,
                                 IsActive = @IsActive,
                                 IssueReason = @IssueReason,
                                 CreatedByUserID = @CreatedByUserID
                             WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;
                command.Parameters.Add("@ApplicationID", SqlDbType.Int).Value = dto.ApplicationID;
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dto.LicenseClassID;
                command.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = dto.IssueDate;
                command.Parameters.Add("@ExpirationDate", SqlDbType.DateTime).Value = dto.ExpirationDate;
                command.Parameters.Add("@Notes", SqlDbType.NVarChar, 500).Value = String.IsNullOrEmpty(dto.Notes) ? DBNull.Value : (Object)dto.Notes;
                command.Parameters.Add("@PaidFees", SqlDbType.SmallMoney).Value = dto.PaidFees;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = dto.IsActive;
                command.Parameters.Add("@IssueReason", SqlDbType.TinyInt).Value = dto.IssueReason;
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

        public static DataTable GetAllLicenses()
        {

            DataTable dtLicneses = new DataTable();
            string Query = @"SELECT ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, CreatedByUserID FROM Licenses;";

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

        public static DataTable GetDriverLicenses(int DriverID)
        {

            DataTable dtLicneses = new DataTable();
            string Query = @"SELECT l.LicenseID, l.ApplicationID, c.ClassName, l.IssueDate, l.ExpirationDate, l.IsActive
                            FROM Licenses l INNER JOIN LicenseClasses c ON l.LicenseClassID = c.LicenseClassID
                            WHERE l.DriverID = @DriverID
                            ORDER BY l.ExpirationDate DESC, l.IsActive DESC;";

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

        public static int? GetActiveLicenseIDbyPersonID(int PersonID, int LicenseClassID)
        {
            string Query = @"SELECT l.LicenseID
                             FROM Licenses l INNER JOIN Drivers d ON d.DriverID = l.DriverID
                             WHERE d.PersonID = @PersonID AND l.LicenseClassID = @LicenseClassID AND IsActive = 1;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
                Command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = LicenseClassID;
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


        public static bool? DeactivateLicense(int LicenseID)
        {
            int AffectedRows;
            string Query = @"UPDATE Licenses SET IsActive = 0 WHERE LicenseID = @LicenseID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
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
    }
}

