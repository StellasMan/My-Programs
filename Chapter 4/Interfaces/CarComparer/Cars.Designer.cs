namespace CarComparer
{
	partial class CarForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.cmbSortBy = new System.Windows.Forms.ComboBox();
			this.lstvwCars = new System.Windows.Forms.ListView();
			this.btnSort = new System.Windows.Forms.Button();
			this.radioAscending = new System.Windows.Forms.RadioButton();
			this.radioDescending = new System.Windows.Forms.RadioButton();
			this.btnNoDuplicates = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Sort &By:";
			// 
			// cmbSortBy
			// 
			this.cmbSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSortBy.FormattingEnabled = true;
			this.cmbSortBy.Location = new System.Drawing.Point(60, 23);
			this.cmbSortBy.Name = "cmbSortBy";
			this.cmbSortBy.Size = new System.Drawing.Size(121, 21);
			this.cmbSortBy.TabIndex = 1;
			// 
			// lstvwCars
			// 
			this.lstvwCars.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstvwCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lstvwCars.Location = new System.Drawing.Point(12, 63);
			this.lstvwCars.Name = "lstvwCars";
			this.lstvwCars.Size = new System.Drawing.Size(510, 362);
			this.lstvwCars.TabIndex = 6;
			this.lstvwCars.UseCompatibleStateImageBehavior = false;
			// 
			// btnSort
			// 
			this.btnSort.Location = new System.Drawing.Point(197, 21);
			this.btnSort.Name = "btnSort";
			this.btnSort.Size = new System.Drawing.Size(75, 23);
			this.btnSort.TabIndex = 2;
			this.btnSort.Text = "&Sort";
			this.btnSort.UseVisualStyleBackColor = true;
			this.btnSort.Click += new System.EventHandler(this.OnSort);
			// 
			// radioAscending
			// 
			this.radioAscending.AutoSize = true;
			this.radioAscending.Checked = true;
			this.radioAscending.Location = new System.Drawing.Point(288, 13);
			this.radioAscending.Name = "radioAscending";
			this.radioAscending.Size = new System.Drawing.Size(75, 17);
			this.radioAscending.TabIndex = 3;
			this.radioAscending.TabStop = true;
			this.radioAscending.Text = "&Ascending";
			this.radioAscending.UseVisualStyleBackColor = true;
			// 
			// radioDescending
			// 
			this.radioDescending.AutoSize = true;
			this.radioDescending.Location = new System.Drawing.Point(288, 36);
			this.radioDescending.Name = "radioDescending";
			this.radioDescending.Size = new System.Drawing.Size(82, 17);
			this.radioDescending.TabIndex = 4;
			this.radioDescending.Text = "&Descending";
			this.radioDescending.UseVisualStyleBackColor = true;
			// 
			// btnNoDuplicates
			// 
			this.btnNoDuplicates.Location = new System.Drawing.Point(401, 20);
			this.btnNoDuplicates.Name = "btnNoDuplicates";
			this.btnNoDuplicates.Size = new System.Drawing.Size(121, 23);
			this.btnNoDuplicates.TabIndex = 5;
			this.btnNoDuplicates.Text = "&Remove Duplicates";
			this.btnNoDuplicates.UseVisualStyleBackColor = true;
			this.btnNoDuplicates.Click += new System.EventHandler(this.OnRemoveDuplicates);
			// 
			// CarForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(534, 437);
			this.Controls.Add(this.btnNoDuplicates);
			this.Controls.Add(this.radioDescending);
			this.Controls.Add(this.radioAscending);
			this.Controls.Add(this.btnSort);
			this.Controls.Add(this.lstvwCars);
			this.Controls.Add(this.cmbSortBy);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(1100, 900);
			this.MinimumSize = new System.Drawing.Size(550, 450);
			this.Name = "CarForm";
			this.Text = "Cars";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cmbSortBy;
		private System.Windows.Forms.ListView lstvwCars;
		private System.Windows.Forms.Button btnSort;
		private System.Windows.Forms.RadioButton radioAscending;
		private System.Windows.Forms.RadioButton radioDescending;
		private System.Windows.Forms.Button btnNoDuplicates;
	}
}

