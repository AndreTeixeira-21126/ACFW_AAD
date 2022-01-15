using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ACFW_AAD.BELayer;

namespace ACFW_AAD.DALayer
{
    public class DataAcess
    {
        private static SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["database"].ConnectionString);
        private static SqlCommand command = new SqlCommand();

        public static int GetNumberDonators()
        {
            connection.Open();
            command.Connection = connection;
            command.CommandType = CommandType.Text;
            command.CommandText = "Select count(*) from Donator";
            int n = (int)command.ExecuteScalar();
            connection.Close();
            return n;
        }

        public static int GetNumberAddresses()
        {
            
                connection.Open();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "Select count(*) from Address";
                int n = command.ExecuteReader().GetInt32(0);
                return n;
            
        }
        public static void InsertDonator(Donator donator)
        {

            connection.Open();
           
            try
            {
                command.Connection = connection;
                command.CommandText = "SET IDENTITY_INSERT [Address] OFF";
                command.ExecuteNonQuery();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "add_zipcode";
                command.Parameters.AddWithValue("@zipcode", donator.Adr.ZIPCode.ZIPCode);
                command.Parameters.AddWithValue("@locality", donator.Adr.ZIPCode.Locality);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "add_address";
                command.Parameters.AddWithValue("@street", donator.Adr.Street);
                command.Parameters.AddWithValue("@number", donator.Adr.Number);
                command.Parameters.AddWithValue("@zipcode", donator.Adr.ZIPCode.ZIPCode);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "insert_donator";
                command.Parameters.AddWithValue("@name", donator.Name);
                command.Parameters.AddWithValue("@addressID", donator.Adr.ID);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                command.CommandText = "create_donator_login";
                command.Parameters.AddWithValue("@donID", Donator.NextID++);
                command.Parameters.AddWithValue("@email", donator.LData.Email);
                command.Parameters.AddWithValue("@password", donator.LData.Password);
                command.ExecuteNonQuery();
                command.Parameters.Clear();
                
                connection.Close();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
        }
    }
}
