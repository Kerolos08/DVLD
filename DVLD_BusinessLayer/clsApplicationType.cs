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
    public class clsApplicationType
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode = enMode.AddNew;
        public int ApplicationTypeID { get; set; }
        public string ApplicationTypeTitle { get; set; }
        public decimal ApplicationFees { get; set; }

        private dtoApplicationType ToDTO()
        {
            return new dtoApplicationType
            {
                ApplicationTypeID = this.ApplicationTypeID,
                ApplicationTypeTitle = this.ApplicationTypeTitle,
                ApplicationFees = this.ApplicationFees,

            };
        }
        public clsApplicationType()
        {
            _Mode = enMode.AddNew;
        }
        private clsApplicationType(dtoApplicationType dto)
        {
            _Mode = enMode.Update;
            this.ApplicationTypeID = dto.ApplicationTypeID;
            this.ApplicationTypeTitle = dto.ApplicationTypeTitle;
            this.ApplicationFees = dto.ApplicationFees;
        }

        public static clsApplicationType GetApplicationTypeObj(int ID)
        {
            dtoApplicationType dto = clsApplicationTypesDataAccess.GetApplicationType(ID);
            if (dto != null)
                return new clsApplicationType(dto);
            else
                return null;
        }

        private bool _Add()
        {
            int? NewAppID = clsApplicationTypesDataAccess.AddNewApplicationType(ToDTO());
            if (NewAppID.HasValue)
            {
                this.ApplicationTypeID = NewAppID.Value;
                return true;
            }
            else
                return false;
        }

        private bool _Update()
        {
            bool? eResult = clsApplicationTypesDataAccess.ApplicationTypeEdit(ToDTO());
            if (eResult.HasValue)
                return eResult.Value;
            else
                return false;
        }

        public static DataTable ListApplicationTypes()
        {
            return clsApplicationTypesDataAccess.GetAllApplicationTypes();
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
