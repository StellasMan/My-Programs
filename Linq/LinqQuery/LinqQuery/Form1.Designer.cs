namespace LinqQuery
{
	partial class LinqTestForm
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
			this.btnTest = new System.Windows.Forms.Button();
			this.rtText = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// btnTest
			// 
			this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnTest.Location = new System.Drawing.Point(146, 29);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(75, 23);
			this.btnTest.TabIndex = 0;
			this.btnTest.Text = "&Test";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.OnTest);
			// 
			// rtText
			// 
			this.rtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtText.Location = new System.Drawing.Point(12, 76);
			this.rtText.Name = "rtText";
			this.rtText.Size = new System.Drawing.Size(349, 166);
			this.rtText.TabIndex = 1;
			this.rtText.Text = "";
			// 
			// LinqTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(374, 251);
			this.Controls.Add(this.rtText);
			this.Controls.Add(this.btnTest);
			this.MinimumSize = new System.Drawing.Size(390, 290);
			this.Name = "LinqTestForm";
			this.Text = "Linq Query Testing";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.RichTextBox rtText;
	}
}

