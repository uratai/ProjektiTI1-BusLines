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
			btnDelete = new Button();
			dataAddCompany = new DataGridView();
			btnUpdate = new Button();
			cbStatus = new ComboBox();
			label4 = new Label();
			label3 = new Label();
			txtCompanyName = new TextBox();
			label2 = new Label();
			label1 = new Label();
			btnAdd = new Button();
			txtTotalSeats = new TextBox();
			txtCompanyNumber = new TextBox();
			((System.ComponentModel.ISupportInitialize)dataAddCompany).BeginInit();
			SuspendLayout();
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(632, 343);
			btnDelete.Margin = new Padding(2);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(90, 27);
			btnDelete.TabIndex = 37;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// dataAddCompany
			// 
			dataAddCompany.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataAddCompany.Location = new Point(360, 79);
			dataAddCompany.Margin = new Padding(2);
			dataAddCompany.Name = "dataAddCompany";
			dataAddCompany.RowHeadersWidth = 62;
			dataAddCompany.RowTemplate.Height = 33;
			dataAddCompany.Size = new Size(370, 201);
			dataAddCompany.TabIndex = 36;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(510, 344);
			btnUpdate.Margin = new Padding(2);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(90, 27);
			btnUpdate.TabIndex = 35;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			btnUpdate.Click += btnUpdate_Click;
			// 
			// cbStatus
			// 
			cbStatus.FormattingEnabled = true;
			cbStatus.Items.AddRange(new object[] { "Active", "Out of Service" });
			cbStatus.Location = new Point(167, 254);
			cbStatus.Margin = new Padding(2);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(121, 28);
			cbStatus.TabIndex = 32;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(79, 260);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(52, 20);
			label4.TabIndex = 31;
			label4.Text = "Status:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(44, 129);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(119, 20);
			label3.TabIndex = 30;
			label3.Text = "Company Name:";
			// 
			// txtCompanyName
			// 
			txtCompanyName.Location = new Point(167, 126);
			txtCompanyName.Margin = new Padding(2);
			txtCompanyName.Name = "txtCompanyName";
			txtCompanyName.Size = new Size(121, 27);
			txtCompanyName.TabIndex = 29;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(70, 214);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(84, 20);
			label2.TabIndex = 28;
			label2.Text = "Total Seats:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(30, 177);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(133, 20);
			label1.TabIndex = 27;
			label1.Text = "Company Number:";
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(382, 344);
			btnAdd.Margin = new Padding(2);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(90, 27);
			btnAdd.TabIndex = 26;
			btnAdd.Text = "ADD";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// txtTotalSeats
			// 
			txtTotalSeats.Location = new Point(167, 210);
			txtTotalSeats.Margin = new Padding(2);
			txtTotalSeats.Name = "txtTotalSeats";
			txtTotalSeats.Size = new Size(121, 27);
			txtTotalSeats.TabIndex = 25;
			// 
			// txtCompanyNumber
			// 
			txtCompanyNumber.Location = new Point(167, 170);
			txtCompanyNumber.Margin = new Padding(2);
			txtCompanyNumber.Name = "txtCompanyNumber";
			txtCompanyNumber.Size = new Size(121, 27);
			txtCompanyNumber.TabIndex = 24;
			// 
			// AdminCompanyForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnDelete);
			Controls.Add(dataAddCompany);
			Controls.Add(btnUpdate);
			Controls.Add(cbStatus);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtCompanyName);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(btnAdd);
			Controls.Add(txtTotalSeats);
			Controls.Add(txtCompanyNumber);
			Name = "AdminCompanyForm";
			Text = "AdminCompanyForm";
			Load += AdminCompanyForm_Load;
			((System.ComponentModel.ISupportInitialize)dataAddCompany).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnDelete;
		private DataGridView dataAddCompany;
		private Button btnUpdate;
		private ComboBox cbStatus;
		private Label label4;
		private Label label3;
		private TextBox txtCompanyName;
		private Label label2;
		private Label label1;
		private Button btnAdd;
		private TextBox txtTotalSeats;
		private TextBox txtCompanyNumber;
	}
}