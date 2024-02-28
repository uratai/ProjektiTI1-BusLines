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
			cbRole = new ComboBox();
			btnLogin = new Button();
			btnRegisterUser = new Button();
			txtPassword = new TextBox();
			txtUserName = new TextBox();
			lblPassword = new Label();
			lblUsername = new Label();
			SuspendLayout();
			// 
			// cbRole
			// 
			cbRole.FormattingEnabled = true;
			cbRole.Items.AddRange(new object[] { "User", "Admin" });
			cbRole.Location = new Point(313, 71);
			cbRole.Margin = new Padding(2);
			cbRole.Name = "cbRole";
			cbRole.Size = new Size(146, 28);
			cbRole.TabIndex = 13;
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnLogin.Location = new Point(408, 311);
			btnLogin.Margin = new Padding(2);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(90, 68);
			btnLogin.TabIndex = 12;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click_1;
			// 
			// btnRegisterUser
			// 
			btnRegisterUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			btnRegisterUser.Location = new Point(303, 311);
			btnRegisterUser.Margin = new Padding(2);
			btnRegisterUser.Name = "btnRegisterUser";
			btnRegisterUser.Size = new Size(90, 68);
			btnRegisterUser.TabIndex = 11;
			btnRegisterUser.Text = "Register User";
			btnRegisterUser.UseVisualStyleBackColor = true;
			// 
			// txtPassword
			// 
			txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtPassword.Location = new Point(303, 253);
			txtPassword.Margin = new Padding(2);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(188, 34);
			txtPassword.TabIndex = 10;
			// 
			// txtUserName
			// 
			txtUserName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			txtUserName.Location = new Point(303, 170);
			txtUserName.Margin = new Padding(2);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(188, 34);
			txtUserName.TabIndex = 9;
			// 
			// lblPassword
			// 
			lblPassword.AutoSize = true;
			lblPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblPassword.Location = new Point(303, 217);
			lblPassword.Margin = new Padding(2, 0, 2, 0);
			lblPassword.Name = "lblPassword";
			lblPassword.Size = new Size(93, 28);
			lblPassword.TabIndex = 8;
			lblPassword.Text = "Password";
			// 
			// lblUsername
			// 
			lblUsername.AutoSize = true;
			lblUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblUsername.Location = new Point(303, 138);
			lblUsername.Margin = new Padding(2, 0, 2, 0);
			lblUsername.Name = "lblUsername";
			lblUsername.Size = new Size(103, 28);
			lblUsername.TabIndex = 7;
			lblUsername.Text = "Username:";
			// 
			// LogIn
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(cbRole);
			Controls.Add(btnLogin);
			Controls.Add(btnRegisterUser);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(lblPassword);
			Controls.Add(lblUsername);
			Name = "LogIn";
			Text = "LogIn";
			Load += LogIn_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbRole;
		private Button btnLogin;
		private Button btnRegisterUser;
		private TextBox txtPassword;
		private TextBox txtUserName;
		private Label lblPassword;
		private Label lblUsername;
	}
}