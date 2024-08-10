using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsTransfers
    {
        static public int AddTransferLog(DateTime Time, decimal Amount)
        {
            return clsTransfersDataAccessLayer.AddTransferLog(Time, Amount);
        }

        static public bool AddTransfersInfo(int UserID,int ClientID,int ClientID2,int TransferLogID)
        {
           return clsTransfersDataAccessLayer.AddTransfersInfo(UserID,ClientID,ClientID2,TransferLogID);
        }
        public static DataTable GetAllTransferLog()
        {
            return clsTransfersDataAccessLayer.GetAllTransferLog();
        }



    }
}
