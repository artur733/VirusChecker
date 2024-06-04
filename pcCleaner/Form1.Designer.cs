namespace pcCleaner
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.BTNScan = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.browseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passwordCheckerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.safeunzipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.featuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.protegent = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.serialPort2 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFilePath
            // 
            resources.ApplyResources(this.tbFilePath, "tbFilePath");
            this.tbFilePath.Name = "tbFilePath";
            // 
            // tbMD5
            // 
            resources.ApplyResources(this.tbMD5, "tbMD5");
            this.tbMD5.Name = "tbMD5";
            // 
            // BTNScan
            // 
            resources.ApplyResources(this.BTNScan, "BTNScan");
            this.BTNScan.Name = "BTNScan";
            this.BTNScan.UseVisualStyleBackColor = true;
            this.BTNScan.Click += new System.EventHandler(this.BTNScan_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lblstatus
            // 
            resources.ApplyResources(this.lblstatus, "lblstatus");
            this.lblstatus.Name = "lblstatus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.featuresToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.browseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // browseToolStripMenuItem
            // 
            this.browseToolStripMenuItem.Name = "browseToolStripMenuItem";
            resources.ApplyResources(this.browseToolStripMenuItem, "browseToolStripMenuItem");
            this.browseToolStripMenuItem.Click += new System.EventHandler(this.browseToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.passwordCheckerToolStripMenuItem,
            this.safeunzipToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            // 
            // passwordCheckerToolStripMenuItem
            // 
            this.passwordCheckerToolStripMenuItem.Name = "passwordCheckerToolStripMenuItem";
            resources.ApplyResources(this.passwordCheckerToolStripMenuItem, "passwordCheckerToolStripMenuItem");
            this.passwordCheckerToolStripMenuItem.Click += new System.EventHandler(this.passwordCheckerToolStripMenuItem_Click_1);
            // 
            // safeunzipToolStripMenuItem
            // 
            this.safeunzipToolStripMenuItem.Name = "safeunzipToolStripMenuItem";
            resources.ApplyResources(this.safeunzipToolStripMenuItem, "safeunzipToolStripMenuItem");
            this.safeunzipToolStripMenuItem.Click += new System.EventHandler(this.safeunzipToolStripMenuItem_Click);
            // 
            // featuresToolStripMenuItem
            // 
            this.featuresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.extensionToolStripMenuItem});
            this.featuresToolStripMenuItem.Name = "featuresToolStripMenuItem";
            resources.ApplyResources(this.featuresToolStripMenuItem, "featuresToolStripMenuItem");
            // 
            // extensionToolStripMenuItem
            // 
            this.extensionToolStripMenuItem.Name = "extensionToolStripMenuItem";
            resources.ApplyResources(this.extensionToolStripMenuItem, "extensionToolStripMenuItem");
            this.extensionToolStripMenuItem.Click += new System.EventHandler(this.extensionToolStripMenuItem_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // protegent
            // 
            resources.ApplyResources(this.protegent, "protegent");
            this.protegent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.protegent.Name = "protegent";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pcCleaner.Properties.Resources.warning;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.protegent);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNScan);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.tbFilePath);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.Button BTNScan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem browseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem passwordCheckerToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem safeunzipToolStripMenuItem;
        private System.Windows.Forms.Label protegent;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripMenuItem featuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extensionToolStripMenuItem;
        private System.IO.Ports.SerialPort serialPort2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

