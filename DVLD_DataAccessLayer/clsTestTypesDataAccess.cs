using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
namespace DVLD_DataAccessLayer
{
    public class dtoTestType
    {
        public int TestTypeID { set; get; }
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }
    }

    public class clsTestTypesDataAccess
    {
        public static dtoTestType GetTestTypeObj(int ID)
        {
            string Query = @"SELECT TestTypeTitle, TestTypeDescription, TestTypeFees FROM TestTypes
                            WHERE TestTypeID = @TestTypeID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoTestType
                        {
                            TestTypeID = ID,
                            TestTypeTitle = (string)Reader["TestTypeTitle"],
                            TestTypeDescription = (string)Reader["TestTypeDescription"],
                            TestTypeFees = (decimal)Reader["TestTypeFees"]
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

        public static bool? UpdateTestType(dtoTestType dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE TestTypes
                             SET TestTypeTitle = @TestTypeTitle,
                                 TestTypeDescription = @TestTypeDescription,
                                 TestTypeFees = @TestTypeFees
                             WHERE TestTypeID = @TestTypeID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@TestTypeTitle", SqlDbType.NVarChar, 100).Value = dto.TestTypeTitle;
                command.Parameters.Add("@TestTypeDescription", SqlDbType.NVarChar, 500).Value = dto.TestTypeDescription;
                command.Parameters.Add("@TestTypeFees", SqlDbType.SmallMoney).Value = dto.TestTypeFees;
                command.Parameters.Add("@TestTypeID", SqlDbType.Int).Value = dto.TestTypeID;
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

        public static int? AddTestType(dtoTestType dto)
        {
            string Query = @"INSERT INTO TestTypes (TestTypeTitle, TestTypeDescription, TestTypeFees)
                             VALUES (@TestTypeTitle, @TestTypeDescription, @TestTypeFees);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";


            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@TestTypeTitle", SqlDbType.NVarChar, 100).Value = dto.TestTypeTitle;
                command.Parameters.Add("@TestTypeDescription", SqlDbType.NVarChar, 500).Value = dto.TestTypeDescription;
                command.Parameters.Add("@TestTypeFees", SqlDbType.SmallMoney).Value = dto.TestTypeFees;
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

        public static DataTable GetAllTestTypes()
        {
            DataTable DT = new DataTable();

            string Query = @"SELECT TestTypeID, TestTypeTitle, TestTypeDescription, TestTypeFees 
                             FROM TestTypes;";

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
