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
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class dtoDetainedLicense
    {
        public int DetainID { set; get; }
        public int LicenseID { set; get; }
        public DateTime DetainDate { set; get; }
        public decimal FineFees { set; get; }
        public int CreatedByUserID { set; get; }
        public bool IsReleased { set; get; }
        public DateTime? ReleaseDate { set; get; }
        public int? ReleasedByUserID { set; get; }
        public int? ReleaseApplicationID { set; get; }
    }

    public class clsDetainedLicenseDataAccess
    {
        public static dtoDetainedLicense FindDetainedLicenseByDetainID(int DetainID)
        {
            string Query = @"SELECT LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased ,ReleaseDate ,ReleasedByUserID, ReleaseApplicationID
                             FROM DetainedLicenses WHERE DetainID = @DetainID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@DetainID", SqlDbType.Int).Value = DetainID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoDetainedLicense
                        {
                            DetainID = DetainID,
                            LicenseID = (int)Reader["LicenseID"],
                            DetainDate = (DateTime)Reader["DetainDate"],
                            FineFees = (decimal)Reader["FineFees"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"],
                            IsReleased = (bool)Reader["IsReleased"],
                            ReleaseDate = Reader["ReleaseDate"] == DBNull.Value ? (DateTime?)null : (DateTime)Reader["ReleaseDate"],
                            ReleasedByUserID = Reader["ReleasedByUserID"] == DBNull.Value ? (int?)null : (int)Reader["ReleasedByUserID"],
                            ReleaseApplicationID = Reader["ReleaseApplicationID"] == DBNull.Value ? (int?)null : (int)Reader["ReleaseApplicationID"]
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

        public static dtoDetainedLicense FindDetainedLicenseByLicenseID(int LicenseID)
        {
            string Query = @"SELECT TOP(1) DetainID, DetainDate, FineFees, CreatedByUserID, IsReleased ,ReleaseDate ,ReleasedByUserID, ReleaseApplicationID
                             FROM DetainedLicenses WHERE LicenseID = @LicenseID AND IsReleased = 0;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoDetainedLicense
                        {
                            DetainID = (int)Reader["DetainID"],
                            LicenseID = LicenseID,
                            DetainDate = (DateTime)Reader["DetainDate"],
                            FineFees = (decimal)Reader["FineFees"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"],
                            IsReleased = (bool)Reader["IsReleased"],
                            ReleaseDate = Reader["ReleaseDate"] == DBNull.Value ? null : (DateTime?)Reader["ReleaseDate"],
                            ReleasedByUserID = Reader["ReleasedByUserID"] == DBNull.Value ? null : (int?)Reader["ReleasedByUserID"],
                            ReleaseApplicationID = Reader["ReleaseApplicationID"] == DBNull.Value ? null : (int?)Reader["ReleaseApplicationID"]
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

        public static int? DetainNewLicense(dtoDetainedLicense dto)
        {
            string Query = @"INSERT INTO DetainedLicenses (LicenseID, DetainDate, FineFees, CreatedByUserID, IsReleased)
                             VALUES (@LicenseID, @DetainDate, @FineFees, @CreatedByUserID, 0);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;
                command.Parameters.Add("@DetainDate", SqlDbType.DateTime).Value = dto.DetainDate;
                command.Parameters.Add("@FineFees", SqlDbType.SmallMoney).Value = dto.FineFees;
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

        public static bool? UpdateDetainedLicense(dtoDetainedLicense dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE DetainedLicenses
                             SET LicenseID = @LicenseID,
                                 DetainDate = @DetainDate,
                                 ReleasedByUserID = @ReleasedByUserID,
                                 CreatedByUserID = @CreatedByUserID,
                             WHERE DetainID = @DetainID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = dto.LicenseID;
                command.Parameters.Add("@DetainDate", SqlDbType.DateTime).Value = dto.DetainDate;
                command.Parameters.Add("@FineFees", SqlDbType.SmallMoney).Value = dto.FineFees;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                command.Parameters.Add("@DetainID", SqlDbType.Int).Value = dto.DetainID;
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

        public static bool? ReleaseDetainLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE DetainedLicenses
                             SET IsReleased = 1,
                                 ReleaseDate = @ReleaseDate,
                                 ReleasedByUserID = @ReleasedByUserID,
                                 ReleaseApplicationID = @ReleaseApplicationID
                             WHERE DetainID = @DetainID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ReleaseDate", SqlDbType.DateTime).Value = DateTime.Now;
                command.Parameters.Add("@ReleasedByUserID", SqlDbType.Int).Value = ReleasedByUserID;
                command.Parameters.Add("@ReleaseApplicationID", SqlDbType.Int).Value = ReleaseApplicationID;
                command.Parameters.Add("@DetainID", SqlDbType.Int).Value = DetainID;
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

        public static DataTable GetAllDetainedLicenses()
        {

            DataTable dtLicneses = new DataTable();
            string Query = @"SELECT DetainID, LicenseID, DetainDate, IsReleased, FineFees, ReleaseDate, NationalNo, FullName, ReleaseApplicationID FROM DetainedLicenses_View ORDER BY DetainID DESC;";

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

        public static bool? IsLicenseDetained(int LicenseID)
        {
            string Query = @"SELECT IsDetained = 1 
                            FROM DetainedLicenses 
                            WHERE LicenseID = @LicenseID AND IsReleased=0;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, Connection))
            {
                command.Parameters.Add("@LicenseID", SqlDbType.Int).Value = LicenseID;
                try
                {
                    Connection.Open();
                    object Qresult = command.ExecuteScalar();
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