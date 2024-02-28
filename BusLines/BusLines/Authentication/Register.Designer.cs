namespace BusLines.Authentication
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pictureBox6 = new PictureBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnRegister = new Button();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserType = new Label();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(154, 22);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(212, 149);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 44;
            pictureBox6.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Verdana", 11F, FontStyle.Underline, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(154, 664);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(210, 26);
            label1.TabIndex = 43;
            label1.Text = "Go back to Log In";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(112, 244);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 37);
            txtEmail.TabIndex = 42;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(112, 203);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 29);
            label3.TabIndex = 41;
            label3.Text = "Email:";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Teal;
            btnRegister.Font = new Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(154, 576);
            btnRegister.Margin = new Padding(2);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(212, 76);
            btnRegister.TabIndex = 40;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // cmbRole
            // 
            cmbRole.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "User ", "Admin" });
            cmbRole.Location = new Point(112, 518);
            cmbRole.Margin = new Padding(2);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(287, 37);
            cmbRole.TabIndex = 39;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(112, 434);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(287, 37);
            txtPassword.TabIndex = 38;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(112, 336);
            txtUserName.Margin = new Padding(2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(287, 37);
            txtUserName.TabIndex = 37;
            // 
            // lblUserType
            // 
            lblUserType.AutoSize = true;
            lblUserType.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUserType.Location = new Point(112, 487);
            lblUserType.Margin = new Padding(2, 0, 2, 0);
            lblUserType.Name = "lblUserType";
            lblUserType.Size = new Size(75, 29);
            lblUserType.TabIndex = 36;
            lblUserType.Text = "Role:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(112, 392);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(113, 29);
            label2.TabIndex = 35;
            label2.Text = "Pasword";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(112, 296);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(134, 29);
            label5.TabIndex = 34;
            label5.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(516, -1);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(44, 44);
            label4.TabIndex = 45;
            label4.Text = "X";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(560, 716);
            Controls.Add(label4);
            Controls.Add(pictureBox6);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserType);
            Controls.Add(label2);
            Controls.Add(label5);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label label1;
        private TextBox txtEmail;
        private Label label3;
        private Button btnRegister;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblUserType;
        private Label label2;
        private Label label5;
        private Label label4;
    }
}