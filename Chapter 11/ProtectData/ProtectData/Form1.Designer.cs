namespace ProtectData
{
	partial class ProtectDataMainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProtectDataMainForm));
			this.lblSource = new System.Windows.Forms.Label();
			this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
			this.txtSrcFile = new System.Windows.Forms.TextBox();
			this.btnEncryptSource = new System.Windows.Forms.Button();
			this.grpEncrypt = new System.Windows.Forms.GroupBox();
			this.txtDestFile = new System.Windows.Forms.TextBox();
			this.btnEncryptDest = new System.Windows.Forms.Button();
			this.lblDest = new System.Windows.Forms.Label();
			this.radioEncrypt = new System.Windows.Forms.RadioButton();
			this.radioDecrypt = new System.Windows.Forms.RadioButton();
			this.dlgSaveFile = new System.Windows.Forms.SaveFileDialog();
			this.btnEncryptDecrypt = new System.Windows.Forms.Button();
			this.grpEncrypt.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblSource
			// 
			this.lblSource.AutoSize = true;
			this.lblSource.Location = new System.Drawing.Point(29, 41);
			this.lblSource.Name = "lblSource";
			this.lblSource.Size = new System.Drawing.Size(63, 13);
			this.lblSource.TabIndex = 0;
			this.lblSource.Text = "&Source File:";
			// 
			// dlgOpenFile
			// 
			this.dlgOpenFile.Filter = "\"Text Files|*.txt|All Files|*.*\"";
			// 
			// txtSrcFile
			// 
			this.txtSrcFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSrcFile.Location = new System.Drawing.Point(103, 37);
			this.txtSrcFile.Name = "txtSrcFile";
			this.txtSrcFile.Size = new System.Drawing.Size(308, 20);
			this.txtSrcFile.TabIndex = 1;
			// 
			// btnEncryptSource
			// 
			this.btnEncryptSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEncryptSource.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryptSource.Image")));
			this.btnEncryptSource.Location = new System.Drawing.Point(418, 31);
			this.btnEncryptSource.Name = "btnEncryptSource";
			this.btnEncryptSource.Size = new System.Drawing.Size(32, 32);
			this.btnEncryptSource.TabIndex = 2;
			this.btnEncryptSource.UseVisualStyleBackColor = true;
			this.btnEncryptSource.Click += new System.EventHandler(this.OnFindDecryptSrc);
			// 
			// grpEncrypt
			// 
			this.grpEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpEncrypt.Controls.Add(this.txtDestFile);
			this.grpEncrypt.Controls.Add(this.btnEncryptDest);
			this.grpEncrypt.Controls.Add(this.lblDest);
			this.grpEncrypt.Controls.Add(this.txtSrcFile);
			this.grpEncrypt.Controls.Add(this.btnEncryptSource);
			this.grpEncrypt.Controls.Add(this.lblSource);
			this.grpEncrypt.Location = new System.Drawing.Point(12, 69);
			this.grpEncrypt.Name = "grpEncrypt";
			this.grpEncrypt.Size = new System.Drawing.Size(460, 131);
			this.grpEncrypt.TabIndex = 3;
			this.grpEncrypt.TabStop = false;
			this.grpEncrypt.Text = "Encryption";
			// 
			// txtDestFile
			// 
			this.txtDestFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDestFile.Location = new System.Drawing.Point(103, 78);
			this.txtDestFile.Name = "txtDestFile";
			this.txtDestFile.Size = new System.Drawing.Size(308, 20);
			this.txtDestFile.TabIndex = 4;
			// 
			// btnEncryptDest
			// 
			this.btnEncryptDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnEncryptDest.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryptDest.Image")));
			this.btnEncryptDest.Location = new System.Drawing.Point(418, 72);
			this.btnEncryptDest.Name = "btnEncryptDest";
			this.btnEncryptDest.Size = new System.Drawing.Size(32, 32);
			this.btnEncryptDest.TabIndex = 5;
			this.btnEncryptDest.UseVisualStyleBackColor = true;
			this.btnEncryptDest.Click += new System.EventHandler(this.OnFindDecryptDest);
			// 
			// lblDest
			// 
			this.lblDest.AutoSize = true;
			this.lblDest.Location = new System.Drawing.Point(10, 82);
			this.lblDest.Name = "lblDest";
			this.lblDest.Size = new System.Drawing.Size(82, 13);
			this.lblDest.TabIndex = 3;
			this.lblDest.Text = "&Destination File:";
			// 
			// radioEncrypt
			// 
			this.radioEncrypt.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radioEncrypt.AutoSize = true;
			this.radioEncrypt.Location = new System.Drawing.Point(166, 31);
			this.radioEncrypt.Name = "radioEncrypt";
			this.radioEncrypt.Size = new System.Drawing.Size(61, 17);
			this.radioEncrypt.TabIndex = 4;
			this.radioEncrypt.TabStop = true;
			this.radioEncrypt.Text = "&Encrypt";
			this.radioEncrypt.UseVisualStyleBackColor = true;
			this.radioEncrypt.CheckedChanged += new System.EventHandler(this.OnEncryptDecryptChanged);
			// 
			// radioDecrypt
			// 
			this.radioDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.radioDecrypt.AutoSize = true;
			this.radioDecrypt.Location = new System.Drawing.Point(256, 31);
			this.radioDecrypt.Name = "radioDecrypt";
			this.radioDecrypt.Size = new System.Drawing.Size(62, 17);
			this.radioDecrypt.TabIndex = 5;
			this.radioDecrypt.TabStop = true;
			this.radioDecrypt.Text = "D&ecrypt";
			this.radioDecrypt.UseVisualStyleBackColor = true;
			this.radioDecrypt.CheckedChanged += new System.EventHandler(this.OnEncryptDecryptChanged);
			// 
			// dlgSaveFile
			// 
			this.dlgSaveFile.Filter = "\"Encrypted Files|*.enc|All Files|*.*\"";
			// 
			// btnEncryptDecrypt
			// 
			this.btnEncryptDecrypt.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnEncryptDecrypt.Location = new System.Drawing.Point(205, 217);
			this.btnEncryptDecrypt.Name = "btnEncryptDecrypt";
			this.btnEncryptDecrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncryptDecrypt.TabIndex = 6;
			this.btnEncryptDecrypt.Text = "En&crypt";
			this.btnEncryptDecrypt.UseVisualStyleBackColor = true;
			this.btnEncryptDecrypt.Click += new System.EventHandler(this.OnEncryptDecrypt);
			// 
			// ProtectDataMainForm
			// 
			this.AcceptButton = this.btnEncryptDecrypt;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 261);
			this.Controls.Add(this.btnEncryptDecrypt);
			this.Controls.Add(this.radioDecrypt);
			this.Controls.Add(this.radioEncrypt);
			this.Controls.Add(this.grpEncrypt);
			this.MinimumSize = new System.Drawing.Size(500, 300);
			this.Name = "ProtectDataMainForm";
			this.Text = "Protect User Data";
			this.grpEncrypt.ResumeLayout(false);
			this.grpEncrypt.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblSource;
		private System.Windows.Forms.OpenFileDialog dlgOpenFile;
		private System.Windows.Forms.TextBox txtSrcFile;
		private System.Windows.Forms.Button btnEncryptSource;
		private System.Windows.Forms.GroupBox grpEncrypt;
		private System.Windows.Forms.TextBox txtDestFile;
		private System.Windows.Forms.Button btnEncryptDest;
		private System.Windows.Forms.Label lblDest;
		private System.Windows.Forms.RadioButton radioEncrypt;
		private System.Windows.Forms.RadioButton radioDecrypt;
		private System.Windows.Forms.SaveFileDialog dlgSaveFile;
		private System.Windows.Forms.Button btnEncryptDecrypt;
	}
}

