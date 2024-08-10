using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsPersonDataAccessLayer
    {

        public static bool Find(int PersonID,ref string FirstName,ref string LastName,ref string Phone, ref string Email, ref string Password)
        {
            bool IsFound = false;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select * from Persons Where PersonID=@PersonID";
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    Phone = (string)reader["Phone"];
                    Email = (string)reader["Email"];
                    Password = (string)reader["Password"];

                    IsFound = true;
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();

            }
            catch(Exception ex)
            {
                IsFound=false;
            }
            finally { connection.Close(); }

            return IsFound;

        }
        public static bool IsPersonExist(int PersonID)
        {
            bool IsFound = false;
            SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Select found=1 from Persons Where PersonID=@PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;
                reader.Close();
            }
            catch(Exception ex)
            {
                IsFound = false;
            }
            finally { connection.Close(); }

            return IsFound;
        }
        public static int AddPerson(string FirstName, string LastName, string Phone, string Email, string Password)
        {
            int PersonID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"INSERT INTO Persons (FirstName,LastName,Phone,Email,Password) VALUES(@FirstName,@LastName,@Phone,@Email,@Password);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand Command=new SqlCommand(query, connection);

            Command.Parameters.AddWithValue("@FirstName", FirstName);
            Command.Parameters.AddWithValue("@LastName", LastName);
            Command.Parameters.AddWithValue("@Phone", Phone);
            Command.Parameters.AddWithValue("@Email", Email);
            Command.Parameters.AddWithValue("@Password", Password);
            try
            {
                connection.Open();
                object Result=Command.ExecuteScalar();

                if(Result != null && int.TryParse(Result.ToString(), out int InsertedID) )
                {
                    PersonID = InsertedID;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                connection.Close();
            }




            return PersonID;
        }

        public static bool UpdatePerson(int PersonID,string FirstName, string LastName, string Phone, string Email, string Password)
        {
            bool ISUpdate=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Update  Persons  set
FirstName=@FirstName,
LastName=@LastName,
Phone=@Phone,
Email=@Email,
Password=@Password
Where PersonID=@PersonID";

          SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                ISUpdate = true;

            }
            catch(Exception ex)
            {
                ISUpdate = false;

            }
            finally { connection.Close(); }



            return ISUpdate;
        }

        public static bool DeletePerson(int PersonID)
        {
            bool IsDeleted = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "Delete From Persons Where PersonID=@PersonID";
            SqlCommand command= new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                IsDeleted = true;
            }
            catch(Exception ex)
            {
                IsDeleted = false;
            }
            finally { connection.Close(); }

            return IsDeleted;

        }

        public static DataTable GetAllPersons()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection( clsDataAccessSettings.ConnectionString);
            string query = "Select * From Persons";
            SqlCommand Command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader=Command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
            }
            catch(Exception ex)
            {

            }
            finally { connection.Close(); }
            return dt;

        }


    }
}
