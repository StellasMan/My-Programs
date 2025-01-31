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
			this.txtAvaliable = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.numDesired = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtRunning = new System.Windows.Forms.TextBox();
			this.btnStart = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.numDesired)).BeginInit();
			this.SuspendLayout();
			// 
			// txtAvaliable
			// 
			this.txtAvaliable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAvaliable.Location = new System.Drawing.Point(158, 17);
			this.txtAvaliable.Name = "txtAvaliable";
			this.txtAvaliable.ReadOnly = true;
			this.txtAvaliable.Size = new System.Drawing.Size(64, 20);
			this.txtAvaliable.TabIndex = 1;
			this.txtAvaliable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(95, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Available Threads:";
			// 
			// numDesired
			// 
			this.numDesired.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.numDesired.Location = new System.Drawing.Point(158, 73);
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
			this.label2.Location = new System.Drawing.Point(64, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(88, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Threads &Desired:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "&Running Threads:";
			// 
			// txtRunning
			// 
			this.txtRunning.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtRunning.Location = new System.Drawing.Point(158, 45);
			this.txtRunning.Name = "txtRunning";
			this.txtRunning.ReadOnly = true;
			this.txtRunning.Size = new System.Drawing.Size(64, 20);
			this.txtRunning.TabIndex = 3;
			this.txtRunning.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStart.Location = new System.Drawing.Point(102, 129);
			this.btnStart.MinimumSize = new System.Drawing.Size(75, 25);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 25);
			this.btnStart.TabIndex = 6;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStartStop);
			// 
			// PoolTestForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(279, 186);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtRunning);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numDesired);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtAvaliable);
			this.MinimumSize = new System.Drawing.Size(295, 225);
			this.Name = "PoolTestForm";
			this.Text = "Thead Pool Test";
			((System.ComponentModel.ISupportInitialize)(this.numDesired)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtAvaliable;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numDesired;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtRunning;
		private System.Windows.Forms.Button btnStart;
	}
}

