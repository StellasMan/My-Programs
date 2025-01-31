namespace EventWaitTest
{
	partial class EventWaitTestForm
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
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.txtThreads = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRelease = new System.Windows.Forms.Button();
			this.btnReleaseAll = new System.Windows.Forms.Button();
			this.grpEvents = new System.Windows.Forms.GroupBox();
			this.grpCountdown = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCDThreads = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCDCount = new System.Windows.Forms.TextBox();
			this.btnCDStart = new System.Windows.Forms.Button();
			this.nudCDThreads = new System.Windows.Forms.NumericUpDown();
			this.label3 = new System.Windows.Forms.Label();
			this.btnBARStart = new System.Windows.Forms.Button();
			this.nudParticipants = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.rtxtStatus = new System.Windows.Forms.RichTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.nudPhases = new System.Windows.Forms.NumericUpDown();
			this.label8 = new System.Windows.Forms.Label();
			this.grpBarrier = new System.Windows.Forms.GroupBox();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			this.grpEvents.SuspendLayout();
			this.grpCountdown.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCDThreads)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudParticipants)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPhases)).BeginInit();
			this.grpBarrier.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(42, 60);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// nudThreads
			// 
			this.nudThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudThreads.Location = new System.Drawing.Point(144, 62);
			this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudThreads.Name = "nudThreads";
			this.nudThreads.Size = new System.Drawing.Size(68, 20);
			this.nudThreads.TabIndex = 1;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(144, 33);
			this.label1.MaximumSize = new System.Drawing.Size(75, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 26);
			this.label1.TabIndex = 2;
			this.label1.Text = "# of Threads to Start";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtThreads
			// 
			this.txtThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtThreads.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtThreads.Location = new System.Drawing.Point(341, 62);
			this.txtThreads.Name = "txtThreads";
			this.txtThreads.ReadOnly = true;
			this.txtThreads.Size = new System.Drawing.Size(68, 20);
			this.txtThreads.TabIndex = 3;
			this.txtThreads.Text = "0";
			this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(333, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(85, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Waiting Threads";
			// 
			// btnRelease
			// 
			this.btnRelease.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnRelease.Location = new System.Drawing.Point(239, 43);
			this.btnRelease.Name = "btnRelease";
			this.btnRelease.Size = new System.Drawing.Size(75, 23);
			this.btnRelease.TabIndex = 5;
			this.btnRelease.Text = "&Release 1";
			this.btnRelease.UseVisualStyleBackColor = true;
			this.btnRelease.Click += new System.EventHandler(this.OnRelease);
			// 
			// btnReleaseAll
			// 
			this.btnReleaseAll.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnReleaseAll.Location = new System.Drawing.Point(239, 72);
			this.btnReleaseAll.Name = "btnReleaseAll";
			this.btnReleaseAll.Size = new System.Drawing.Size(75, 23);
			this.btnReleaseAll.TabIndex = 6;
			this.btnReleaseAll.Text = "Release &All";
			this.btnReleaseAll.UseVisualStyleBackColor = true;
			this.btnReleaseAll.Click += new System.EventHandler(this.OnReleaseAll);
			// 
			// grpEvents
			// 
			this.grpEvents.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpEvents.Controls.Add(this.btnStart);
			this.grpEvents.Controls.Add(this.btnReleaseAll);
			this.grpEvents.Controls.Add(this.nudThreads);
			this.grpEvents.Controls.Add(this.btnRelease);
			this.grpEvents.Controls.Add(this.label1);
			this.grpEvents.Controls.Add(this.label2);
			this.grpEvents.Controls.Add(this.txtThreads);
			this.grpEvents.Location = new System.Drawing.Point(12, 12);
			this.grpEvents.Name = "grpEvents";
			this.grpEvents.Size = new System.Drawing.Size(460, 119);
			this.grpEvents.TabIndex = 7;
			this.grpEvents.TabStop = false;
			this.grpEvents.Text = "Events";
			// 
			// grpCountdown
			// 
			this.grpCountdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpCountdown.Controls.Add(this.label5);
			this.grpCountdown.Controls.Add(this.txtCDThreads);
			this.grpCountdown.Controls.Add(this.label4);
			this.grpCountdown.Controls.Add(this.txtCDCount);
			this.grpCountdown.Controls.Add(this.btnCDStart);
			this.grpCountdown.Controls.Add(this.nudCDThreads);
			this.grpCountdown.Controls.Add(this.label3);
			this.grpCountdown.Location = new System.Drawing.Point(13, 154);
			this.grpCountdown.Name = "grpCountdown";
			this.grpCountdown.Size = new System.Drawing.Size(459, 113);
			this.grpCountdown.TabIndex = 8;
			this.grpCountdown.TabStop = false;
			this.grpCountdown.Text = "CountDown Event";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(249, 21);
			this.label5.MaximumSize = new System.Drawing.Size(60, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 26);
			this.label5.TabIndex = 11;
			this.label5.Text = "Active Threads";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCDThreads
			// 
			this.txtCDThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCDThreads.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtCDThreads.Location = new System.Drawing.Point(238, 48);
			this.txtCDThreads.Name = "txtCDThreads";
			this.txtCDThreads.ReadOnly = true;
			this.txtCDThreads.Size = new System.Drawing.Size(68, 20);
			this.txtCDThreads.TabIndex = 10;
			this.txtCDThreads.Text = "0";
			this.txtCDThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(341, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 8;
			this.label4.Text = "Count Down";
			// 
			// txtCDCount
			// 
			this.txtCDCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtCDCount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtCDCount.Location = new System.Drawing.Point(340, 48);
			this.txtCDCount.Name = "txtCDCount";
			this.txtCDCount.ReadOnly = true;
			this.txtCDCount.Size = new System.Drawing.Size(68, 20);
			this.txtCDCount.TabIndex = 7;
			this.txtCDCount.Text = "0";
			this.txtCDCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnCDStart
			// 
			this.btnCDStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnCDStart.Location = new System.Drawing.Point(41, 46);
			this.btnCDStart.Name = "btnCDStart";
			this.btnCDStart.Size = new System.Drawing.Size(75, 23);
			this.btnCDStart.TabIndex = 7;
			this.btnCDStart.Text = "S&tart";
			this.btnCDStart.UseVisualStyleBackColor = true;
			this.btnCDStart.Click += new System.EventHandler(this.OnCDStart);
			// 
			// nudCDThreads
			// 
			this.nudCDThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudCDThreads.Location = new System.Drawing.Point(143, 49);
			this.nudCDThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudCDThreads.Name = "nudCDThreads";
			this.nudCDThreads.Size = new System.Drawing.Size(68, 20);
			this.nudCDThreads.TabIndex = 8;
			this.nudCDThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudCDThreads.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(143, 21);
			this.label3.MaximumSize = new System.Drawing.Size(75, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 26);
			this.label3.TabIndex = 9;
			this.label3.Text = "# of Threads to Start";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnBARStart
			// 
			this.btnBARStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnBARStart.Location = new System.Drawing.Point(102, 43);
			this.btnBARStart.Name = "btnBARStart";
			this.btnBARStart.Size = new System.Drawing.Size(75, 23);
			this.btnBARStart.TabIndex = 12;
			this.btnBARStart.Text = "St&art";
			this.btnBARStart.UseVisualStyleBackColor = true;
			this.btnBARStart.Click += new System.EventHandler(this.OnBarrierStart);
			// 
			// nudParticipants
			// 
			this.nudParticipants.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudParticipants.Location = new System.Drawing.Point(201, 44);
			this.nudParticipants.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudParticipants.Name = "nudParticipants";
			this.nudParticipants.Size = new System.Drawing.Size(68, 20);
			this.nudParticipants.TabIndex = 12;
			this.nudParticipants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudParticipants.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(201, 14);
			this.label6.MaximumSize = new System.Drawing.Size(75, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(62, 26);
			this.label6.TabIndex = 13;
			this.label6.Text = "# of Participants";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rtxtStatus
			// 
			this.rtxtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtxtStatus.Location = new System.Drawing.Point(12, 416);
			this.rtxtStatus.Name = "rtxtStatus";
			this.rtxtStatus.Size = new System.Drawing.Size(460, 123);
			this.rtxtStatus.TabIndex = 14;
			this.rtxtStatus.Text = "";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(12, 400);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Status";
			// 
			// nudPhases
			// 
			this.nudPhases.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudPhases.Location = new System.Drawing.Point(288, 44);
			this.nudPhases.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudPhases.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPhases.Name = "nudPhases";
			this.nudPhases.Size = new System.Drawing.Size(68, 20);
			this.nudPhases.TabIndex = 16;
			this.nudPhases.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudPhases.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(288, 26);
			this.label8.MaximumSize = new System.Drawing.Size(75, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 13);
			this.label8.TabIndex = 17;
			this.label8.Text = "# of Phases";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// grpBarrier
			// 
			this.grpBarrier.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpBarrier.Controls.Add(this.btnBARStart);
			this.grpBarrier.Controls.Add(this.nudPhases);
			this.grpBarrier.Controls.Add(this.label6);
			this.grpBarrier.Controls.Add(this.label8);
			this.grpBarrier.Controls.Add(this.nudParticipants);
			this.grpBarrier.Location = new System.Drawing.Point(12, 288);
			this.grpBarrier.Name = "grpBarrier";
			this.grpBarrier.Size = new System.Drawing.Size(460, 100);
			this.grpBarrier.TabIndex = 18;
			this.grpBarrier.TabStop = false;
			this.grpBarrier.Text = "Barrier Test";
			// 
			// EventWaitTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 551);
			this.Controls.Add(this.grpBarrier);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.rtxtStatus);
			this.Controls.Add(this.grpCountdown);
			this.Controls.Add(this.grpEvents);
			this.MinimumSize = new System.Drawing.Size(500, 590);
			this.Name = "EventWaitTestForm";
			this.Text = "Event Wait Test";
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			this.grpEvents.ResumeLayout(false);
			this.grpEvents.PerformLayout();
			this.grpCountdown.ResumeLayout(false);
			this.grpCountdown.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudCDThreads)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudParticipants)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudPhases)).EndInit();
			this.grpBarrier.ResumeLayout(false);
			this.grpBarrier.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.NumericUpDown nudThreads;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtThreads;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnRelease;
		private System.Windows.Forms.Button btnReleaseAll;
		private System.Windows.Forms.GroupBox grpEvents;
		private System.Windows.Forms.GroupBox grpCountdown;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCDThreads;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCDCount;
		private System.Windows.Forms.Button btnCDStart;
		private System.Windows.Forms.NumericUpDown nudCDThreads;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnBARStart;
		private System.Windows.Forms.NumericUpDown nudParticipants;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.RichTextBox rtxtStatus;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.NumericUpDown nudPhases;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox grpBarrier;
	}
}

