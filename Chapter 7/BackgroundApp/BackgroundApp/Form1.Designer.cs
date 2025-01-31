namespace BackgroundApp
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
            this.btnStartOrCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStartOrCancel
            // 
            this.btnStartOrCancel.Location = new System.Drawing.Point(61, 96);
            this.btnStartOrCancel.Name = "btnStartOrCancel";
            this.btnStartOrCancel.Size = new System.Drawing.Size(103, 37);
            this.btnStartOrCancel.TabIndex = 0;
            this.btnStartOrCancel.Text = "St&art";
            this.btnStartOrCancel.UseVisualStyleBackColor = true;
            this.btnStartOrCancel.Click += new System.EventHandler(this.OnStartOrCancel);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Thread Status:";
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(198, 176);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(393, 26);
            this.txtStatus.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 287);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStartOrCancel);
            this.Name = "Form1";
            this.Text = "Background Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStartOrCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStatus;
    }
}

