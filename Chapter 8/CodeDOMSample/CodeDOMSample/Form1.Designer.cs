namespace CodeDOMSample
{
	partial class Form1
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
			this.btnGenerate = new System.Windows.Forms.Button();
			this.btnFromAuthor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGenerate
			// 
			this.btnGenerate.Location = new System.Drawing.Point(85, 70);
			this.btnGenerate.Name = "btnGenerate";
			this.btnGenerate.Size = new System.Drawing.Size(75, 23);
			this.btnGenerate.TabIndex = 0;
			this.btnGenerate.Text = "&Generate Code";
			this.btnGenerate.UseVisualStyleBackColor = true;
			this.btnGenerate.Click += new System.EventHandler(this.OnGenerateCode);
			// 
			// btnFromAuthor
			// 
			this.btnFromAuthor.Location = new System.Drawing.Point(85, 117);
			this.btnFromAuthor.Name = "btnFromAuthor";
			this.btnFromAuthor.Size = new System.Drawing.Size(75, 23);
			this.btnFromAuthor.TabIndex = 1;
			this.btnFromAuthor.Text = "&From Author";
			this.btnFromAuthor.UseVisualStyleBackColor = true;
			this.btnFromAuthor.Click += new System.EventHandler(this.OnAuthorGenerateCode);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(265, 221);
			this.Controls.Add(this.btnFromAuthor);
			this.Controls.Add(this.btnGenerate);
			this.Name = "Form1";
			this.Text = "Code DOM Sample";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnGenerate;
		private System.Windows.Forms.Button btnFromAuthor;
	}
}

