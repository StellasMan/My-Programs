namespace ADOEntity
{
	partial class CustomerHistoryForm
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
			this.lstvwCustomers = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lstvwHistory = new System.Windows.Forms.ListView();
			this.btnClose = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lstvwCustomers
			// 
			this.lstvwCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstvwCustomers.Location = new System.Drawing.Point(9, 41);
			this.lstvwCustomers.Name = "lstvwCustomers";
			this.lstvwCustomers.Size = new System.Drawing.Size(265, 366);
			this.lstvwCustomers.TabIndex = 0;
			this.lstvwCustomers.UseCompatibleStateImageBehavior = false;
			this.lstvwCustomers.SelectedIndexChanged += new System.EventHandler(this.OnCustomerSelectionChanged);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Customers";
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(242, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Order History";
			// 
			// lstvwHistory
			// 
			this.lstvwHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstvwHistory.Location = new System.Drawing.Point(3, 41);
			this.lstvwHistory.Name = "lstvwHistory";
			this.lstvwHistory.Size = new System.Drawing.Size(547, 366);
			this.lstvwHistory.TabIndex = 2;
			this.lstvwHistory.UseCompatibleStateImageBehavior = false;
			// 
			// btnClose
			// 
			this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClose.Location = new System.Drawing.Point(772, 428);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.OnClose);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.Location = new System.Drawing.Point(13, 12);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.lstvwCustomers);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.lstvwHistory);
			this.splitContainer1.Panel2.Controls.Add(this.label2);
			this.splitContainer1.Size = new System.Drawing.Size(834, 410);
			this.splitContainer1.SplitterDistance = 277;
			this.splitContainer1.TabIndex = 5;
			// 
			// CustomerHistoryForm
			// 
			this.AcceptButton = this.btnClose;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(859, 461);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.btnClose);
			this.MinimumSize = new System.Drawing.Size(875, 500);
			this.Name = "CustomerHistoryForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "CustomerHistory";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lstvwCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ListView lstvwHistory;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.SplitContainer splitContainer1;
	}
}