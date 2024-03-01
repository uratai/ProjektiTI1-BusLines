using BusLines.Bookings;
using BusLines.Company;
using BusLines.Feedback;
using BusLines.Lines;

namespace BusLines
{
    public partial class AdminIntroForm : Form
    {
        public AdminIntroForm()
        {
            InitializeComponent();

        }




        private void lblLinesUser_Click(object sender, EventArgs e)
        {
            AdminFormLines adminFormLines = new AdminFormLines();
            adminFormLines.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            adminFormLines.Show();
            this.Hide();
        }

        private void lblCompanyUser_Click(object sender, EventArgs e)
        {
            AdminCompanyForm adminCompany = new AdminCompanyForm();
            adminCompany.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            adminCompany.Show();
            this.Hide();
        }

        private void lblBookingUser_Click(object sender, EventArgs e)
        {
            AdminBookForm bookForm = new AdminBookForm();
            bookForm.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            bookForm.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            FeedbackAdminForm feedbackAdminForm = new FeedbackAdminForm();
            feedbackAdminForm.Location = new Point(this.Location.X + 20, this.Location.Y + 20);
            feedbackAdminForm.Show();
            this.Hide();
        }

        private void AdminIntroForm_Load(object sender, EventArgs e)
        {
            AdminIntroForm adminIntro = new AdminIntroForm(); ;
            adminIntro.Location = new Point(this.Location.X + 20, this.Location.Y + 50);
        }
    }
}