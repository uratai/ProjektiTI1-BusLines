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
    public partial class FeedbackAdminForm : Form
    {
        public FeedbackAdminForm()
        {
            InitializeComponent();
        }
        public void UpdateDataGridView()
        {
            DataTable feedbackdata = FeedbackDAL.ReadFeedback();
            dataFeedbackUser.DataSource = feedbackdata;

            // Assuming the column name in your DataGridView for user name is "UserName"
            //feedbackdata.Columns["UserName"].HeaderText = "User Name";
        }
        private void FeedbackAdminForm_Load(object sender, EventArgs e)
        {

        }

        private void dataFeedbackUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
