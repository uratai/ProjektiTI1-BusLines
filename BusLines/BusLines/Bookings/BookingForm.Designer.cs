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
			label1 = new Label();
			dataBookForm = new DataGridView();
			panel1 = new Panel();
			((System.ComponentModel.ISupportInitialize)dataBookForm).BeginInit();
			SuspendLayout();
			// 
			// txtDestinationTrip
			// 
			txtDestinationTrip.Location = new Point(764, 137);
			txtDestinationTrip.Margin = new Padding(2);
			txtDestinationTrip.Name = "txtDestinationTrip";
			txtDestinationTrip.Size = new Size(121, 27);
			txtDestinationTrip.TabIndex = 53;
			// 
			// txtSourceTrip
			// 
			txtSourceTrip.Location = new Point(417, 141);
			txtSourceTrip.Margin = new Padding(2);
			txtSourceTrip.Name = "txtSourceTrip";
			txtSourceTrip.Size = new Size(121, 27);
			txtSourceTrip.TabIndex = 52;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(651, 140);
			label7.Margin = new Padding(2, 0, 2, 0);
			label7.Name = "label7";
			label7.Size = new Size(88, 20);
			label7.TabIndex = 51;
			label7.Text = "Destination:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(329, 143);
			label6.Margin = new Padding(2, 0, 2, 0);
			label6.Name = "label6";
			label6.Size = new Size(57, 20);
			label6.TabIndex = 50;
			label6.Text = "Source:";
			// 
			// btnSearch
			// 
			btnSearch.Location = new Point(938, 137);
			btnSearch.Margin = new Padding(2);
			btnSearch.Name = "btnSearch";
			btnSearch.Size = new Size(97, 33);
			btnSearch.TabIndex = 49;
			btnSearch.Text = "Search";
			btnSearch.UseVisualStyleBackColor = true;
			btnSearch.Click += btnSearch_Click;
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
			// dataBookForm
			// 
			dataBookForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataBookForm.Location = new Point(272, 293);
			dataBookForm.Margin = new Padding(2);
			dataBookForm.Name = "dataBookForm";
			dataBookForm.RowHeadersWidth = 62;
			dataBookForm.RowTemplate.Height = 33;
			dataBookForm.Size = new Size(773, 342);
			dataBookForm.TabIndex = 44;
			dataBookForm.CellContentClick += dataBookForm_CellContentClick;
			// 
			// panel1
			// 
			panel1.Location = new Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new Size(257, 669);
			panel1.TabIndex = 54;
			// 
			// BookingForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1151, 662);
			Controls.Add(panel1);
			Controls.Add(txtDestinationTrip);
			Controls.Add(txtSourceTrip);
			Controls.Add(label7);
			Controls.Add(label6);
			Controls.Add(btnSearch);
			Controls.Add(label1);
			Controls.Add(dataBookForm);
			Name = "BookingForm";
			Text = "BookingForm";
			Load += BookingForm_Load;
			((System.ComponentModel.ISupportInitialize)dataBookForm).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox txtDestinationTrip;
		private TextBox txtSourceTrip;
		private Label label7;
		private Label label6;
		private Button btnSearch;
		private Label label1;
		private DataGridView dataBookForm;
		private Panel panel1;
	}
}