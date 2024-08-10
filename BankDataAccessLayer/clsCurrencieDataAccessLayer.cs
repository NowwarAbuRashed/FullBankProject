using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankDataAccessLayer
{
    public class clsCurrencieDataAccessLayer
    {
        static public bool Find(int CurrencieID,ref string Country,ref string Code, ref string CurrenciesName,ref double Rat1Dolar)
        {
            bool ISFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Currencies Where CurrencieID=@CurrencieID";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@CurrencieID", CurrencieID);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CurrencieID = (int)reader["CurrencieID"];
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    CurrenciesName = (string)reader["CurrenciesName"];
                    Rat1Dolar = (double)reader["Rat1Dolar"];
                   
                    ISFound = true;
                }
                else
                {
                    ISFound = false;
                }

            }
            catch (Exception ex)
            {
                ISFound = false;
            }
            finally { connection.Close(); }



            return ISFound;
        }
        static public bool Find(string CountryOrCode,ref int CurrencieID, ref string Country, ref string Code, ref string CurrenciesName, ref double Rat1Dolar)
        {
            bool ISFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Select * From Currencies Where Code=@Code or Country=@Country";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Code", CountryOrCode);
            command.Parameters.AddWithValue("@Country", CountryOrCode);

            try
            {

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CurrencieID = (int)reader["CurrencieID"];
                    Country = (string)reader["Country"];
                    Code = (string)reader["Code"];
                    CurrenciesName = (string)reader["CurrenciesName"];
                    Rat1Dolar = (double)reader["Rat1Dolar"];

                    ISFound = true;
                }
                else
                {
                    ISFound = false;
                }

            }
            catch (Exception ex)
            {
                ISFound = false;
            }
            finally { connection.Close(); }



            return ISFound;
        }
        static public int AddCurrencie(string Country, string Code, string CurrenciesName, double Rat1Dolar)
        {
            int ClientID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Insert into Currencies (Country,Code,CurrenciesName,Rat1Dolar) VALUES (@Country,@Code,@CurrenciesName,@Rat1Dolar);
                            SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@CurrenciesName", CurrenciesName);
            command.Parameters.AddWithValue("@Rat1Dolar", Rat1Dolar);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();
                if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                {
                    ClientID = InsertedID;
                }

            }
            catch (Exception ex)
            {
                ClientID = -1;
            }
            finally { connection.Close(); }


            return ClientID;
        }

        static public bool UpdateCurrencie(int CurrencieID, string Country, string Code, string CurrenciesName, double Rat1Dolar)
        {
            bool IsUpdate = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = @"Update Currencies set
Country = @Country,
Code = @Code,
CurrenciesName = @CurrenciesName,
Rat1Dolar = @Rat1Dolar
Where CurrencieID = @CurrencieID";

            SqlCommand command = new SqlCommand(Query, connection);


            command.Parameters.AddWithValue("@CurrencieID", CurrencieID);
            command.Parameters.AddWithValue("@Country", Country);
            command.Parameters.AddWithValue("@Code", Code);
            command.Parameters.AddWithValue("@CurrenciesName", CurrenciesName);
            command.Parameters.AddWithValue("@Rat1Dolar", Rat1Dolar);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

                IsUpdate = true;
            }
            catch (Exception ex)
            {
                IsUpdate = false;
            }
            finally { connection.Close(); }



            return IsUpdate;
        }

        static public bool DeleteCurrencie(int CurrencieID)
        {
            bool IsDelete = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Delete From Currencies Where CurrencieID = @CurrencieID";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencieID", CurrencieID);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                IsDelete = true;
            }
            catch (Exception ex)
            {
                IsDelete = false;
            }
            finally { connection.Close(); }

            return IsDelete;

        }


        static public DataTable GetAllCurrencieAndAllInfo()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string Query = "Select * From Currencies";
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
