namespace pcCleaner
{
    partial class password_chk
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
            this.butchk = new System.Windows.Forms.Button();
            this.txtpass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Safetybar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "This function checking how much your password is safe";
            // 
            // butchk
            // 
            this.butchk.Location = new System.Drawing.Point(525, 97);
            this.butchk.Name = "butchk";
            this.butchk.Size = new System.Drawing.Size(108, 23);
            this.butchk.TabIndex = 1;
            this.butchk.Text = "check";
            this.butchk.UseVisualStyleBackColor = true;
            this.butchk.Click += new System.EventHandler(this.butchk_Click);
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(107, 97);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(363, 22);
            this.txtpass.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Safety N/A";
            // 
            // Safetybar
            // 
            this.Safetybar.Location = new System.Drawing.Point(304, 188);
            this.Safetybar.Name = "Safetybar";
            this.Safetybar.Size = new System.Drawing.Size(303, 23);
            this.Safetybar.TabIndex = 5;
            // 
            // password_chk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 259);
            this.Controls.Add(this.Safetybar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.butchk);
            this.Controls.Add(this.label1);
            this.Name = "password_chk";
            this.Text = "password_chk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butchk;
        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Safetybar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}