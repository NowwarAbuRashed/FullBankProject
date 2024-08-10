using BankDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankBusinessLayer
{
    public class clsPerson
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Password {  get; set; }
        enum enMode { AddMode=0,UpdateMode=1};
        enMode Mode= enMode.AddMode;


      public  clsPerson()
        {
            ID = -1;
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            Password= "Password";
            Mode= enMode.AddMode;
        }
        private clsPerson(int ID,string FirstName, string LastName, string Phone, string Email, string Password)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Password = Password;
            Mode = enMode.UpdateMode;
        }

       
        private bool _AddPerson(string FirstName, string LastName, string Phone, string Email, string Password)
        {
            this.ID =clsPersonDataAccessLayer.AddPerson(FirstName,LastName,Phone,Email,Password);

            return (this.ID != -1);
        }
        private bool _UpdatePerson(string FirstName, string LastName, string Phone, string Email, string Password)
        {
            return clsPersonDataAccessLayer.UpdatePerson(this.ID,FirstName, LastName, Phone, Email, Password);
        }
        static public clsPerson Find(int PersonID)
        {

            string FirstName = "";
            string LastName = "";
            string Phone = "";
            string Email = "";
            string Password = "";
            if (clsPersonDataAccessLayer.Find(PersonID, ref FirstName, ref LastName, ref Phone, ref Email, ref Password))
                return new clsPerson(PersonID, FirstName, LastName, Phone, Email, Password);
            else
                return null;


        }
        static public bool IsPersonExist(int PersonID)
        {
            return clsPersonDataAccessLayer.IsPersonExist(PersonID);
        }
        static public bool DeletedPerson(int PersonID)
        {
            return clsPersonDataAccessLayer.DeletePerson(PersonID);
        }

        static public DataTable GetAllPerson()
        {
            return clsPersonDataAccessLayer.GetAllPersons();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddMode:
                    return _AddPerson(this.FirstName,this.LastName,this.Phone,this.Email,this.Password);

                    case enMode.UpdateMode: 
                    return _UpdatePerson(this.FirstName, this.LastName, this.Phone, this.Email, this.Password);
            }
           return false;
        }

    }
}
