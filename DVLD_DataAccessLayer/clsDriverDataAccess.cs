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
    public class dtoDriver
    {
        public int DriverID { set; get; }
        public int PersonID { set; get; }
        public int CreatedByUserID { set; get; }
        public DateTime CreatedDate { set; get; }
    }

    public class clsDriverDataAccess
    {
        public static dtoDriver FindDriverByDriverID(int ID)
        {
            string Query = @"SELECT PersonID, CreatedByUserID, CreatedDate
                            FROM Drivers
                            WHERE DriverID = @DriverID";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoDriver
                        {
                            DriverID = ID,
                            PersonID = (int)Reader["PersonID"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"],
                            CreatedDate = (DateTime)Reader["CreatedDate"],
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

        public static dtoDriver FindDriverByPersonID(int ID)
        {
            string Query = @"SELECT DriverID, CreatedByUserID, CreatedDate
                            FROM Drivers
                            WHERE PersonID = @PersonID";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoDriver
                        {
                            PersonID = ID,
                            DriverID = (int)Reader["DriverID"],
                            CreatedByUserID = (int)Reader["CreatedByUserID"],
                            CreatedDate = (DateTime)Reader["CreatedDate"],
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

        public static int? AddNewDriver(dtoDriver dto)
        {
            string Query = @"INSERT INTO Drivers (PersonID, CreatedByUserID, CreatedDate)
                             Values (@PersonID, @CreatedByUserID, @CreatedDate);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = dto.PersonID;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                command.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = dto.CreatedDate;

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

        public static bool? UpdateDriver(dtoDriver dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE Drivers
                             SET PersonID = @PersonID,
                                 CreatedByUserID = @CreatedByUserID,
                                 CreatedDate = @CreatedDate
                             WHERE DriverID = @DriverID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@DriverID", SqlDbType.Int).Value = dto.DriverID;
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = dto.PersonID;
                command.Parameters.Add("@CreatedByUserID", SqlDbType.Int).Value = dto.CreatedByUserID;
                command.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = dto.CreatedDate;
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

        public static DataTable GetAllDrivers()
        {

            DataTable dtDrivers = new DataTable();
            string Query = @"SELECT DriverID, PersonID, NationalNo, FullName, CreatedDate, NumberOfActiveLicenses FROM Drivers_View;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    dtDrivers.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtDrivers;
                }

                return dtDrivers;

            }
        }
    }
}