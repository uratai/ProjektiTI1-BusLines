using BusLines.Authentication;
using BusLines.Company;
using BusLines.DAL;
using BusLines.Feedback;
using BusLines.Lines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusLines.Bookings
{
    public partial class AdminBookForm : Form
    {
        public AdminBookForm()
        {
            InitializeComponent();
            UpdateDataGridView();

            DataTable bookingData = BookingDAL.ReadBooking();
            dataBookUsers.DataSource = bookingData;// Call the method to populate DataGridView initially
        }

        public void UpdateDataGridView()
        {
            DataTable bookingData = BookingDAL.ReadBooking();
            dataBookUsers.DataSource = bookingData;

            // Assuming the column name in your DataGridView for user name is "UserName"
            dataBookUsers.Columns["UserName"].HeaderText = "User Name";
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (dataBookUsers.SelectedCells.Count > 0)
            {
                int rowIndex = dataBookUsers.SelectedCells[0].RowIndex;
                int bookingID = Convert.ToInt32(dataBookUsers.Rows[rowIndex].Cells["BookingID"].Value); // Assuming LineID is the column name

                try
                {
                    // Assuming you have a method to delete a line in your DAL
                    BookingDAL.DeleteBooking(bookingID);
                    MessageBox.Show("Booking deleted successfully!");
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting booking: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a book to delete.");
            }
        }

        private void lblLinesCom_Click(object sender, EventArgs e)
        {
            AdminFormLines adminFormLines = new AdminFormLines();
            adminFormLines.Show();
            this.Hide();
        }

        private void lblCompanyCom_Click(object sender, EventArgs e)
        {
            AdminCompanyForm adminCompanyForm = new AdminCompanyForm();
            adminCompanyForm.Show();
            this.Hide();
        }

        private void lblFeedbackCom_Click(object sender, EventArgs e)
        {
            FeedbackAdminForm feedbackAdminForm = new FeedbackAdminForm();
            feedbackAdminForm.Show();
            this.Hide();
        }

        private void lblLOgoutCom_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }
    }
}






