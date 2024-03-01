using BusLines.Bookings;
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

namespace BusLines
{
    public partial class UserIntroForm : Form
    {
        int UserId;
        public UserIntroForm()
        {
            InitializeComponent();
        }

       

        private void label3_Click(object sender, EventArgs e)
        {

            BookingForm bookingForm = new BookingForm(UserId);
            bookingForm.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            bookingForm.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            FeedbackUserForm feedbackUser = new FeedbackUserForm(UserId);
            feedbackUser.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            feedbackUser.Show();
            this.Hide();


        }
    }
}
