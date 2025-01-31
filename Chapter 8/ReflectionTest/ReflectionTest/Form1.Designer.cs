namespace ReflectionTest
{
	partial class ReflectionTestForm
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
			this.btnLoad = new System.Windows.Forms.Button();
			this.tvReflect = new System.Windows.Forms.TreeView();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 26);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "&Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.OnLoad);
			// 
			// tvReflect
			// 
			this.tvReflect.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tvReflect.Location = new System.Drawing.Point(12, 84);
			this.tvReflect.Name = "tvReflect";
			this.tvReflect.Size = new System.Drawing.Size(510, 290);
			this.tvReflect.TabIndex = 1;
			// 
			// txtName
			// 
			this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.txtName.Location = new System.Drawing.Point(93, 28);
			this.txtName.Name = "txtName";
			this.txtName.ReadOnly = true;
			this.txtName.Size = new System.Drawing.Size(429, 20);
			this.txtName.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(274, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Module Path";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(12, 55);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(75, 23);
			this.btnCreate.TabIndex = 4;
			this.btnCreate.Text = "&Create";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.OnCreate);
			// 
			// ReflectionTestForm
			// 
			this.AcceptButton = this.btnLoad;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 386);
			this.Controls.Add(this.btnCreate);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.tvReflect);
			this.Controls.Add(this.btnLoad);
			this.MinimumSize = new System.Drawing.Size(550, 425);
			this.Name = "ReflectionTestForm";
			this.Text = "Reflection Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.TreeView tvReflect;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCreate;
	}
}

