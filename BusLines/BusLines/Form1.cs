using BusLines.Bookings;
using BusLines.Company;
using BusLines.Lines;

namespace BusLines
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadForm(object Form)
        {
            if (this.panel6.Controls.Count > 0)
                this.panel6.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel6.Controls.Add(f);
            this.panel6.Tag = f;
            f.Show();

        }


        private void lblLinesBook_Click(object sender, EventArgs e)
        {
            loadForm(new AdminFormLines());

        }

        private void lblCompanyBook_Click(object sender, EventArgs e)
        {
            loadForm(new AdminCompanyForm());
        }
    }
}