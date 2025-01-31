namespace ParallelLibApp
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
			this.btnSyncronous = new System.Windows.Forms.Button();
			this.btnParallel = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTime = new System.Windows.Forms.TextBox();
			this.txtResults = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnContinue = new System.Windows.Forms.Button();
			this.grpTasks = new System.Windows.Forms.GroupBox();
			this.btnBackground = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.txtAvailable = new System.Windows.Forms.TextBox();
			this.txtActive = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnThreads = new System.Windows.Forms.Button();
			this.grpTasks.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnSyncronous
			// 
			this.btnSyncronous.Location = new System.Drawing.Point(30, 30);
			this.btnSyncronous.Name = "btnSyncronous";
			this.btnSyncronous.Size = new System.Drawing.Size(89, 23);
			this.btnSyncronous.TabIndex = 1;
			this.btnSyncronous.Text = "&Synchronous";
			this.btnSyncronous.UseVisualStyleBackColor = true;
			this.btnSyncronous.Click += new System.EventHandler(this.OnSynchronous);
			// 
			// btnParallel
			// 
			this.btnParallel.Location = new System.Drawing.Point(10, 27);
			this.btnParallel.Name = "btnParallel";
			this.btnParallel.Size = new System.Drawing.Size(89, 23);
			this.btnParallel.TabIndex = 2;
			this.btnParallel.Text = "&Parallel";
			this.btnParallel.UseVisualStyleBackColor = true;
			this.btnParallel.Click += new System.EventHandler(this.OnParallel);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "&Elapsed Time:";
			// 
			// txtTime
			// 
			this.txtTime.Location = new System.Drawing.Point(96, 69);
			this.txtTime.Name = "txtTime";
			this.txtTime.ReadOnly = true;
			this.txtTime.Size = new System.Drawing.Size(100, 20);
			this.txtTime.TabIndex = 4;
			this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtResults
			// 
			this.txtResults.Location = new System.Drawing.Point(96, 103);
			this.txtResults.Name = "txtResults";
			this.txtResults.ReadOnly = true;
			this.txtResults.Size = new System.Drawing.Size(100, 20);
			this.txtResults.TabIndex = 6;
			this.txtResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "&Results:";
			// 
			// btnContinue
			// 
			this.btnContinue.Location = new System.Drawing.Point(116, 27);
			this.btnContinue.Name = "btnContinue";
			this.btnContinue.Size = new System.Drawing.Size(89, 23);
			this.btnContinue.TabIndex = 6;
			this.btnContinue.Text = "&Continue";
			this.btnContinue.UseVisualStyleBackColor = true;
			this.btnContinue.Click += new System.EventHandler(this.OnContinue);
			// 
			// grpTasks
			// 
			this.grpTasks.Controls.Add(this.txtActive);
			this.grpTasks.Controls.Add(this.label4);
			this.grpTasks.Controls.Add(this.btnParallel);
			this.grpTasks.Controls.Add(this.txtAvailable);
			this.grpTasks.Controls.Add(this.btnBackground);
			this.grpTasks.Controls.Add(this.label3);
			this.grpTasks.Controls.Add(this.btnContinue);
			this.grpTasks.Controls.Add(this.txtResults);
			this.grpTasks.Controls.Add(this.label1);
			this.grpTasks.Controls.Add(this.label2);
			this.grpTasks.Controls.Add(this.txtTime);
			this.grpTasks.Location = new System.Drawing.Point(21, 72);
			this.grpTasks.Name = "grpTasks";
			this.grpTasks.Size = new System.Drawing.Size(338, 210);
			this.grpTasks.TabIndex = 0;
			this.grpTasks.TabStop = false;
			this.grpTasks.Text = "Thread Pool";
			// 
			// btnBackground
			// 
			this.btnBackground.Location = new System.Drawing.Point(220, 27);
			this.btnBackground.Name = "btnBackground";
			this.btnBackground.Size = new System.Drawing.Size(89, 23);
			this.btnBackground.TabIndex = 7;
			this.btnBackground.Text = "&BackGround";
			this.btnBackground.UseVisualStyleBackColor = true;
			this.btnBackground.Click += new System.EventHandler(this.OnBackGround);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(7, 146);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(131, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "&Available Pooled Threads:";
			// 
			// txtAvailable
			// 
			this.txtAvailable.Location = new System.Drawing.Point(144, 143);
			this.txtAvailable.Name = "txtAvailable";
			this.txtAvailable.ReadOnly = true;
			this.txtAvailable.Size = new System.Drawing.Size(52, 20);
			this.txtAvailable.TabIndex = 9;
			this.txtAvailable.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// txtActive
			// 
			this.txtActive.Location = new System.Drawing.Point(144, 169);
			this.txtActive.Name = "txtActive";
			this.txtActive.ReadOnly = true;
			this.txtActive.Size = new System.Drawing.Size(52, 20);
			this.txtActive.TabIndex = 11;
			this.txtActive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 172);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(118, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Active Pooled &Threads:";
			// 
			// btnThreads
			// 
			this.btnThreads.Location = new System.Drawing.Point(381, 99);
			this.btnThreads.Name = "btnThreads";
			this.btnThreads.Size = new System.Drawing.Size(89, 23);
			this.btnThreads.TabIndex = 2;
			this.btnThreads.Text = "&Threads";
			this.btnThreads.UseVisualStyleBackColor = true;
			this.btnThreads.Click += new System.EventHandler(this.OnThreads);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 333);
			this.Controls.Add(this.btnThreads);
			this.Controls.Add(this.btnSyncronous);
			this.Controls.Add(this.grpTasks);
			this.Name = "Form1";
			this.Text = "Parallel Library";
			this.grpTasks.ResumeLayout(false);
			this.grpTasks.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSyncronous;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnContinue;
		private System.Windows.Forms.GroupBox grpTasks;
		private System.Windows.Forms.Button btnBackground;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtAvailable;
		private System.Windows.Forms.TextBox txtActive;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnThreads;
	}
}

