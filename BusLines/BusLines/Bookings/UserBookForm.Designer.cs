namespace BusLines.Bookings
{
    partial class UserBookForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserBookForm));
            cbStatus = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            txtLine = new TextBox();
            label1 = new Label();
            btnBook = new Button();
            dateTimeBooking = new DateTimePicker();
            panel1 = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblFeedback = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label16 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Book", "Cancel" });
            cbStatus.Location = new Point(671, 358);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(248, 37);
            cbStatus.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 361);
            label4.Name = "label4";
            label4.Size = new Size(100, 29);
            label4.TabIndex = 39;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(545, 273);
            label3.Name = "label3";
            label3.Size = new Size(72, 29);
            label3.TabIndex = 38;
            label3.Text = "Line:";
            // 
            // txtLine
            // 
            txtLine.Location = new Point(671, 270);
            txtLine.Margin = new Padding(3, 2, 3, 2);
            txtLine.Name = "txtLine";
            txtLine.Size = new Size(248, 37);
            txtLine.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(974, 277);
            label1.Name = "label1";
            label1.Size = new Size(184, 29);
            label1.TabIndex = 35;
            label1.Text = "Booking Date:";
            // 
            // btnBook
            // 
            btnBook.BackColor = Color.Teal;
            btnBook.Font = new Font("Verdana", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnBook.ForeColor = Color.White;
            btnBook.Location = new Point(863, 512);
            btnBook.Margin = new Padding(6);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(171, 84);
            btnBook.TabIndex = 41;
            btnBook.Text = "Book";
            btnBook.UseVisualStyleBackColor = false;
            btnBook.Click += btnBook_Click;
            // 
            // dateTimeBooking
            // 
            dateTimeBooking.Location = new Point(974, 324);
            dateTimeBooking.Margin = new Padding(6);
            dateTimeBooking.Name = "dateTimeBooking";
            dateTimeBooking.Size = new Size(448, 37);
            dateTimeBooking.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(lblFeedback);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 788);
            panel1.TabIndex = 54;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(63, 16);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(182, 129);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(30, 358);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 61);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(25, 275);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 61);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // lblFeedback
            // 
            lblFeedback.AutoSize = true;
            lblFeedback.BackColor = Color.DarkCyan;
            lblFeedback.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedback.ForeColor = Color.White;
            lblFeedback.Location = new Point(90, 370);
            lblFeedback.Margin = new Padding(0);
            lblFeedback.Name = "lblFeedback";
            lblFeedback.Size = new Size(135, 32);
            lblFeedback.TabIndex = 8;
            lblFeedback.Text = "Feedback";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkCyan;
            label7.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(85, 287);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(187, 32);
            label7.TabIndex = 12;
            label7.Text = "Search & Book";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(2, 728);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 60);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(83, 17);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 15;
            label2.Text = "Logout";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(label16);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(303, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1428, 53);
            panel5.TabIndex = 70;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Trebuchet MS", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(654, 16);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(110, 33);
            label16.TabIndex = 72;
            label16.Text = "Booking";
            // 
            // UserBookForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1731, 788);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(dateTimeBooking);
            Controls.Add(btnBook);
            Controls.Add(cbStatus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtLine);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "UserBookForm";
            Text = "UserBookForm";
            Load += UserBookForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbStatus;
        private Label label4;
        private Label label3;
        private TextBox txtLine;
        private Label label1;
        private Button btnBook;
        private DateTimePicker dateTimeBooking;
        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label lblFeedback;
        private Label label7;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label16;
    }
}