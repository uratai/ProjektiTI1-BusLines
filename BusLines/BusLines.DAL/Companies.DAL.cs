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
    internal class Companies
    {

        public static DataTable ReadCompany()

        {
            //created new instance for connection with sql via connection string
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("ReadCompany", Con);
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

        public static void CreateCompany(int companyID, string companyName, string companyNumber,int seats, string status)
        {
            // Create a new instance of the SqlConnection class to connect to the database
            //SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Menaxhimi_porosive;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the connection to the database
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("CreateCompany", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add value to params of procedure
                cmd.Parameters.Add("@CompanyId", System.Data.SqlDbType.Int, 100).Value = companyID;
                cmd.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 100).Value = companyName;
                cmd.Parameters.Add("@CompanyNumber", System.Data.SqlDbType.NVarChar, 100).Value = companyNumber;
                cmd.Parameters.Add("@Seats", System.Data.SqlDbType.Int).Value = seats;
                cmd.Parameters.Add("Status", System.Data.SqlDbType.NVarChar, 100).Value= status;


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

        public static void UpdateCompany(int companyID, string companyName, string companyNumber, int seats, string status)
        {
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("UpdateCompany", Con);

                // Set the command type to StoredProcedure
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // added values to specific parameters of procedures
                cmd.Parameters.Add("@CompanyId", SqlDbType.Int).Value = companyID;
                cmd.Parameters.Add("@CompanyName", System.Data.SqlDbType.NVarChar, 50).Value = companyName;
                cmd.Parameters.Add("@CompanyNumber", System.Data.SqlDbType.NVarChar, 50).Value = companyNumber;
                cmd.Parameters.Add("@Seats", System.Data.SqlDbType.Int, 100).Value = seats;
                cmd.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar, 50).Value = status;



                // Execute the SqlCommand object to update the row in the Klienti table
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If an exception occurs, rethrow the exception to the calling method
                throw ex;
            }
            finally
            {
                // Close the database connection
                Con.Close();
            }

        }

        public static void DeleteCompany(int companyId)
        {
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("DeleteCompany", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Assign the parameter for the stored procedure
                cmd.Parameters.Add("@Id", SqlDbType.Int).Value = companyId;

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
        public static DataTable SearchCompanyByName(string companyName)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("SearchCompanyByName", con);
                cmd.CommandType = CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 100).Value = companyName;

                // Execute the stored procedure and retrieve the results
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable searchResults = new DataTable();
                adapter.Fill(searchResults);

                // Check if there are any rows in the result DataTable
                if (searchResults.Rows.Count > 0)
                {
                    return searchResults;
                }
                else
                {
                    return null; // or return an empty DataTable if desired
                }
            }
            catch (Exception ex)
            {
                // If an exception occurs, throw it or handle it as needed
                throw ex;
            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }
    }
}

