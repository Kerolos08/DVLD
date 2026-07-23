using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsCountry
    {
        public int CountryID { set; get; }
        public string CountryName { set; get; }

        private clsCountry(int ID, string Name)
        {
            this.CountryID = ID;
            this.CountryName = Name;
        }

        public static clsCountry Find(int ID)
        {
            string CountryName = default;

            if (clsCountryDataAccess.FindCountry(ID, ref CountryName))
                return new clsCountry(ID, CountryName);
            else
                return null;
        }

        public static clsCountry Find(string Name)
        {
            int CountryID = default;

            if (clsCountryDataAccess.FindCountry(Name, ref CountryID))
                return new clsCountry(CountryID, Name);
            else
                return null;
        }

        public static DataTable ListCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }
    }
}
