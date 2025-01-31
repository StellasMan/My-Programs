namespace ContinueTasks
{
	partial class ContinueTaskForm
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
			this.nudTasks = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.txtQueued = new System.Windows.Forms.TextBox();
			this.txtRunning = new System.Windows.Forms.TextBox();
			this.txtComplete = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.rtxtStatus = new System.Windows.Forms.RichTextBox();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudTasks)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(46, 36);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// nudTasks
			// 
			this.nudTasks.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudTasks.Location = new System.Drawing.Point(136, 37);
			this.nudTasks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudTasks.Name = "nudTasks";
			this.nudTasks.Size = new System.Drawing.Size(72, 20);
			this.nudTasks.TabIndex = 1;
			this.nudTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudTasks.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(143, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "# of Tasks";
			// 
			// txtQueued
			// 
			this.txtQueued.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtQueued.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtQueued.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtQueued.Location = new System.Drawing.Point(223, 41);
			this.txtQueued.Name = "txtQueued";
			this.txtQueued.ReadOnly = true;
			this.txtQueued.Size = new System.Drawing.Size(62, 13);
			this.txtQueued.TabIndex = 3;
			this.txtQueued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRunning
			// 
			this.txtRunning.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtRunning.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtRunning.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtRunning.Location = new System.Drawing.Point(300, 41);
			this.txtRunning.Name = "txtRunning";
			this.txtRunning.ReadOnly = true;
			this.txtRunning.Size = new System.Drawing.Size(62, 13);
			this.txtRunning.TabIndex = 4;
			this.txtRunning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtComplete
			// 
			this.txtComplete.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtComplete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtComplete.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtComplete.Location = new System.Drawing.Point(377, 41);
			this.txtComplete.Name = "txtComplete";
			this.txtComplete.ReadOnly = true;
			this.txtComplete.Size = new System.Drawing.Size(62, 13);
			this.txtComplete.TabIndex = 5;
			this.txtComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(232, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Queued";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(308, 20);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Running";
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(383, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Complete";
			// 
			// rtxtStatus
			// 
			this.rtxtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtxtStatus.Location = new System.Drawing.Point(12, 101);
			this.rtxtStatus.Name = "rtxtStatus";
			this.rtxtStatus.Size = new System.Drawing.Size(460, 148);
			this.rtxtStatus.TabIndex = 9;
			this.rtxtStatus.Text = "";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 82);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Status";
			// 
			// ContinueTaskForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.rtxtStatus);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtComplete);
			this.Controls.Add(this.txtRunning);
			this.Controls.Add(this.txtQueued);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudTasks);
			this.Controls.Add(this.btnStart);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "ContinueTaskForm";
			this.Text = "Continue Tasks Testing";
			((System.ComponentModel.ISupportInitialize)(this.nudTasks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudTasks;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtQueued;
		private System.Windows.Forms.TextBox txtRunning;
		private System.Windows.Forms.TextBox txtComplete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.RichTextBox rtxtStatus;
		private System.Windows.Forms.Label label5;
	}
}

