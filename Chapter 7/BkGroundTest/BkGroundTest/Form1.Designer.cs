namespace BkGroundTest
{
	partial class BkGroundForm
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
			this.lblStatus = new System.Windows.Forms.Label();
			this.btnStartStop = new System.Windows.Forms.Button();
			this.lvStatus = new System.Windows.Forms.ListView();
			this.nudThreads = new System.Windows.Forms.NumericUpDown();
			this.label1 = new System.Windows.Forms.Label();
			this.colThread = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.txtAvgPct = new System.Windows.Forms.TextBox();
			this.labAvgPct = new System.Windows.Forms.Label();
			this.labTotComplete = new System.Windows.Forms.Label();
			this.txtTotComplete = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).BeginInit();
			this.SuspendLayout();
			// 
			// lblStatus
			// 
			this.lblStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.lblStatus.AutoSize = true;
			this.lblStatus.Location = new System.Drawing.Point(147, 65);
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(37, 13);
			this.lblStatus.TabIndex = 5;
			this.lblStatus.Text = "S&tatus";
			// 
			// btnStartStop
			// 
			this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnStartStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnStartStop.Location = new System.Drawing.Point(12, 32);
			this.btnStartStop.Name = "btnStartStop";
			this.btnStartStop.Size = new System.Drawing.Size(75, 23);
			this.btnStartStop.TabIndex = 0;
			this.btnStartStop.Text = "&Start";
			this.btnStartStop.UseVisualStyleBackColor = true;
			this.btnStartStop.Click += new System.EventHandler(this.OnStartStop);
			// 
			// lvStatus
			// 
			this.lvStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colThread,
            this.colStatus});
			this.lvStatus.FullRowSelect = true;
			this.lvStatus.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvStatus.HideSelection = false;
			this.lvStatus.LabelEdit = true;
			this.lvStatus.Location = new System.Drawing.Point(12, 81);
			this.lvStatus.Name = "lvStatus";
			this.lvStatus.Size = new System.Drawing.Size(309, 218);
			this.lvStatus.TabIndex = 6;
			this.lvStatus.UseCompatibleStateImageBehavior = false;
			this.lvStatus.View = System.Windows.Forms.View.Details;
			// 
			// nudThreads
			// 
			this.nudThreads.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.nudThreads.Location = new System.Drawing.Point(105, 33);
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
			this.nudThreads.Size = new System.Drawing.Size(55, 20);
			this.nudThreads.TabIndex = 2;
			this.nudThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.nudThreads.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(109, 19);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Threads";
			// 
			// colThread
			// 
			this.colThread.Text = "Thread";
			this.colThread.Width = 80;
			// 
			// colStatus
			// 
			this.colStatus.Text = "Status";
			this.colStatus.Width = 225;
			// 
			// txtAvgPct
			// 
			this.txtAvgPct.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtAvgPct.BackColor = System.Drawing.SystemColors.Window;
			this.txtAvgPct.Location = new System.Drawing.Point(257, 33);
			this.txtAvgPct.Name = "txtAvgPct";
			this.txtAvgPct.ReadOnly = true;
			this.txtAvgPct.Size = new System.Drawing.Size(61, 20);
			this.txtAvgPct.TabIndex = 4;
			this.txtAvgPct.Text = "0.0";
			this.txtAvgPct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// labAvgPct
			// 
			this.labAvgPct.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labAvgPct.Location = new System.Drawing.Point(257, 2);
			this.labAvgPct.Name = "labAvgPct";
			this.labAvgPct.Size = new System.Drawing.Size(61, 30);
			this.labAvgPct.TabIndex = 3;
			this.labAvgPct.Text = "Avg Pct Complete";
			this.labAvgPct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// labTotComplete
			// 
			this.labTotComplete.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.labTotComplete.Location = new System.Drawing.Point(178, 3);
			this.labTotComplete.Name = "labTotComplete";
			this.labTotComplete.Size = new System.Drawing.Size(61, 30);
			this.labTotComplete.TabIndex = 7;
			this.labTotComplete.Text = "Total Complete";
			this.labTotComplete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// txtTotComplete
			// 
			this.txtTotComplete.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtTotComplete.BackColor = System.Drawing.SystemColors.Window;
			this.txtTotComplete.Location = new System.Drawing.Point(178, 33);
			this.txtTotComplete.Name = "txtTotComplete";
			this.txtTotComplete.ReadOnly = true;
			this.txtTotComplete.Size = new System.Drawing.Size(61, 20);
			this.txtTotComplete.TabIndex = 8;
			this.txtTotComplete.Text = "0";
			this.txtTotComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// BkGroundForm
			// 
			this.AcceptButton = this.btnStartStop;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 311);
			this.Controls.Add(this.labTotComplete);
			this.Controls.Add(this.txtTotComplete);
			this.Controls.Add(this.labAvgPct);
			this.Controls.Add(this.txtAvgPct);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.nudThreads);
			this.Controls.Add(this.lvStatus);
			this.Controls.Add(this.btnStartStop);
			this.Controls.Add(this.lblStatus);
			this.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.MinimumSize = new System.Drawing.Size(350, 350);
			this.Name = "BkGroundForm";
			this.Text = "Background Test";
			((System.ComponentModel.ISupportInitialize)(this.nudThreads)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lblStatus;
		private System.Windows.Forms.Button btnStartStop;
		private System.Windows.Forms.ListView lvStatus;
		private System.Windows.Forms.NumericUpDown nudThreads;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader colThread;
		private System.Windows.Forms.ColumnHeader colStatus;
		private System.Windows.Forms.TextBox txtAvgPct;
		private System.Windows.Forms.Label labAvgPct;
		private System.Windows.Forms.Label labTotComplete;
		private System.Windows.Forms.TextBox txtTotComplete;
	}
}

