namespace BusLines.Bookings
{
    partial class BookingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            panel5 = new Panel();
            label16 = new Label();
            dataBookForm = new DataGridView();
            txtDestinationTrip = new TextBox();
            txtSourceTrip = new TextBox();
            label13 = new Label();
            label14 = new Label();
            button4 = new Button();
            label5 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            panel3 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            pictureBox12 = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox7 = new PictureBox();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataBookForm).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(label16);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(303, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1428, 66);
            panel5.TabIndex = 48;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Trebuchet MS", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(599, 20);
            label16.Name = "label16";
            label16.Size = new Size(180, 33);
            label16.TabIndex = 75;
            label16.Text = "Booking Form";
            // 
            // dataBookForm
            // 
            dataBookForm.BackgroundColor = Color.Lavender;
            dataBookForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataBookForm.Location = new Point(516, 255);
            dataBookForm.Margin = new Padding(2);
            dataBookForm.Name = "dataBookForm";
            dataBookForm.RowHeadersWidth = 62;
            dataBookForm.RowTemplate.Height = 33;
            dataBookForm.Size = new Size(934, 437);
            dataBookForm.TabIndex = 74;
            dataBookForm.CellContentClick += dataBookForm_CellContentClick_1;
            // 
            // txtDestinationTrip
            // 
            txtDestinationTrip.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDestinationTrip.Location = new Point(1031, 138);
            txtDestinationTrip.Margin = new Padding(2);
            txtDestinationTrip.Name = "txtDestinationTrip";
            txtDestinationTrip.Size = new Size(266, 37);
            txtDestinationTrip.TabIndex = 73;
            // 
            // txtSourceTrip
            // 
            txtSourceTrip.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSourceTrip.Location = new Point(516, 144);
            txtSourceTrip.Margin = new Padding(2);
            txtSourceTrip.Name = "txtSourceTrip";
            txtSourceTrip.Size = new Size(257, 37);
            txtSourceTrip.TabIndex = 72;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(868, 146);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(159, 29);
            label13.TabIndex = 71;
            label13.Text = "Destination:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(405, 148);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(107, 29);
            label14.TabIndex = 70;
            label14.Text = "Source:";
            // 
            // button4
            // 
            button4.BackColor = Color.Teal;
            button4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(1388, 138);
            button4.Margin = new Padding(2);
            button4.Name = "button4";
            button4.Size = new Size(150, 68);
            button4.TabIndex = 69;
            button4.Text = "Search";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
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
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(3, 723);
            panel2.Name = "panel2";
            panel2.Size = new Size(300, 75);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(104, 21);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(102, 32);
            label4.TabIndex = 15;
            label4.Text = "Logout";
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
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 788);
            panel3.TabIndex = 15;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(17, 375);
            pictureBox8.Margin = new Padding(0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(76, 76);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 9;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(18, 275);
            pictureBox9.Margin = new Padding(0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(76, 76);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.DarkCyan;
            label2.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(92, 390);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 8;
            label2.Text = "Feedback";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DarkCyan;
            label3.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(93, 290);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(187, 32);
            label3.TabIndex = 12;
            label3.Text = "Search & Book";
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumTurquoise;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(pictureBox12);
            panel4.Location = new Point(3, 723);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 75);
            panel4.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.White;
            label10.Location = new Point(104, 21);
            label10.Margin = new Padding(0);
            label10.Name = "label10";
            label10.Size = new Size(102, 32);
            label10.TabIndex = 15;
            label10.Text = "Logout";
            // 
            // pictureBox12
            // 
            pictureBox12.Image = (Image)resources.GetObject("pictureBox12.Image");
            pictureBox12.Location = new Point(28, 1);
            pictureBox12.Margin = new Padding(0);
            pictureBox12.Name = "pictureBox12";
            pictureBox12.Size = new Size(76, 76);
            pictureBox12.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox12.TabIndex = 7;
            pictureBox12.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(panel3);
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
            panel1.Size = new Size(303, 788);
            panel1.TabIndex = 47;
            // 
            // label1
            // 
            label1.AccessibleName = "txtSourceLocation";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(239, 450);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 46;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(56, 20);
            pictureBox7.Margin = new Padding(0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(182, 129);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 15;
            pictureBox7.TabStop = false;
            // 
            // BookingForm
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1731, 788);
            Controls.Add(dataBookForm);
            Controls.Add(txtDestinationTrip);
            Controls.Add(txtSourceTrip);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(button4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label1);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "BookingForm";
            Text = "BookingForm";
            Load += BookingForm_Load;
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataBookForm).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private DataGridView dataBookForm;
        private TextBox txtDestinationTrip;
        private TextBox txtSourceTrip;
        private Label label13;
        private Label label14;
        private Button button4;
        private Label label5;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label8;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Panel panel3;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label label10;
        private PictureBox pictureBox12;
        private Panel panel1;
        private Label label1;
        private Label label16;
        private PictureBox pictureBox7;
    }
}