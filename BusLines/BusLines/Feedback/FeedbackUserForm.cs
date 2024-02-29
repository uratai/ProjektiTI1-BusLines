using BusLines.Bookings;
using BusLines.Company;
using BusLines.DAL;
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
    public partial class FeedbackUserForm : Form
    {
        int UserId;
        public FeedbackUserForm(int userId)
        {
            InitializeComponent();
            UserId = userId;
        }




        private void btnSend_Click(object sender, EventArgs e)
        {
            int companyID = Convert.ToInt32(cbFeedbackCompany.SelectedValue);

            string feedbackText = txtFeedbackText.Text;
            DateTime feedbackDate = dateTimeFeedback.Value;

            FeedbackAdminForm feedback = new FeedbackAdminForm();
            if (feedback != null)
            {
                DataTable feedbackdata = FeedbackDAL.ReadFeedback();

                // Bind the DataGridView to the linesData
                //dataBookUsers.DataSource = userbook;
                FeedbackDAL.InsertFeedback(UserId, companyID, feedbackText, feedbackDate); // Use UserId instead of UserID
                MessageBox.Show("Feedback added successfully!");

                feedback.UpdateDataGridView();
                feedback.Show();


            }
        }

        private void FeedbackUserForm_Load(object sender, EventArgs e)
        {
            try
            {
                // Fetch company data from your data source
                DataTable companyData = CompanyDAL.ReadCompany();

                // Ensure the DataTable has data
                if (companyData.Rows.Count > 0)
                {
                    // Clear existing items in the ComboBox
                    cbFeedbackCompany.Items.Clear();

                    // Bind the DataTable to the ComboBox
                    cbFeedbackCompany.DataSource = companyData;

                    // Set the DisplayMember to the column name that represents the company name
                    cbFeedbackCompany.DisplayMember = "CompanyName";

                    // Set the ValueMember to the column name that represents the company ID
                    cbFeedbackCompany.ValueMember = "CompanyId";

                    // Set the ComboBox to show the first company by default
                    cbFeedbackCompany.SelectedIndex = 0;

                    int companyID = Convert.ToInt32(cbFeedbackCompany.SelectedValue);
                }
                else
                {
                    MessageBox.Show("No companies found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading companies: " + ex.Message);
            }
        }


    }
}




