using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiTi1_Busat.BO
{
	public class Companies
	{
		private int companyID;
		private string companyName;
		private string companyNumber;
		private int seats;
		private string status;

		public int CompanyID
		{
			get { return companyID; }
			set { companyID = value; }
		}

		public string CompanyName
		{
			get { return companyName; }
			set { companyName = value; }
		}

		public string CompanyNumber
		{
			get { return companyNumber; }
			set { companyNumber = value; }
		}

		public int Seats
		{
			get { return seats; }
			set { seats = value; }
		}

		public string Status
		{
			get { return status; }
			set { status = value; }
		}
	}
}