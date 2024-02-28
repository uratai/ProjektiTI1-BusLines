using MenagjimiAutobusav.DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusLines.DAL
{
    public class Booking
    {
        public static void CreateBooking(int bookingID, int userID, int lineID, DateTime bookingDate, string status)
        {
            SqlConnection con = new SqlConnection(DBHelper.GetConnectionString());

            try
            {
                // Open the database connection
                con.Open();

                // Create a new instance of the SqlCommand class to execute the stored procedure
                SqlCommand cmd = new SqlCommand("CreateBooking", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Add parameters for the stored procedure
                cmd.Parameters.Add("@BookingId", System.Data.SqlDbType.Int).Value = bookingID;
                cmd.Parameters.Add("@UserId", System.Data.SqlDbType.NVarChar, 100).Value = userID;
                cmd.Parameters.Add("@LineId", System.Data.SqlDbType.Date).Value = lineID;
                cmd.Parameters.Add("@BookingDate", System.Data.SqlDbType.NVarChar, 100).Value = bookingDate;
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

    }

}

