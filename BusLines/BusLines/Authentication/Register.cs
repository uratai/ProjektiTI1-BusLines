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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }

        private void lblBackLogIn_Click(object sender, EventArgs e)
        {

            LogIn logIn = new LogIn();
            logIn.Show();

        }

        private void lblCloseR_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnRegister_Click(object sender, EventArgs e)
        {
            string enteredEmail = txtEmail.Text;
            string enteredUsername = txtUserName.Text;
            string enteredPassword = txtPassword.Text;
            string selectedRole = cmbRole.SelectedItem?.ToString(); // Ensure selectedRole is not null

            // Check if any of the text boxes is empty
            if (string.IsNullOrEmpty(enteredEmail) || string.IsNullOrEmpty(enteredUsername) || string.IsNullOrEmpty(enteredPassword) || string.IsNullOrEmpty(selectedRole))
            {
                MessageBox.Show("Please fill in all the fields before registering.");
            }
            else
            {
                // Create a SQL query to call the stored procedure for creating a user
                string query = "EXEC [dbo].[InsertUser] @Username = @Username, @Password = @Password, @Role = @Role, @Email = @Email";

                using (SqlConnection con = new SqlConnection(DBHelper.GetConnectionString()))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@Email", enteredEmail);
                        command.Parameters.AddWithValue("@Role", selectedRole); // Assuming roles are correctly populated in cmbRole
                        command.Parameters.AddWithValue("@Username", enteredUsername);
                        command.Parameters.AddWithValue("@Password", enteredPassword);

                        con.Open();
                        command.ExecuteNonQuery();

                        MessageBox.Show("Registration successful! You can now log in.");

                        // Reset the input fields after successful registration
                        txtEmail.Text = "";
                        txtUserName.Text = "";
                        txtPassword.Text = "";
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

