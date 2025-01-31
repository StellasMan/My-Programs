namespace ADOEntity
{
	partial class CategoriesForm
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
			this.lstvwCategories = new System.Windows.Forms.ListView();
			this.CategoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CategoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnHistory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstvwCategories
			// 
			this.lstvwCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstvwCategories.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CategoryID,
            this.CategoryName});
			this.lstvwCategories.FullRowSelect = true;
			this.lstvwCategories.GridLines = true;
			this.lstvwCategories.Location = new System.Drawing.Point(12, 46);
			this.lstvwCategories.MultiSelect = false;
			this.lstvwCategories.Name = "lstvwCategories";
			this.lstvwCategories.Size = new System.Drawing.Size(415, 192);
			this.lstvwCategories.TabIndex = 1;
			this.lstvwCategories.UseCompatibleStateImageBehavior = false;
			this.lstvwCategories.View = System.Windows.Forms.View.Details;
			// 
			// CategoryID
			// 
			this.CategoryID.Text = "Category ID";
			this.CategoryID.Width = 201;
			// 
			// CategoryName
			// 
			this.CategoryName.Text = "Category Name";
			this.CategoryName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.CategoryName.Width = 205;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(57, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Categories";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnAdd.Location = new System.Drawing.Point(12, 266);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(85, 23);
			this.btnAdd.TabIndex = 3;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.OnAdd);
			// 
			// btnDelete
			// 
			this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnDelete.Location = new System.Drawing.Point(122, 266);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(85, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "&Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.OnDelete);
			// 
			// btnModify
			// 
			this.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnModify.Location = new System.Drawing.Point(232, 266);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(85, 23);
			this.btnModify.TabIndex = 5;
			this.btnModify.Text = "&Modify";
			this.btnModify.UseVisualStyleBackColor = true;
			this.btnModify.Click += new System.EventHandler(this.OnModify);
			// 
			// btnHistory
			// 
			this.btnHistory.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnHistory.Location = new System.Drawing.Point(342, 266);
			this.btnHistory.Name = "btnHistory";
			this.btnHistory.Size = new System.Drawing.Size(85, 23);
			this.btnHistory.TabIndex = 6;
			this.btnHistory.Text = "Order &History";
			this.btnHistory.UseVisualStyleBackColor = true;
			this.btnHistory.Click += new System.EventHandler(this.OnHistory);
			// 
			// CategoriesForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(439, 311);
			this.Controls.Add(this.btnHistory);
			this.Controls.Add(this.btnModify);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstvwCategories);
			this.MinimumSize = new System.Drawing.Size(455, 350);
			this.Name = "CategoriesForm";
			this.Text = "ADO Entity Framework";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ListView lstvwCategories;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColumnHeader CategoryID;
		private System.Windows.Forms.ColumnHeader CategoryName;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnHistory;
	}
}

