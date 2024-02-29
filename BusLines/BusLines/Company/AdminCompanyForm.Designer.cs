namespace BusLines.Company
{
    partial class AdminCompanyForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCompanyForm));
            label1 = new Label();
            label13 = new Label();
            label12 = new Label();
            btnDelete = new Button();
            dataAddCompany = new DataGridView();
            btnUpdate = new Button();
            cbStatus = new ComboBox();
            label14 = new Label();
            label15 = new Label();
            txtCompanyName = new TextBox();
            label16 = new Label();
            label17 = new Label();
            btnAdd = new Button();
            txtTotalSeats = new TextBox();
            txtCompanyNumber = new TextBox();
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            lblFeedbackCom = new Label();
            pictureBox10 = new PictureBox();
            lblLinesCom = new Label();
            lblBookingCom = new Label();
            pictureBox11 = new PictureBox();
            panel4 = new Panel();
            lblLOgoutCom = new Label();
            pictureBox12 = new PictureBox();
            lblCompanyCom = new Label();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            pictureBox3 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel5 = new Panel();
            label18 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataAddCompany).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AccessibleName = "txtSourceLocation";
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(953, 450);
            label1.Name = "label1";
            label1.Size = new Size(0, 32);
            label1.TabIndex = 48;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(735, 127);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(245, 32);
            label13.TabIndex = 65;
            label13.Text = "List of Companies";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(370, 127);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(234, 32);
            label12.TabIndex = 64;
            label12.Text = "Company Details";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Teal;
            btnDelete.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(434, 714);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 62);
            btnDelete.TabIndex = 63;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dataAddCompany
            // 
            dataAddCompany.BackgroundColor = Color.AliceBlue;
            dataAddCompany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataAddCompany.Location = new Point(735, 215);
            dataAddCompany.Margin = new Padding(2);
            dataAddCompany.Name = "dataAddCompany";
            dataAddCompany.RowHeadersWidth = 62;
            dataAddCompany.RowTemplate.Height = 33;
            dataAddCompany.Size = new Size(958, 409);
            dataAddCompany.TabIndex = 62;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Teal;
            btnUpdate.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(518, 629);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 62);
            btnUpdate.TabIndex = 61;
            btnUpdate.Text = "Edit";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "Active", "Out of Service" });
            cbStatus.Location = new Point(361, 543);
            cbStatus.Margin = new Padding(2);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(272, 37);
            cbStatus.TabIndex = 60;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(361, 503);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(100, 29);
            label14.TabIndex = 59;
            label14.Text = "Status:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(360, 215);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(214, 29);
            label15.TabIndex = 58;
            label15.Text = "Company Name:";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyName.Location = new Point(360, 255);
            txtCompanyName.Margin = new Padding(2);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(273, 37);
            txtCompanyName.TabIndex = 57;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(360, 408);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(154, 29);
            label16.TabIndex = 56;
            label16.Text = "Total Seats:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(360, 305);
            label17.Margin = new Padding(2, 0, 2, 0);
            label17.Name = "label17";
            label17.Size = new Size(240, 29);
            label17.TabIndex = 55;
            label17.Text = "Company Number:";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Teal;
            btnAdd.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(361, 629);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(115, 62);
            btnAdd.TabIndex = 54;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // txtTotalSeats
            // 
            txtTotalSeats.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTotalSeats.Location = new Point(361, 448);
            txtTotalSeats.Margin = new Padding(2);
            txtTotalSeats.Name = "txtTotalSeats";
            txtTotalSeats.Size = new Size(272, 37);
            txtTotalSeats.TabIndex = 53;
            // 
            // txtCompanyNumber
            // 
            txtCompanyNumber.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCompanyNumber.Location = new Point(361, 350);
            txtCompanyNumber.Margin = new Padding(2);
            txtCompanyNumber.Name = "txtCompanyNumber";
            txtCompanyNumber.Size = new Size(272, 37);
            txtCompanyNumber.TabIndex = 52;
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
            panel1.TabIndex = 66;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Teal;
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(pictureBox8);
            panel3.Controls.Add(pictureBox9);
            panel3.Controls.Add(lblFeedbackCom);
            panel3.Controls.Add(pictureBox10);
            panel3.Controls.Add(lblLinesCom);
            panel3.Controls.Add(lblBookingCom);
            panel3.Controls.Add(pictureBox11);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(lblCompanyCom);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(303, 788);
            panel3.TabIndex = 15;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(31, 31);
            pictureBox7.Margin = new Padding(0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(228, 180);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 14;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(17, 588);
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
            pictureBox9.Location = new Point(17, 290);
            pictureBox9.Margin = new Padding(0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(76, 76);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            // 
            // lblFeedbackCom
            // 
            lblFeedbackCom.AutoSize = true;
            lblFeedbackCom.BackColor = Color.DarkCyan;
            lblFeedbackCom.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFeedbackCom.ForeColor = Color.White;
            lblFeedbackCom.Location = new Point(92, 603);
            lblFeedbackCom.Margin = new Padding(0);
            lblFeedbackCom.Name = "lblFeedbackCom";
            lblFeedbackCom.Size = new Size(135, 32);
            lblFeedbackCom.TabIndex = 8;
            lblFeedbackCom.Text = "Feedback";
            lblFeedbackCom.Click += lblFeedbackCom_Click;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(17, 488);
            pictureBox10.Margin = new Padding(0);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(76, 76);
            pictureBox10.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox10.TabIndex = 11;
            pictureBox10.TabStop = false;
            // 
            // lblLinesCom
            // 
            lblLinesCom.AutoSize = true;
            lblLinesCom.BackColor = Color.DarkCyan;
            lblLinesCom.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblLinesCom.ForeColor = Color.White;
            lblLinesCom.Location = new Point(93, 305);
            lblLinesCom.Margin = new Padding(0);
            lblLinesCom.Name = "lblLinesCom";
            lblLinesCom.Size = new Size(80, 32);
            lblLinesCom.TabIndex = 12;
            lblLinesCom.Text = "Lines";
            lblLinesCom.Click += lblLinesCom_Click;
            // 
            // lblBookingCom
            // 
            lblBookingCom.AutoSize = true;
            lblBookingCom.BackColor = Color.DarkCyan;
            lblBookingCom.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblBookingCom.ForeColor = Color.White;
            lblBookingCom.Location = new Point(92, 503);
            lblBookingCom.Margin = new Padding(0);
            lblBookingCom.Name = "lblBookingCom";
            lblBookingCom.Size = new Size(132, 32);
            lblBookingCom.TabIndex = 10;
            lblBookingCom.Text = "Bookings";
            lblBookingCom.Click += lblBookingCom_Click;
            // 
            // pictureBox11
            // 
            pictureBox11.Image = (Image)resources.GetObject("pictureBox11.Image");
            pictureBox11.Location = new Point(17, 390);
            pictureBox11.Margin = new Padding(0);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(76, 76);
            pictureBox11.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox11.TabIndex = 9;
            pictureBox11.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.MediumTurquoise;
            panel4.Controls.Add(lblLOgoutCom);
            panel4.Controls.Add(pictureBox12);
            panel4.Location = new Point(3, 723);
            panel4.Name = "panel4";
            panel4.Size = new Size(300, 75);
            panel4.TabIndex = 2;
            // 
            // lblLOgoutCom
            // 
            lblLOgoutCom.AutoSize = true;
            lblLOgoutCom.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblLOgoutCom.ForeColor = Color.White;
            lblLOgoutCom.Location = new Point(104, 21);
            lblLOgoutCom.Margin = new Padding(0);
            lblLOgoutCom.Name = "lblLOgoutCom";
            lblLOgoutCom.Size = new Size(102, 32);
            lblLOgoutCom.TabIndex = 15;
            lblLOgoutCom.Text = "Logout";
            lblLOgoutCom.Click += lblLOgoutCom_Click;
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
            // lblCompanyCom
            // 
            lblCompanyCom.AutoSize = true;
            lblCompanyCom.BackColor = Color.DarkCyan;
            lblCompanyCom.Font = new Font("Verdana", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompanyCom.ForeColor = Color.White;
            lblCompanyCom.Location = new Point(92, 405);
            lblCompanyCom.Margin = new Padding(0);
            lblCompanyCom.Name = "lblCompanyCom";
            lblCompanyCom.Size = new Size(136, 32);
            lblCompanyCom.TabIndex = 8;
            lblCompanyCom.Text = "Company";
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
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(label18);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(303, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1428, 66);
            panel5.TabIndex = 67;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Trebuchet MS", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = Color.White;
            label18.Location = new Point(555, 20);
            label18.Name = "label18";
            label18.Size = new Size(210, 33);
            label18.TabIndex = 72;
            label18.Text = "Admin Company";
            // 
            // AdminCompanyForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1731, 788);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(btnDelete);
            Controls.Add(dataAddCompany);
            Controls.Add(btnUpdate);
            Controls.Add(cbStatus);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(txtCompanyName);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(btnAdd);
            Controls.Add(txtTotalSeats);
            Controls.Add(txtCompanyNumber);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "AdminCompanyForm";
            Text = "AdminCompanyForm";
            ((System.ComponentModel.ISupportInitialize)dataAddCompany).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox12).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label13;
        private Label label12;
        private Button btnDelete;
        private DataGridView dataAddCompany;
        private Button btnUpdate;
        private ComboBox cbStatus;
        private Label label14;
        private Label label15;
        private TextBox txtCompanyName;
        private Label label16;
        private Label label17;
        private Button btnAdd;
        private TextBox txtTotalSeats;
        private TextBox txtCompanyNumber;
        private Panel panel1;
        private Panel panel3;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private Label lblFeedbackCom;
        private PictureBox pictureBox10;
        private Label lblLinesCom;
        private Label lblBookingCom;
        private PictureBox pictureBox11;
        private Panel panel4;
        private Label lblLOgoutCom;
        private PictureBox pictureBox12;
        private Label lblCompanyCom;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label8;
        private PictureBox pictureBox3;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel5;
        private Label label18;
    }
}