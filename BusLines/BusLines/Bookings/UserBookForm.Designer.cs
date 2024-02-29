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
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Book", "Cancel" });
            cbStatus.Location = new Point(575, 349);
            cbStatus.Margin = new Padding(3, 2, 3, 2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(248, 37);
            cbStatus.TabIndex = 40;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(449, 352);
            label4.Name = "label4";
            label4.Size = new Size(100, 29);
            label4.TabIndex = 39;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(449, 264);
            label3.Name = "label3";
            label3.Size = new Size(72, 29);
            label3.TabIndex = 38;
            label3.Text = "Line:";
            // 
            // txtLine
            // 
            txtLine.Location = new Point(575, 261);
            txtLine.Margin = new Padding(3, 2, 3, 2);
            txtLine.Name = "txtLine";
            txtLine.Size = new Size(248, 37);
            txtLine.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(944, 258);
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
            btnBook.Location = new Point(652, 488);
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
            dateTimeBooking.Location = new Point(944, 305);
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
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(303, 838);
            panel1.TabIndex = 43;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(40, 20);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(228, 161);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 14;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(17, 588);
            pictureBox5.Margin = new Padding(0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(76, 76);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(17, 290);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(76, 76);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkCyan;
            label8.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(92, 603);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 8;
            label8.Text = "Feedback";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(17, 488);
            pictureBox3.Margin = new Padding(0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(76, 76);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.DarkCyan;
            label7.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(92, 305);
            label7.Margin = new Padding(0);
            label7.Name = "label7";
            label7.Size = new Size(187, 32);
            label7.TabIndex = 12;
            label7.Text = "Search & Book";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.DarkCyan;
            label6.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(92, 503);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(146, 32);
            label6.TabIndex = 10;
            label6.Text = "Passenger";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 390);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(76, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 763);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 75);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(104, 21);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 15;
            label2.Text = "Logout";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 1);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(76, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.DarkCyan;
            label5.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(92, 405);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(62, 32);
            label5.TabIndex = 8;
            label5.Text = "Bus";
            // 
            // panel3
            // 
            panel3.BackColor = Color.MediumTurquoise;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(303, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1621, 66);
            panel3.TabIndex = 44;
            // 
            // UserBookForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1924, 838);
            Controls.Add(panel3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Label label8;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel3;
    }
}