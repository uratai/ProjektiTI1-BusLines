namespace BusLines.Feedback
{
	partial class FeedbackAdminForm
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
			dataFeedbackUser = new DataGridView();
			((System.ComponentModel.ISupportInitialize)dataFeedbackUser).BeginInit();
			SuspendLayout();
			// 
			// dataFeedbackUser
			// 
			dataFeedbackUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataFeedbackUser.Location = new Point(96, 71);
			dataFeedbackUser.Name = "dataFeedbackUser";
			dataFeedbackUser.RowHeadersWidth = 51;
			dataFeedbackUser.RowTemplate.Height = 29;
			dataFeedbackUser.Size = new Size(487, 245);
			dataFeedbackUser.TabIndex = 0;
			dataFeedbackUser.CellContentClick += dataFeedbackUser_CellContentClick;
			// 
			// FeedbackAdminForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(dataFeedbackUser);
			Name = "FeedbackAdminForm";
			Text = "FeedbackAdminForm";
			Load += FeedbackAdminForm_Load;
			((System.ComponentModel.ISupportInitialize)dataFeedbackUser).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private DataGridView dataFeedbackUser;
	}
}