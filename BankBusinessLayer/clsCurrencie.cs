using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsCurrencie
    {
        public int ID { get; set; }
        public string Country { get; set; }
        public string Code { get; set; }
        public string CurrenciesName { get; set; }
        public double Rat1Dolar { get; set; }

        enum enMode { AddMode = 0, UpdateMode = 1 }
        enMode Mode = enMode.AddMode;

        public clsCurrencie() 
        { 
            this.ID = -1;
            this.Country = "";
            this.Code = "";
            this.CurrenciesName = "";
            this.Rat1Dolar = 0.0;
            Mode = enMode.AddMode;
        }

        private clsCurrencie(int ID, string Country, string Code, string CurrenciesName, double Rat1Dolar)
        {
            this.ID = ID;
            this.Country = Country;
            this.Code = Code;
            this.CurrenciesName = CurrenciesName;
            this.Rat1Dolar=Rat1Dolar;
            Mode = enMode.UpdateMode;
        }
        static public clsCurrencie Find(int CurrencieID)
        {
            string Country = "";
            string Code = "";
            string CurrenciesName="";
            double Rat1Dolar = 0.0;
            if (clsCurrencieDataAccessLayer.Find(CurrencieID, ref Country, ref Code,ref CurrenciesName, ref Rat1Dolar))
            {
                return new clsCurrencie(CurrencieID, Country, Code, CurrenciesName, Rat1Dolar);
            }
            else
            {
                return null;
            }
        }
        static public clsCurrencie Find(string CountryOrCode)
        {
            int CurrencieID = -1;
            string Country = "";
            string Code = "";
            string CurrenciesName = "";
            double Rat1Dolar = 0.0;
            if (clsCurrencieDataAccessLayer.Find(CountryOrCode,ref CurrencieID, ref Country, ref Code, ref CurrenciesName, ref Rat1Dolar))
            {
                return new clsCurrencie(CurrencieID, Country, Code, CurrenciesName, Rat1Dolar);
            }
            else
            {
                return null;
            }
        }
        private bool _AddCurrencie()
        {
            ID = clsCurrencieDataAccessLayer.AddCurrencie(this.Country, this.Code,this.CurrenciesName,this.Rat1Dolar);
            return (ID != -1);
        }
        private bool _UpdateCurrencie()
        {
            return clsCurrencieDataAccessLayer.UpdateCurrencie(this.ID,this.Country, this.Code, this.CurrenciesName, this.Rat1Dolar);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:

                    return _AddCurrencie();

                case enMode.UpdateMode:

                    return _UpdateCurrencie();

            }
            return false;
        }

        static public bool DeleteCurrencie(int CurrencieID)
        {
            return clsCurrencieDataAccessLayer.DeleteCurrencie(CurrencieID);
        }

        static public DataTable GetAllCurrencieAndAllInfo()
        {
            return clsCurrencieDataAccessLayer.GetAllCurrencieAndAllInfo();
        }
     



    }
}
