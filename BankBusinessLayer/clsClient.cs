using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsClient
    {
        public int ID {  get; set; }
        public int PersonID {  get; set; }
        public decimal Balance {  get; set; }

        enum enMode { AddMode=0, UpdateMode=1 }
        enMode Mode= enMode.AddMode;

        public clsClient() 
        { 
            this.ID = -1;
            this.PersonID = -1;
            this.Balance = 0;
            Mode = enMode.AddMode;
        }
        private clsClient(int ClientID,int  PersonID, decimal Balance)
        {
            this.ID = ClientID;
            this.PersonID = PersonID;
            this.Balance = Balance;
            Mode = enMode.UpdateMode;
        }


        static public clsClient Find(int ClientID)
        {
            int PersonID = -1;
            decimal Balance = 0;
            if( clsClientDataAccessLayer.Find(ClientID, ref PersonID,ref Balance))
            {
                return new clsClient(ClientID,PersonID,Balance);
            }
            else
            {
                return null;
            }
        }

        private bool _AddClient()
        {
            ID = clsClientDataAccessLayer.AddClient(this.PersonID,this.Balance);
            return (ID != -1);
        }
        private bool _UpdateClient()
        {
            return clsClientDataAccessLayer.UpdateClient(this.ID,this.PersonID,this.Balance);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:

                    return _AddClient();

                case enMode.UpdateMode:

                    return _UpdateClient();

            }
            return false;
        }

        static public bool DeleteClient(int ClientID)
        {
            return clsClientDataAccessLayer.DeleteClient(ClientID);
        }

        static public DataTable GetAllCliantandAllInfo()
        {
            return clsClientDataAccessLayer.GetAllCliantandAllInfo();
        }
      



    }
}
