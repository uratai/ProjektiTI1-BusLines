using BusLines.DAL;
using MenagjimiAutobusav.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BusLines.Company
{
	public partial class AdminCompanyForm : Form
	{

		public AdminCompanyForm()
		{
			InitializeComponent();
		}
		public void UpdateDataGridView()
		{
			DataTable company = CompanyDAL.ReadCompany();
			dataAddCompany.DataSource = company;
		}
		private void AdminCompanyForm_Load(object sender, EventArgs e)
		{

		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string companyName = txtCompanyName.Text;
			string companyNumber = txtCompanyNumber.Text;
			int seats = int.Parse(txtTotalSeats.Text);
			string status = cbStatus.SelectedItem?.ToString();

			try
			{
				// Assuming you have a method to create a company in your DAL
				CompanyDAL.InsertCompany(companyName, companyNumber, seats, status);
				MessageBox.Show("Company added successfully!");
				UpdateDataGridView();
				//companyListForm.UpdateDataGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error adding company: " + ex.Message);
			}
		}


		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (dataAddCompany.SelectedRows.Count > 0)
			{
				int columnIndex = dataAddCompany.SelectedRows[0].Index;
				int companyId = Convert.ToInt32(dataAddCompany.Rows[columnIndex].Cells["CompanyId"].Value);

				// Retrieve the updated input values
				string companyName = txtCompanyName.Text;
				string companyNumber = txtCompanyNumber.Text;
				int seats = int.Parse(txtTotalSeats.Text);
				string status = cbStatus.SelectedItem?.ToString();

				try
				{
					// Assuming you have a method to update a company in your DAL
					CompanyDAL.UpdateCompany(companyId, companyName, companyNumber, seats, status);
					MessageBox.Show("Company updated successfully!");
					UpdateDataGridView();
					//companyListForm.UpdateDataGridView();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error updating company: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please select a company to update.");
			}
		}



		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataAddCompany.SelectedCells.Count > 0)
			{
				int columnIndex = dataAddCompany.Columns["CompanyID"].Index;
				int companyId = Convert.ToInt32(dataAddCompany.SelectedCells[columnIndex].Value);

				try
				{
					// Assuming you have a method to delete a company in your DAL
					CompanyDAL.DeleteCompany(companyId);
					MessageBox.Show("Company deleted successfully!");
					UpdateDataGridView();
					//companyListForm.UpdateDataGridView();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error deleting company: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please select a company to delete.");
			}
		}
	}
}