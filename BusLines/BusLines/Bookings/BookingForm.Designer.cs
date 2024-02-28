namespace BusLines.Bookings
{
	partial class BookingForm
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
			txtDestinationTrip = new TextBox();
			txtSourceTrip = new TextBox();
			label7 = new Label();
			label6 = new Label();
			btnSearch = new Button();
			dateTimePicker2 = new DateTimePicker();
			dateTimePicker1 = new DateTimePicker();
			label1 = new Label();
			btnBookTicket = new Button();
			dtgTicketInfo = new DataGridView();
			lblscheduleID = new Label();
			lblDestinationLocation = new Label();
			((System.ComponentModel.ISupportInitialize)dtgTicketInfo).BeginInit();
			SuspendLayout();
			// 
			// txtDestinationTrip
			// 
			txtDestinationTrip.Location = new Point(649, 18);
			txtDestinationTrip.Margin = new Padding(2);
			txtDestinationTrip.Name = "txtDestinationTrip";
			txtDestinationTrip.Size = new Size(121, 27);
			txtDestinationTrip.TabIndex = 53;
			// 
			// txtSourceTrip
			// 
			txtSourceTrip.Location = new Point(215, 28);
			txtSourceTrip.Margin = new Padding(2);
			txtSourceTrip.Name = "txtSourceTrip";
			txtSourceTrip.Size = new Size(121, 27);
			txtSourceTrip.TabIndex = 52;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(515, 18);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(88, 20);
			label7.TabIndex = 51;
			label7.Text = "Destination:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(127, 30);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(57, 20);
			label6.TabIndex = 50;
			label6.Text = "Source:";
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(893, 68);
			btnSearch.Margin = new Padding(2);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(90, 27);
			btnSearch.TabIndex = 49;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			// 
			// dateTimePicker2
			// 
			dateTimePicker2.Location = new Point(633, 70);
			dateTimePicker2.Margin = new Padding(2);
			dateTimePicker2.Name = "dateTimePicker2";
			dateTimePicker2.Size = new Size(241, 27);
			dateTimePicker2.TabIndex = 48;
			// 
			// dateTimePicker1
			// 
			dateTimePicker1.Location = new Point(218, 70);
			dateTimePicker1.Margin = new Padding(2);
			dateTimePicker1.Name = "dateTimePicker1";
			dateTimePicker1.Size = new Size(241, 27);
			dateTimePicker1.TabIndex = 47;
			// 
			// label1
			// 
			label1.AccessibleName = "txtSourceLocation";
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			label1.Location = new Point(127, 310);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(0, 28);
			label1.TabIndex = 46;
			// 
			// btnBookTicket
			// 
			btnBookTicket.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
			btnBookTicket.Location = new Point(855, 423);
			btnBookTicket.Margin = new Padding(2);
			btnBookTicket.Name = "btnBookTicket";
			btnBookTicket.Size = new Size(127, 42);
			btnBookTicket.TabIndex = 45;
			btnBookTicket.Text = "Book Ticket";
			btnBookTicket.UseVisualStyleBackColor = true;
			// 
			// dtgTicketInfo
			// 
			dtgTicketInfo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dtgTicketInfo.Location = new Point(136, 183);
			dtgTicketInfo.Margin = new Padding(2);
			dtgTicketInfo.Name = "dtgTicketInfo";
			dtgTicketInfo.RowHeadersWidth = 62;
			dtgTicketInfo.RowTemplate.Height = 33;
			dtgTicketInfo.Size = new Size(698, 316);
			dtgTicketInfo.TabIndex = 44;
			// 
			// lblscheduleID
			// 
			lblscheduleID.AutoSize = true;
			lblscheduleID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblscheduleID.Location = new Point(495, 70);
			lblscheduleID.Margin = new Padding(2, 0, 2, 0);
			lblscheduleID.Name = "lblscheduleID";
			lblscheduleID.Size = new Size(120, 28);
			lblscheduleID.TabIndex = 43;
			lblscheduleID.Text = "Arrival Time:";
			// 
			// lblDestinationLocation
			// 
			lblDestinationLocation.AutoSize = true;
			lblDestinationLocation.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			lblDestinationLocation.Location = new Point(56, 73);
			lblDestinationLocation.Margin = new Padding(2, 0, 2, 0);
			lblDestinationLocation.Name = "lblDestinationLocation";
			lblDestinationLocation.Size = new Size(151, 28);
			lblDestinationLocation.TabIndex = 42;
			lblDestinationLocation.Text = "Departure Time:";
			// 
			// BookingForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1038, 516);
			Controls.Add(txtDestinationTrip);
			Controls.Add(txtSourceTrip);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(btnSearch);
			Controls.Add(dateTimePicker2);
			Controls.Add(dateTimePicker1);
			Controls.Add(label1);
			Controls.Add(btnBookTicket);
			Controls.Add(dtgTicketInfo);
			Controls.Add(lblscheduleID);
			Controls.Add(lblDestinationLocation);
			Name = "BookingForm";
			Text = "BookingForm";
			((System.ComponentModel.ISupportInitialize)dtgTicketInfo).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtDestinationTrip;
		private TextBox txtSourceTrip;
		private Label label7;
		private Label label6;
		private Button btnSearch;
		private DateTimePicker dateTimePicker2;
		private DateTimePicker dateTimePicker1;
		private Label label1;
		private Button btnBookTicket;
		private DataGridView dtgTicketInfo;
		private Label lblscheduleID;
		private Label lblDestinationLocation;
	}
}