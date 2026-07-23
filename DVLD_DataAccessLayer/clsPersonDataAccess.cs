using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.SymbolStore;
using System.Net;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;

namespace DVLD_DataAccessLayer
{
    public class dtoPerson
    {
        public int PersonID { set; get; }
        public string NationalNo { set; get; }
        public string FirstName { set; get; }
        public string SecondName { set; get; }
        public string ThirdName { set; get; }
        public string LastName { set; get; }
        public DateTime DateOfBirth { set; get; }
        public byte Gender { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public string Email { set; get; }
        public int CountryID { set; get; }
        public string ImagePath { set; get; }
    }
    public class clsPersonDataAccess
    {
        public static dtoPerson FindPersonbyPersonID(int ID)
        {
            string Query = @"Select NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                            Gender, Address, Phone, Email, NationalityCountryID, ImagePath
                            From People Where PersonID = @PersonID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;
                try
                {
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoPerson
                        {
                            PersonID = ID,
                            NationalNo = (string)Reader["NationalNo"],
                            FirstName = (string)Reader["FirstName"],
                            SecondName = (string)Reader["SecondName"],
                            ThirdName = Reader["ThirdName"] as string ?? string.Empty,
                            LastName = (string)Reader["LastName"],
                            DateOfBirth = (DateTime)Reader["DateOfBirth"],
                            Gender = (byte)Reader["Gender"],
                            Address = (string)Reader["Address"],
                            Phone = (string)Reader["Phone"],
                            Email = Reader["Email"] as string ?? string.Empty,
                            CountryID = (int)Reader["NationalityCountryID"],
                            ImagePath = Reader["ImagePath"] as string ?? string.Empty,
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

        public static dtoPerson FindPersonbyNationalNO(string NationalNumber)
        {
            string Query = @"Select PersonID, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                            Gender, Address, Phone, Email, NationalityCountryID, ImagePath
                            From People Where NationalNo = @NationalNo;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNumber;
                try
                {
                    Connection.Open();
                    SqlDataReader Reader = Command.ExecuteReader();
                    if (Reader.Read())
                    {
                        return new dtoPerson
                        {

                            NationalNo = NationalNumber,
                            PersonID = (int)Reader["PersonID"],
                            FirstName = (string)Reader["FirstName"],
                            SecondName = (string)Reader["SecondName"],
                            ThirdName = Reader["ThirdName"] as string ?? string.Empty,
                            LastName = (string)Reader["LastName"],
                            DateOfBirth = (DateTime)Reader["DateOfBirth"],
                            Gender = (byte)Reader["Gender"],
                            Address = (string)Reader["Address"],
                            Phone = (string)Reader["Phone"],
                            Email = Reader["Email"] as string ?? string.Empty,
                            CountryID = (int)Reader["NationalityCountryID"],
                            ImagePath = Reader["ImagePath"] as string ?? string.Empty,
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

        public static DataTable GetAllPeopleInSystem()
        {
            DataTable dtPeople = new DataTable();
            string Query = @"SELECT p.PersonID, p.NationalNo, p.FirstName, p.SecondName, p.ThirdName, p.LastName,
                             CASE 
                             WHEN p.Gender = 0 THEN 'Male'
                             WHEN p.Gender = 1 THEN 'Female'
                             END as Gender, p.DateOfBirth, c.CountryName as Nationality, p.Phone, p.Email
                             FROM People p INNER JOIN Countries c ON p.NationalityCountryID = c.CountryID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                try
                {
                    Connection.Open();
                    dtPeople.Load(Command.ExecuteReader());
                }
                catch
                {
                    return dtPeople;
                }

                return dtPeople;
            }
        }

        public static bool? IsPersonExist(string NationalNo)
        {
            string Query = "Select Found=1 FROM People WHERE NationalNo = @NationalNo";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NationalNo;
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

        public static bool? IsPersonExist(int ID)
        {
            string Query = "Select Found=1 FROM People WHERE PersonID = @PersonID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;
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

        public static int? AddNewPerson(dtoPerson NewPerson)
        {
            string Query = @"INSERT INTO People (NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth,
                             Gender, Address, Phone, Email, NationalityCountryID, ImagePath)
                             VALUES
                             (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address,
                             @Phone, @Email, @NationalityCountryID, @ImagePath);
                             SELECT CAST(SCOPE_IDENTITY() AS INT);";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = NewPerson.NationalNo;
                Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = NewPerson.FirstName;
                Command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = NewPerson.SecondName;
                Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value = String.IsNullOrEmpty(NewPerson.ThirdName) ? DBNull.Value : (Object)NewPerson.ThirdName;
                Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = NewPerson.LastName;
                Command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = NewPerson.DateOfBirth;
                Command.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = NewPerson.Gender;
                Command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = NewPerson.Address;
                Command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = NewPerson.Phone;
                Command.Parameters.Add("@Email", SqlDbType.NVarChar, 20).Value = String.IsNullOrEmpty(NewPerson.Email) ? DBNull.Value : (Object)NewPerson.Email;
                Command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = NewPerson.CountryID;
                Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = String.IsNullOrEmpty(NewPerson.ImagePath) ? DBNull.Value : (Object)NewPerson.ImagePath;

                try
                {
                    Connection.Open();
                    object Result = Command.ExecuteScalar();
                    return (int?)Result;
                }
                catch
                {
                    return null;
                }
            }
        }

        public static bool? UpdatePerson(dtoPerson Person)
        {
            int RowsAffected = 0;
            string Query = @"Update People 
                             SET NationalNo = @NationalNo,
                                 FirstName = @FirstName,
                                 SecondName =  @SecondName,
                                 ThirdName = @ThirdName,
                                 LastName = @LastName,
                                 DateOfBirth = @DateOfBirth,
                                 Gender = @Gender,
                                 Address = @Address,
                                 Phone = @Phone,
                                 Email = @Email,
                                 NationalityCountryID = @NationalityCountryID,
                                 ImagePath = @ImagePath
                                 WHERE PersonID = @PersonID;";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = Person.PersonID;
                Command.Parameters.Add("@NationalNo", SqlDbType.NVarChar, 20).Value = Person.NationalNo;
                Command.Parameters.Add("@FirstName", SqlDbType.NVarChar, 20).Value = Person.FirstName;
                Command.Parameters.Add("@SecondName", SqlDbType.NVarChar, 20).Value = Person.SecondName;
                Command.Parameters.Add("@ThirdName", SqlDbType.NVarChar, 20).Value = String.IsNullOrEmpty(Person.ThirdName) ? DBNull.Value : (Object)Person.ThirdName;
                Command.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = Person.LastName;
                Command.Parameters.Add("@DateOfBirth", SqlDbType.DateTime).Value = Person.DateOfBirth;
                Command.Parameters.Add("@Gender", SqlDbType.TinyInt).Value = Person.Gender;
                Command.Parameters.Add("@Address", SqlDbType.NVarChar, 500).Value = Person.Address;
                Command.Parameters.Add("@Phone", SqlDbType.NVarChar, 20).Value = Person.Phone;
                Command.Parameters.Add("@Email", SqlDbType.NVarChar, 20).Value = String.IsNullOrEmpty(Person.Email) ? DBNull.Value : (Object)Person.Email;
                Command.Parameters.Add("@NationalityCountryID", SqlDbType.Int).Value = Person.CountryID;
                Command.Parameters.Add("@ImagePath", SqlDbType.NVarChar, 250).Value = String.IsNullOrEmpty(Person.ImagePath) ? DBNull.Value : (Object)Person.ImagePath;

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

        public static bool? DeletePerson(int ID)
        {
            int RowsAffected = 0;
            string Query = @"DELETE FROM People WHERE PersonID = @PersonID";

            using (SqlConnection Connection = new SqlConnection(DAL_Settings.ConnectionSTR))
            using (SqlCommand Command = new SqlCommand(Query, Connection))
            {
                Command.Parameters.Add("@PersonID", SqlDbType.Int).Value = ID;
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
