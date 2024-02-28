using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiTi1_Busat.BO
{
	public class Feedback
	{
		
			private int feedbackID;
			private int userID;
			private int companyID;
			private string feedbackText;
			private DateTime feedbackDate;

			public int FeedbackID
			{
				get { return feedbackID; }
				set { feedbackID = value; }
			}

			public int UserID
			{
				get { return userID; }
				set { userID = value; }
			}

			public int CompanyID
			{
				get { return companyID; }
				set { companyID = value; }
			}

			public string FeedbackText
			{
				get { return feedbackText; }
				set { feedbackText = value; }
			}

			public DateTime FeedbackDate
			{
				get { return feedbackDate; }
				set { feedbackDate = value; }
			}
		}
	}
}