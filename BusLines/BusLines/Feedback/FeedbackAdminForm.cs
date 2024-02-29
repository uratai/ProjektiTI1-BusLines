using BusLines.Authentication;
using BusLines.Bookings;
using BusLines.Company;
using BusLines.DAL;
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

namespace BusLines.Feedback
{
    public partial class FeedbackAdminForm : Form
    {
        public FeedbackAdminForm()
        {
            InitializeComponent();
            UpdateDataGridView();
        }
        public void UpdateDataGridView()
        {
            DataTable feedbackdata = FeedbackDAL.ReadFeedback();
            dataFeedbackUser.DataSource = feedbackdata;

            // Assuming the column name in your DataGridView for user name is "UserName"
            //feedbackdata.Columns["UserName"].HeaderText = "User Name";
        }

        private void lblLinesUser_Click(object sender, EventArgs e)
        {
            AdminFormLines adminFormLines = new AdminFormLines();
            adminFormLines.Show();
            this.Hide();
        }

        private void lblCompanyUser_Click(object sender, EventArgs e)
        {
            AdminCompanyForm adminCompanyForm = new AdminCompanyForm();
            adminCompanyForm.Show();
            this.Hide();
        }

        private void lblBookingUser_Click(object sender, EventArgs e)
        {
            AdminBookForm adminBookForm = new AdminBookForm();
            adminBookForm.Show();
            this.Hide();
        }

        private void lblLogoutForm_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();
        }

        private void FeedbackAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataFeedbackUser.SelectedCells.Count > 0)
            {
                int rowIndex = dataFeedbackUser.SelectedCells[0].RowIndex;
                int feedbackId = Convert.ToInt32(dataFeedbackUser.Rows[rowIndex].Cells["FeedbackID"].Value); // Assuming LineID is the column name

                try
                {
                    // Assuming you have a method to delete a line in your DAL
                    FeedbackDAL.DeleteFeedback(feedbackId);
                    MessageBox.Show("Feedback deleted successfully!");
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting feedback: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a feedback to delete.");
            }
        }
    }
}
