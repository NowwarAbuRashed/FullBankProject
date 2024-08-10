using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsLoginRegisters
    {

        private clsLoginRegisters() 
        {
        

        }
        public static bool AddLoginRegisters(int UserID, DateTime RegistrationTime)
        {
            return clsLoginRegistersDataAccessLayer.AddLoginRegisters(UserID, RegistrationTime);
        }

        public static DataTable GetAllLoginRegisters()
        {
            return  clsLoginRegistersDataAccessLayer.GetAllLoginRegisters();
        }


    }
}
