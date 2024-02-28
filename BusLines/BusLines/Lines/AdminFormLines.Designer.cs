namespace BusLines.Lines
{
	partial class AdminFormLines
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
			label3 = new Label();
			txtDepartureCity = new TextBox();
			label2 = new Label();
			label1 = new Label();
			ttArrivalCity = new TextBox();
			dtDeprartureTime = new DateTimePicker();
			dtArrivalTime = new DateTimePicker();
			label5 = new Label();
			txtCompanyId = new TextBox();
			btnAdd = new Button();
			btnDelete = new Button();
			btnUpdate = new Button();
			
			SuspendLayout();
			// 
			// dataAddLines
			
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(23, 307);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(92, 20);
			label4.TabIndex = 29;
			label4.Text = "Arrival Time:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(23, 171);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(108, 20);
			label3.TabIndex = 28;
			label3.Text = "Departure City:";
			// 
			// txtDepartureCity
			// 
			txtDepartureCity.Location = new Point(167, 171);
			txtDepartureCity.Margin = new Padding(2);
			txtDepartureCity.Name = "txtDepartureCity";
			txtDepartureCity.Size = new Size(121, 27);
			txtDepartureCity.TabIndex = 27;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(15, 258);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(116, 20);
			label2.TabIndex = 26;
			label2.Text = "Departure Time:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(71, 217);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(84, 20);
			label1.TabIndex = 25;
			label1.Text = "Arrival City:";
			// 
			// ttArrivalCity
			// 
			ttArrivalCity.Location = new Point(167, 215);
			ttArrivalCity.Margin = new Padding(2);
			ttArrivalCity.Name = "ttArrivalCity";
			ttArrivalCity.Size = new Size(121, 27);
			ttArrivalCity.TabIndex = 23;
			// 
			// dtDeprartureTime
			// 
			dtDeprartureTime.Location = new Point(142, 258);
			dtDeprartureTime.Name = "dtDeprartureTime";
			dtDeprartureTime.Size = new Size(250, 27);
			dtDeprartureTime.TabIndex = 32;
			// 
			// dtArrivalTime
			// 
			dtArrivalTime.Location = new Point(142, 307);
			dtArrivalTime.Name = "dtArrivalTime";
			dtArrivalTime.Size = new Size(250, 27);
			dtArrivalTime.TabIndex = 33;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(42, 116);
			label5.Margin = new Padding(2, 0, 2, 0);
			label5.Name = "label5";
			label5.Size = new Size(94, 20);
			label5.TabIndex = 35;
			label5.Text = "Company ID:";
			// 
			// txtCompanyId
			// 
			txtCompanyId.Location = new Point(167, 113);
			txtCompanyId.Margin = new Padding(2);
			txtCompanyId.Name = "txtCompanyId";
			txtCompanyId.Size = new Size(121, 27);
			txtCompanyId.TabIndex = 34;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(167, 365);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(94, 29);
			btnAdd.TabIndex = 36;
			btnAdd.Text = "Add";
			btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(317, 365);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(94, 29);
			btnDelete.TabIndex = 37;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			// 
			// btnUpdate
			// 
			btnUpdate.Location = new Point(477, 365);
			btnUpdate.Name = "btnUpdate";
			btnUpdate.Size = new Size(94, 29);
			btnUpdate.TabIndex = 38;
			btnUpdate.Text = "Update";
			btnUpdate.UseVisualStyleBackColor = true;
			// 
			// AdminFormLines
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnUpdate);
			Controls.Add(btnDelete);
			Controls.Add(btnAdd);
			Controls.Add(label5);
			Controls.Add(txtCompanyId);
			Controls.Add(dtArrivalTime);
			Controls.Add(dtDeprartureTime);
			
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtDepartureCity);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(ttArrivalCity);
			Name = "AdminFormLines";
			Text = "AdminFormLines";
		
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataAddBus;
		private ComboBox cbStatus;
		private Label label4;
		private Label label3;
		private TextBox txtDepartureCity;
		private Label label2;
		private Label label1;
		private TextBox ttArrivalCity;
		private DateTimePicker dtDeprartureTime;
		private DateTimePicker dtArrivalTime;
		private Label label5;
		private TextBox txtCompanyId;
		private Button btnAdd;
		private Button btnDelete;
		private Button btnUpdate;
	}
}