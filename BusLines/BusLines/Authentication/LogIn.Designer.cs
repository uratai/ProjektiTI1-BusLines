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
            pictureBox6 = new PictureBox();
            label5 = new Label();
            lblCloseL = new Label();
            lblRegister = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lblUserName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // cbRole
            // 
            resources.ApplyResources(cbRole, "cbRole");
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { resources.GetString("cbRole.Items"), resources.GetString("cbRole.Items1") });
            cbRole.Name = "cbRole";
            // 
            // btnLogin
            // 
            resources.ApplyResources(btnLogin, "btnLogin");
            btnLogin.BackColor = Color.Teal;
            btnLogin.ForeColor = Color.White;
            btnLogin.Name = "btnLogin";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            resources.ApplyResources(txtPassword, "txtPassword");
            txtPassword.Name = "txtPassword";
            // 
            // txtUserName
            // 
            resources.ApplyResources(txtUserName, "txtUserName");
            txtUserName.Name = "txtUserName";
            // 
            // pictureBox6
            // 
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.Crimson;
            label5.Name = "label5";
            // 
            // lblCloseL
            // 
            resources.ApplyResources(lblCloseL, "lblCloseL");
            lblCloseL.ForeColor = Color.Crimson;
            lblCloseL.Name = "lblCloseL";
            lblCloseL.Click += lblCloseL_Click;
            // 
            // lblRegister
            // 
            resources.ApplyResources(lblRegister, "lblRegister");
            lblRegister.Name = "lblRegister";
            lblRegister.Click += lblRegister_Click;
            // 
            // comboBox1
            // 
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2") });
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            resources.ApplyResources(pictureBox2, "pictureBox2");
            pictureBox2.Name = "pictureBox2";
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            resources.ApplyResources(pictureBox3, "pictureBox3");
            pictureBox3.Name = "pictureBox3";
            pictureBox3.TabStop = false;
            // 
            // lblUserName
            // 
            resources.ApplyResources(lblUserName, "lblUserName");
            lblUserName.Name = "lblUserName";
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(lblUserName);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblRegister);
            Controls.Add(label1);
            Controls.Add(cbRole);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(pictureBox6);
            Controls.Add(label5);
            Controls.Add(lblCloseL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
          
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbRole;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private PictureBox pictureBox6;
        private Label label5;
        private Label lblCloseL;
        private Label lblRegister;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label lblUserName;
    }
}