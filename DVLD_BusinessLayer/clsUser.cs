using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using DVLD_DataAccessLayer;

namespace DVLD_BusinessLayer
{
    public class clsUser
    {
        private enum enMode { AddNew = 0, Update = 1 };
        private enMode Mode = enMode.AddNew;
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PersonID { get; set; }

        private dtoUser _ToDTO()
        {
            return new dtoUser
            {
                UserID = this.UserID,
                UserName = this.UserName,
                Password = this.Password,
                IsActive = this.IsActive,
                PersonID = this.PersonID
            };
        }
        public clsUser()
        {
            this.Mode = enMode.AddNew;
        }

        private clsUser(dtoUser PassingUser)
        {
            Mode = enMode.Update;
            this.UserID = PassingUser.UserID;
            this.UserName = PassingUser.UserName;
            this.Password = PassingUser.Password;
            this.IsActive = PassingUser.IsActive;
            this.PersonID = PassingUser.PersonID;
        }

        public static clsUser Find(string UserName)
        {
            dtoUser dto = clsUserDataAccess.FindUserByUsername(UserName);
            if (dto != null)
                return new clsUser(dto);
            else
                return null;
        }

        public static clsUser Find(int ID)
        {
            dtoUser dto = clsUserDataAccess.FindUserByUserID(ID);
            if (dto != null)
                return new clsUser(dto);
            else
                return null;
        }

        public static clsUser FindUserByUsernameAndPassword(string UserName, string Password)
        {
            dtoUser dto = clsUserDataAccess.FindUserByUsernameAndPassword(UserName, Password);
            if (dto != null)
                return new clsUser(dto);
            else
                return null;
        }
        public bool _Add()
        {
            int? NewUserID = clsUserDataAccess.AddNewUser(_ToDTO());
            if (NewUserID.HasValue)
            {
                this.UserID = NewUserID.Value;
                return true;
            }
            else
                return false;
        }

        public bool _Update()
        {
            bool? UpdateResult = clsUserDataAccess.UpdateUser(_ToDTO());

            if (UpdateResult.HasValue)
            {
                return UpdateResult.Value;
            }
            else
            {
                return false;
            }
        }

        public static DataTable ListUsers()
        {
            return clsUserDataAccess.GetAllUsersInSystem();
        }

        public static bool IsUserExists(string UserName)
        {
            bool? Result = clsUserDataAccess.IsUserExist(UserName);
            if (Result.HasValue)
            {
                return Result.Value;
            }
            else
                return false;
        }

        public static bool IsConnectedToPerson(int PersonID)
        {
            bool? Result = clsUserDataAccess.IsUser(PersonID);
            if (Result.HasValue)
            {
                return Result.Value;
            }
            else
                return false;
        }

        public static bool Delete(int UserID)
        {
            bool? Result = clsUserDataAccess.DeleteUser(UserID);
            if (Result.HasValue)
            {
                return Result.Value;
            }
            else
                return false;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    {
                        if (_Add())
                        {
                            this.Mode = enMode.Update;
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
