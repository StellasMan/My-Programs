namespace PoolTest
{
	partial class PoolTestForm
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
			this.txtAvailable = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numDesired = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRunning = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.numAllowed = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.txtWaiting = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numDesired)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numAllowed)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAvaliable
			// 
			this.txtAvailable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAvailable.Location = new System.Drawing.Point(158, 17);
			this.txtAvailable.Name = "txtAvaliable";
			this.txtAvailable.ReadOnly = true;
			this.txtAvailable.Size = new System.Drawing.Size(64, 20);
			this.txtAvailable.TabIndex = 1;
			this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(54, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Available Threads:";
			// 
			// numDesired
			// 
			this.numDesired.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numDesired.Location = new System.Drawing.Point(158, 137);
			this.numDesired.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numDesired.Name = "numDesired";
			this.numDesired.Size = new System.Drawing.Size(64, 20);
			this.numDesired.TabIndex = 5;
			this.numDesired.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numDesired.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(61, 141);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Threads &Desired:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 81);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "&Running Threads:";
			// 
			// txtRunning
			// 
			this.txtRunning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRunning.Location = new System.Drawing.Point(158, 77);
			this.txtRunning.Name = "txtRunning";
			this.txtRunning.ReadOnly = true;
			this.txtRunning.Size = new System.Drawing.Size(64, 20);
			this.txtRunning.TabIndex = 3;
			this.txtRunning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(102, 179);
			this.btnStart.MinimumSize = new System.Drawing.Size(75, 25);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 25);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStartStop);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(60, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "Threads A&llowed:";
			// 
			// numAllowed
			// 
			this.numAllowed.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numAllowed.Location = new System.Drawing.Point(158, 107);
			this.numAllowed.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.numAllowed.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
			this.numAllowed.Name = "numAllowed";
			this.numAllowed.Size = new System.Drawing.Size(64, 20);
			this.numAllowed.TabIndex = 8;
			this.numAllowed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.numAllowed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(61, 51);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(88, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "&Waiting Threads:";
			// 
			// txtWaiting
			// 
			this.txtWaiting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtWaiting.Location = new System.Drawing.Point(158, 47);
			this.txtWaiting.Name = "txtWaiting";
			this.txtWaiting.ReadOnly = true;
			this.txtWaiting.Size = new System.Drawing.Size(64, 20);
			this.txtWaiting.TabIndex = 10;
			this.txtWaiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// PoolTestForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 212);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtWaiting);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.numAllowed);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtRunning);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numDesired);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAvailable);
			this.MinimumSize = new System.Drawing.Size(295, 225);
			this.Name = "PoolTestForm";
			this.Text = "Thead Pool Test";
			((System.ComponentModel.ISupportInitialize)(this.numDesired)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numAllowed)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAvailable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numDesired;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRunning;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.NumericUpDown numAllowed;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtWaiting;
	}
}

