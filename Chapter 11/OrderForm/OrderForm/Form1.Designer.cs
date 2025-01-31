namespace OrderForm
{
	partial class Form1
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblFName = new System.Windows.Forms.Label();
			this.lblLName = new System.Windows.Forms.Label();
			this.btnStreet = new System.Windows.Forms.Label();
			this.lblState = new System.Windows.Forms.Label();
			this.lblCity = new System.Windows.Forms.Label();
			this.lblZIP = new System.Windows.Forms.Label();
			this.txtFName = new System.Windows.Forms.TextBox();
			this.txtLName = new System.Windows.Forms.TextBox();
			this.txtStreet = new System.Windows.Forms.TextBox();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.txtState = new System.Windows.Forms.TextBox();
			this.grpContact = new System.Windows.Forms.GroupBox();
			this.cmbZip = new System.Windows.Forms.ComboBox();
			this.lbDescription = new System.Windows.Forms.Label();
			this.lblUnit = new System.Windows.Forms.Label();
			this.lblQty = new System.Windows.Forms.Label();
			this.lblTotal = new System.Windows.Forms.Label();
			this.txtDesc1 = new System.Windows.Forms.TextBox();
			this.txtCost1 = new System.Windows.Forms.TextBox();
			this.txtQty1 = new System.Windows.Forms.TextBox();
			this.txtTotal1 = new System.Windows.Forms.TextBox();
			this.txtTotal2 = new System.Windows.Forms.TextBox();
			this.txtQty2 = new System.Windows.Forms.TextBox();
			this.txtCost2 = new System.Windows.Forms.TextBox();
			this.txtDesc2 = new System.Windows.Forms.TextBox();
			this.txtTotal3 = new System.Windows.Forms.TextBox();
			this.txtQty3 = new System.Windows.Forms.TextBox();
			this.txtCost3 = new System.Windows.Forms.TextBox();
			this.txtDesc3 = new System.Windows.Forms.TextBox();
			this.txtTotal4 = new System.Windows.Forms.TextBox();
			this.txtQty4 = new System.Windows.Forms.TextBox();
			this.txtCost4 = new System.Windows.Forms.TextBox();
			this.txtDesc4 = new System.Windows.Forms.TextBox();
			this.grpOrderItems = new System.Windows.Forms.GroupBox();
			this.txtOrderTotal = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.grpContact.SuspendLayout();
			this.grpOrderItems.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(317, 454);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.OnOK);
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(401, 454);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.OnCancel);
			// 
			// lblFName
			// 
			this.lblFName.AutoSize = true;
			this.lblFName.Location = new System.Drawing.Point(26, 32);
			this.lblFName.Name = "lblFName";
			this.lblFName.Size = new System.Drawing.Size(60, 13);
			this.lblFName.TabIndex = 0;
			this.lblFName.Text = "&First Name:";
			// 
			// lblLName
			// 
			this.lblLName.AutoSize = true;
			this.lblLName.Location = new System.Drawing.Point(25, 64);
			this.lblLName.Name = "lblLName";
			this.lblLName.Size = new System.Drawing.Size(61, 13);
			this.lblLName.TabIndex = 2;
			this.lblLName.Text = "&Last Name:";
			// 
			// btnStreet
			// 
			this.btnStreet.AutoSize = true;
			this.btnStreet.Location = new System.Drawing.Point(48, 96);
			this.btnStreet.Name = "btnStreet";
			this.btnStreet.Size = new System.Drawing.Size(38, 13);
			this.btnStreet.TabIndex = 4;
			this.btnStreet.Text = "&Street:";
			// 
			// lblState
			// 
			this.lblState.AutoSize = true;
			this.lblState.Location = new System.Drawing.Point(51, 160);
			this.lblState.Name = "lblState";
			this.lblState.Size = new System.Drawing.Size(35, 13);
			this.lblState.TabIndex = 8;
			this.lblState.Text = "&State:";
			// 
			// lblCity
			// 
			this.lblCity.AutoSize = true;
			this.lblCity.Location = new System.Drawing.Point(59, 128);
			this.lblCity.Name = "lblCity";
			this.lblCity.Size = new System.Drawing.Size(27, 13);
			this.lblCity.TabIndex = 6;
			this.lblCity.Text = "&City:";
			// 
			// lblZIP
			// 
			this.lblZIP.AutoSize = true;
			this.lblZIP.Location = new System.Drawing.Point(216, 160);
			this.lblZIP.Name = "lblZIP";
			this.lblZIP.Size = new System.Drawing.Size(27, 13);
			this.lblZIP.TabIndex = 10;
			this.lblZIP.Text = "&ZIP:";
			// 
			// txtFName
			// 
			this.txtFName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtFName.Location = new System.Drawing.Point(97, 28);
			this.txtFName.Name = "txtFName";
			this.txtFName.Size = new System.Drawing.Size(267, 20);
			this.txtFName.TabIndex = 1;
			this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
			// 
			// txtLName
			// 
			this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtLName.Location = new System.Drawing.Point(97, 60);
			this.txtLName.Name = "txtLName";
			this.txtLName.Size = new System.Drawing.Size(267, 20);
			this.txtLName.TabIndex = 3;
			this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
			// 
			// txtStreet
			// 
			this.txtStreet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStreet.Location = new System.Drawing.Point(97, 92);
			this.txtStreet.Name = "txtStreet";
			this.txtStreet.Size = new System.Drawing.Size(267, 20);
			this.txtStreet.TabIndex = 5;
			// 
			// txtCity
			// 
			this.txtCity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCity.Location = new System.Drawing.Point(97, 124);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(267, 20);
			this.txtCity.TabIndex = 7;
			// 
			// txtState
			// 
			this.txtState.Location = new System.Drawing.Point(97, 156);
			this.txtState.Name = "txtState";
			this.txtState.ReadOnly = true;
			this.txtState.Size = new System.Drawing.Size(60, 20);
			this.txtState.TabIndex = 9;
			this.txtState.Text = "FL";
			this.txtState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// grpContact
			// 
			this.grpContact.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpContact.Controls.Add(this.cmbZip);
			this.grpContact.Controls.Add(this.lblFName);
			this.grpContact.Controls.Add(this.lblLName);
			this.grpContact.Controls.Add(this.txtState);
			this.grpContact.Controls.Add(this.btnStreet);
			this.grpContact.Controls.Add(this.txtCity);
			this.grpContact.Controls.Add(this.lblState);
			this.grpContact.Controls.Add(this.txtStreet);
			this.grpContact.Controls.Add(this.lblCity);
			this.grpContact.Controls.Add(this.txtLName);
			this.grpContact.Controls.Add(this.lblZIP);
			this.grpContact.Controls.Add(this.txtFName);
			this.grpContact.Location = new System.Drawing.Point(12, 12);
			this.grpContact.Name = "grpContact";
			this.grpContact.Size = new System.Drawing.Size(397, 208);
			this.grpContact.TabIndex = 0;
			this.grpContact.TabStop = false;
			this.grpContact.Text = "Contact Information";
			// 
			// cmbZip
			// 
			this.cmbZip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbZip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbZip.FormattingEnabled = true;
			this.cmbZip.Items.AddRange(new object[] {
            "13370",
            "13371",
            "13372",
            "13375",
            "13376",
            "13376",
            "13377",
            "13378",
            "13379"});
			this.cmbZip.Location = new System.Drawing.Point(264, 156);
			this.cmbZip.Name = "cmbZip";
			this.cmbZip.Size = new System.Drawing.Size(99, 21);
			this.cmbZip.TabIndex = 11;
			this.cmbZip.SelectedIndexChanged += new System.EventHandler(this.OnZipIndexChanged);
			// 
			// lbDescription
			// 
			this.lbDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbDescription.AutoSize = true;
			this.lbDescription.Location = new System.Drawing.Point(84, 35);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(60, 13);
			this.lbDescription.TabIndex = 0;
			this.lbDescription.Text = "&Description";
			// 
			// lblUnit
			// 
			this.lblUnit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblUnit.AutoSize = true;
			this.lblUnit.Location = new System.Drawing.Point(237, 35);
			this.lblUnit.Name = "lblUnit";
			this.lblUnit.Size = new System.Drawing.Size(50, 13);
			this.lblUnit.TabIndex = 1;
			this.lblUnit.Text = "&Unit Cost";
			// 
			// lblQty
			// 
			this.lblQty.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblQty.AutoSize = true;
			this.lblQty.Location = new System.Drawing.Point(323, 35);
			this.lblQty.Name = "lblQty";
			this.lblQty.Size = new System.Drawing.Size(46, 13);
			this.lblQty.TabIndex = 2;
			this.lblQty.Text = "&Quantity";
			// 
			// lblTotal
			// 
			this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(415, 35);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(31, 13);
			this.lblTotal.TabIndex = 3;
			this.lblTotal.Text = "&Total";
			// 
			// txtDesc1
			// 
			this.txtDesc1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc1.Location = new System.Drawing.Point(14, 58);
			this.txtDesc1.Name = "txtDesc1";
			this.txtDesc1.Size = new System.Drawing.Size(198, 20);
			this.txtDesc1.TabIndex = 4;
			// 
			// txtCost1
			// 
			this.txtCost1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCost1.Location = new System.Drawing.Point(229, 58);
			this.txtCost1.Name = "txtCost1";
			this.txtCost1.Size = new System.Drawing.Size(67, 20);
			this.txtCost1.TabIndex = 5;
			this.txtCost1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtCost1.LostFocus += new System.EventHandler(this.ValidateCost);
			// 
			// txtQty1
			// 
			this.txtQty1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty1.Location = new System.Drawing.Point(313, 58);
			this.txtQty1.Name = "txtQty1";
			this.txtQty1.Size = new System.Drawing.Size(67, 20);
			this.txtQty1.TabIndex = 6;
			this.txtQty1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotal1
			// 
			this.txtTotal1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal1.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtTotal1.Location = new System.Drawing.Point(397, 58);
			this.txtTotal1.Name = "txtTotal1";
			this.txtTotal1.ReadOnly = true;
			this.txtTotal1.Size = new System.Drawing.Size(67, 20);
			this.txtTotal1.TabIndex = 7;
			this.txtTotal1.TabStop = false;
			this.txtTotal1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtTotal2
			// 
			this.txtTotal2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtTotal2.Location = new System.Drawing.Point(397, 84);
			this.txtTotal2.Name = "txtTotal2";
			this.txtTotal2.ReadOnly = true;
			this.txtTotal2.Size = new System.Drawing.Size(67, 20);
			this.txtTotal2.TabIndex = 11;
			this.txtTotal2.TabStop = false;
			this.txtTotal2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQty2
			// 
			this.txtQty2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty2.Location = new System.Drawing.Point(313, 84);
			this.txtQty2.Name = "txtQty2";
			this.txtQty2.Size = new System.Drawing.Size(67, 20);
			this.txtQty2.TabIndex = 10;
			this.txtQty2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCost2
			// 
			this.txtCost2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCost2.Location = new System.Drawing.Point(229, 84);
			this.txtCost2.Name = "txtCost2";
			this.txtCost2.Size = new System.Drawing.Size(67, 20);
			this.txtCost2.TabIndex = 9;
			this.txtCost2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDesc2
			// 
			this.txtDesc2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc2.Location = new System.Drawing.Point(14, 84);
			this.txtDesc2.Name = "txtDesc2";
			this.txtDesc2.Size = new System.Drawing.Size(198, 20);
			this.txtDesc2.TabIndex = 8;
			// 
			// txtTotal3
			// 
			this.txtTotal3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal3.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtTotal3.Location = new System.Drawing.Point(397, 110);
			this.txtTotal3.Name = "txtTotal3";
			this.txtTotal3.ReadOnly = true;
			this.txtTotal3.Size = new System.Drawing.Size(67, 20);
			this.txtTotal3.TabIndex = 15;
			this.txtTotal3.TabStop = false;
			this.txtTotal3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQty3
			// 
			this.txtQty3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty3.Location = new System.Drawing.Point(313, 110);
			this.txtQty3.Name = "txtQty3";
			this.txtQty3.Size = new System.Drawing.Size(67, 20);
			this.txtQty3.TabIndex = 14;
			this.txtQty3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCost3
			// 
			this.txtCost3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCost3.Location = new System.Drawing.Point(229, 110);
			this.txtCost3.Name = "txtCost3";
			this.txtCost3.Size = new System.Drawing.Size(67, 20);
			this.txtCost3.TabIndex = 13;
			this.txtCost3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDesc3
			// 
			this.txtDesc3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc3.Location = new System.Drawing.Point(14, 110);
			this.txtDesc3.Name = "txtDesc3";
			this.txtDesc3.Size = new System.Drawing.Size(198, 20);
			this.txtDesc3.TabIndex = 12;
			// 
			// txtTotal4
			// 
			this.txtTotal4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotal4.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtTotal4.Location = new System.Drawing.Point(397, 136);
			this.txtTotal4.Name = "txtTotal4";
			this.txtTotal4.ReadOnly = true;
			this.txtTotal4.Size = new System.Drawing.Size(67, 20);
			this.txtTotal4.TabIndex = 19;
			this.txtTotal4.TabStop = false;
			this.txtTotal4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtQty4
			// 
			this.txtQty4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtQty4.Location = new System.Drawing.Point(313, 136);
			this.txtQty4.Name = "txtQty4";
			this.txtQty4.Size = new System.Drawing.Size(67, 20);
			this.txtQty4.TabIndex = 18;
			this.txtQty4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtCost4
			// 
			this.txtCost4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCost4.Location = new System.Drawing.Point(229, 136);
			this.txtCost4.Name = "txtCost4";
			this.txtCost4.Size = new System.Drawing.Size(67, 20);
			this.txtCost4.TabIndex = 17;
			this.txtCost4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDesc4
			// 
			this.txtDesc4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDesc4.Location = new System.Drawing.Point(14, 136);
			this.txtDesc4.Name = "txtDesc4";
			this.txtDesc4.Size = new System.Drawing.Size(198, 20);
			this.txtDesc4.TabIndex = 16;
			// 
			// grpOrderItems
			// 
			this.grpOrderItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpOrderItems.Controls.Add(this.txtOrderTotal);
			this.grpOrderItems.Controls.Add(this.label1);
			this.grpOrderItems.Controls.Add(this.lbDescription);
			this.grpOrderItems.Controls.Add(this.txtTotal4);
			this.grpOrderItems.Controls.Add(this.lblUnit);
			this.grpOrderItems.Controls.Add(this.txtQty4);
			this.grpOrderItems.Controls.Add(this.lblQty);
			this.grpOrderItems.Controls.Add(this.txtCost4);
			this.grpOrderItems.Controls.Add(this.lblTotal);
			this.grpOrderItems.Controls.Add(this.txtDesc4);
			this.grpOrderItems.Controls.Add(this.txtDesc1);
			this.grpOrderItems.Controls.Add(this.txtTotal3);
			this.grpOrderItems.Controls.Add(this.txtCost1);
			this.grpOrderItems.Controls.Add(this.txtQty3);
			this.grpOrderItems.Controls.Add(this.txtQty1);
			this.grpOrderItems.Controls.Add(this.txtCost3);
			this.grpOrderItems.Controls.Add(this.txtTotal1);
			this.grpOrderItems.Controls.Add(this.txtDesc3);
			this.grpOrderItems.Controls.Add(this.txtDesc2);
			this.grpOrderItems.Controls.Add(this.txtTotal2);
			this.grpOrderItems.Controls.Add(this.txtCost2);
			this.grpOrderItems.Controls.Add(this.txtQty2);
			this.grpOrderItems.Location = new System.Drawing.Point(12, 226);
			this.grpOrderItems.Name = "grpOrderItems";
			this.grpOrderItems.Size = new System.Drawing.Size(485, 209);
			this.grpOrderItems.TabIndex = 1;
			this.grpOrderItems.TabStop = false;
			this.grpOrderItems.Text = "Order Items";
			// 
			// txtOrderTotal
			// 
			this.txtOrderTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOrderTotal.BackColor = System.Drawing.SystemColors.ControlLight;
			this.txtOrderTotal.Location = new System.Drawing.Point(397, 175);
			this.txtOrderTotal.Name = "txtOrderTotal";
			this.txtOrderTotal.ReadOnly = true;
			this.txtOrderTotal.Size = new System.Drawing.Size(67, 20);
			this.txtOrderTotal.TabIndex = 21;
			this.txtOrderTotal.TabStop = false;
			this.txtOrderTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(323, 179);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 20;
			this.label1.Text = "Order Total:";
			// 
			// Form1
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(519, 497);
			this.Controls.Add(this.grpOrderItems);
			this.Controls.Add(this.grpContact);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.MinimumSize = new System.Drawing.Size(535, 500);
			this.Name = "Form1";
			this.Text = "New Order";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.grpContact.ResumeLayout(false);
			this.grpContact.PerformLayout();
			this.grpOrderItems.ResumeLayout(false);
			this.grpOrderItems.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label lblFName;
		private System.Windows.Forms.Label lblLName;
		private System.Windows.Forms.Label btnStreet;
		private System.Windows.Forms.Label lblState;
		private System.Windows.Forms.Label lblCity;
		private System.Windows.Forms.Label lblZIP;
		private System.Windows.Forms.TextBox txtFName;
		private System.Windows.Forms.TextBox txtLName;
		private System.Windows.Forms.TextBox txtStreet;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.TextBox txtState;
		private System.Windows.Forms.GroupBox grpContact;
		private System.Windows.Forms.Label lbDescription;
		private System.Windows.Forms.Label lblUnit;
		private System.Windows.Forms.Label lblQty;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.TextBox txtDesc1;
		private System.Windows.Forms.TextBox txtCost1;
		private System.Windows.Forms.TextBox txtQty1;
		private System.Windows.Forms.TextBox txtTotal1;
		private System.Windows.Forms.TextBox txtTotal2;
		private System.Windows.Forms.TextBox txtQty2;
		private System.Windows.Forms.TextBox txtCost2;
		private System.Windows.Forms.TextBox txtDesc2;
		private System.Windows.Forms.TextBox txtTotal3;
		private System.Windows.Forms.TextBox txtQty3;
		private System.Windows.Forms.TextBox txtCost3;
		private System.Windows.Forms.TextBox txtDesc3;
		private System.Windows.Forms.TextBox txtTotal4;
		private System.Windows.Forms.TextBox txtQty4;
		private System.Windows.Forms.TextBox txtCost4;
		private System.Windows.Forms.TextBox txtDesc4;
		private System.Windows.Forms.GroupBox grpOrderItems;
		private System.Windows.Forms.ComboBox cmbZip;
		private System.Windows.Forms.TextBox txtOrderTotal;
		private System.Windows.Forms.Label label1;
	}
}

