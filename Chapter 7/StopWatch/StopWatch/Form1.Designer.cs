namespace StopWatchTest
{
	partial class StopWatchForm
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
			this.btnStart = new System.Windows.Forms.Button();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.lblTime = new System.Windows.Forms.Label();
			this.lblValue = new System.Windows.Forms.Label();
			this.txtValue = new System.Windows.Forms.TextBox();
			this.btnCursor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(43, 49);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// txtTime
			// 
			this.txtTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTime.BackColor = System.Drawing.SystemColors.Window;
			this.txtTime.Location = new System.Drawing.Point(92, 116);
			this.txtTime.Name = "txtTime";
			this.txtTime.ReadOnly = true;
			this.txtTime.Size = new System.Drawing.Size(100, 20);
			this.txtTime.TabIndex = 1;
			this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// lblTime
			// 
			this.lblTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblTime.AutoSize = true;
			this.lblTime.Location = new System.Drawing.Point(126, 100);
			this.lblTime.Name = "lblTime";
			this.lblTime.Size = new System.Drawing.Size(30, 13);
			this.lblTime.TabIndex = 2;
			this.lblTime.Text = "Time";
			this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lblValue
			// 
			this.lblValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblValue.AutoSize = true;
			this.lblValue.Location = new System.Drawing.Point(124, 168);
			this.lblValue.Name = "lblValue";
			this.lblValue.Size = new System.Drawing.Size(34, 13);
			this.lblValue.TabIndex = 4;
			this.lblValue.Text = "Value";
			this.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtValue
			// 
			this.txtValue.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtValue.BackColor = System.Drawing.SystemColors.Window;
			this.txtValue.Location = new System.Drawing.Point(56, 184);
			this.txtValue.Name = "txtValue";
			this.txtValue.ReadOnly = true;
			this.txtValue.Size = new System.Drawing.Size(173, 20);
			this.txtValue.TabIndex = 3;
			this.txtValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCursor
			// 
			this.btnCursor.Location = new System.Drawing.Point(154, 49);
			this.btnCursor.Name = "btnCursor";
			this.btnCursor.Size = new System.Drawing.Size(75, 23);
			this.btnCursor.TabIndex = 5;
			this.btnCursor.Text = "&Cursor";
			this.btnCursor.UseVisualStyleBackColor = true;
			this.btnCursor.Click += new System.EventHandler(this.OnCursor);
			// 
			// StopWatchForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.btnCursor);
			this.Controls.Add(this.lblValue);
			this.Controls.Add(this.txtValue);
			this.Controls.Add(this.lblTime);
			this.Controls.Add(this.txtTime);
			this.Controls.Add(this.btnStart);
			this.MinimumSize = new System.Drawing.Size(300, 300);
			this.Name = "StopWatchForm";
			this.Text = "StopWatch Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtTime;
		private System.Windows.Forms.Label lblTime;
		private System.Windows.Forms.Label lblValue;
		private System.Windows.Forms.TextBox txtValue;
		private System.Windows.Forms.Button btnCursor;
	}
}

