using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsClientDataAccessLayer
    {
        static public bool Find(int ClientID, ref int PersonID,ref decimal Balance)
        {
            bool ISFound=false;
            
            SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Clients Where ClientID=@ClientID";

            SqlCommand command= new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
               
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    Balance = (decimal)reader["Balance"];
                    ISFound = true;
                }
                else
                {
                    ISFound=false;
                }

            }
            catch(Exception ex) 
            {
                ISFound = false;
            }
            finally { connection.Close(); }



            return ISFound;
        }

        static public int AddClient(int PersonID, decimal Balance)
        {
            int ClientID = -1;

            SqlConnection connection=new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Clients (PersonID,Balance) VALUES (@PersonID,@Balance);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                connection.Open();
                object Result= command.ExecuteScalar();
                if(Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }

            }
            catch(Exception ex)
            {
                ClientID = -1;
            }
            finally { connection.Close(); }


            return ClientID;
        }

        static public bool UpdateClient(int ClientID,int PersonID, decimal Balance)
        {
            bool IsUpdate=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Clients set
Balance = @Balance
Where ClientID = @ClientID";

            SqlCommand command = new SqlCommand(Query, connection);

            
            command.Parameters.AddWithValue("@ClientID", ClientID);
            command.Parameters.AddWithValue("@Balance", Balance);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                IsUpdate = true;
            }
            catch(Exception ex)
            {
                IsUpdate = false;
            }
            finally { connection.Close(); }



            return IsUpdate;
        }

        static public bool DeleteClient(int ClientID)
        {
            bool IsDelete=false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Clients Where ClientID = @ClientID";
            SqlCommand command= new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                IsDelete = true;
            }
            catch(Exception ex)
            {
                IsDelete = false;
            }
            finally { connection.Close(); }

            return IsDelete;

        }


        static public DataTable GetAllCliantandAllInfo()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From InfoClients";
            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader= command.ExecuteReader();
                if(reader.HasRows)
                {
                    dt.Load(reader);
                }
                

            }
            catch(Exception ex)
            {

            }
            finally { connection.Close(); }


            return dt;
        }

    }
}
