using BusLines.Bookings;
using MenagjimiAutobusav.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusLines.Authentication
{
	public partial class LogIn : Form
	{
		public LogIn()
		{
			InitializeComponent();
		}






		private void LogIn_Load(object sender, EventArgs e)
		{

		}

		private void btnRegisterUser_Click(object sender, EventArgs e)
		{
			Register registeruser = new Register();
			registeruser.Show();

		}

		private void btnLogin_Click_1(object sender, EventArgs e)
		{
			string enteredUsername = txtUserName.Text;
			string enteredPassword = txtPassword.Text;
			string selectedRole = cbRole.SelectedItem?.ToString(); // Assuming you have a ComboBox control named cbRole for role selection

			// Create a SQL query to check if the user with the provided credentials exists
			string query = "SELECT COUNT(*) FROM [Users] WHERE Username = @Username AND Password = @Password AND Role = @Role";

			using (SqlConnection con = new SqlConnection(DBHelper.GetConnectionString()))
			{
				using (SqlCommand command = new SqlCommand(query, con))
				{
					command.Parameters.AddWithValue("@Username", enteredUsername);
					command.Parameters.AddWithValue("@Password", enteredPassword);
					command.Parameters.AddWithValue("@Role", selectedRole);

					try
					{
						con.Open();
						int count = (int)command.ExecuteScalar();

						if (count > 0)
						{
							MessageBox.Show("Login successful!");

							// Open the appropriate form based on the selected role
							if (selectedRole.Equals("User", StringComparison.OrdinalIgnoreCase))
							{
								// Open UserForm
								BookingForm userForm = new BookingForm();
								userForm.Show();
							}
							else if (selectedRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
							{
								// Open AdminForm
								BookingForm adminForm = new BookingForm();
								adminForm.Show();
							}
						}
						else
						{
							MessageBox.Show("Invalid username, password, or role. Please try again.");
						}
					}
					catch (Exception ex)
					{
						MessageBox.Show("An error occurred: " + ex.Message);
					}
				}
			}
		}
	}
}