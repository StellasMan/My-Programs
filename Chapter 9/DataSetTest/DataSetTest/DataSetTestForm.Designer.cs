namespace DataSetTest
{
	partial class DataSetTestForm
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
			this.btnInsert = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstvwCustomers
			// 
			this.lstvwCustomers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstvwCustomers.FullRowSelect = true;
			this.lstvwCustomers.GridLines = true;
			this.lstvwCustomers.Location = new System.Drawing.Point(13, 43);
			this.lstvwCustomers.Name = "lstvwCustomers";
			this.lstvwCustomers.Size = new System.Drawing.Size(659, 336);
			this.lstvwCustomers.TabIndex = 0;
			this.lstvwCustomers.UseCompatibleStateImageBehavior = false;
			this.lstvwCustomers.View = System.Windows.Forms.View.Details;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(314, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Customers";
			// 
			// btnInsert
			// 
			this.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnInsert.Location = new System.Drawing.Point(264, 401);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(75, 23);
			this.btnInsert.TabIndex = 3;
			this.btnInsert.Text = "&Insert";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.OnInsert);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDelete.Location = new System.Drawing.Point(345, 401);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.OnDelete);
			// 
			// DataSetTestForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(684, 436);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstvwCustomers);
			this.MinimumSize = new System.Drawing.Size(700, 475);
			this.Name = "DataSetTestForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "DataSet Test";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView lstvwCustomers;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.Button btnDelete;
	}
}

