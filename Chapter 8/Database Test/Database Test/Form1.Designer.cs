namespace Database_Test
{
	partial class dbTestForm
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnLoad = new System.Windows.Forms.Button();
			this.dgvCustGrid = new System.Windows.Forms.DataGridView();
			this.DBName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Country = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvCustGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(12, 12);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 0;
			this.btnLoad.Text = "&Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.OnStart);
			// 
			// dgvCustGrid
			// 
			this.dgvCustGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvCustGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvCustGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvCustGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DBName,
            this.Address,
            this.City,
            this.State,
            this.Zip,
            this.Country});
			this.dgvCustGrid.Location = new System.Drawing.Point(12, 41);
			this.dgvCustGrid.Name = "dgvCustGrid";
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvCustGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvCustGrid.Size = new System.Drawing.Size(547, 411);
			this.dgvCustGrid.TabIndex = 1;
			// 
			// DBName
			// 
			this.DBName.HeaderText = "Name";
			this.DBName.Name = "DBName";
			// 
			// Address
			// 
			this.Address.HeaderText = "Address";
			this.Address.Name = "Address";
			// 
			// City
			// 
			this.City.HeaderText = "City";
			this.City.Name = "City";
			// 
			// State
			// 
			this.State.HeaderText = "State";
			this.State.Name = "State";
			// 
			// Zip
			// 
			this.Zip.HeaderText = "Zip";
			this.Zip.Name = "Zip";
			// 
			// Country
			// 
			this.Country.HeaderText = "Country";
			this.Country.Name = "Country";
			// 
			// dbTestForm
			// 
			this.AcceptButton = this.btnLoad;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 464);
			this.Controls.Add(this.dgvCustGrid);
			this.Controls.Add(this.btnLoad);
			this.MinimumSize = new System.Drawing.Size(450, 300);
			this.Name = "dbTestForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Database Test";
			((System.ComponentModel.ISupportInitialize)(this.dgvCustGrid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.DataGridView dgvCustGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn DBName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Address;
		private System.Windows.Forms.DataGridViewTextBoxColumn City;
		private System.Windows.Forms.DataGridViewTextBoxColumn State;
		private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
		private System.Windows.Forms.DataGridViewTextBoxColumn Country;
	}
}

