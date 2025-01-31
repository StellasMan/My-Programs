namespace ThreadsTest
{
	partial class ThreadsTestForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.numThreadCount = new System.Windows.Forms.NumericUpDown();
			this.txtCounter1 = new System.Windows.Forms.TextBox();
			this.txtCounter2 = new System.Windows.Forms.TextBox();
			this.txtCounter4 = new System.Windows.Forms.TextBox();
			this.txtCounter3 = new System.Windows.Forms.TextBox();
			this.txtCounter8 = new System.Windows.Forms.TextBox();
			this.txtCounter7 = new System.Windows.Forms.TextBox();
			this.txtCounter6 = new System.Windows.Forms.TextBox();
			this.txtCounter5 = new System.Windows.Forms.TextBox();
			this.grpCounters = new System.Windows.Forms.GroupBox();
			this.btnStartStop = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numThreadCount)).BeginInit();
			this.grpCounters.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(119, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(101, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Number of Threads:";
			// 
			// numThreadCount
			// 
			this.numThreadCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.numThreadCount.Location = new System.Drawing.Point(232, 52);
			this.numThreadCount.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
			this.numThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numThreadCount.Name = "numThreadCount";
			this.numThreadCount.Size = new System.Drawing.Size(50, 20);
			this.numThreadCount.TabIndex = 1;
			this.numThreadCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtCounter1
			// 
			this.txtCounter1.Location = new System.Drawing.Point(22, 19);
			this.txtCounter1.Name = "txtCounter1";
			this.txtCounter1.ReadOnly = true;
			this.txtCounter1.Size = new System.Drawing.Size(73, 20);
			this.txtCounter1.TabIndex = 2;
			this.txtCounter1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter2
			// 
			this.txtCounter2.Location = new System.Drawing.Point(117, 19);
			this.txtCounter2.Name = "txtCounter2";
			this.txtCounter2.ReadOnly = true;
			this.txtCounter2.Size = new System.Drawing.Size(73, 20);
			this.txtCounter2.TabIndex = 3;
			this.txtCounter2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter4
			// 
			this.txtCounter4.Location = new System.Drawing.Point(307, 19);
			this.txtCounter4.Name = "txtCounter4";
			this.txtCounter4.ReadOnly = true;
			this.txtCounter4.Size = new System.Drawing.Size(73, 20);
			this.txtCounter4.TabIndex = 5;
			this.txtCounter4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter3
			// 
			this.txtCounter3.Location = new System.Drawing.Point(212, 19);
			this.txtCounter3.Name = "txtCounter3";
			this.txtCounter3.ReadOnly = true;
			this.txtCounter3.Size = new System.Drawing.Size(73, 20);
			this.txtCounter3.TabIndex = 4;
			this.txtCounter3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter8
			// 
			this.txtCounter8.Location = new System.Drawing.Point(307, 58);
			this.txtCounter8.Name = "txtCounter8";
			this.txtCounter8.ReadOnly = true;
			this.txtCounter8.Size = new System.Drawing.Size(73, 20);
			this.txtCounter8.TabIndex = 9;
			this.txtCounter8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter7
			// 
			this.txtCounter7.Location = new System.Drawing.Point(212, 58);
			this.txtCounter7.Name = "txtCounter7";
			this.txtCounter7.ReadOnly = true;
			this.txtCounter7.Size = new System.Drawing.Size(73, 20);
			this.txtCounter7.TabIndex = 8;
			this.txtCounter7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter6
			// 
			this.txtCounter6.Location = new System.Drawing.Point(117, 58);
			this.txtCounter6.Name = "txtCounter6";
			this.txtCounter6.ReadOnly = true;
			this.txtCounter6.Size = new System.Drawing.Size(73, 20);
			this.txtCounter6.TabIndex = 7;
			this.txtCounter6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtCounter5
			// 
			this.txtCounter5.Location = new System.Drawing.Point(22, 58);
			this.txtCounter5.Name = "txtCounter5";
			this.txtCounter5.ReadOnly = true;
			this.txtCounter5.Size = new System.Drawing.Size(73, 20);
			this.txtCounter5.TabIndex = 6;
			this.txtCounter5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// grpCounters
			// 
			this.grpCounters.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.grpCounters.Controls.Add(this.txtCounter1);
			this.grpCounters.Controls.Add(this.txtCounter8);
			this.grpCounters.Controls.Add(this.txtCounter2);
			this.grpCounters.Controls.Add(this.txtCounter7);
			this.grpCounters.Controls.Add(this.txtCounter3);
			this.grpCounters.Controls.Add(this.txtCounter6);
			this.grpCounters.Controls.Add(this.txtCounter4);
			this.grpCounters.Controls.Add(this.txtCounter5);
			this.grpCounters.Location = new System.Drawing.Point(13, 106);
			this.grpCounters.Name = "grpCounters";
			this.grpCounters.Size = new System.Drawing.Size(398, 91);
			this.grpCounters.TabIndex = 10;
			this.grpCounters.TabStop = false;
			this.grpCounters.Text = "Counters";
			// 
			// btnStartStop
			// 
			this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStartStop.Location = new System.Drawing.Point(175, 225);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 11;
			this.btnStartStop.Text = "&Start";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.OnStartStop);
			// 
			// ThreadsTestForm
			// 
			this.AcceptButton = this.btnStartStop;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 281);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.grpCounters);
			this.Controls.Add(this.numThreadCount);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(440, 320);
			this.Name = "ThreadsTestForm";
			this.Text = "Threads Test";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.numThreadCount)).EndInit();
			this.grpCounters.ResumeLayout(false);
			this.grpCounters.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numThreadCount;
		private System.Windows.Forms.TextBox txtCounter1;
		private System.Windows.Forms.TextBox txtCounter2;
		private System.Windows.Forms.TextBox txtCounter4;
		private System.Windows.Forms.TextBox txtCounter3;
		private System.Windows.Forms.TextBox txtCounter8;
		private System.Windows.Forms.TextBox txtCounter7;
		private System.Windows.Forms.TextBox txtCounter6;
		private System.Windows.Forms.TextBox txtCounter5;
		private System.Windows.Forms.GroupBox grpCounters;
		private System.Windows.Forms.Button btnStartStop;
	}
}

