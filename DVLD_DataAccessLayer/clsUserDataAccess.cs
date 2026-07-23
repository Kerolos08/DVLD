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
    public class dtoUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }
    }
    public class clsUserDataAccess
    {
        public static dtoUser FindUserByUsername(string UserName)
        {
            string Query = @"SELECT PersonID, UserID, Password, IsActive
                            From Users
                            WHERE UserName = @UserName;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoUser
                        {
                            UserName = UserName,
                            UserID = (int)Reader["UserID"],
                            Password = (string)Reader["Password"],
                            IsActive = (bool)Reader["IsActive"],
                            PersonID = (int)Reader["PersonID"]
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

        public static dtoUser FindUserByUsernameAndPassword(string UserName, string Password)
        {
            string Query = @"SELECT PersonID, UserID, Password, IsActive
                            From Users
                            WHERE UserName = @UserName AND Password = @Password;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = Password;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoUser
                        {
                            UserName = UserName,
                            UserID = (int)Reader["UserID"],
                            Password = (string)Reader["Password"],
                            IsActive = (bool)Reader["IsActive"],
                            PersonID = (int)Reader["PersonID"]
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

        public static dtoUser FindUserByUserID(int ID)
        {
            string Query = @"SELECT PersonID, UserID, UserName, Password, IsActive
                            From Users
                            WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = ID;
                try
                {
                    connection.Open();
                    SqlDataReader Reader = command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoUser
                        {
                            UserID = ID,
                            UserName = (string)Reader["UserName"],
                            Password = (string)Reader["Password"],
                            IsActive = (bool)Reader["IsActive"],
                            PersonID = (int)Reader["PersonID"]
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

        public static int? AddNewUser (dtoUser user)
        {
            string Query = @"INSERT INTO Users (UserName, Password, IsActive, PersonID)
                             VALUES (@UserName, @Password, @IsActive, @PersonID);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = user.UserName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = user.Password;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;
                command.Parameters.Add("@PersonID", SqlDbType.Int).Value = user.PersonID;
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

        public static DataTable GetAllUsersInSystem()
        {
            DataTable dtUsers = new DataTable();
            string Query = @"SELECT U.UserID, U.PersonID,
                             P.FirstName + ' ' + P.SecondName + ' ' + P.ThirdName + ' ' + P.LastName AS FullName,
                             U.UserName, U.IsActive
                             FROM Users U INNER JOIN People P ON U.PersonID = P.PersonID
                             ORDER BY U.UserID ASC;";

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

        public static bool? UpdateUser (dtoUser user)
        {
            int RowsAffected = 0;
            string Query = @"UPDATE Users
                             SET UserName = @UserName, 
                                 Password = @Password,
                                 IsActive = @IsActive
                                 WHERE UserID = @UserID;";

            using (SqlConnection connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.Add("@UserID", SqlDbType.Int).Value = user.UserID;
                command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = user.UserName;
                command.Parameters.Add("@Password", SqlDbType.NVarChar, 20).Value = user.Password;
                command.Parameters.Add("@IsActive", SqlDbType.Bit).Value = user.IsActive;
                try
                {
                    connection.Open();
                    RowsAffected = command.ExecuteNonQuery();
                    return RowsAffected > 0;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? IsUserExist(string UserName)
        {
            string Query = "SELECT Found=1 FROM Users WHERE UserName = @UserName";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@UserName", SqlDbType.NVarChar, 20).Value = UserName;
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

        public static bool? IsUserExist(int UserID)
        {
            string Query = "SELECT Found=1 FROM Users WHERE UserID = @UserID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
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

        public static bool? IsUser(int PersonID)
        {
            string Query = "SELECT Found=1 FROM Users WHERE PersonID = @PersonID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = PersonID;
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

        public static bool? DeleteUser(int UserID)
        {
            int RowsAffected = 0;
            string Query = @"DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@UserID", SqlDbType.Int).Value = UserID;
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
    }
}