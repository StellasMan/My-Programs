namespace BankEvent
{
	partial class BankAcctForm
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
			this.grpDeposit = new System.Windows.Forms.GroupBox();
			this.btnDeposit = new System.Windows.Forms.Button();
			this.txtDeposit = new System.Windows.Forms.TextBox();
			this.lblAmount = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAcctBalance = new System.Windows.Forms.TextBox();
			this.radioDeposit = new System.Windows.Forms.RadioButton();
			this.radioWithdraw = new System.Windows.Forms.RadioButton();
			this.label2 = new System.Windows.Forms.Label();
			this.comboAccounts = new System.Windows.Forms.ComboBox();
			this.grpDeposit.SuspendLayout();
			this.SuspendLayout();
			// 
			// grpDeposit
			// 
			this.grpDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpDeposit.Controls.Add(this.btnDeposit);
			this.grpDeposit.Controls.Add(this.txtDeposit);
			this.grpDeposit.Controls.Add(this.lblAmount);
			this.grpDeposit.Location = new System.Drawing.Point(7, 112);
			this.grpDeposit.Name = "grpDeposit";
			this.grpDeposit.Size = new System.Drawing.Size(315, 101);
			this.grpDeposit.TabIndex = 4;
			this.grpDeposit.TabStop = false;
			this.grpDeposit.Text = "Deposit";
			// 
			// btnDeposit
			// 
			this.btnDeposit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.btnDeposit.Location = new System.Drawing.Point(95, 64);
			this.btnDeposit.Name = "btnDeposit";
			this.btnDeposit.Size = new System.Drawing.Size(125, 23);
			this.btnDeposit.TabIndex = 2;
			this.btnDeposit.Text = "&Make Withdrawal";
			this.btnDeposit.UseVisualStyleBackColor = true;
			this.btnDeposit.Click += new System.EventHandler(this.OnDepositOrWithdraw);
			// 
			// txtDeposit
			// 
			this.txtDeposit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDeposit.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtDeposit.Location = new System.Drawing.Point(146, 25);
			this.txtDeposit.Name = "txtDeposit";
			this.txtDeposit.Size = new System.Drawing.Size(125, 20);
			this.txtDeposit.TabIndex = 1;
			this.txtDeposit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lblAmount
			// 
			this.lblAmount.AutoSize = true;
			this.lblAmount.Location = new System.Drawing.Point(38, 29);
			this.lblAmount.Name = "lblAmount";
			this.lblAmount.Size = new System.Drawing.Size(102, 13);
			this.lblAmount.TabIndex = 0;
			this.lblAmount.Text = "Withdrawal Amount:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 245);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account Balance:";
			// 
			// txtAcctBalance
			// 
			this.txtAcctBalance.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtAcctBalance.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.txtAcctBalance.Location = new System.Drawing.Point(117, 241);
			this.txtAcctBalance.Name = "txtAcctBalance";
			this.txtAcctBalance.ReadOnly = true;
			this.txtAcctBalance.Size = new System.Drawing.Size(125, 20);
			this.txtAcctBalance.TabIndex = 1;
			this.txtAcctBalance.TabStop = false;
			this.txtAcctBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// radioDeposit
			// 
			this.radioDeposit.AutoSize = true;
			this.radioDeposit.Location = new System.Drawing.Point(16, 74);
			this.radioDeposit.Name = "radioDeposit";
			this.radioDeposit.Size = new System.Drawing.Size(61, 17);
			this.radioDeposit.TabIndex = 2;
			this.radioDeposit.TabStop = true;
			this.radioDeposit.Text = "&Deposit";
			this.radioDeposit.UseVisualStyleBackColor = true;
			this.radioDeposit.CheckedChanged += new System.EventHandler(this.OnDepositChecked);
			// 
			// radioWithdraw
			// 
			this.radioWithdraw.AutoSize = true;
			this.radioWithdraw.Location = new System.Drawing.Point(102, 74);
			this.radioWithdraw.Name = "radioWithdraw";
			this.radioWithdraw.Size = new System.Drawing.Size(70, 17);
			this.radioWithdraw.TabIndex = 3;
			this.radioWithdraw.TabStop = true;
			this.radioWithdraw.Text = "&Withdraw";
			this.radioWithdraw.UseVisualStyleBackColor = true;
			this.radioWithdraw.CheckedChanged += new System.EventHandler(this.OnWithdrawChecked);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Account:";
			// 
			// comboAccounts
			// 
			this.comboAccounts.AllowDrop = true;
			this.comboAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.comboAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboAccounts.FormattingEnabled = true;
			this.comboAccounts.Location = new System.Drawing.Point(69, 30);
			this.comboAccounts.Name = "comboAccounts";
			this.comboAccounts.Size = new System.Drawing.Size(226, 21);
			this.comboAccounts.TabIndex = 6;
			this.comboAccounts.SelectedIndexChanged += new System.EventHandler(this.OnSelectedAccountChanged);
			// 
			// BankAcctForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(334, 291);
			this.Controls.Add(this.comboAccounts);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.radioWithdraw);
			this.Controls.Add(this.radioDeposit);
			this.Controls.Add(this.txtAcctBalance);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.grpDeposit);
			this.MinimumSize = new System.Drawing.Size(350, 330);
			this.Name = "BankAcctForm";
			this.Text = "Bank Account";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.grpDeposit.ResumeLayout(false);
			this.grpDeposit.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpDeposit;
		private System.Windows.Forms.Button btnDeposit;
		private System.Windows.Forms.TextBox txtDeposit;
		private System.Windows.Forms.Label lblAmount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAcctBalance;
		private System.Windows.Forms.RadioButton radioDeposit;
		private System.Windows.Forms.RadioButton radioWithdraw;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox comboAccounts;
	}
}

