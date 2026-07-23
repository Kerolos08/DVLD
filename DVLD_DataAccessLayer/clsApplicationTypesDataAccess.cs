using System;
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
    public class dtoApplicationType
    {
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }
    }

    public class clsApplicationTypesDataAccess
    {
        public static int? AddNewApplicationType(dtoApplicationType dto)
        {
            string Query = @"INSERT INTO ApplicationTypes (ApplicationTypeTitle, ApplicationFees)
                             VALUES (@ApplicationTypeTitle, @ApplicationFees);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationTypeTitle", SqlDbType.NVarChar, 150).Value = dto.ApplicationTypeTitle;
                command.Parameters.Add("@ApplicationFees", SqlDbType.SmallMoney).Value = dto.ApplicationFees;
                try
                {
                    connection.Open();
                    object Result = command.ExecuteScalar();
                    return (int?) Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? ApplicationTypeEdit(dtoApplicationType dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @ApplicationTypeTitle,
                                 ApplicationFees = @ApplicationFees
                             WHERE ApplicationTypeID = @ApplicationTypeID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationTypeTitle", SqlDbType.NVarChar, 150).Value = dto.ApplicationTypeTitle;
                command.Parameters.Add("@ApplicationFees", SqlDbType.SmallMoney).Value = dto.ApplicationFees;
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = dto.ApplicationTypeID;
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

        public static dtoApplicationType GetApplicationType(int ID)
        {
            string Query = @"SELECT ApplicationTypeTitle, ApplicationFees FROM ApplicationTypes
                             WHERE ApplicationTypeID = @ApplicationTypeID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ApplicationTypeID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoApplicationType
                        {
                            ApplicationTypeID = ID,
                            ApplicationTypeTitle = (string)Reader["ApplicationTypeTitle"],
                            ApplicationFees = (decimal)Reader["ApplicationFees"]
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

        public static DataTable GetAllApplicationTypes()
        {
            DataTable DT = new DataTable();

            string Query = "SELECT ApplicationTypeID, ApplicationTypeTitle, ApplicationFees FROM ApplicationTypes";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    DT.Load(Command.ExecuteReader());
                }
                catch
                {
                    return DT;
                }

                return DT;
            }
        }
    }
}
