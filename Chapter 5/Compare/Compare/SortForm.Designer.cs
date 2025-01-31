namespace Compare
{
	partial class SortFormDlg
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

		public VehicleComparer.SortType GetSortType()
		{
			return 
				radioMakeAndModel.Checked	?	VehicleComparer.SortType.ST_MAKEMODEL	:
				radioSpeed.Checked			?	VehicleComparer.SortType.ST_TOPSPEED	:
												VehicleComparer.SortType.ST_PRICE;
		}

		public bool GetSortDirection()
		{
			return radioAscending.Checked ? true : false;
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.radioMakeAndModel = new System.Windows.Forms.RadioButton();
			this.radioSpeed = new System.Windows.Forms.RadioButton();
			this.radioPrice = new System.Windows.Forms.RadioButton();
			this.groupSortBy = new System.Windows.Forms.GroupBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.radioAscending = new System.Windows.Forms.RadioButton();
			this.radioDescending = new System.Windows.Forms.RadioButton();
			this.groupDirection = new System.Windows.Forms.GroupBox();
			this.groupSortBy.SuspendLayout();
			this.groupDirection.SuspendLayout();
			this.SuspendLayout();
			// 
			// radioMakeAndModel
			// 
			this.radioMakeAndModel.AutoSize = true;
			this.radioMakeAndModel.Checked = true;
			this.radioMakeAndModel.Location = new System.Drawing.Point(21, 31);
			this.radioMakeAndModel.Name = "radioMakeAndModel";
			this.radioMakeAndModel.Size = new System.Drawing.Size(105, 17);
			this.radioMakeAndModel.TabIndex = 0;
			this.radioMakeAndModel.TabStop = true;
			this.radioMakeAndModel.Text = "&Make and Model";
			this.radioMakeAndModel.UseVisualStyleBackColor = true;
			// 
			// radioSpeed
			// 
			this.radioSpeed.AutoSize = true;
			this.radioSpeed.Location = new System.Drawing.Point(21, 54);
			this.radioSpeed.Name = "radioSpeed";
			this.radioSpeed.Size = new System.Drawing.Size(78, 17);
			this.radioSpeed.TabIndex = 1;
			this.radioSpeed.TabStop = true;
			this.radioSpeed.Text = "&Top Speed";
			this.radioSpeed.UseVisualStyleBackColor = true;
			// 
			// radioPrice
			// 
			this.radioPrice.AutoSize = true;
			this.radioPrice.Location = new System.Drawing.Point(21, 77);
			this.radioPrice.Name = "radioPrice";
			this.radioPrice.Size = new System.Drawing.Size(49, 17);
			this.radioPrice.TabIndex = 2;
			this.radioPrice.TabStop = true;
			this.radioPrice.Text = "&Price";
			this.radioPrice.UseVisualStyleBackColor = true;
			// 
			// groupSortBy
			// 
			this.groupSortBy.Controls.Add(this.radioMakeAndModel);
			this.groupSortBy.Controls.Add(this.radioPrice);
			this.groupSortBy.Controls.Add(this.radioSpeed);
			this.groupSortBy.Location = new System.Drawing.Point(12, 27);
			this.groupSortBy.Name = "groupSortBy";
			this.groupSortBy.Size = new System.Drawing.Size(139, 119);
			this.groupSortBy.TabIndex = 3;
			this.groupSortBy.TabStop = false;
			this.groupSortBy.Text = "Sort By";
			// 
			// btnOK
			// 
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(168, 33);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 4;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(168, 64);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// radioAscending
			// 
			this.radioAscending.AutoSize = true;
			this.radioAscending.Checked = true;
			this.radioAscending.Location = new System.Drawing.Point(21, 31);
			this.radioAscending.Name = "radioAscending";
			this.radioAscending.Size = new System.Drawing.Size(75, 17);
			this.radioAscending.TabIndex = 0;
			this.radioAscending.TabStop = true;
			this.radioAscending.Text = "&Ascending";
			this.radioAscending.UseVisualStyleBackColor = true;
			// 
			// radioDescending
			// 
			this.radioDescending.AutoSize = true;
			this.radioDescending.Location = new System.Drawing.Point(21, 54);
			this.radioDescending.Name = "radioDescending";
			this.radioDescending.Size = new System.Drawing.Size(82, 17);
			this.radioDescending.TabIndex = 1;
			this.radioDescending.TabStop = true;
			this.radioDescending.Text = "&Descending";
			this.radioDescending.UseVisualStyleBackColor = true;
			// 
			// groupDirection
			// 
			this.groupDirection.Controls.Add(this.radioAscending);
			this.groupDirection.Controls.Add(this.radioDescending);
			this.groupDirection.Location = new System.Drawing.Point(12, 158);
			this.groupDirection.Name = "groupDirection";
			this.groupDirection.Size = new System.Drawing.Size(139, 91);
			this.groupDirection.TabIndex = 4;
			this.groupDirection.TabStop = false;
			this.groupDirection.Text = "Sort Direction";
			// 
			// SortFormDlg
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(257, 264);
			this.Controls.Add(this.groupDirection);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupSortBy);
			this.Name = "SortFormDlg";
			this.Text = "SortForm";
			this.groupSortBy.ResumeLayout(false);
			this.groupSortBy.PerformLayout();
			this.groupDirection.ResumeLayout(false);
			this.groupDirection.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RadioButton radioMakeAndModel;
		private System.Windows.Forms.RadioButton radioSpeed;
		private System.Windows.Forms.RadioButton radioPrice;
		private System.Windows.Forms.GroupBox groupSortBy;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RadioButton radioAscending;
		private System.Windows.Forms.RadioButton radioDescending;
		private System.Windows.Forms.GroupBox groupDirection;
	}
}