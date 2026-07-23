using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer
{
    public class clsCountryDataAccess
    {
        public static DataTable GetAllCountries()
        {
            DataTable DT = new DataTable();

            string Query = "SELECT * FROM Countries";

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

        public static bool FindCountry(int ID, ref string CountryName)
        {
            string Query = "SELECT * FROM Countries WHERE CountryID = @CountryID";
            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@CountryID", SqlDbType.Int).Value = ID;
                try
                {
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.Read())
                    {
                        CountryName = (string)Reader["CountryName"];
                        return true;
                    }
                }
                catch
                {
                    return false;
                }

                return false;
            }
        }

        public static bool FindCountry(string CountryName, ref int ID)
        {
            string Query = "SELECT * FROM Countries WHERE CountryName = @CountryName";
            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@CountryName", SqlDbType.NVarChar, 50).Value = CountryName;
                try
                {
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.Read())
                    {
                        ID = (int)Reader["CountryID"];
                        return true;
                    }
                }
                catch
                {
                    return false;
                }

                return false;
            }
        }
    }
}