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
			label4 = new Label();
			txtEmail = new TextBox();
			label3 = new Label();
			btnRegister = new Button();
			cmbRole = new ComboBox();
			txtPassword = new TextBox();
			txtUserName = new TextBox();
			lblUserType = new Label();
			label2 = new Label();
			label1 = new Label();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(342, 375);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(126, 20);
			label4.TabIndex = 19;
			label4.Text = "Go back to Log In";
			// 
			// txtEmail
			// 
			txtEmail.Location = new Point(332, 87);
			txtEmail.Margin = new Padding(2);
			txtEmail.Name = "txtEmail";
			txtEmail.Size = new Size(136, 27);
			txtEmail.TabIndex = 18;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(332, 55);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(49, 20);
			label3.TabIndex = 17;
			label3.Text = "Email:";
			// 
			// btnRegister
			// 
			btnRegister.Location = new Point(342, 340);
			btnRegister.Margin = new Padding(2);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(114, 33);
			btnRegister.TabIndex = 16;
			btnRegister.Text = "Register";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click_1;
			// 
			// cmbRole
			// 
			cmbRole.FormattingEnabled = true;
			cmbRole.Items.AddRange(new object[] { "User ", "Admin" });
			cmbRole.Location = new Point(332, 309);
			cmbRole.Margin = new Padding(2);
			cmbRole.Name = "cmbRole";
			cmbRole.Size = new Size(136, 28);
			cmbRole.TabIndex = 15;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(332, 234);
			txtPassword.Margin = new Padding(2);
			txtPassword.Name = "txtPassword";
			txtPassword.Size = new Size(136, 27);
			txtPassword.TabIndex = 14;
			// 
			// txtUserName
			// 
			txtUserName.Location = new Point(332, 159);
			txtUserName.Margin = new Padding(2);
			txtUserName.Name = "txtUserName";
			txtUserName.Size = new Size(136, 27);
			txtUserName.TabIndex = 13;
			// 
			// lblUserType
			// 
			lblUserType.AutoSize = true;
			lblUserType.Location = new Point(332, 271);
			lblUserType.Margin = new Padding(2, 0, 2, 0);
			lblUserType.Name = "lblUserType";
			lblUserType.Size = new Size(42, 20);
			lblUserType.TabIndex = 12;
			lblUserType.Text = "Role:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(332, 200);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(64, 20);
			label2.TabIndex = 11;
			label2.Text = "Pasword";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(332, 128);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(75, 20);
			label1.TabIndex = 10;
			label1.Text = "Username";
			// 
			// Register
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label4);
			Controls.Add(txtEmail);
			Controls.Add(label3);
			Controls.Add(btnRegister);
			Controls.Add(cmbRole);
			Controls.Add(txtPassword);
			Controls.Add(txtUserName);
			Controls.Add(lblUserType);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Register";
			Text = "Register";
			
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label4;
		private TextBox txtEmail;
		private Label label3;
		private Button btnRegister;
		private ComboBox cmbRole;
		private TextBox txtPassword;
		private TextBox txtUserName;
		private Label lblUserType;
		private Label label2;
		private Label label1;
	}
}