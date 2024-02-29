namespace BusLines.Feedback
{
    partial class FeedbackUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FeedbackUserForm));
            dateTimeFeedback = new DateTimePicker();
            btnSend = new Button();
            label3 = new Label();
            txtFeedbackText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cbFeedbackCompany = new ComboBox();
            panel1 = new Panel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            label8 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label16 = new Label();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // dateTimeFeedback
            // 
            dateTimeFeedback.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimeFeedback.Location = new Point(845, 485);
            dateTimeFeedback.Margin = new Padding(4, 4, 4, 4);
            dateTimeFeedback.Name = "dateTimeFeedback";
            dateTimeFeedback.Size = new Size(468, 37);
            dateTimeFeedback.TabIndex = 49;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.Teal;
            btnSend.Font = new Font("Verdana", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(1006, 588);
            btnSend.Margin = new Padding(4, 4, 4, 4);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(171, 84);
            btnSend.TabIndex = 48;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(629, 419);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 29);
            label3.TabIndex = 45;
            label3.Text = "Description:";
            // 
            // txtFeedbackText
            // 
            txtFeedbackText.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtFeedbackText.Location = new Point(845, 411);
            txtFeedbackText.Margin = new Padding(2);
            txtFeedbackText.Name = "txtFeedbackText";
            txtFeedbackText.Size = new Size(468, 37);
            txtFeedbackText.TabIndex = 44;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(629, 492);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(200, 29);
            label1.TabIndex = 43;
            label1.Text = "Feedback Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(629, 342);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 29);
            label2.TabIndex = 51;
            label2.Text = "Company :";
            // 
            // cbFeedbackCompany
            // 
            cbFeedbackCompany.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbFeedbackCompany.FormattingEnabled = true;
            cbFeedbackCompany.Location = new Point(845, 342);
            cbFeedbackCompany.Margin = new Padding(4, 4, 4, 4);
            cbFeedbackCompany.Name = "cbFeedbackCompany";
            cbFeedbackCompany.Size = new Size(468, 37);
            cbFeedbackCompany.TabIndex = 52;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(pictureBox6);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(pictureBox4);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(302, 985);
            panel1.TabIndex = 53;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 397);
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
            pictureBox4.Location = new Point(18, 290);
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
            label8.Location = new Point(92, 411);
            label8.Margin = new Padding(0);
            label8.Name = "label8";
            label8.Size = new Size(135, 32);
            label8.TabIndex = 8;
            label8.Text = "Feedback";
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
            // panel2
            // 
            panel2.BackColor = Color.MediumTurquoise;
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(2, 908);
            panel2.Margin = new Padding(2);
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
            // panel5
            // 
            panel5.BackColor = Color.MediumTurquoise;
            panel5.Controls.Add(label16);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(302, 0);
            panel5.Margin = new Padding(0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1644, 66);
            panel5.TabIndex = 69;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Trebuchet MS", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label16.ForeColor = Color.White;
            label16.Location = new Point(601, 20);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(130, 33);
            label16.TabIndex = 72;
            label16.Text = "Feedback";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(56, 30);
            pictureBox6.Margin = new Padding(0);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(182, 129);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // FeedbackUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(1946, 985);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(cbFeedbackCompany);
            Controls.Add(label2);
            Controls.Add(dateTimeFeedback);
            Controls.Add(btnSend);
            Controls.Add(label3);
            Controls.Add(txtFeedbackText);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "FeedbackUserForm";
            Text = "FeedbackUserForm";
            Load += FeedbackUserForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimeFeedback;
        private Button btnSend;
        private Label label3;
        private TextBox txtFeedbackText;
        private Label label1;
        private Label label2;
        private ComboBox cbFeedbackCompany;
        private Panel panel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private Label label8;
        private Label label7;
        private Panel panel2;
        private Label label4;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Label label16;
        private PictureBox pictureBox6;
    }
}