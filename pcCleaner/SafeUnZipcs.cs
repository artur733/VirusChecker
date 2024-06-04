using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace pcCleaner
{
    public partial class SafeUnZipcs : Form
    {
        public SafeUnZipcs()
        {
            InitializeComponent();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All | *.zip";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                var zippath = ofd.FileName;
                if (Directory.Exists(@"C:\cleaner"))
                {
                    
                }
                else
                {
                    Directory.CreateDirectory(@"C:\cleaner");
                }

            }
        }
    }
}
