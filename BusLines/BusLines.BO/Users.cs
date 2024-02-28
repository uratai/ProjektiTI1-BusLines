using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektiTi1_Busat.BO
{
	public class Users
	{
		private int userID;
		private string username;
		private string password;
		private string userType;

		public int UserID
		{
			get { return userID; }
			set { userID = value; }
		}

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public string UserType
		{
			get { return userType; }
			set { userType = value; }
		}
	}
}