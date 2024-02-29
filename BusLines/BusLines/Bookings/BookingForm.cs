using BusLines.DAL;
using BusLines.Feedback;
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
    public partial class BookingForm : Form
    {
        int UserId;
        public BookingForm(int userId)
        {
            InitializeComponent();
            DataTable linesData = LinesDAL.ReadLinesWithCompanyName();

            // Bind the DataGridView to the linesData
            dataBookForm.DataSource = linesData;
            UserId = userId;
        }

        private void BookingForm_Load(object sender, EventArgs e)
        {

        }



        private void label2_Click(object sender, EventArgs e)
        {
            FeedbackUserForm feedbackUserForm = new FeedbackUserForm(UserId);
            feedbackUserForm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string departureCity = txtSourceTrip.Text.Trim();
            string arrivalCity = txtDestinationTrip.Text.Trim();

            try
            {
                DataTable searchResults = LinesDAL.SearchLinesbyDestination(departureCity, arrivalCity);

                if (searchResults != null && searchResults.Rows.Count > 0)
                {
                    dataBookForm.DataSource = searchResults;
                }
                else
                {
                    MessageBox.Show("No matching Destination.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching for the destination: " + ex.Message);
            }

        }

        private void dataBookForm_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataBookForm.Rows[e.RowIndex];

                // Extract the data from the selected row
                int lineId = Convert.ToInt32(selectedRow.Cells["LineID"].Value);
                //string companyId = Convert.ToString(selectedRow.Cells["CompanyName"].Value); 
                string departureCity = Convert.ToString(selectedRow.Cells["DepartureCity"].Value);
                string arrivalCity = Convert.ToString(selectedRow.Cells["ArrivalCity"].Value);
                DateTime departureTime = Convert.ToDateTime(selectedRow.Cells["DepartureTime"].Value);
                DateTime arrivalTime = Convert.ToDateTime(selectedRow.Cells["ArrivalTime"].Value);

                // Open the new form for booking a ticket with the extracted data
                UserBookForm bookForm = new UserBookForm(UserId, lineId, departureCity, arrivalCity, departureTime, arrivalTime);
                bookForm.ShowDialog(); // Show the form as a modal dialog
            }
        }
    }
}


