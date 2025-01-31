namespace Threads
{
    partial class ThreadingForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtForeGround = new System.Windows.Forms.TextBox();
            this.txtBkGround = new System.Windows.Forms.TextBox();
            this.btnJoin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWaiting = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPooledActive = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPooledAvail = new System.Windows.Forms.TextBox();
            this.btnPoolStart = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPooledWaiting = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnStart.Location = new System.Drawing.Point(34, 39);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(103, 29);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.OnStart);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 94);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Active Foreground Threads:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Active Background Threads:";
            // 
            // txtForeGround
            // 
            this.txtForeGround.Location = new System.Drawing.Point(185, 92);
            this.txtForeGround.Margin = new System.Windows.Forms.Padding(2);
            this.txtForeGround.Name = "txtForeGround";
            this.txtForeGround.ReadOnly = true;
            this.txtForeGround.Size = new System.Drawing.Size(68, 20);
            this.txtForeGround.TabIndex = 5;
            this.txtForeGround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBkGround
            // 
            this.txtBkGround.Location = new System.Drawing.Point(185, 118);
            this.txtBkGround.Margin = new System.Windows.Forms.Padding(2);
            this.txtBkGround.Name = "txtBkGround";
            this.txtBkGround.ReadOnly = true;
            this.txtBkGround.Size = new System.Drawing.Size(68, 20);
            this.txtBkGround.TabIndex = 6;
            this.txtBkGround.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnJoin
            // 
            this.btnJoin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnJoin.Location = new System.Drawing.Point(149, 39);
            this.btnJoin.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(103, 29);
            this.btnJoin.TabIndex = 7;
            this.btnJoin.Text = "Sto&p";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.OnJoinAndExit);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 162);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 8;
            // 
            // txtWaiting
            // 
            this.txtWaiting.Location = new System.Drawing.Point(34, 157);
            this.txtWaiting.Margin = new System.Windows.Forms.Padding(2);
            this.txtWaiting.Name = "txtWaiting";
            this.txtWaiting.ReadOnly = true;
            this.txtWaiting.Size = new System.Drawing.Size(219, 20);
            this.txtWaiting.TabIndex = 9;
            this.txtWaiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(34, 190);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(219, 20);
            this.txtStatus.TabIndex = 10;
            this.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(263, 231);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thread Basics";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPooledWaiting);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.txtPooledActive);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPooledAvail);
            this.groupBox2.Controls.Add(this.btnPoolStart);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(294, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(267, 227);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thread Pool";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(127, 27);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 29);
            this.button1.TabIndex = 17;
            this.button1.Text = "Sta&tus";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnStatus);
            // 
            // txtPooledActive
            // 
            this.txtPooledActive.Location = new System.Drawing.Point(162, 103);
            this.txtPooledActive.Margin = new System.Windows.Forms.Padding(2);
            this.txtPooledActive.Name = "txtPooledActive";
            this.txtPooledActive.ReadOnly = true;
            this.txtPooledActive.Size = new System.Drawing.Size(68, 20);
            this.txtPooledActive.TabIndex = 16;
            this.txtPooledActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Active Pooled Threads:";
            // 
            // txtPooledAvail
            // 
            this.txtPooledAvail.Location = new System.Drawing.Point(162, 79);
            this.txtPooledAvail.Margin = new System.Windows.Forms.Padding(2);
            this.txtPooledAvail.Name = "txtPooledAvail";
            this.txtPooledAvail.ReadOnly = true;
            this.txtPooledAvail.Size = new System.Drawing.Size(68, 20);
            this.txtPooledAvail.TabIndex = 14;
            this.txtPooledAvail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPoolStart
            // 
            this.btnPoolStart.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPoolStart.Location = new System.Drawing.Point(14, 27);
            this.btnPoolStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnPoolStart.Name = "btnPoolStart";
            this.btnPoolStart.Size = new System.Drawing.Size(103, 29);
            this.btnPoolStart.TabIndex = 13;
            this.btnPoolStart.Text = "&Start";
            this.btnPoolStart.UseVisualStyleBackColor = true;
            this.btnPoolStart.Click += new System.EventHandler(this.OnStartThreadPool);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Available Pooled Threads:";
            // 
            // txtPooledWaiting
            // 
            this.txtPooledWaiting.Location = new System.Drawing.Point(162, 127);
            this.txtPooledWaiting.Margin = new System.Windows.Forms.Padding(2);
            this.txtPooledWaiting.Name = "txtPooledWaiting";
            this.txtPooledWaiting.ReadOnly = true;
            this.txtPooledWaiting.Size = new System.Drawing.Size(68, 20);
            this.txtPooledWaiting.TabIndex = 19;
            this.txtPooledWaiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 131);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Waiting Pooled Threads:";
            // 
            // ThreadingForm
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnJoin;
            this.ClientSize = new System.Drawing.Size(614, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtWaiting);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.txtBkGround);
            this.Controls.Add(this.txtForeGround);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(305, 257);
            this.Name = "ThreadingForm";
            this.Text = "Threading Form";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtForeGround;
        private System.Windows.Forms.TextBox txtBkGround;
        private System.Windows.Forms.Button btnJoin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWaiting;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPooledActive;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPooledAvail;
        private System.Windows.Forms.Button btnPoolStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtPooledWaiting;
        private System.Windows.Forms.Label label6;
    }
}

