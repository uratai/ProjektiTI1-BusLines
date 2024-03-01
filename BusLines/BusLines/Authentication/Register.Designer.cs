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
            lblBackLogIn = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            btnRegister = new Button();
            cmbRole = new ComboBox();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            lblUserType = new Label();
            label2 = new Label();
            label5 = new Label();
            lblCloseR = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox6
            // 
            resources.ApplyResources(pictureBox6, "pictureBox6");
            pictureBox6.Name = "pictureBox6";
            pictureBox6.TabStop = false;
            // 
            // lblBackLogIn
            // 
            resources.ApplyResources(lblBackLogIn, "lblBackLogIn");
            lblBackLogIn.BackColor = Color.White;
            lblBackLogIn.ForeColor = Color.Red;
            lblBackLogIn.Name = "lblBackLogIn";
            lblBackLogIn.Click += lblBackLogIn_Click;
            // 
            // txtEmail
            // 
            resources.ApplyResources(txtEmail, "txtEmail");
            txtEmail.Name = "txtEmail";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Teal;
            resources.ApplyResources(btnRegister, "btnRegister");
            btnRegister.ForeColor = Color.White;
            btnRegister.Name = "btnRegister";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // cmbRole
            // 
            resources.ApplyResources(cmbRole, "cmbRole");
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { resources.GetString("cmbRole.Items"), resources.GetString("cmbRole.Items1") });
            cmbRole.Name = "cmbRole";
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
            // lblUserType
            // 
            resources.ApplyResources(lblUserType, "lblUserType");
            lblUserType.Name = "lblUserType";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // lblCloseR
            // 
            resources.ApplyResources(lblCloseR, "lblCloseR");
            lblCloseR.ForeColor = Color.Crimson;
            lblCloseR.Name = "lblCloseR";
            lblCloseR.Click += lblCloseR_Click;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(pictureBox1, "pictureBox1");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { resources.GetString("comboBox1.Items"), resources.GetString("comboBox1.Items1"), resources.GetString("comboBox1.Items2") });
            resources.ApplyResources(comboBox1, "comboBox1");
            comboBox1.Name = "comboBox1";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Register
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Azure;
            Controls.Add(pictureBox1);
            Controls.Add(comboBox1);
            Controls.Add(lblCloseR);
            Controls.Add(pictureBox6);
            Controls.Add(lblBackLogIn);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(btnRegister);
            Controls.Add(cmbRole);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(lblUserType);
            Controls.Add(label2);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
           
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox6;
        private Label lblBackLogIn;
        private TextBox txtEmail;
        private Label label3;
        private Button btnRegister;
        private ComboBox cmbRole;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label lblUserType;
        private Label label2;
        private Label label5;
        private Label lblCloseR;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
    }
}