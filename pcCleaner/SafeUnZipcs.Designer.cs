namespace pcCleaner
{
    partial class SafeUnZipcs
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnbrowse = new System.Windows.Forms.Button();
            this.Filepath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(135, 263);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(513, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(654, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "SafeUnZip";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnbrowse
            // 
            this.btnbrowse.Location = new System.Drawing.Point(12, 248);
            this.btnbrowse.Name = "btnbrowse";
            this.btnbrowse.Size = new System.Drawing.Size(117, 50);
            this.btnbrowse.TabIndex = 2;
            this.btnbrowse.Text = "Select file";
            this.btnbrowse.UseVisualStyleBackColor = true;
            this.btnbrowse.Click += new System.EventHandler(this.btnbrowse_Click);
            // 
            // Filepath
            // 
            this.Filepath.Location = new System.Drawing.Point(135, 235);
            this.Filepath.Name = "Filepath";
            this.Filepath.Size = new System.Drawing.Size(442, 22);
            this.Filepath.TabIndex = 3;
            // 
            // SafeUnZipcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Filepath);
            this.Controls.Add(this.btnbrowse);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.progressBar1);
            this.Name = "SafeUnZipcs";
            this.Text = "SafeUnZipcs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnbrowse;
        private System.Windows.Forms.TextBox Filepath;
    }
}