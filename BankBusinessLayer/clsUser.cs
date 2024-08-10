using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsUser
    {
        public int ID {  get; set; }

        public int PersonID {  get; set; }
        public string UserName { get; set; }
        public int Permissions {  get; set; }

        enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;

        public clsUser() 
        {
            this.ID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Permissions = 0;
            Mode = enMode.AddMode;
        }

        private clsUser(int UserID,int PersonID,string UserName, int Permissions)
        {
            this.ID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Permissions = Permissions;
            Mode = enMode.UpdateMode;
        }

        public static clsUser Find(int UserID)
        {
            int PersonID = -1;
            string UserName = "";
            int Permissions = 0;
            if(clsUserDataAccessLayer.Find(UserID,ref PersonID,ref UserName,ref Permissions))
            {
                return new clsUser(UserID,PersonID,UserName,Permissions);
            }
            else
            {
                return null;
            }


        }

        private bool _AddUser()
        {
           this.ID=clsUserDataAccessLayer.AddUser(this.PersonID,this.UserName,this.Permissions);
            return (this.ID != -1);
        }
        private bool _UpdateUser()
        {
            return clsUserDataAccessLayer.UpdateUser(this.ID, this.PersonID, this.UserName, this.Permissions);
        }
        public  bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    return _AddUser();
                    case enMode.UpdateMode:
                    return _UpdateUser();

            }
            return false;
        }

       static public bool DeleteUser(int UserID) 
        { 
            return clsUserDataAccessLayer.DeleteUser(UserID);
        }

        static public DataTable GetAllUsersAllInfo()
        {
           return clsUserDataAccessLayer.GetAllUserAllInfo();
        }

        static public DataTable GetAllUsers()
        {
            return clsUserDataAccessLayer.GetAllUsers();
        }



        //static internal bool ChickUserName(DataTable dataTable, string UserName)
        //{

        //    foreach (DataRow RowUser in dataTable.Rows)
        //    {
        //        if (RowUser["UserName"].ToString() == UserName)
        //        {
        //            int PersonID = Convert.ToInt32(RowUser["PersonID"]);

        //            clsPerson person = new clsPerson();
        //            person = clsPerson.Find(PersonID);
        //            if (PersonID == null)
        //            {
        //                return false;
        //            }
        //            else
        //            {
        //                return true;
        //            }
        //        }
        //    }
        //    return false;

        //}
        //static internal bool ChickPassWord(DataTable dataTable, string PassWord)
        //{
        //    foreach (DataRow RowPerson in dataTable.Rows)
        //    {
        //        if (RowPerson["Password"].ToString() == PassWord)
        //        {
        //            return true;
        //        }
        //    }
        //    return false;

        //}
        static public bool ChickUserNameAndPassowrd(string UserName,string PassWord)
        {
            DataTable dataTable = GetAllUsers();

            foreach (DataRow RowUser in dataTable.Rows)
            {
                if (RowUser["UserName"].ToString() == UserName)
                {
                    int PersonID = Convert.ToInt32(RowUser["PersonID"]);

                    clsPerson person = new clsPerson();
                    person = clsPerson.Find(PersonID);

                    if (PersonID == null)
                    {
                        return false;
                    }

                    DataTable dataTable1 = clsPerson.GetAllPerson();

                    foreach (DataRow RowPerson in dataTable1.Rows)
                    {
                        if (RowPerson["Password"].ToString() == PassWord)
                        {
                            clsGlobal.UserLogIn = clsUser.Find(Convert.ToInt32(RowUser["UserID"]));
                            return true;
                        }
                    }


                }
            }
            return false;


        }

    }
}
