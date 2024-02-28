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
    public class Feedback
    {
		public static void InsertFeedback(int feedbackID , int userID, int companyID, string feedbackText, DateTime feedbackDate)
		{
			string connectionString = DBHelper.GetConnectionString();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("InsertFeedback", con);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);
					cmd.Parameters.AddWithValue("@UserID", userID);
					cmd.Parameters.AddWithValue("@CompanyID", companyID);
					cmd.Parameters.AddWithValue("@FeedbackText", feedbackText);
					cmd.Parameters.AddWithValue("@FeedbackDate", feedbackDate);
					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public static void UpdateFeedback(int feedbackID, int userID, int companyID, string feedbackText, DateTime feedbackDate)
		{
			string connectionString = DBHelper.GetConnectionString();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("UpdateFeedback", con);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@FeedbackID",feedbackID);
					cmd.Parameters.AddWithValue("@UserID", userID);
					cmd.Parameters.AddWithValue("@CompanyID", companyID);
					cmd.Parameters.AddWithValue("@FeedbackText", feedbackText);
					cmd.Parameters.AddWithValue("@FeedbackDate", feedbackDate);

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public static void DeleteFeedback(int feedbackID)
		{
			string connectionString = DBHelper.GetConnectionString();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("DeleteFeedback", con);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@FeedbackID", feedbackID);

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public static DataTable ReadFeedback()
		{
			string connectionString = DBHelper.GetConnectionString();
			DataTable feedbackTable = new DataTable();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("ReadFeedback", con);
					cmd.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(feedbackTable);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return feedbackTable;
		}
	}
}