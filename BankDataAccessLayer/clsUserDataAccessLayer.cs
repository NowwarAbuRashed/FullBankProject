using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsUserDataAccessLayer
    {
        static public bool Find(int UserID,ref int PersonID,ref string UserName,ref int Permissions)
        {
            bool IsFind=true;
            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Users Where UserID=@UserID";
            SqlCommand command =new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();

                if(reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    UserName = (string)reader["UserName"];
                    Permissions = (int)reader["Permissions"];

                    IsFind = true;
                }
                else
                {
                    IsFind = false;
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }


            return IsFind;
        }

        static public int AddUser(int PersonID, string UserName,  int Permissions)
        {
            int UserID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Insert into Users (PersonID,UserName,Permissions) VALUES (@PersonID,@UserName,@Permissions); SELECT SCOPE_IDENTITY();";

            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertID))
                {
                    UserID = InsertID;
                }
            }
            catch (Exception ex) { UserID=-1; }
            finally { connection.Close(); }


            return UserID;
        }
        static public bool UpdateUser(int UserID,int PersonID, string UserName, int Permissions)
        {
            bool IsUpdate=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Users set
UserName=@UserName,
Permissions=@Permissions
where UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permissions", Permissions);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                IsUpdate = true;
            }
            catch(Exception ex) { IsUpdate = false; }
            finally { connection.Close(); }



            return IsUpdate;
        }

        public static bool DeleteUser(int UserID)
        {
            bool isDeleted = false;
            string query = "DELETE FROM Users WHERE UserID = @UserID";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", UserID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isDeleted = true;
                }
                catch (Exception ex)
                {
                    // Optionally log the exception message here
                    // LogException(ex);
                    isDeleted = false;
                }
            }

            return isDeleted;
        }

        static public DataTable GetAllUserAllInfo()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from UserInfo";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }


            return dt;
        }

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from Users";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {

            }
            finally { connection.Close(); }


            return dt;
        }

    }
}
