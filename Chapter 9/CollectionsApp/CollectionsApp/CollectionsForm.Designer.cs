namespace CollectionsApp
{
	partial class CollectionForm
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
			this.grpCollections = new System.Windows.Forms.GroupBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnDBTest = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// grpCollections
			// 
			this.grpCollections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpCollections.Location = new System.Drawing.Point(12, 12);
			this.grpCollections.Name = "grpCollections";
			this.grpCollections.Size = new System.Drawing.Size(460, 277);
			this.grpCollections.TabIndex = 0;
			this.grpCollections.TabStop = false;
			this.grpCollections.Text = "Collections";
			// 
			// btnStart
			// 
			this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnStart.Location = new System.Drawing.Point(152, 299);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "&Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.OnStart);
			// 
			// btnDBTest
			// 
			this.btnDBTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDBTest.Location = new System.Drawing.Point(258, 299);
			this.btnDBTest.Name = "btnDBTest";
			this.btnDBTest.Size = new System.Drawing.Size(75, 23);
			this.btnDBTest.TabIndex = 2;
			this.btnDBTest.Text = "&DB Test";
			this.btnDBTest.UseVisualStyleBackColor = true;
			this.btnDBTest.Click += new System.EventHandler(this.OnDBTest);
			// 
			// CollectionForm
			// 
			this.AcceptButton = this.btnStart;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 330);
			this.Controls.Add(this.btnDBTest);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.grpCollections);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "CollectionForm";
			this.Text = "Collections";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox grpCollections;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnDBTest;
	}
}

