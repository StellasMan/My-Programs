using System.Collections.Generic;

namespace OrderEntry
{
	partial class OrderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		LinkedList<object> m_llRow1 = new LinkedList<object>();
		LinkedList<object> m_llRow2 = new LinkedList<object>();
		LinkedList<object> m_llRow3 = new LinkedList<object>();
		LinkedList<object> m_llRow4 = new LinkedList<object>();

		List<LinkedList<object>> m_listRowData = new List<LinkedList<object>>();

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
			this.txtDescription1 = new System.Windows.Forms.TextBox();
			this.txtQuantity1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPrice1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtTotal1 = new System.Windows.Forms.TextBox();
			this.txtTotalPrice1 = new System.Windows.Forms.Label();
			this.txtTotal2 = new System.Windows.Forms.TextBox();
			this.txtPrice2 = new System.Windows.Forms.TextBox();
			this.txtQuantity2 = new System.Windows.Forms.TextBox();
			this.txtDescription2 = new System.Windows.Forms.TextBox();
			this.txtTotal3 = new System.Windows.Forms.TextBox();
			this.txtPrice3 = new System.Windows.Forms.TextBox();
			this.txtQuantity3 = new System.Windows.Forms.TextBox();
			this.txtDescription3 = new System.Windows.Forms.TextBox();
			this.txtTotal4 = new System.Windows.Forms.TextBox();
			this.txtPrice4 = new System.Windows.Forms.TextBox();
			this.txtQuantity4 = new System.Windows.Forms.TextBox();
			this.txtDescription4 = new System.Windows.Forms.TextBox();
			this.txtSubtotal = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtTaxRate = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtTax = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtGrandTotal = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(67, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "&Description";
			// 
			// txtDescription1
			// 
			this.txtDescription1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription1.Location = new System.Drawing.Point(16, 36);
			this.txtDescription1.Name = "txtDescription1";
			this.txtDescription1.Size = new System.Drawing.Size(163, 20);
			this.txtDescription1.TabIndex = 1;
			// 
			// txtQuantity1
			// 
			this.txtQuantity1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantity1.Location = new System.Drawing.Point(198, 36);
			this.txtQuantity1.Name = "txtQuantity1";
			this.txtQuantity1.Size = new System.Drawing.Size(78, 20);
			this.txtQuantity1.TabIndex = 3;
			this.txtQuantity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(214, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "&Quantity";
			// 
			// txtPrice1
			// 
			this.txtPrice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrice1.Location = new System.Drawing.Point(295, 36);
			this.txtPrice1.Name = "txtPrice1";
			this.txtPrice1.Size = new System.Drawing.Size(81, 20);
			this.txtPrice1.TabIndex = 5;
			this.txtPrice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(306, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(59, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Price &Each";
			// 
			// txtTotal1
			// 
			this.txtTotal1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal1.Location = new System.Drawing.Point(417, 36);
			this.txtTotal1.Name = "txtTotal1";
			this.txtTotal1.ReadOnly = true;
			this.txtTotal1.Size = new System.Drawing.Size(104, 20);
			this.txtTotal1.TabIndex = 7;
			this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotalPrice1
			// 
			this.txtTotalPrice1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalPrice1.AutoSize = true;
			this.txtTotalPrice1.Location = new System.Drawing.Point(440, 12);
			this.txtTotalPrice1.Name = "txtTotalPrice1";
			this.txtTotalPrice1.Size = new System.Drawing.Size(58, 13);
			this.txtTotalPrice1.TabIndex = 6;
			this.txtTotalPrice1.Text = "Total &Price";
			// 
			// txtTotal2
			// 
			this.txtTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal2.Location = new System.Drawing.Point(417, 62);
			this.txtTotal2.Name = "txtTotal2";
			this.txtTotal2.ReadOnly = true;
			this.txtTotal2.Size = new System.Drawing.Size(104, 20);
			this.txtTotal2.TabIndex = 11;
			this.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtPrice2
			// 
			this.txtPrice2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrice2.Location = new System.Drawing.Point(295, 62);
			this.txtPrice2.Name = "txtPrice2";
			this.txtPrice2.Size = new System.Drawing.Size(81, 20);
			this.txtPrice2.TabIndex = 10;
			this.txtPrice2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQuantity2
			// 
			this.txtQuantity2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantity2.Location = new System.Drawing.Point(198, 62);
			this.txtQuantity2.Name = "txtQuantity2";
			this.txtQuantity2.Size = new System.Drawing.Size(78, 20);
			this.txtQuantity2.TabIndex = 9;
			this.txtQuantity2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDescription2
			// 
			this.txtDescription2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription2.Location = new System.Drawing.Point(16, 62);
			this.txtDescription2.Name = "txtDescription2";
			this.txtDescription2.Size = new System.Drawing.Size(163, 20);
			this.txtDescription2.TabIndex = 8;
			// 
			// txtTotal3
			// 
			this.txtTotal3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal3.Location = new System.Drawing.Point(417, 88);
			this.txtTotal3.Name = "txtTotal3";
			this.txtTotal3.ReadOnly = true;
			this.txtTotal3.Size = new System.Drawing.Size(104, 20);
			this.txtTotal3.TabIndex = 15;
			this.txtTotal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtPrice3
			// 
			this.txtPrice3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrice3.Location = new System.Drawing.Point(295, 88);
			this.txtPrice3.Name = "txtPrice3";
			this.txtPrice3.Size = new System.Drawing.Size(81, 20);
			this.txtPrice3.TabIndex = 14;
			this.txtPrice3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQuantity3
			// 
			this.txtQuantity3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantity3.Location = new System.Drawing.Point(198, 88);
			this.txtQuantity3.Name = "txtQuantity3";
			this.txtQuantity3.Size = new System.Drawing.Size(78, 20);
			this.txtQuantity3.TabIndex = 13;
			this.txtQuantity3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDescription3
			// 
			this.txtDescription3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription3.Location = new System.Drawing.Point(16, 88);
			this.txtDescription3.Name = "txtDescription3";
			this.txtDescription3.Size = new System.Drawing.Size(163, 20);
			this.txtDescription3.TabIndex = 12;
			// 
			// txtTotal4
			// 
			this.txtTotal4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal4.Location = new System.Drawing.Point(417, 114);
			this.txtTotal4.Name = "txtTotal4";
			this.txtTotal4.ReadOnly = true;
			this.txtTotal4.Size = new System.Drawing.Size(104, 20);
			this.txtTotal4.TabIndex = 19;
			this.txtTotal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtPrice4
			// 
			this.txtPrice4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtPrice4.Location = new System.Drawing.Point(295, 114);
			this.txtPrice4.Name = "txtPrice4";
			this.txtPrice4.Size = new System.Drawing.Size(81, 20);
			this.txtPrice4.TabIndex = 18;
			this.txtPrice4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQuantity4
			// 
			this.txtQuantity4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQuantity4.Location = new System.Drawing.Point(198, 114);
			this.txtQuantity4.Name = "txtQuantity4";
			this.txtQuantity4.Size = new System.Drawing.Size(78, 20);
			this.txtQuantity4.TabIndex = 17;
			this.txtQuantity4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtDescription4
			// 
			this.txtDescription4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDescription4.Location = new System.Drawing.Point(18, 114);
			this.txtDescription4.Name = "txtDescription4";
			this.txtDescription4.Size = new System.Drawing.Size(163, 20);
			this.txtDescription4.TabIndex = 16;
			// 
			// txtSubtotal
			// 
			this.txtSubtotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSubtotal.Location = new System.Drawing.Point(417, 145);
			this.txtSubtotal.Name = "txtSubtotal";
			this.txtSubtotal.ReadOnly = true;
			this.txtSubtotal.Size = new System.Drawing.Size(104, 20);
			this.txtSubtotal.TabIndex = 21;
			this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(330, 149);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(46, 13);
			this.label4.TabIndex = 20;
			this.label4.Text = "&Subtotal";
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(325, 174);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(51, 13);
			this.label5.TabIndex = 22;
			this.label5.Text = "Ta&x Rate";
			// 
			// txtTaxRate
			// 
			this.txtTaxRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTaxRate.Location = new System.Drawing.Point(417, 171);
			this.txtTaxRate.Name = "txtTaxRate";
			this.txtTaxRate.Size = new System.Drawing.Size(104, 20);
			this.txtTaxRate.TabIndex = 23;
			this.txtTaxRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(322, 200);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(54, 13);
			this.label6.TabIndex = 24;
			this.label6.Text = "S&ales Tax";
			// 
			// txtTax
			// 
			this.txtTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTax.Location = new System.Drawing.Point(417, 197);
			this.txtTax.Name = "txtTax";
			this.txtTax.ReadOnly = true;
			this.txtTax.Size = new System.Drawing.Size(104, 20);
			this.txtTax.TabIndex = 25;
			this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.label7.Location = new System.Drawing.Point(18, 232);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(503, 2);
			this.label7.TabIndex = 26;
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(322, 255);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(63, 13);
			this.label8.TabIndex = 26;
			this.label8.Text = "&Grand Total";
			// 
			// txtGrandTotal
			// 
			this.txtGrandTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtGrandTotal.Location = new System.Drawing.Point(417, 252);
			this.txtGrandTotal.Name = "txtGrandTotal";
			this.txtGrandTotal.ReadOnly = true;
			this.txtGrandTotal.Size = new System.Drawing.Size(104, 20);
			this.txtGrandTotal.TabIndex = 27;
			this.txtGrandTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnOK.Location = new System.Drawing.Point(284, 294);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 29;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnClear
			// 
			this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClear.Location = new System.Drawing.Point(365, 294);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 30;
			this.btnClear.Text = "&Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnExit
			// 
			this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnExit.Location = new System.Drawing.Point(446, 294);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(75, 23);
			this.btnExit.TabIndex = 31;
			this.btnExit.Text = "E&xit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// OrderForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClear;
			this.ClientSize = new System.Drawing.Size(559, 329);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtGrandTotal);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtTax);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.txtTaxRate);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtSubtotal);
			this.Controls.Add(this.txtTotal4);
			this.Controls.Add(this.txtPrice4);
			this.Controls.Add(this.txtQuantity4);
			this.Controls.Add(this.txtDescription4);
			this.Controls.Add(this.txtTotal3);
			this.Controls.Add(this.txtPrice3);
			this.Controls.Add(this.txtQuantity3);
			this.Controls.Add(this.txtDescription3);
			this.Controls.Add(this.txtTotal2);
			this.Controls.Add(this.txtPrice2);
			this.Controls.Add(this.txtQuantity2);
			this.Controls.Add(this.txtDescription2);
			this.Controls.Add(this.txtTotal1);
			this.Controls.Add(this.txtTotalPrice1);
			this.Controls.Add(this.txtPrice1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtQuantity1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtDescription1);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(575, 368);
			this.Name = "OrderForm";
			this.Text = "Order Form";
			this.Load += new System.EventHandler(this.OrderForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtDescription1;
		private System.Windows.Forms.TextBox txtQuantity1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPrice1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtTotal1;
		private System.Windows.Forms.Label txtTotalPrice1;
		private System.Windows.Forms.TextBox txtTotal2;
		private System.Windows.Forms.TextBox txtPrice2;
		private System.Windows.Forms.TextBox txtQuantity2;
		private System.Windows.Forms.TextBox txtDescription2;
		private System.Windows.Forms.TextBox txtTotal3;
		private System.Windows.Forms.TextBox txtPrice3;
		private System.Windows.Forms.TextBox txtQuantity3;
		private System.Windows.Forms.TextBox txtDescription3;
		private System.Windows.Forms.TextBox txtTotal4;
		private System.Windows.Forms.TextBox txtPrice4;
		private System.Windows.Forms.TextBox txtQuantity4;
		private System.Windows.Forms.TextBox txtDescription4;
		private System.Windows.Forms.TextBox txtSubtotal;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtTaxRate;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtTax;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtGrandTotal;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnExit;
	}
}

