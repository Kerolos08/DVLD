using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsTestType
    {
        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public enum enTestType { VisionTest = 1, WrittenTest = 2, StreetTest = 3}
        public enTestType TestTypeID;
        public string TestTypeTitle { set; get; }
        public string TestTypeDescription { set; get; }
        public decimal TestTypeFees { set; get; }

        private dtoTestType ToDTO()
        {
            return new dtoTestType
            {
                TestTypeID = (int)this.TestTypeID,
                TestTypeTitle = this.TestTypeTitle,
                TestTypeDescription = this.TestTypeDescription,
                TestTypeFees = this.TestTypeFees
            };
        }

        private clsTestType (dtoTestType dto)
        {
            _Mode = enMode.Update;
            this.TestTypeID = (enTestType)dto.TestTypeID;
            this.TestTypeTitle = dto.TestTypeTitle;
            this.TestTypeDescription = dto.TestTypeDescription;
            this.TestTypeFees = dto.TestTypeFees;
        }
        public clsTestType ()
        {
            _Mode = enMode.AddNew;
        }

        public static clsTestType GetTestTypeObj (int ID)
        {
            dtoTestType dto = clsTestTypesDataAccess.GetTestTypeObj(ID);
            if (dto != null)
                return new clsTestType(dto);
            else
                return null;
        }
        private bool _Add()
        {
            int? NewAppID = clsTestTypesDataAccess.AddTestType(ToDTO());
            if (NewAppID.HasValue)
            {
                this.TestTypeID = (enTestType)NewAppID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? eResult = clsTestTypesDataAccess.UpdateTestType(ToDTO());
            if (eResult.HasValue)
                return eResult.Value;
            else
                return false;
        }

        public static DataTable ListTestTypes()
        {
            return clsTestTypesDataAccess.GetAllTestTypes();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    {
                        if (_Add())
                        {
                            _Mode = enMode.Update;
                            return true;
                        }
                        else
                            return false;
                    }
                case enMode.Update:
                    return _Update();
            }
            return false;
        }
    }
}
