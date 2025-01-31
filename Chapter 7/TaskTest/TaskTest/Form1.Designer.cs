namespace TaskTest
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
			this.lvStatus = new System.Windows.Forms.ListView();
			this.labStatus = new System.Windows.Forms.Label();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			this.radTask = new System.Windows.Forms.RadioButton();
			this.radFactory = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radUIThread = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lvStatus
			// 
			this.lvStatus.HideSelection = false;
			this.lvStatus.Location = new System.Drawing.Point(12, 129);
			this.lvStatus.Name = "lvStatus";
			this.lvStatus.Size = new System.Drawing.Size(356, 180);
			this.lvStatus.TabIndex = 0;
			this.lvStatus.UseCompatibleStateImageBehavior = false;
			// 
			// labStatus
			// 
			this.labStatus.AutoSize = true;
			this.labStatus.Location = new System.Drawing.Point(172, 108);
			this.labStatus.Name = "labStatus";
			this.labStatus.Size = new System.Drawing.Size(37, 13);
			this.labStatus.TabIndex = 1;
			this.labStatus.Text = "Status";
			// 
			// btnStartStop
			// 
			this.btnStartStop.Location = new System.Drawing.Point(28, 38);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 2;
			this.btnStartStop.Text = "&Start";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.OnStartStop);
			// 
			// nudThreads
			// 
			this.nudThreads.Location = new System.Drawing.Point(161, 39);
			this.nudThreads.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.nudThreads.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudThreads.Name = "nudThreads";
			this.nudThreads.Size = new System.Drawing.Size(59, 20);
			this.nudThreads.TabIndex = 3;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// radTask
			// 
			this.radTask.AutoSize = true;
			this.radTask.Location = new System.Drawing.Point(17, 19);
			this.radTask.Name = "radTask";
			this.radTask.Size = new System.Drawing.Size(49, 17);
			this.radTask.TabIndex = 4;
			this.radTask.TabStop = true;
			this.radTask.Text = "&Task";
			this.radTask.UseVisualStyleBackColor = true;
			// 
			// radFactory
			// 
			this.radFactory.AutoSize = true;
			this.radFactory.Location = new System.Drawing.Point(17, 42);
			this.radFactory.Name = "radFactory";
			this.radFactory.Size = new System.Drawing.Size(87, 17);
			this.radFactory.TabIndex = 5;
			this.radFactory.TabStop = true;
			this.radFactory.Text = "Task &Factory";
			this.radFactory.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(167, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "&Threads";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radUIThread);
			this.groupBox1.Controls.Add(this.radTask);
			this.groupBox1.Controls.Add(this.radFactory);
			this.groupBox1.Location = new System.Drawing.Point(260, 14);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(108, 94);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Type";
			// 
			// radUIThread
			// 
			this.radUIThread.AutoSize = true;
			this.radUIThread.Location = new System.Drawing.Point(17, 65);
			this.radUIThread.Name = "radUIThread";
			this.radUIThread.Size = new System.Drawing.Size(73, 17);
			this.radUIThread.TabIndex = 6;
			this.radUIThread.TabStop = true;
			this.radUIThread.Text = "&UI Thread";
			this.radUIThread.UseVisualStyleBackColor = true;
			// 
			// TaskTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(381, 321);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudThreads);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.labStatus);
			this.Controls.Add(this.lvStatus);
			this.Name = "TaskTestForm";
			this.Text = "Task Test";
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lvStatus;
		private System.Windows.Forms.Label labStatus;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.NumericUpDown nudThreads;
		private System.Windows.Forms.RadioButton radTask;
		private System.Windows.Forms.RadioButton radFactory;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radUIThread;
	}
}

