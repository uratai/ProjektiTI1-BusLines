namespace BusLines.Authentication
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label1 = new Label();
            cbRole = new ComboBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblPassword = new Label();
            lblUsername = new Label();
            pictureBox6 = new PictureBox();
            label5 = new Label();
            lblCloseL = new Label();
            lblRegister = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(93, 245);
            label1.Name = "label1";
            label1.Size = new Size(75, 29);
            label1.TabIndex = 34;
            label1.Text = "Role:";
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "User", "Admin" });
            cbRole.Location = new Point(93, 292);
            cbRole.Margin = new Padding(3, 2, 3, 2);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(366, 37);
            cbRole.TabIndex = 33;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Teal;
            btnLogin.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(170, 560);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(214, 77);
            btnLogin.TabIndex = 32;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(93, 491);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(366, 37);
            txtPassword.TabIndex = 30;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(93, 397);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(366, 37);
            txtUserName.TabIndex = 29;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPassword.Location = new Point(93, 455);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(126, 29);
            lblPassword.TabIndex = 28;
            lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsername.Location = new Point(93, 345);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(145, 29);
            lblUsername.TabIndex = 27;
            lblUsername.Text = "Username:";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(170, 54);
            pictureBox6.Margin = new Padding(4, 3, 4, 3);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(232, 166);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Crimson;
            label5.Location = new Point(1162, 739);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 26);
            label5.TabIndex = 25;
            label5.Text = "Reset";
            // 
            // lblCloseL
            // 
            lblCloseL.AutoSize = true;
            lblCloseL.Font = new Font("Verdana", 18F, FontStyle.Regular, GraphicsUnit.Point);
            lblCloseL.ForeColor = Color.Crimson;
            lblCloseL.Location = new Point(516, -1);
            lblCloseL.Margin = new Padding(4, 0, 4, 0);
            lblCloseL.Name = "lblCloseL";
            lblCloseL.Size = new Size(44, 44);
            lblCloseL.TabIndex = 24;
            lblCloseL.Text = "X";
            lblCloseL.Click += lblCloseL_Click;
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.Location = new Point(218, 651);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(134, 29);
            lblRegister.TabIndex = 35;
            lblRegister.Text = "Register...";
            lblRegister.Click += lblRegister_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(15F, 29F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            ClientSize = new Size(560, 716);
            Controls.Add(lblRegister);
            Controls.Add(label1);
            Controls.Add(cbRole);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            Controls.Add(pictureBox6);
            Controls.Add(label5);
            Controls.Add(lblCloseL);
            Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(6, 5, 6, 5);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbRole;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblPassword;
        private Label lblUsername;
        private PictureBox pictureBox6;
        private Label label5;
        private Label lblCloseL;
        private Label lblRegister;
    }
}