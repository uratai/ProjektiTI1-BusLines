namespace BusLines.Feedback
{
	partial class FeedbackUserForm
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
			dateTimeFeedback = new DateTimePicker();
			btnSend = new Button();
			label3 = new Label();
			txtFeedbackText = new TextBox();
			label1 = new Label();
			label2 = new Label();
			cbFeedbackCompany = new ComboBox();
			SuspendLayout();
			// 
			// dateTimeFeedback
			// 
			dateTimeFeedback.Location = new Point(344, 205);
			dateTimeFeedback.Name = "dateTimeFeedback";
			dateTimeFeedback.Size = new Size(250, 27);
			dateTimeFeedback.TabIndex = 49;
			// 
			// btnSend
			// 
			btnSend.Location = new Point(344, 322);
			btnSend.Name = "btnSend";
			btnSend.Size = new Size(94, 29);
			btnSend.TabIndex = 48;
			btnSend.Text = "Send";
			btnSend.UseVisualStyleBackColor = true;
			btnSend.Click += btnSend_Click;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(221, 151);
			label3.Margin = new Padding(2, 0, 2, 0);
			label3.Name = "label3";
			label3.Size = new Size(88, 20);
			label3.TabIndex = 45;
			label3.Text = "Description:";
			// 
			// txtFeedbackText
			// 
			txtFeedbackText.Location = new Point(344, 148);
			txtFeedbackText.Margin = new Padding(2);
			txtFeedbackText.Name = "txtFeedbackText";
			txtFeedbackText.Size = new Size(121, 27);
			txtFeedbackText.TabIndex = 44;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(207, 205);
			label1.Margin = new Padding(2, 0, 2, 0);
			label1.Name = "label1";
			label1.Size = new Size(111, 20);
			label1.TabIndex = 43;
			label1.Text = "Feedback Date:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(221, 90);
			label2.Margin = new Padding(2, 0, 2, 0);
			label2.Name = "label2";
			label2.Size = new Size(79, 20);
			label2.TabIndex = 51;
			label2.Text = "Company :";
			// 
			// cbFeedbackCompany
			// 
			cbFeedbackCompany.FormattingEnabled = true;
			cbFeedbackCompany.Location = new Point(344, 82);
			cbFeedbackCompany.Name = "cbFeedbackCompany";
			cbFeedbackCompany.Size = new Size(151, 28);
			cbFeedbackCompany.TabIndex = 52;
			// 
			// FeedbackUserForm
			// 
			AutoScaleDimensions = new SizeF(8F, 20F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(cbFeedbackCompany);
			Controls.Add(label2);
			Controls.Add(dateTimeFeedback);
			Controls.Add(btnSend);
			Controls.Add(label3);
			Controls.Add(txtFeedbackText);
			Controls.Add(label1);
			Name = "FeedbackUserForm";
			Text = "FeedbackUserForm";
			Load += FeedbackUserForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DateTimePicker dateTimeFeedback;
		private Button btnSend;
		private Label label3;
		private TextBox txtFeedbackText;
		private Label label1;
		private Label label2;
		private ComboBox cbFeedbackCompany;
	}
}