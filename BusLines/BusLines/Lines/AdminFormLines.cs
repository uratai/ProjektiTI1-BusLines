using BusLines.Authentication;
using BusLines.Bookings;
using BusLines.Company;
using BusLines.DAL;
using BusLines.Feedback;
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

namespace BusLines.Lines
{
    public partial class AdminFormLines : Form
    {
        public AdminFormLines()
        {
            InitializeComponent();
            UpdateDataGridView();
        }


        public void UpdateDataGridView()
        {
            DataTable linesData = LinesDAL.ReadLinesWithCompanyName();

            // Bind the DataGridView to the linesData
            dataAddLines.DataSource = linesData;




        }


        private void AdminFormLines_Load(object sender, EventArgs e)
        {

            try
            {
                // Fetch company data from your data source
                DataTable companyData = CompanyDAL.ReadCompany();

                // Ensure the DataTable has data
                if (companyData.Rows.Count > 0)
                {
                    // Clear existing items in the ComboBox
                    cmbCompanyID.Items.Clear();

                    // Bind the DataTable to the ComboBox
                    cmbCompanyID.DataSource = companyData;

                    // Set the DisplayMember to the column name that represents the company name
                    cmbCompanyID.DisplayMember = "CompanyName";

                    // Set the ValueMember to the column name that represents the company ID
                    cmbCompanyID.ValueMember = "CompanyId";

                    // Set the ComboBox to show the first company by default
                    cmbCompanyID.SelectedIndex = 0;

                    int companyID = Convert.ToInt32(cmbCompanyID.SelectedValue);
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



        private void lblCompany_Click(object sender, EventArgs e)
        {
            AdminCompanyForm adminCompanyForm = new AdminCompanyForm();
            adminCompanyForm.Show();
            this.Hide();


        }

        private void lblBookings_Click(object sender, EventArgs e)
        {
            AdminBookForm adminBookForm = new AdminBookForm();
            adminBookForm.Show();
            this.Hide();
        }

        private void lblFeedback_Click(object sender, EventArgs e)
        {
            FeedbackAdminForm feedbackAdminForm = new FeedbackAdminForm();
            feedbackAdminForm.Show();
            this.Hide();
        }

        private void lblLogOut_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.Hide();


        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            int companyID = Convert.ToInt32(cmbCompanyID.SelectedValue);

            string departureCity = txtDepartureCity.Text;
            string arrivalCity = ttArrivalCity.Text;
            DateTime departureTime = dtDeprartureTime.Value;
            DateTime arrivalTime = dtArrivalTime.Value;


            try
            {
                // Assuming you have a method to add a line in your DAL
                LinesDAL.InsertLine(companyID, departureCity, arrivalCity, departureTime, arrivalTime);
                MessageBox.Show("Line added successfully!");
                UpdateDataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding line: " + ex.Message);
            }
        }


        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (dataAddLines.SelectedCells.Count > 0)
            {
                int rowIndex = dataAddLines.SelectedCells[0].RowIndex;
                int lineID = Convert.ToInt32(dataAddLines.Rows[rowIndex].Cells["LineID"].Value); // Assuming LineID is the column name

                try
                {
                    // Assuming you have a method to delete a line in your DAL
                    LinesDAL.DeleteLine(lineID);
                    MessageBox.Show("Line deleted successfully!");
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting line: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a line to delete.");
            }
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (dataAddLines.SelectedRows.Count > 0)
            {
                int rowIndex = dataAddLines.SelectedRows[0].Index;
                int lineID = Convert.ToInt32(dataAddLines.Rows[rowIndex].Cells["LineID"].Value); // Assuming LineID is the column name

                // Retrieve the updated input values
                int companyID = Convert.ToInt32(cmbCompanyID.SelectedValue);
                // Assuming cmbCompanyID contains company IDs
                string departureCity = txtDepartureCity.Text;
                string arrivalCity = ttArrivalCity.Text;
                DateTime departureTime = dtDeprartureTime.Value;
                DateTime arrivalTime = dtArrivalTime.Value;

                try
                {
                    // Assuming you have a method to update a line in your DAL
                    LinesDAL.UpdateLine(lineID, companyID, departureCity, arrivalCity, departureTime, arrivalTime);
                    MessageBox.Show("Line updated successfully!");
                    UpdateDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating line: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a line to update.");
            }
        }

        private void lblLines_Click(object sender, EventArgs e)
        {
            AdminFormLines adminFormLines = new AdminFormLines();
            adminFormLines.Show();
            this.Hide();

        }

        private void Mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}


