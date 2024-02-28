namespace BusLines.Bookings
{
	partial class UserBookForm
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
			cbStatus = new ComboBox();
			label4 = new Label();
			label3 = new Label();
			txtLine = new TextBox();
			label1 = new Label();
			btnBook = new Button();
			dateTimeBooking = new DateTimePicker();
			SuspendLayout();
			// 
			// cbStatus
			// 
			cbStatus.FormattingEnabled = true;
			cbStatus.Items.AddRange(new object[] { "Book", "Cancel" });
			cbStatus.Location = new Point(332, 167);
			cbStatus.Margin = new Padding(2);
			cbStatus.Name = "cbStatus";
			cbStatus.Size = new Size(121, 28);
			cbStatus.TabIndex = 40;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(227, 175);
			label4.Margin = new Padding(2, 0, 2, 0);
			label4.Name = "label4";
			label4.Size = new Size(52, 20);
			label4.TabIndex = 39;
			label4.Text = "Status:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(218, 76);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(39, 20);
			label3.TabIndex = 38;
			label3.Text = "Line:";
			// 
			// txtLine
			// 
			txtLine.Location = new Point(341, 73);
			txtLine.Margin = new Padding(2);
			txtLine.Name = "txtLine";
			txtLine.Size = new Size(121, 27);
			txtLine.TabIndex = 37;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(204, 124);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(103, 20);
			label1.TabIndex = 35;
			label1.Text = "Booking Date:";
			// 
			// btnBook
			// 
			btnBook.Location = new Point(341, 296);
			btnBook.Name = "btnBook";
			btnBook.Size = new Size(94, 29);
			btnBook.TabIndex = 41;
			btnBook.Text = "Book";
			btnBook.UseVisualStyleBackColor = true;
			btnBook.Click += btnBook_Click;
			// 
			// dateTimeBooking
			// 
			dateTimeBooking.Location = new Point(341, 119);
			dateTimeBooking.Name = "dateTimeBooking";
			dateTimeBooking.Size = new Size(250, 27);
			dateTimeBooking.TabIndex = 42;
			// 
			// UserBookForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dateTimeBooking);
			Controls.Add(btnBook);
			Controls.Add(cbStatus);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtLine);
			Controls.Add(label1);
			Name = "UserBookForm";
			Text = "UserBookForm";
			Load += UserBookForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox cbStatus;
		private Label label4;
		private Label label3;
		private TextBox txtLine;
		private Label label1;
		private Button btnBook;
		private DateTimePicker dateTimeBooking;
	}
}