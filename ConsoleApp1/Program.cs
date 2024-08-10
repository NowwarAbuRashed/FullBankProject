using BankBusinessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {

      static public void tistAddPerson()
        {
            clsPerson person=new clsPerson();

            person.FirstName = "aaahmed";
            person.LastName = "Aabu Rashed";
            person.Phone = "134567890";
            person.Email = "amd.com";
            person.Password= "2333";

            if(person.Save())
            {
                Console.WriteLine("Add is Successfuly");
            }
            else
            {
                Console.WriteLine("Add is Fild");
            }
        }
        static public void tistUpdatePerson() 
        {
            clsPerson person = clsPerson.Find(13);
            if(person != null)
            {
                person.Phone = "99998888";
                person.FirstName = "Keye";

                if(person.Save())
                {
                    Console.WriteLine("the Update Is Successfuly");
                }
                else
                {
                    Console.WriteLine("the Update Is Fiald");
                }


            }
            else { Console.WriteLine("the Person is Not Found"); }

        }

        static public void tistDeletedPerson()
        {
            if (clsPerson.DeletedPerson(8))
            {
                Console.WriteLine("Deleted Is Successfuly");
            }
            else
            {
                Console.WriteLine("Deleted Is Faild");
            }

        }

        static public void tistGetAllPersons()
        {
            DataTable dataTable = clsPerson.GetAllPerson();

            foreach(DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"PersonID = { row["PersonID"]} \nFirstName = {row["FirstName"]} \nLastName = {row["LastName"]} \n");
            }

        }
        static public void tistPersonISExist()
        {
            if (clsPerson.IsPersonExist(8))
            {
                Console.WriteLine("the person is  Found");
            }
            else
            {
                Console.WriteLine("Not Found");
            }
        }

        static public void tistFindClint()
        {
            clsClient client = clsClient.Find(2);
            if(client != null)
            {
                Console.WriteLine($" Client ID = {client.ID} \n PersonID = {client.PersonID} \n Balance = {client.Balance}");
            }
            else
            {
                Console.WriteLine("Is Not Found");
            }

        }

        static public void tistAddClient()
        {
            clsPerson person = new clsPerson();

            person.FirstName = "Nowwar";
            person.LastName = "abu Rashed";
            person.Phone = "134567890";
            person.Email = "Nowwar.com";
            person.Password = "76859";

            person.Save();

            clsClient client= new clsClient();

            client.PersonID=person.ID;
            client.Balance = 97699;

           if( client.Save())
            {
                Console.WriteLine("Add Is Successfuly");
            }
            else
            {
                Console.WriteLine("Add is Faild");
            }


        }

        static public void tistUpdateCliant()
        {
            clsClient client =clsClient.Find(2);
            if(client != null)
            {
                clsPerson person = clsPerson.Find(client.PersonID);

                person.FirstName = "Bahaa";
                person.LastName = "Abu Rashed";
                person.Password = "223344";

                person.Save();

                client.Balance = 8500;

                if( client.Save())
                {
                    Console.WriteLine("Client Update Successfuly");
                }
                else
                {
                    Console.WriteLine("the Prosess Fiald");
                }


            }
            else
            {
                Console.WriteLine("the Client is not Found");
            }
        }

        static public void tistDeletCliant()
        {
            if(clsClient.DeleteClient(6))
            {
                Console.WriteLine("Deleted Successfuly");
            }
            else
            {
                Console.WriteLine("Delete is Faild");
            }

        }

        static public void tistGetAllClientInfo()
        {
            DataTable dt = clsClient.GetAllCliantandAllInfo();

            foreach(DataRow row in dt.Rows) 
            {
                Console.WriteLine($"ClientID = {row["ClientID"]}\n FirstName = {row["FirstName"]}\n LastName = { row["LastName"] }\n Phone = {row["Phone"]}\n Email = { row["Email"]}\n Password = {row["Password"]}");
                Console.WriteLine();
            }


        }

        static public void tistFindUser()
        {
            if(clsClient.Find(2) != null )
            {
                Console.WriteLine("Successfuly");
            }
            else
            {
                Console.WriteLine("Fiald");
            }
        }
        static public void tistAddUser()
        {
            
            clsUser user = new clsUser();
            user.PersonID = 16;
            user.UserName = "User1234";
            user.Permissions = 90;

            if (user.Save())
            {
                Console.WriteLine("Successfuly");
            }
            else
            {
                Console.WriteLine("Fiald");
            } 
            
            
           
       

        }
        static public void tistUpdateUser()
        {
            clsUser user = clsUser.Find(3);
            
               if(user != null ) 
            { 
                user.PersonID = 2;
                user.UserName = "ap";
                user.Permissions = 2;

                if (user.Save())
                {
                    Console.WriteLine("Successfuly");
                }
                else
                {
                    Console.WriteLine("Fiald");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }




        }
        static public void tistDeleteUser()
        {
            if (clsUser.DeleteUser(2))
            {
                Console.WriteLine("Deleted Successfuly");
            }
            else
            {
                Console.WriteLine("Delete is Faild");
            }

        }

        static public void tistGetAllUsers()
        {
            DataTable dt = clsUser.GetAllUsersAllInfo();
            foreach(DataRow row in dt.Rows)
            {
                Console.WriteLine($"UserName = {row["UserName"]}\n FullName = {row["FullName"]}\n  Phone = {row["Phone"]}\n Email = {row["Email"]}\n Password = {row["Password"]} \n Permissions = {row["Permissions"]}");
                Console.WriteLine();

            }
        }

        static public void tistFindCurrencie()
        {
            if (clsCurrencie.Find(2) != null)
            {
                Console.WriteLine("Successfuly");
            }
            else
            {
                Console.WriteLine("Fiald");
            }
        }


        static public void tistAddCurrencie()
        {

            clsCurrencie Currencie = new clsCurrencie();

            Currencie.Country = "Jordan";
            Currencie.Code = "Jod";
            Currencie.CurrenciesName = "Denar";
            Currencie.Rat1Dolar = 12.4;

            if (Currencie.Save())
            {
                Console.WriteLine("Successfuly");
            }
            else
            {
                Console.WriteLine("Fiald");
            }





        }
        static public void tistUpdateCurrencie()
        {
            clsCurrencie Currencie = clsCurrencie.Find(3);

            if (Currencie != null)
            {
                Currencie.Country = "Jordan";
                Currencie.Code = "Jod";
                Currencie.CurrenciesName = "Denar";
                Currencie.Rat1Dolar = 50.5; ;

                if (Currencie.Save())
                {
                    Console.WriteLine("Successfuly");
                }
                else
                {
                    Console.WriteLine("Fiald");
                }
            }
            else
            {
                Console.WriteLine("Not Found");
            }




        }

        static public void tistDeleteCurrencie()
        {
            if (clsCurrencie.DeleteCurrencie(3))
            {
                Console.WriteLine("Deleted Successfuly");
            }
            else
            {
                Console.WriteLine("Delete is Faild");
            }

        }

        static public void tistGetAllCurrencie()
        {
            DataTable dt = clsCurrencie.GetAllCurrencieAndAllInfo();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine($"Country = {row["Country"]}\n Code = {row["Code"]}\n CurrenciesName = {row["CurrenciesName"]}\n Rat1Dolar = {row["Rat1Dolar"]}");
                Console.WriteLine();

            }
        }




        static public void tistADDLonginRegister()
        {
            if(clsLoginRegisters.AddLoginRegisters(2,DateTime.Now))
            {
                Console.WriteLine("ADD Successfuly");
            }
            else
            {
                Console.WriteLine("ADD is Faild");
            }

        }

        static public void tistGetInfoLoginRegister()
        {
            DataTable table = clsLoginRegisters.GetAllLoginRegisters();

            foreach(DataRow row in table.Rows)
            {
                Console.WriteLine($"LoginRegisterID = {row["LoginRegisterID"]}\n UserName = {row["UserName"]}\n Password = {row["Password"]}\n Permissions = {row["Permissions"]} \n RegistrationTime = {row["RegistrationTime"]}");
                Console.WriteLine();
            }

        }


        static public void tistADDTransferLog()
        {
            if (Convert.ToBoolean( clsTransfers.AddTransferLog(DateTime.Now,1)))
            {
                Console.WriteLine("ADD Successfuly");
            }
            else
            {
                Console.WriteLine("ADD is Faild");
            }

        }

        static public void tistGetInfoTransferLog()
        {
            DataTable table = clsTransfers.GetAllTransferLog();

            foreach (DataRow row in table.Rows)
            {
                Console.WriteLine($"DateTime = {row["DateTime"]}\n SAcct = {row["SAcct"]}\n DAcct = {row["DAcct"]}\n Amount = {row["Amount"]} \n SBalance = {row["SBalance"]}\nDBalance = {row["DBalance"]}");
                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            // tistAddPerson();\

            //  tistUpdatePerson();
            //   tistDeletedPerson();
            // tistGetAllPersons();
            //  tistPersonISExist();


            //tistFindClint();
            //     tistAddClient();

            //   tistUpdateCliant();
            //  tistDeletCliant();
            //     tistGetAllClientInfo();

            //tistFindUser();

            //tistAddUser();
            //        tistUpdateUser();
            //tistDeleteUser();

            // tistGetAllUsers();

            // tistFindCurrencie();


            //   tistAddCurrencie();
            //  tistUpdateCurrencie();

            // tistDeleteCurrencie();
            // tistGetAllCurrencie();

            // tistADDLonginRegister();
            // tistGetInfoLoginRegister();
            // tistADDTransferLog();


           // tistGetInfoTransferLog();
            tistDeleteUser();

            Console.ReadLine();
        }
    }
}
