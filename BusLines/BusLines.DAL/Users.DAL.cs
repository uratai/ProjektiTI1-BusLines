using MenagjimiAutobusav.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLines.DAL
{
    internal class Users
    {

        public static DataTable ReadUsers()

        {
            //created new instance for connection with sql via connection string
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("ReadUsers", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Create a new instance of the SqlDataAdapter class and execute the stored procedure using the SqlCommand object
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                // Create a new instance of the DataTable class and fill it with the data returned by the SqlDataAdapter
                DataTable dtCompany = new DataTable();
                dataAdapter.Fill(dtCompany);

                // Return the filled DataTable object
                return dtCompany;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Con.Close();
            }
        }

        public static void InsertUsers(int userID, string username, string password, string userType)
        {
            // Create a new instance of the SqlConnection class to connect to the database
            //SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Menaxhimi_porosive;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the connection to the database
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("InsertUsers", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add value to params of procedure
                cmd.Parameters.Add("@UserID", System.Data.SqlDbType.Int, 100).Value = userID;
                cmd.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 100).Value = username;
                cmd.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 100).Value = password;
                cmd.Parameters.Add("UserType", System.Data.SqlDbType.NVarChar, 100).Value = userType;


                // Execute the stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Close the connection to the database
                Con.Close();
            }
        }


        public static void UpdateUsers(int userID, string username, string password, string userType)
        {
            // Create a new instance of the SqlConnection class to connect to the database
            //SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Menaxhimi_porosive;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the connection to the database
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("UpdateUsers", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add value to params of procedure
                cmd.Parameters.Add("@UserID", System.Data.SqlDbType.Int, 100).Value = userID;
                cmd.Parameters.Add("@Username", System.Data.SqlDbType.NVarChar, 100).Value = username;
                cmd.Parameters.Add("@Password", System.Data.SqlDbType.NVarChar, 100).Value = password;
                cmd.Parameters.Add("UserType", System.Data.SqlDbType.NVarChar, 100).Value = userType;


                // Execute the stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Close the connection to the database
                Con.Close();
            }
        }


        public static void DeleteUsers(int userID)
        {
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("DeleteUsers", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Assign the parameter for the stored procedure
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = userID;

                // Execute the stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If an exception occurs, throw it back to the calling code
                throw ex;
            }
            finally
            {
                // Make sure to close the database connection, whether an exception occurred or not
                Con.Close();
            }
        }



    }
}
