namespace AsymEncrypt
{
	partial class AsymEncryptForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsymEncryptForm));
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.radioEncrypt = new System.Windows.Forms.RadioButton();
			this.radioDecrypt = new System.Windows.Forms.RadioButton();
			this.grpEncryptDecrypt = new System.Windows.Forms.GroupBox();
			this.btnDest = new System.Windows.Forms.Button();
			this.txtSource = new System.Windows.Forms.TextBox();
			this.txtDest = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnSource = new System.Windows.Forms.Button();
			this.openSourceDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveDestDialog = new System.Windows.Forms.SaveFileDialog();
			this.grpEncryptDecrypt.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnEncrypt.Location = new System.Drawing.Point(230, 219);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 2;
			this.btnEncrypt.Text = "E&xecute";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.OnEncrypt);
			// 
			// radioEncrypt
			// 
			this.radioEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radioEncrypt.AutoSize = true;
			this.radioEncrypt.Location = new System.Drawing.Point(192, 40);
			this.radioEncrypt.Name = "radioEncrypt";
			this.radioEncrypt.Size = new System.Drawing.Size(61, 17);
			this.radioEncrypt.TabIndex = 3;
			this.radioEncrypt.TabStop = true;
			this.radioEncrypt.Text = "&Encrypt";
			this.radioEncrypt.UseVisualStyleBackColor = true;
			this.radioEncrypt.CheckedChanged += new System.EventHandler(this.OnRadioEncryptChanged);
			// 
			// radioDecrypt
			// 
			this.radioDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radioDecrypt.AutoSize = true;
			this.radioDecrypt.Location = new System.Drawing.Point(280, 40);
			this.radioDecrypt.Name = "radioDecrypt";
			this.radioDecrypt.Size = new System.Drawing.Size(62, 17);
			this.radioDecrypt.TabIndex = 4;
			this.radioDecrypt.TabStop = true;
			this.radioDecrypt.Text = "&Decrypt";
			this.radioDecrypt.UseVisualStyleBackColor = true;
			// 
			// grpEncryptDecrypt
			// 
			this.grpEncryptDecrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpEncryptDecrypt.Controls.Add(this.btnDest);
			this.grpEncryptDecrypt.Controls.Add(this.txtSource);
			this.grpEncryptDecrypt.Controls.Add(this.txtDest);
			this.grpEncryptDecrypt.Controls.Add(this.label1);
			this.grpEncryptDecrypt.Controls.Add(this.label2);
			this.grpEncryptDecrypt.Controls.Add(this.btnSource);
			this.grpEncryptDecrypt.Location = new System.Drawing.Point(19, 79);
			this.grpEncryptDecrypt.Name = "grpEncryptDecrypt";
			this.grpEncryptDecrypt.Size = new System.Drawing.Size(496, 117);
			this.grpEncryptDecrypt.TabIndex = 5;
			this.grpEncryptDecrypt.TabStop = false;
			this.grpEncryptDecrypt.Text = "Encrypt/Decrypt";
			// 
			// btnDest
			// 
			this.btnDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDest.Image = ((System.Drawing.Image)(resources.GetObject("btnDest.Image")));
			this.btnDest.Location = new System.Drawing.Point(439, 70);
			this.btnDest.Name = "btnDest";
			this.btnDest.Size = new System.Drawing.Size(28, 23);
			this.btnDest.TabIndex = 11;
			this.btnDest.UseVisualStyleBackColor = true;
			this.btnDest.Click += new System.EventHandler(this.OnFindDestFile);
			// 
			// txtSource
			// 
			this.txtSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSource.Location = new System.Drawing.Point(105, 30);
			this.txtSource.Name = "txtSource";
			this.txtSource.Size = new System.Drawing.Size(328, 20);
			this.txtSource.TabIndex = 7;
			// 
			// txtDest
			// 
			this.txtDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDest.Location = new System.Drawing.Point(105, 71);
			this.txtDest.Name = "txtDest";
			this.txtDest.Size = new System.Drawing.Size(328, 20);
			this.txtDest.TabIndex = 10;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "&Source File:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 75);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "&Destination File:";
			// 
			// btnSource
			// 
			this.btnSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSource.Image = ((System.Drawing.Image)(resources.GetObject("btnSource.Image")));
			this.btnSource.Location = new System.Drawing.Point(439, 29);
			this.btnSource.Name = "btnSource";
			this.btnSource.Size = new System.Drawing.Size(28, 23);
			this.btnSource.TabIndex = 8;
			this.btnSource.UseVisualStyleBackColor = true;
			this.btnSource.Click += new System.EventHandler(this.OnFindSourceFile);
			// 
			// openSourceDialog
			// 
			this.openSourceDialog.Filter = "\"Text Files|*.txt|All Files|*.*\"";
			this.openSourceDialog.RestoreDirectory = true;
			// 
			// saveDestDialog
			// 
			this.saveDestDialog.Filter = "\"Encrypted Files|*.enc|All Files|*.*\"";
			this.saveDestDialog.RestoreDirectory = true;
			// 
			// AsymEncryptForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 261);
			this.Controls.Add(this.grpEncryptDecrypt);
			this.Controls.Add(this.radioDecrypt);
			this.Controls.Add(this.radioEncrypt);
			this.Controls.Add(this.btnEncrypt);
			this.MinimumSize = new System.Drawing.Size(550, 300);
			this.Name = "AsymEncryptForm";
			this.Text = "Asymmetic Encryption";
			this.grpEncryptDecrypt.ResumeLayout(false);
			this.grpEncryptDecrypt.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.RadioButton radioEncrypt;
		private System.Windows.Forms.RadioButton radioDecrypt;
		private System.Windows.Forms.GroupBox grpEncryptDecrypt;
		private System.Windows.Forms.Button btnDest;
		private System.Windows.Forms.TextBox txtSource;
		private System.Windows.Forms.TextBox txtDest;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnSource;
		private System.Windows.Forms.OpenFileDialog openSourceDialog;
		private System.Windows.Forms.SaveFileDialog saveDestDialog;
	}
}

