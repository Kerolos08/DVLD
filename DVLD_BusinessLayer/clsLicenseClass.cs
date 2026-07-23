using DVLD_DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_BusinessLayer
{
    public class clsLicenseClass
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;

        public int LicenseClassID { set; get; }
        public string ClassName { set; get; }
        public string ClassDescription { set; get; }
        public byte MinimumAllowedAge { set; get; }
        public byte DefaultValidityLength { set; get; }
        public decimal ClassFees { set; get; }

        private dtoLicenseClass ToDTO()
        {
            return new dtoLicenseClass
            {
                LicenseClassID = this.LicenseClassID,
                ClassName = this.ClassName,
                ClassDescription = this.ClassDescription,
                MinimumAllowedAge = this.MinimumAllowedAge,
                DefaultValidityLength = this.DefaultValidityLength,
                ClassFees = this.ClassFees,

            };
        }

        public clsLicenseClass()
        {
            _Mode = enMode.AddNew;
        }
        private clsLicenseClass(dtoLicenseClass dto)
        {
            _Mode = enMode.Update;
            this.LicenseClassID = dto.LicenseClassID;
            this.ClassName = dto.ClassName;
            this.ClassDescription = dto.ClassDescription;
            this.MinimumAllowedAge = dto.MinimumAllowedAge;
            this.DefaultValidityLength = dto.DefaultValidityLength;
            this.ClassFees = dto.ClassFees;
        }

        public static clsLicenseClass GetLicenseClassObj(int ID)
        {
            dtoLicenseClass dto = clsLicenseClassDataAccess.GetLicenseClassObj(ID);
            if (dto != null)
                return new clsLicenseClass(dto);
            else
                return null;
        }

        public static clsLicenseClass GetLicenseClassObj(string ClassName)
        {
            dtoLicenseClass dto = clsLicenseClassDataAccess.GetLicenseClassObj(ClassName);
            if (dto != null)
                return new clsLicenseClass(dto);
            else
                return null;
        }

        private bool _Add()
        {
            int? NewLicenseClassID = clsLicenseClassDataAccess.AddLicenseClass(ToDTO());
            if (NewLicenseClassID.HasValue)
            {
                this.LicenseClassID = NewLicenseClassID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? eResult = clsLicenseClassDataAccess.UpdateLicenseClass(ToDTO());
            if (eResult.HasValue)
                return eResult.Value;
            else
                return false;
        }

        public static DataTable ListLicenseClasses()
        {
            return clsLicenseClassDataAccess.GetAllLicenseClasses();
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
