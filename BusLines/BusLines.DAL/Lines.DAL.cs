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
	public class LinesDAL
	{
		public static DataTable ReadLines()
		{
			string connectionString = DBHelper.GetConnectionString();
			DataTable linesTable = new DataTable();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("ReadLines", con);
					cmd.CommandType = CommandType.StoredProcedure;

					SqlDataAdapter adapter = new SqlDataAdapter(cmd);
					adapter.Fill(linesTable);
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}

			return linesTable;
		}

		public static void InsertLine(int companyID, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime)
		{
			string connectionString = DBHelper.GetConnectionString();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("InsertLine", con);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@CompanyID", companyID);
					cmd.Parameters.AddWithValue("@DepartureCity", departureCity);
					cmd.Parameters.AddWithValue("@ArrivalCity", arrivalCity);
					cmd.Parameters.AddWithValue("@DepartureTime", departureTime);
					cmd.Parameters.AddWithValue("@ArrivalTime", arrivalTime);

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public static void UpdateLine(int lineID, int companyID, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime)
		{
			string connectionString = DBHelper.GetConnectionString();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("UpdateLine", con);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@LineID", lineID);
					cmd.Parameters.AddWithValue("@CompanyID", companyID);
					cmd.Parameters.AddWithValue("@DepartureCity", departureCity);
					cmd.Parameters.AddWithValue("@ArrivalCity", arrivalCity);
					cmd.Parameters.AddWithValue("@DepartureTime", departureTime);
					cmd.Parameters.AddWithValue("@ArrivalTime", arrivalTime);

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}

		public static void DeleteLine(int lineID)
		{
			string connectionString = DBHelper.GetConnectionString();

			using (SqlConnection con = new SqlConnection(connectionString))
			{
				try
				{
					con.Open();

					SqlCommand cmd = new SqlCommand("DeleteLine", con);
					cmd.CommandType = CommandType.StoredProcedure;

					cmd.Parameters.AddWithValue("@LineID", lineID);

					cmd.ExecuteNonQuery();
				}
				catch (Exception ex)
				{
					throw ex;
				}
			}
		}
	}
}
