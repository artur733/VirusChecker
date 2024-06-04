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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Threading;

namespace pcCleaner
{
    public partial class password_chk : Form
    {
        static char[] Match =            {'0','1','2','3','4','5','6','7','8','9','a','b','c','d','e','f','g','h','i','j' ,'k','l','m','n','o','p',
                        'q','r','s','t','u','v','w','x','y','z','A','B','C','D','E','F','G','H','I','J','C','L','M','N','O','P',
                        'Q','R','S','T','U','V','X','Y','Z','!','?',' ','*','-','+'};

        static string FindPassword;
        static int Combi;
        static string space;
        static int Characters;
        public password_chk()
        {
            InitializeComponent();
        }

        private async void butchk_Click(object sender, EventArgs e)
        {

            var safety = 0;
            var unsafepass = File.ReadAllLines("ListaUnSafe.txt");
            if (txtpass.Text.Length > 8)
            {
                safety += 2;
            }
            if (txtpass.Text.Length > 14)
            {
                safety += 2;
            }
            if (txtpass.Text.Contains("!"))
            {
                safety += 1;
            }
            if (unsafepass.Contains(txtpass.Text))
            {
                safety = 0;
            }
            Safetybar.Maximum = 5;
            Safetybar.Value = safety;
            label2.Text = safety.ToString();
            
            

        }

        
    }
}
