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
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class dtoLicenseClass
    { 
        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }
    }

    public class clsLicenseClassDataAccess
    {
        public static dtoLicenseClass GetLicenseClassObj(int ID)
        {
            string Query = @"SELECT ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees
                             FROM LicenseClasses WHERE LicenseClassID = @LicenseClassID;";
            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoLicenseClass
                        {
                            LicenseClassID = ID,
                            ClassName = (string)Reader["ClassName"],
                            ClassDescription = (string)Reader["ClassDescription"],
                            MinimumAllowedAge = Convert.ToByte(Reader["MinimumAllowedAge"]),
                            DefaultValidityLength = Convert.ToByte(Reader["DefaultValidityLength"]),
                            ClassFees = (decimal)Reader["ClassFees"]
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

        public static dtoLicenseClass GetLicenseClassObj(string ClassTitle)
        {
            string Query = @"SELECT LicenseClassID, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees
                             FROM LicenseClasses WHERE ClassName = @ClassName;";
            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ClassName", SqlDbType.NVarChar, 50).Value = ClassTitle;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoLicenseClass
                        {
                            LicenseClassID = (int)Reader["LicenseClassID"],
                            ClassName = ClassTitle,
                            ClassDescription = (string)Reader["ClassDescription"],
                            MinimumAllowedAge = Convert.ToByte(Reader["MinimumAllowedAge"]),
                            DefaultValidityLength = Convert.ToByte(Reader["DefaultValidityLength"]),
                            ClassFees = (decimal)Reader["ClassFees"]
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

        public static bool? UpdateLicenseClass(dtoLicenseClass dto)
        {
            int AffectedRows = 0;
            string Query = @"UPDATE LicenseClasses
                             SET ClassName = @ClassName,
                                 ClassDescription = @ClassDescription,
                                 MinimumAllowedAge = @MinimumAllowedAge,
                                 DefaultValidityLength = @DefaultValidityLength,
                                 ClassFees = @ClassFees
                             WHERE LicenseClassID = @LicenseClassID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ClassName", SqlDbType.NVarChar, 50).Value = dto.ClassName;
                command.Parameters.Add("@ClassDescription", SqlDbType.NVarChar, 500).Value = dto.ClassDescription;
                command.Parameters.Add("@MinimumAllowedAge", SqlDbType.TinyInt).Value = dto.MinimumAllowedAge;
                command.Parameters.Add("@DefaultValidityLength", SqlDbType.TinyInt).Value = dto.DefaultValidityLength;
                command.Parameters.Add("@ClassFees", SqlDbType.SmallMoney).Value = dto.ClassFees;
                command.Parameters.Add("@LicenseClassID", SqlDbType.Int).Value = dto.LicenseClassID;
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

        public static int? AddLicenseClass(dtoLicenseClass dto)
        {
            string Query = @"INSERT INTO LicenseClasses (ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees)
                             VALUES (@ClassName, @ClassDescription, @MinimumAllowedAge, @DefaultValidityLength, @ClassFees);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";


            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@ClassName", SqlDbType.NVarChar, 50).Value = dto.ClassName;
                command.Parameters.Add("@ClassDescription", SqlDbType.NVarChar, 500).Value = dto.ClassDescription;
                command.Parameters.Add("@MinimumAllowedAge", SqlDbType.TinyInt).Value = dto.MinimumAllowedAge;
                command.Parameters.Add("@DefaultValidityLength", SqlDbType.TinyInt).Value = dto.DefaultValidityLength;
                command.Parameters.Add("@ClassFees", SqlDbType.SmallMoney).Value = dto.ClassFees;
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

        public static DataTable GetAllLicenseClasses()
        {
            DataTable DT = new DataTable();

            string Query = @"SELECT LicenseClassID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees 
                             FROM LicenseClasses;";

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