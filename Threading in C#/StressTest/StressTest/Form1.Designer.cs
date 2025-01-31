namespace StressTest
{
	partial class FormStress
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
			this.txtPooledActive = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCPUUsage = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRunTime = new System.Windows.Forms.TextBox();
			this.grpProperties = new System.Windows.Forms.GroupBox();
			this.radioLowest = new System.Windows.Forms.RadioButton();
			this.radioBelowNormal = new System.Windows.Forms.RadioButton();
			this.radioNormal = new System.Windows.Forms.RadioButton();
			this.radioAboveNormal = new System.Windows.Forms.RadioButton();
			this.radioHighest = new System.Windows.Forms.RadioButton();
			this.grpStatus = new System.Windows.Forms.GroupBox();
			this.grpProperties.SuspendLayout();
			this.grpStatus.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(105, 328);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// txtPooledActive
			// 
			this.txtPooledActive.Location = new System.Drawing.Point(110, 29);
			this.txtPooledActive.Margin = new System.Windows.Forms.Padding(2);
			this.txtPooledActive.Name = "txtPooledActive";
			this.txtPooledActive.ReadOnly = true;
			this.txtPooledActive.Size = new System.Drawing.Size(68, 20);
			this.txtPooledActive.TabIndex = 1;
			this.txtPooledActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 32);
			this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(82, 13);
			this.label5.TabIndex = 0;
			this.label5.Text = "Active Threads:";
			// 
			// txtCPUUsage
			// 
			this.txtCPUUsage.Location = new System.Drawing.Point(110, 60);
			this.txtCPUUsage.Margin = new System.Windows.Forms.Padding(2);
			this.txtCPUUsage.Name = "txtCPUUsage";
			this.txtCPUUsage.ReadOnly = true;
			this.txtCPUUsage.Size = new System.Drawing.Size(68, 20);
			this.txtCPUUsage.TabIndex = 3;
			this.txtCPUUsage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 63);
			this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 13);
			this.label8.TabIndex = 2;
			this.label8.Text = "CPU Usage:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(29, 120);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "&Thread Run Times:";
			// 
			// txtRunTime
			// 
			this.txtRunTime.Location = new System.Drawing.Point(129, 117);
			this.txtRunTime.Name = "txtRunTime";
			this.txtRunTime.Size = new System.Drawing.Size(49, 20);
			this.txtRunTime.TabIndex = 6;
			this.txtRunTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// grpProperties
			// 
			this.grpProperties.Controls.Add(this.radioHighest);
			this.grpProperties.Controls.Add(this.txtRunTime);
			this.grpProperties.Controls.Add(this.radioAboveNormal);
			this.grpProperties.Controls.Add(this.label1);
			this.grpProperties.Controls.Add(this.radioNormal);
			this.grpProperties.Controls.Add(this.radioBelowNormal);
			this.grpProperties.Controls.Add(this.radioLowest);
			this.grpProperties.Location = new System.Drawing.Point(12, 12);
			this.grpProperties.Name = "grpProperties";
			this.grpProperties.Size = new System.Drawing.Size(259, 168);
			this.grpProperties.TabIndex = 0;
			this.grpProperties.TabStop = false;
			this.grpProperties.Text = "Thread Properties";
			// 
			// radioLowest
			// 
			this.radioLowest.AutoSize = true;
			this.radioLowest.Location = new System.Drawing.Point(29, 32);
			this.radioLowest.Name = "radioLowest";
			this.radioLowest.Size = new System.Drawing.Size(59, 17);
			this.radioLowest.TabIndex = 0;
			this.radioLowest.Text = "&Lowest";
			this.radioLowest.UseVisualStyleBackColor = true;
			// 
			// radioBelowNormal
			// 
			this.radioBelowNormal.AutoSize = true;
			this.radioBelowNormal.Location = new System.Drawing.Point(29, 55);
			this.radioBelowNormal.Name = "radioBelowNormal";
			this.radioBelowNormal.Size = new System.Drawing.Size(90, 17);
			this.radioBelowNormal.TabIndex = 2;
			this.radioBelowNormal.Text = "&Below Normal";
			this.radioBelowNormal.UseVisualStyleBackColor = true;
			// 
			// radioNormal
			// 
			this.radioNormal.AutoSize = true;
			this.radioNormal.Checked = true;
			this.radioNormal.Location = new System.Drawing.Point(29, 78);
			this.radioNormal.Name = "radioNormal";
			this.radioNormal.Size = new System.Drawing.Size(58, 17);
			this.radioNormal.TabIndex = 4;
			this.radioNormal.TabStop = true;
			this.radioNormal.Text = "&Normal";
			this.radioNormal.UseVisualStyleBackColor = true;
			// 
			// radioAboveNormal
			// 
			this.radioAboveNormal.AutoSize = true;
			this.radioAboveNormal.Location = new System.Drawing.Point(129, 32);
			this.radioAboveNormal.Name = "radioAboveNormal";
			this.radioAboveNormal.Size = new System.Drawing.Size(92, 17);
			this.radioAboveNormal.TabIndex = 1;
			this.radioAboveNormal.Text = "&Above Normal";
			this.radioAboveNormal.UseVisualStyleBackColor = true;
			// 
			// radioHighest
			// 
			this.radioHighest.AutoSize = true;
			this.radioHighest.Location = new System.Drawing.Point(129, 55);
			this.radioHighest.Name = "radioHighest";
			this.radioHighest.Size = new System.Drawing.Size(61, 17);
			this.radioHighest.TabIndex = 3;
			this.radioHighest.Text = "&Highest";
			this.radioHighest.UseVisualStyleBackColor = true;
			// 
			// grpStatus
			// 
			this.grpStatus.Controls.Add(this.label5);
			this.grpStatus.Controls.Add(this.txtPooledActive);
			this.grpStatus.Controls.Add(this.txtCPUUsage);
			this.grpStatus.Controls.Add(this.label8);
			this.grpStatus.Location = new System.Drawing.Point(12, 198);
			this.grpStatus.Name = "grpStatus";
			this.grpStatus.Size = new System.Drawing.Size(259, 95);
			this.grpStatus.TabIndex = 1;
			this.grpStatus.TabStop = false;
			this.grpStatus.Text = "Thread Status";
			// 
			// FormStress
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(285, 368);
			this.Controls.Add(this.grpStatus);
			this.Controls.Add(this.grpProperties);
			this.Controls.Add(this.btnStart);
			this.Name = "FormStress";
			this.Text = "Stress Test";
			this.grpProperties.ResumeLayout(false);
			this.grpProperties.PerformLayout();
			this.grpStatus.ResumeLayout(false);
			this.grpStatus.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.TextBox txtPooledActive;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtCPUUsage;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtRunTime;
		private System.Windows.Forms.GroupBox grpProperties;
		private System.Windows.Forms.RadioButton radioLowest;
		private System.Windows.Forms.RadioButton radioHighest;
		private System.Windows.Forms.RadioButton radioAboveNormal;
		private System.Windows.Forms.RadioButton radioNormal;
		private System.Windows.Forms.RadioButton radioBelowNormal;
		private System.Windows.Forms.GroupBox grpStatus;
	}
}

