using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiTi1_Busat.BO
{
	public class Bookings
	{
		private int bookingID;
		private int userID;
		private int lineID;
		private DateTime bookingDate;
		private string status;

		public int BookingID
		{
			get { return bookingID; }
			set { bookingID = value; }
		}

		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		public int LineID
		{
			get { return lineID; }
			set { lineID = value; }
		}

		public DateTime BookingDate
		{
			get { return bookingDate; }
			set { bookingDate = value; }
		}

		public string Status
		{
			get { return status; }
			set { status = value; }
		}
	}
}
//		public int BookingID { get; set; }
//		public int UserID { get; set; }
//		public int LineID { get; set; }
//		public DateTime BookingDate { get; set; }
//		public string Status { get; set; }

//		public Bookings(int bookingID, int userID, int lineID, DateTime bookingDate, string status)
//		{
//			BookingID = bookingID;
//			UserID = userID;
//			LineID = lineID;
//			BookingDate = bookingDate;
//			Status = status;
//		}
//	}
//}
