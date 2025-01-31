namespace ThreadPoolTest
{
	partial class ThreadPoolForm
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
			this.txtAvailable = new System.Windows.Forms.TextBox();
			this.txtRunning = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtQueued = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Available Threads:";
			// 
			// txtAvailable
			// 
			this.txtAvailable.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtAvailable.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtAvailable.Location = new System.Drawing.Point(137, 22);
			this.txtAvailable.Name = "txtAvailable";
			this.txtAvailable.ReadOnly = true;
			this.txtAvailable.Size = new System.Drawing.Size(62, 20);
			this.txtAvailable.TabIndex = 1;
			this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtRunning
			// 
			this.txtRunning.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtRunning.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtRunning.Location = new System.Drawing.Point(137, 59);
			this.txtRunning.Name = "txtRunning";
			this.txtRunning.ReadOnly = true;
			this.txtRunning.Size = new System.Drawing.Size(62, 20);
			this.txtRunning.TabIndex = 3;
			this.txtRunning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(92, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Running Threads:";
			// 
			// txtQueued
			// 
			this.txtQueued.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtQueued.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtQueued.Location = new System.Drawing.Point(137, 96);
			this.txtQueued.Name = "txtQueued";
			this.txtQueued.ReadOnly = true;
			this.txtQueued.Size = new System.Drawing.Size(62, 20);
			this.txtQueued.TabIndex = 5;
			this.txtQueued.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(36, 99);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(90, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Queued Threads:";
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(30, 143);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// btnStop
			// 
			this.btnStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStop.Location = new System.Drawing.Point(130, 143);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 7;
			this.btnStop.Text = "Sto&p";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.OnStop);
			// 
			// ThreadPoolForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(234, 186);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.txtQueued);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtRunning);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtAvailable);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(250, 225);
			this.Name = "ThreadPoolForm";
			this.Text = "Thread Pool Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAvailable;
		private System.Windows.Forms.TextBox txtRunning;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtQueued;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
	}
}

