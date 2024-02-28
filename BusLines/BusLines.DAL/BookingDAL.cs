using MenagjimiAutobusav.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLines.DAL
{
    public class BookingDAL
    {
        public static DataTable ReadBooking()

        {
			//created new instance for connection with sql via connection string
			SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());
			{
				try
				{
					con.Open();

					// Modify the SQL query to include line details by joining the Lines table
					SqlCommand cmd = new SqlCommand(@"SELECT b.BookingID, u.Username AS UserName, l.DepartureCity, l.ArrivalCity, l.DepartureTime, l.ArrivalTime, b.BookingDate, b.Status 
                                               FROM Bookings b 
                                               JOIN Users u ON b.UserID = u.UserID
                                               JOIN Lines l ON b.LineID = l.LineID", con);
					cmd.CommandType = CommandType.Text;

					// Create a SqlDataAdapter to fill a DataTable with the query results
					SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
					DataTable dtBooking = new DataTable();
					dataAdapter.Fill(dtBooking);

					return dtBooking;
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}



		public static void InsertBooking( int userID, int lineID, DateTime bookingDate, string status)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("InsertBooking", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                //cmd.Parameters.Add("@BookingId", System.Data.SqlDbType.Int).Value = bookingID;
                cmd.Parameters.Add("@UserId", System.Data.SqlDbType.Int).Value = userID;
                cmd.Parameters.Add("@LineId", System.Data.SqlDbType.Int).Value = lineID;
                cmd.Parameters.Add("@BookingDate", System.Data.SqlDbType.Date).Value = bookingDate;
                cmd.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar, 100).Value = status;


                // Execute the stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If an exception occurs, display an error message
                throw ex;

            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }


        public static void UpdateBooking(int bookingID, int userID, int lineID, DateTime bookingDate, string status)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("UpdateBooking", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                cmd.Parameters.Add("@BookingId", System.Data.SqlDbType.Int).Value = bookingID;
                cmd.Parameters.Add("@UserId", System.Data.SqlDbType.Int).Value = userID;
                cmd.Parameters.Add("@LineId", System.Data.SqlDbType.Int).Value = lineID;
                cmd.Parameters.Add("@BookingDate", System.Data.SqlDbType.Date).Value = bookingDate;
                cmd.Parameters.Add("@Status", System.Data.SqlDbType.NVarChar, 100).Value = status;


                // Execute the stored procedure
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // If an exception occurs, display an error message
                throw ex;

            }
            finally
            {
                // Close the database connection
                con.Close();
            }
        }


        public static void DeleteBooking(int bookingID)
        {
            SqlConnection Con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                Con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("DeleteBooking", Con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Assign the parameter for the stored procedure
                cmd.Parameters.Add("@BookingID", SqlDbType.Int).Value = bookingID;

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

