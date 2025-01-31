namespace CollectionTest
{
    partial class CollectionForm
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
			this.radioQueue = new System.Windows.Forms.RadioButton();
			this.radioStack = new System.Windows.Forms.RadioButton();
			this.radioSList = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.groupContent = new System.Windows.Forms.GroupBox();
			this.radioInteger = new System.Windows.Forms.RadioButton();
			this.radioObject = new System.Windows.Forms.RadioButton();
			this.radioString = new System.Windows.Forms.RadioButton();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.updItemCount = new System.Windows.Forms.NumericUpDown();
			this.txtStatus = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupContent.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.updItemCount)).BeginInit();
			this.SuspendLayout();
			// 
			// radioQueue
			// 
			this.radioQueue.AutoSize = true;
			this.radioQueue.Checked = true;
			this.radioQueue.Location = new System.Drawing.Point(23, 30);
			this.radioQueue.Name = "radioQueue";
			this.radioQueue.Size = new System.Drawing.Size(57, 17);
			this.radioQueue.TabIndex = 0;
			this.radioQueue.TabStop = true;
			this.radioQueue.Text = "&Queue";
			this.radioQueue.UseVisualStyleBackColor = true;
			// 
			// radioStack
			// 
			this.radioStack.AutoSize = true;
			this.radioStack.Location = new System.Drawing.Point(23, 68);
			this.radioStack.Name = "radioStack";
			this.radioStack.Size = new System.Drawing.Size(53, 17);
			this.radioStack.TabIndex = 1;
			this.radioStack.Text = "&Stack";
			this.radioStack.UseVisualStyleBackColor = true;
			// 
			// radioSList
			// 
			this.radioSList.AutoSize = true;
			this.radioSList.Location = new System.Drawing.Point(23, 106);
			this.radioSList.Name = "radioSList";
			this.radioSList.Size = new System.Drawing.Size(75, 17);
			this.radioSList.TabIndex = 2;
			this.radioSList.Text = "Sorted &List";
			this.radioSList.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioQueue);
			this.groupBox1.Controls.Add(this.radioSList);
			this.groupBox1.Controls.Add(this.radioStack);
			this.groupBox1.Location = new System.Drawing.Point(41, 52);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(129, 146);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Container Type";
			// 
			// groupContent
			// 
			this.groupContent.Controls.Add(this.radioInteger);
			this.groupContent.Controls.Add(this.radioObject);
			this.groupContent.Controls.Add(this.radioString);
			this.groupContent.Location = new System.Drawing.Point(194, 52);
			this.groupContent.Name = "groupContent";
			this.groupContent.Size = new System.Drawing.Size(129, 146);
			this.groupContent.TabIndex = 1;
			this.groupContent.TabStop = false;
			this.groupContent.Text = "Content Type";
			// 
			// radioInteger
			// 
			this.radioInteger.AutoSize = true;
			this.radioInteger.Checked = true;
			this.radioInteger.Location = new System.Drawing.Point(23, 30);
			this.radioInteger.Name = "radioInteger";
			this.radioInteger.Size = new System.Drawing.Size(58, 17);
			this.radioInteger.TabIndex = 0;
			this.radioInteger.TabStop = true;
			this.radioInteger.Text = "&Integer";
			this.radioInteger.UseVisualStyleBackColor = true;
			// 
			// radioObject
			// 
			this.radioObject.AutoSize = true;
			this.radioObject.Location = new System.Drawing.Point(23, 106);
			this.radioObject.Name = "radioObject";
			this.radioObject.Size = new System.Drawing.Size(56, 17);
			this.radioObject.TabIndex = 2;
			this.radioObject.Text = "&Object";
			this.radioObject.UseVisualStyleBackColor = true;
			// 
			// radioString
			// 
			this.radioString.AutoSize = true;
			this.radioString.Location = new System.Drawing.Point(23, 68);
			this.radioString.Name = "radioString";
			this.radioString.Size = new System.Drawing.Size(52, 17);
			this.radioString.TabIndex = 1;
			this.radioString.Text = "S&tring";
			this.radioString.UseVisualStyleBackColor = true;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(41, 238);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 2;
			this.btnAdd.Text = "&Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.OnAdd);
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(154, 238);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(75, 23);
			this.btnRemove.TabIndex = 3;
			this.btnRemove.Text = "&Remove";
			this.btnRemove.UseVisualStyleBackColor = true;
			this.btnRemove.Click += new System.EventHandler(this.OnRemove);
			// 
			// updItemCount
			// 
			this.updItemCount.Location = new System.Drawing.Point(267, 241);
			this.updItemCount.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
			this.updItemCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.updItemCount.Name = "updItemCount";
			this.updItemCount.ReadOnly = true;
			this.updItemCount.Size = new System.Drawing.Size(56, 20);
			this.updItemCount.TabIndex = 4;
			this.updItemCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.updItemCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// txtStatus
			// 
			this.txtStatus.AcceptsReturn = true;
			this.txtStatus.AcceptsTab = true;
			this.txtStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtStatus.Location = new System.Drawing.Point(41, 288);
			this.txtStatus.Multiline = true;
			this.txtStatus.Name = "txtStatus";
			this.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtStatus.Size = new System.Drawing.Size(282, 75);
			this.txtStatus.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(278, 222);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(35, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "&Count";
			// 
			// CollectionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(364, 381);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtStatus);
			this.Controls.Add(this.updItemCount);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.groupContent);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(380, 420);
			this.Name = "CollectionForm";
			this.Text = "Collection Test";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupContent.ResumeLayout(false);
			this.groupContent.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.updItemCount)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioQueue;
        private System.Windows.Forms.RadioButton radioStack;
        private System.Windows.Forms.RadioButton radioSList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupContent;
        private System.Windows.Forms.RadioButton radioInteger;
        private System.Windows.Forms.RadioButton radioObject;
        private System.Windows.Forms.RadioButton radioString;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.NumericUpDown updItemCount;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label1;
    }
}

