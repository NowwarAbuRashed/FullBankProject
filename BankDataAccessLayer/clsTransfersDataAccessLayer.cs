using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsTransfersDataAccessLayer
    {
        static public int AddTransferLog(DateTime Time,decimal Amount)
        {
            int TransferLogID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Insert Into TransferLogs (DateTime,Amount) VALUES(@DateTime,@Amount);SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@DateTime", Time);
            command.Parameters.AddWithValue("@Amount", Amount);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    TransferLogID = InsertedID;
                }

            }
            catch (Exception ex) { TransferLogID = -1; }
            finally { connection.Close(); }




            return TransferLogID;



        }
        public static bool AddTransfersInfo(int UserID, int ClientID, int ClientID2, int TransferLogID)
        {
            bool isAdded = false;
            string query = "INSERT INTO Transfers (UserID, ClientID, ClientID2, TransferLogID) VALUES (@UserID, @ClientID, @ClientID2, @TransferLogID);";

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", UserID);
                command.Parameters.AddWithValue("@ClientID", ClientID);
                command.Parameters.AddWithValue("@ClientID2", ClientID2);
                command.Parameters.AddWithValue("@TransferLogID", TransferLogID);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    isAdded = true;
                }
                catch (Exception ex)
                {
                    // Optionally log the exception message here
                    // LogException(ex);
                    isAdded = false;
                }
            }

            return isAdded;
        }

        public static DataTable GetAllTransferLog()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from InfoTransfer";
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
