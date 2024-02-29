using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenagjimiAutobusav.DAL;

namespace BusLines.DAL
{
	public class TranslationsDAL
	{
		public static DataTable GetAllTranslations()
		{
			//created new instance for connection with sql via connection string
			SqlConnection conn = new SqlConnection(DBHelper.GetConnectionString());
			try
			{
				conn.Open();

				// Create a new instance of the SqlCommand class to execute the stored procedure
				SqlCommand cmd = new SqlCommand("GetAllTranslations", conn);
				cmd.CommandType = System.Data.CommandType.StoredProcedure;

				// Create a new instance of the SqlDataAdapter class and execute the stored procedure using the SqlCommand object
				SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

				// Create a new instance of the DataTable class and fill it with the data returned by the SqlDataAdapter
				DataTable dtTranslations = new DataTable();
				dataAdapter.Fill(dtTranslations);

				// Return the filled DataTable object
				return dtTranslations;
			}
			catch (Exception ex)
			{
				throw ex;
			}
			finally
			{
				conn.Close();
			}
		}

	}
}
