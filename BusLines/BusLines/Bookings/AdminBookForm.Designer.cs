﻿namespace BusLines.Bookings
{
	partial class AdminBookForm
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
			dataBookUsers = new DataGridView();
			btnDelete = new Button();
			((System.ComponentModel.ISupportInitialize)dataBookUsers).BeginInit();
			SuspendLayout();
			// 
			// dataBookUsers
			// 
			dataBookUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataBookUsers.Location = new Point(144, 83);
			dataBookUsers.Name = "dataBookUsers";
			dataBookUsers.RowHeadersWidth = 51;
			dataBookUsers.RowTemplate.Height = 29;
			dataBookUsers.Size = new Size(806, 290);
			dataBookUsers.TabIndex = 0;
			// 
			// btnDelete
			// 
			btnDelete.Location = new Point(553, 398);
			btnDelete.Margin = new Padding(2);
			btnDelete.Name = "btnDelete";
			btnDelete.Size = new Size(90, 27);
			btnDelete.TabIndex = 40;
			btnDelete.Text = "Delete";
			btnDelete.UseVisualStyleBackColor = true;
			btnDelete.Click += btnDelete_Click;
			// 
			// AdminBookForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(997, 491);
			Controls.Add(btnDelete);
			Controls.Add(dataBookUsers);
			Name = "AdminBookForm";
			Text = "AdminBookForm";
			Load += AdminBookForm_Load;
			((System.ComponentModel.ISupportInitialize)dataBookUsers).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataBookUsers;
		private Button btnDelete;
		private Button btnUpdate;
		private Button btnAdd;
		private DateTimePicker dateTimeBooking;
		private ComboBox cbStatus;
		private Label label4;
		private Label label3;
		private TextBox txtLine;
		private Label label1;
	}
}