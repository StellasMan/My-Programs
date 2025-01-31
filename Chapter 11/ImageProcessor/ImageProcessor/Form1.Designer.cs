namespace ImageProcessor
{
	partial class ImgProcessorForm
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
			this.components = new System.ComponentModel.Container();
			this.timerTest = new System.Windows.Forms.Timer(this.components);
			this.btnTimer = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTickCount = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// timerTest
			// 
			this.timerTest.Tick += new System.EventHandler(this.OnTimer1Tick);
			// 
			// btnTimer
			// 
			this.btnTimer.Location = new System.Drawing.Point(89, 111);
			this.btnTimer.Name = "btnTimer";
			this.btnTimer.Size = new System.Drawing.Size(129, 23);
			this.btnTimer.TabIndex = 0;
			this.btnTimer.Text = "Enable &Timer";
			this.btnTimer.UseVisualStyleBackColor = true;
			this.btnTimer.Click += new System.EventHandler(this.OnEnableDisableTimer);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 190);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(62, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tick &Count:";
			// 
			// txtTickCount
			// 
			this.txtTickCount.Location = new System.Drawing.Point(140, 187);
			this.txtTickCount.Name = "txtTickCount";
			this.txtTickCount.ReadOnly = true;
			this.txtTickCount.Size = new System.Drawing.Size(100, 20);
			this.txtTickCount.TabIndex = 2;
			this.txtTickCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// ImgProcessorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(307, 244);
			this.Controls.Add(this.txtTickCount);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTimer);
			this.Name = "ImgProcessorForm";
			this.Text = "Image Processor";
			this.Load += new System.EventHandler(this.ImgProcessorForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Timer timerTest;
		private System.Windows.Forms.Button btnTimer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTickCount;
	}
}

