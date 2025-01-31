namespace TaskTest2
{
	partial class TaskTestForm
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
			this.rtxtStatus = new System.Windows.Forms.RichTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txtWaiting = new System.Windows.Forms.TextBox();
			this.txtRunning = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtComplete = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.nudTasks)).BeginInit();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 30);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// nudTasks
			// 
			this.nudTasks.Location = new System.Drawing.Point(103, 30);
			this.nudTasks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudTasks.Name = "nudTasks";
			this.nudTasks.Size = new System.Drawing.Size(84, 20);
			this.nudTasks.TabIndex = 1;
			this.nudTasks.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudTasks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// rtxtStatus
			// 
			this.rtxtStatus.Location = new System.Drawing.Point(12, 88);
			this.rtxtStatus.Name = "rtxtStatus";
			this.rtxtStatus.Size = new System.Drawing.Size(460, 161);
			this.rtxtStatus.TabIndex = 2;
			this.rtxtStatus.Text = "";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Status:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(116, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "# of Tasks";
			// 
			// txtWaiting
			// 
			this.txtWaiting.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtWaiting.Location = new System.Drawing.Point(207, 29);
			this.txtWaiting.Name = "txtWaiting";
			this.txtWaiting.ReadOnly = true;
			this.txtWaiting.Size = new System.Drawing.Size(64, 20);
			this.txtWaiting.TabIndex = 5;
			this.txtWaiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRunning
			// 
			this.txtRunning.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtRunning.Location = new System.Drawing.Point(287, 29);
			this.txtRunning.Name = "txtRunning";
			this.txtRunning.ReadOnly = true;
			this.txtRunning.Size = new System.Drawing.Size(64, 20);
			this.txtRunning.TabIndex = 6;
			this.txtRunning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(296, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(47, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Running";
			// 
			// txtComplete
			// 
			this.txtComplete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtComplete.Location = new System.Drawing.Point(367, 29);
			this.txtComplete.Name = "txtComplete";
			this.txtComplete.ReadOnly = true;
			this.txtComplete.Size = new System.Drawing.Size(64, 20);
			this.txtComplete.TabIndex = 8;
			this.txtComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(218, 13);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "Waiting";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(375, 13);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 10;
			this.label5.Text = "Complete";
			// 
			// TaskTestForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtComplete);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtRunning);
			this.Controls.Add(this.txtWaiting);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rtxtStatus);
			this.Controls.Add(this.nudTasks);
			this.Controls.Add(this.btnStart);
			this.Name = "TaskTestForm";
			this.Text = "Task Test";
			((System.ComponentModel.ISupportInitialize)(this.nudTasks)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudTasks;
		private System.Windows.Forms.RichTextBox rtxtStatus;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtWaiting;
		private System.Windows.Forms.TextBox txtRunning;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtComplete;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

