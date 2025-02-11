﻿using BusLines.Bookings;
using BusLines.Feedback;
using BusLines.Lines;
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
            //_resourceManager = new ResourceManager("BusLines.SharedResources", typeof(LogIn).Assembly);
            txtPassword.UseSystemPasswordChar = true;
        }


        private void lblRegister_Click(object sender, EventArgs e)
        {
            Register registeruser = new Register();
            registeruser.Show();
        }

        private void lblCloseL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;
            string selectedRole = cbRole.SelectedItem?.ToString(); // Assuming you have a ComboBox control named cbRole for role selection

            if (string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please fill in all the fields before logging in.");
            }
            else
            {
                // Create a SQL query to retrieve the user ID of the logged-in user
                string userIdQuery = "SELECT UserID FROM [Users] WHERE Username = @Username AND Password = @Password AND Role = @Role";


                using (SqlConnection con = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(userIdQuery, con))
                    {
                        command.Parameters.AddWithValue("@Username", enteredUsername);
                        command.Parameters.AddWithValue("@Password", enteredPassword);
                        command.Parameters.AddWithValue("@Role", selectedRole);

                        try
                        {
                            con.Open();
                            object userIdObj = command.ExecuteScalar();

                            if (userIdObj != null)
                            {
                                int userId = (int)userIdObj;

                                MessageBox.Show("Login successful!");

                                // Open the appropriate form based on the selected role
                                if (selectedRole.Equals("User", StringComparison.OrdinalIgnoreCase))
                                {
                                    // Open UserForm and pass user ID
                                    BookingForm userForm = new BookingForm(userId);
                            
                                    //feedbackform.Show();
                                    userForm.Show();
                                }
                                else if (selectedRole.Equals("Admin", StringComparison.OrdinalIgnoreCase))
                                {
                                    // Open AdminForm and pass user ID
                                    AdminIntroForm adminForm = new AdminIntroForm();
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



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("sq-XK");
                    break;
                case 2:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("de-DE");
                    break;
            }
            this.Controls.Clear();
            InitializeComponent();


        }

     
    }
}