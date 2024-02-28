using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiTi1_Busat.BO
{
	public class Lines
	{
		public class Line
		{
			private int lineID;
			private int companyID;
			private string departureCity;
			private string arrivalCity;
			private DateTime departureTime;
			private DateTime arrivalTime;

			public int LineID
			{
				get { return lineID; }
				set { lineID = value; }
			}

			public int CompanyID
			{
				get { return companyID; }
				set { companyID = value; }
			}

			public string DepartureCity
			{
				get { return departureCity; }
				set { departureCity = value; }
			}

			public string ArrivalCity
			{
				get { return arrivalCity; }
				set { arrivalCity = value; }
			}

			public DateTime DepartureTime
			{
				get { return departureTime; }
				set { departureTime = value; }
			}

			public DateTime ArrivalTime
			{
				get { return arrivalTime; }
				set { arrivalTime = value; }
			}
		}
	}
}

//		public int LineID { get; set; }
//		public int CompanyID { get; set; }
//		public string DepartureCity { get; set; }
//		public string ArrivalCity { get; set; }
//		public DateTime DepartureTime { get; set; }
//		public DateTime ArrivalTime { get; set; }

//		public Lines(int lineID, int companyID, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime)
//		{
//			LineID = lineID;
//			CompanyID = companyID;
//			DepartureCity = departureCity;
//			ArrivalCity = arrivalCity;
//			DepartureTime = departureTime;
//			ArrivalTime = arrivalTime;
//		}
//	}
//}