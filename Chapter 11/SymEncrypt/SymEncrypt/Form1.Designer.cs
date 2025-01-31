namespace SymEncrypt
{
	partial class SymEncryptForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymEncryptForm));
			this.lblInput = new System.Windows.Forms.Label();
			this.lblOutput = new System.Windows.Forms.Label();
			this.txtEncryptIn = new System.Windows.Forms.TextBox();
			this.txtEncryptOut = new System.Windows.Forms.TextBox();
			this.btnEncryptIn = new System.Windows.Forms.Button();
			this.btnEncryptOut = new System.Windows.Forms.Button();
			this.grpEncrypt = new System.Windows.Forms.GroupBox();
			this.btnEncrypt = new System.Windows.Forms.Button();
			this.grpDecrypt = new System.Windows.Forms.GroupBox();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.txtDecryptIn = new System.Windows.Forms.TextBox();
			this.btnDecryptOut = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDecryptIn = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txtDecryptOut = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.grpEncrypt.SuspendLayout();
			this.grpDecrypt.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblInput
			// 
			this.lblInput.AutoSize = true;
			this.lblInput.Location = new System.Drawing.Point(21, 23);
			this.lblInput.Name = "lblInput";
			this.lblInput.Size = new System.Drawing.Size(53, 13);
			this.lblInput.TabIndex = 0;
			this.lblInput.Text = "&Input File:";
			// 
			// lblOutput
			// 
			this.lblOutput.AutoSize = true;
			this.lblOutput.Location = new System.Drawing.Point(13, 56);
			this.lblOutput.Name = "lblOutput";
			this.lblOutput.Size = new System.Drawing.Size(61, 13);
			this.lblOutput.TabIndex = 3;
			this.lblOutput.Text = "&Output File:";
			// 
			// txtEncryptIn
			// 
			this.txtEncryptIn.Location = new System.Drawing.Point(80, 19);
			this.txtEncryptIn.Name = "txtEncryptIn";
			this.txtEncryptIn.Size = new System.Drawing.Size(236, 20);
			this.txtEncryptIn.TabIndex = 1;
			// 
			// txtEncryptOut
			// 
			this.txtEncryptOut.Location = new System.Drawing.Point(80, 52);
			this.txtEncryptOut.Name = "txtEncryptOut";
			this.txtEncryptOut.Size = new System.Drawing.Size(236, 20);
			this.txtEncryptOut.TabIndex = 4;
			// 
			// btnEncryptIn
			// 
			this.btnEncryptIn.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryptIn.Image")));
			this.btnEncryptIn.Location = new System.Drawing.Point(322, 18);
			this.btnEncryptIn.Name = "btnEncryptIn";
			this.btnEncryptIn.Size = new System.Drawing.Size(26, 23);
			this.btnEncryptIn.TabIndex = 2;
			this.btnEncryptIn.UseVisualStyleBackColor = true;
			this.btnEncryptIn.Click += new System.EventHandler(this.OnBtnEncryptInput);
			// 
			// btnEncryptOut
			// 
			this.btnEncryptOut.Image = ((System.Drawing.Image)(resources.GetObject("btnEncryptOut.Image")));
			this.btnEncryptOut.Location = new System.Drawing.Point(322, 51);
			this.btnEncryptOut.Name = "btnEncryptOut";
			this.btnEncryptOut.Size = new System.Drawing.Size(26, 23);
			this.btnEncryptOut.TabIndex = 5;
			this.btnEncryptOut.UseVisualStyleBackColor = true;
			this.btnEncryptOut.Click += new System.EventHandler(this.OnBtnEncryptOutput);
			// 
			// grpEncrypt
			// 
			this.grpEncrypt.Controls.Add(this.btnEncrypt);
			this.grpEncrypt.Controls.Add(this.txtEncryptIn);
			this.grpEncrypt.Controls.Add(this.btnEncryptOut);
			this.grpEncrypt.Controls.Add(this.lblInput);
			this.grpEncrypt.Controls.Add(this.btnEncryptIn);
			this.grpEncrypt.Controls.Add(this.lblOutput);
			this.grpEncrypt.Controls.Add(this.txtEncryptOut);
			this.grpEncrypt.Location = new System.Drawing.Point(35, 73);
			this.grpEncrypt.Name = "grpEncrypt";
			this.grpEncrypt.Size = new System.Drawing.Size(370, 125);
			this.grpEncrypt.TabIndex = 2;
			this.grpEncrypt.TabStop = false;
			this.grpEncrypt.Text = "Encrypt";
			// 
			// btnEncrypt
			// 
			this.btnEncrypt.Location = new System.Drawing.Point(154, 83);
			this.btnEncrypt.Name = "btnEncrypt";
			this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
			this.btnEncrypt.TabIndex = 6;
			this.btnEncrypt.Text = "&Encrypt";
			this.btnEncrypt.UseVisualStyleBackColor = true;
			this.btnEncrypt.Click += new System.EventHandler(this.OnBtnEncrypt);
			// 
			// grpDecrypt
			// 
			this.grpDecrypt.Controls.Add(this.btnDecrypt);
			this.grpDecrypt.Controls.Add(this.txtDecryptIn);
			this.grpDecrypt.Controls.Add(this.btnDecryptOut);
			this.grpDecrypt.Controls.Add(this.label1);
			this.grpDecrypt.Controls.Add(this.btnDecryptIn);
			this.grpDecrypt.Controls.Add(this.label2);
			this.grpDecrypt.Controls.Add(this.txtDecryptOut);
			this.grpDecrypt.Location = new System.Drawing.Point(35, 219);
			this.grpDecrypt.Name = "grpDecrypt";
			this.grpDecrypt.Size = new System.Drawing.Size(370, 133);
			this.grpDecrypt.TabIndex = 3;
			this.grpDecrypt.TabStop = false;
			this.grpDecrypt.Text = "Decrypt";
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(154, 95);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
			this.btnDecrypt.TabIndex = 6;
			this.btnDecrypt.Text = "&Decrypt";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.OnDecrypt);
			// 
			// txtDecryptIn
			// 
			this.txtDecryptIn.Location = new System.Drawing.Point(80, 19);
			this.txtDecryptIn.Name = "txtDecryptIn";
			this.txtDecryptIn.Size = new System.Drawing.Size(236, 20);
			this.txtDecryptIn.TabIndex = 1;
			// 
			// btnDecryptOut
			// 
			this.btnDecryptOut.Image = ((System.Drawing.Image)(resources.GetObject("btnDecryptOut.Image")));
			this.btnDecryptOut.Location = new System.Drawing.Point(322, 51);
			this.btnDecryptOut.Name = "btnDecryptOut";
			this.btnDecryptOut.Size = new System.Drawing.Size(26, 23);
			this.btnDecryptOut.TabIndex = 5;
			this.btnDecryptOut.UseVisualStyleBackColor = true;
			this.btnDecryptOut.Click += new System.EventHandler(this.OnBtnDecryptOutput);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(21, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Input &File:";
			// 
			// btnDecryptIn
			// 
			this.btnDecryptIn.Image = ((System.Drawing.Image)(resources.GetObject("btnDecryptIn.Image")));
			this.btnDecryptIn.Location = new System.Drawing.Point(322, 18);
			this.btnDecryptIn.Name = "btnDecryptIn";
			this.btnDecryptIn.Size = new System.Drawing.Size(26, 23);
			this.btnDecryptIn.TabIndex = 2;
			this.btnDecryptIn.UseVisualStyleBackColor = true;
			this.btnDecryptIn.Click += new System.EventHandler(this.OnBtnDecryptInput);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 56);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Out&put File:";
			// 
			// txtDecryptOut
			// 
			this.txtDecryptOut.Location = new System.Drawing.Point(80, 52);
			this.txtDecryptOut.Name = "txtDecryptOut";
			this.txtDecryptOut.Size = new System.Drawing.Size(236, 20);
			this.txtDecryptOut.TabIndex = 4;
			// 
			// btnExit
			// 
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnExit.Location = new System.Drawing.Point(189, 388);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(53, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "&Password:";
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(115, 28);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(209, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.UseSystemPasswordChar = true;
			// 
			// SymEncryptForm
			// 
			this.AcceptButton = this.btnExit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 449);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.grpDecrypt);
			this.Controls.Add(this.grpEncrypt);
			this.Name = "SymEncryptForm";
			this.Text = "Symmetric Encryption";
			this.grpEncrypt.ResumeLayout(false);
			this.grpEncrypt.PerformLayout();
			this.grpDecrypt.ResumeLayout(false);
			this.grpDecrypt.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblInput;
		private System.Windows.Forms.Label lblOutput;
		private System.Windows.Forms.TextBox txtEncryptIn;
		private System.Windows.Forms.TextBox txtEncryptOut;
		private System.Windows.Forms.Button btnEncryptIn;
		private System.Windows.Forms.Button btnEncryptOut;
		private System.Windows.Forms.GroupBox grpEncrypt;
		private System.Windows.Forms.GroupBox grpDecrypt;
		private System.Windows.Forms.TextBox txtDecryptIn;
		private System.Windows.Forms.Button btnDecryptOut;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnDecryptIn;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtDecryptOut;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Button btnEncrypt;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtPassword;
	}
}

