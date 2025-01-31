namespace Formatting
{
	partial class FormattingForm
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
			this.lvFmtDisplay = new System.Windows.Forms.ListView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lvFmtDisplay
			// 
			this.lvFmtDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lvFmtDisplay.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.lvFmtDisplay.FullRowSelect = true;
			this.lvFmtDisplay.HideSelection = false;
			this.lvFmtDisplay.Location = new System.Drawing.Point(12, 16);
			this.lvFmtDisplay.Name = "lvFmtDisplay";
			this.lvFmtDisplay.Size = new System.Drawing.Size(560, 229);
			this.lvFmtDisplay.TabIndex = 0;
			this.lvFmtDisplay.UseCompatibleStateImageBehavior = false;
			this.lvFmtDisplay.View = System.Windows.Forms.View.Details;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnAdd.Location = new System.Drawing.Point(13, 268);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.OnBtnAdd);
			// 
			// FormattingForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 311);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.lvFmtDisplay);
			this.Name = "FormattingForm";
			this.Text = "Formatting Example";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lvFmtDisplay;
		private System.Windows.Forms.Button btnAdd;
	}
}

