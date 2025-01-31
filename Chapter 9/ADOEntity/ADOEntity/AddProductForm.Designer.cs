namespace ADOEntity
{
	partial class AddProductForm
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
			this.txtProdName = new System.Windows.Forms.TextBox();
			this.cmbCategory = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAdd = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cmbSupplier = new System.Windows.Forms.ComboBox();
			this.txtQtyPerUnit = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.mskCurrencyTextBox = new ADOEntity.CurrencyTextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.mskUnitsInStock = new ADOEntity.CurrencyTextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.mskUnitsOnOrder = new ADOEntity.CurrencyTextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mskReorderLevel = new ADOEntity.CurrencyTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.grpPartInfo = new System.Windows.Forms.GroupBox();
			this.chkDiscontinued = new System.Windows.Forms.CheckBox();
			this.grpPartInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(30, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Product Name:";
			// 
			// txtProdName
			// 
			this.txtProdName.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtProdName.Location = new System.Drawing.Point(113, 44);
			this.txtProdName.Name = "txtProdName";
			this.txtProdName.Size = new System.Drawing.Size(232, 20);
			this.txtProdName.TabIndex = 1;
			// 
			// cmbCategory
			// 
			this.cmbCategory.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbCategory.FormattingEnabled = true;
			this.cmbCategory.Location = new System.Drawing.Point(379, 96);
			this.cmbCategory.Name = "cmbCategory";
			this.cmbCategory.Size = new System.Drawing.Size(193, 21);
			this.cmbCategory.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(451, 79);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(49, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "&Category";
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnAdd.Location = new System.Drawing.Point(287, 324);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "A&dd";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.OnAdd);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(453, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(45, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "&Supplier";
			// 
			// cmbSupplier
			// 
			this.cmbSupplier.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.cmbSupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbSupplier.FormattingEnabled = true;
			this.cmbSupplier.Location = new System.Drawing.Point(379, 45);
			this.cmbSupplier.Name = "cmbSupplier";
			this.cmbSupplier.Size = new System.Drawing.Size(193, 21);
			this.cmbSupplier.TabIndex = 3;
			// 
			// txtQtyPerUnit
			// 
			this.txtQtyPerUnit.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.txtQtyPerUnit.Location = new System.Drawing.Point(113, 96);
			this.txtQtyPerUnit.Name = "txtQtyPerUnit";
			this.txtQtyPerUnit.Size = new System.Drawing.Size(232, 20);
			this.txtQtyPerUnit.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(18, 99);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "&Quantity Per Unit:";
			// 
			// mskCurrencyTextBox
			// 
			this.mskCurrencyTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mskCurrencyTextBox.HidePromptOnLeave = true;
			this.mskCurrencyTextBox.Location = new System.Drawing.Point(113, 148);
			this.mskCurrencyTextBox.Mask = "$000000.00";
			this.mskCurrencyTextBox.Name = "mskCurrencyTextBox";
			this.mskCurrencyTextBox.Size = new System.Drawing.Size(104, 20);
			this.mskCurrencyTextBox.TabIndex = 9;
			this.mskCurrencyTextBox.Text = "      00";
			this.mskCurrencyTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.mskCurrencyTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mskCurrencyTextBox.ValidatingType = typeof(int);
			this.mskCurrencyTextBox.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(52, 151);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "&Unit Price:";
			// 
			// mskUnitsInStock
			// 
			this.mskUnitsInStock.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mskUnitsInStock.HidePromptOnLeave = true;
			this.mskUnitsInStock.Location = new System.Drawing.Point(468, 148);
			this.mskUnitsInStock.Mask = "000000";
			this.mskUnitsInStock.Name = "mskUnitsInStock";
			this.mskUnitsInStock.Size = new System.Drawing.Size(104, 20);
			this.mskUnitsInStock.TabIndex = 11;
			this.mskUnitsInStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.mskUnitsInStock.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mskUnitsInStock.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(387, 151);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 13);
			this.label6.TabIndex = 10;
			this.label6.Text = "Units in &Stock:";
			// 
			// mskUnitsOnOrder
			// 
			this.mskUnitsOnOrder.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mskUnitsOnOrder.HidePromptOnLeave = true;
			this.mskUnitsOnOrder.Location = new System.Drawing.Point(113, 201);
			this.mskUnitsOnOrder.Mask = "000000";
			this.mskUnitsOnOrder.Name = "mskUnitsOnOrder";
			this.mskUnitsOnOrder.Size = new System.Drawing.Size(104, 20);
			this.mskUnitsOnOrder.TabIndex = 13;
			this.mskUnitsOnOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.mskUnitsOnOrder.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mskUnitsOnOrder.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(30, 204);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(78, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Units on &Order:";
			// 
			// mskReorderLevel
			// 
			this.mskReorderLevel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mskReorderLevel.HidePromptOnLeave = true;
			this.mskReorderLevel.Location = new System.Drawing.Point(468, 201);
			this.mskReorderLevel.Mask = "000000";
			this.mskReorderLevel.Name = "mskReorderLevel";
			this.mskReorderLevel.Size = new System.Drawing.Size(104, 20);
			this.mskReorderLevel.TabIndex = 15;
			this.mskReorderLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.mskReorderLevel.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals;
			this.mskReorderLevel.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(386, 204);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(77, 13);
			this.label8.TabIndex = 14;
			this.label8.Text = "&Reorder Level:";
			// 
			// grpPartInfo
			// 
			this.grpPartInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.grpPartInfo.Controls.Add(this.chkDiscontinued);
			this.grpPartInfo.Controls.Add(this.txtProdName);
			this.grpPartInfo.Controls.Add(this.mskReorderLevel);
			this.grpPartInfo.Controls.Add(this.label1);
			this.grpPartInfo.Controls.Add(this.label8);
			this.grpPartInfo.Controls.Add(this.cmbCategory);
			this.grpPartInfo.Controls.Add(this.mskUnitsOnOrder);
			this.grpPartInfo.Controls.Add(this.label2);
			this.grpPartInfo.Controls.Add(this.label7);
			this.grpPartInfo.Controls.Add(this.cmbSupplier);
			this.grpPartInfo.Controls.Add(this.mskUnitsInStock);
			this.grpPartInfo.Controls.Add(this.label3);
			this.grpPartInfo.Controls.Add(this.label6);
			this.grpPartInfo.Controls.Add(this.label4);
			this.grpPartInfo.Controls.Add(this.mskCurrencyTextBox);
			this.grpPartInfo.Controls.Add(this.txtQtyPerUnit);
			this.grpPartInfo.Controls.Add(this.label5);
			this.grpPartInfo.Location = new System.Drawing.Point(12, 12);
			this.grpPartInfo.Name = "grpPartInfo";
			this.grpPartInfo.Size = new System.Drawing.Size(625, 291);
			this.grpPartInfo.TabIndex = 0;
			this.grpPartInfo.TabStop = false;
			this.grpPartInfo.Text = "Part Information";
			// 
			// chkDiscontinued
			// 
			this.chkDiscontinued.AutoSize = true;
			this.chkDiscontinued.Location = new System.Drawing.Point(38, 250);
			this.chkDiscontinued.Name = "chkDiscontinued";
			this.chkDiscontinued.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.chkDiscontinued.Size = new System.Drawing.Size(88, 17);
			this.chkDiscontinued.TabIndex = 16;
			this.chkDiscontinued.Text = "&Discontinued";
			this.chkDiscontinued.UseVisualStyleBackColor = true;
			// 
			// AddProductForm
			// 
			this.AcceptButton = this.btnAdd;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(649, 368);
			this.Controls.Add(this.grpPartInfo);
			this.Controls.Add(this.btnAdd);
			this.MinimumSize = new System.Drawing.Size(665, 370);
			this.Name = "AddProductForm";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Add Product";
			this.grpPartInfo.ResumeLayout(false);
			this.grpPartInfo.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtProdName;
		private System.Windows.Forms.ComboBox cmbCategory;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cmbSupplier;
		private System.Windows.Forms.TextBox txtQtyPerUnit;
		private System.Windows.Forms.Label label4;
		private ADOEntity.CurrencyTextBox mskCurrencyTextBox;
		private System.Windows.Forms.Label label5;
		private CurrencyTextBox mskUnitsInStock;
		private System.Windows.Forms.Label label6;
		private CurrencyTextBox mskUnitsOnOrder;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.GroupBox grpPartInfo;
		private CurrencyTextBox mskReorderLevel;
		private System.Windows.Forms.CheckBox chkDiscontinued;
	}
}