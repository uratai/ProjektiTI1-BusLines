using BusLines.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusLines.Bookings
{
    public partial class UserBookForm : Form
    {
        int LineId;
        int Companyid;
        int UserId;



        public UserBookForm(int userId, int lineId, string departureCity, string arrivalCity, DateTime departureTime, DateTime arrivalTime)
        {
            InitializeComponent();
            LineId = lineId;

            txtLine.Text = lineId.ToString();
            UserId = userId;


        }

        private void UserBookForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            AdminBookForm adminBookForm = new AdminBookForm();
            if (adminBookForm != null)
            {
                DataTable userbook = BookingDAL.ReadBooking();

                // Bind the DataGridView to the linesData
                //dataBookUsers.DataSource = userbook;
                BookingDAL.InsertBooking(UserId, LineId, dateTimeBooking.Value, cbStatus.Text);

                adminBookForm.UpdateDataGridView();


            }


        }


    }

}

