using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
      public class clsLoginRegistersDataAccessLayer
    {
  
        static public bool AddLoginRegisters(int UserID, DateTime RegistrationTime)
        {
            bool ISAdd = false;

            SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Insert Into LoginRegisters (UserID,DateTime) VALUES(@UserID,@DateTime)";
            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@DateTime", RegistrationTime);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                ISAdd = true;

            }
            catch(Exception ex) { ISAdd = false; }
            finally { connection.Close(); }




            return ISAdd;
        }

        public static DataTable GetAllLoginRegisters()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * from InfoLoginRegisters";
            SqlCommand command =new SqlCommand(Query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
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
