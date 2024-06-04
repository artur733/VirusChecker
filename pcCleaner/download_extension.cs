using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pcCleaner
{
    public partial class download_extension : Form
    {
        public static int pakiet = 000;
        public download_extension()
        {
            InitializeComponent();
            if (File.Exists("hashdata"))
            {
                string[] pinstalled = File.ReadAllLines("hashdata");
                if (pinstalled.Contains("1ext"))
                {
                    button1.Enabled = false;
                }
                if (pinstalled.Contains("2ext"))
                {
                    button2.Enabled = false;
                }
                if (pinstalled.Contains("3ext"))
                {
                    button3.Enabled = false;
                }
                if (pinstalled.Contains("4ext"))
                {
                    button4.Enabled = false;
                }
                if (pinstalled.Contains("custom"))
                {
                    MessageBox.Show("Initalizing custom components...", "Pccleaner mods tool", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                File.Create("hashdata");
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            button1.Enabled = false;
            pakiet = 1;
            Thread download = new Thread(dwnl);
            download.Start();
            progressD.Maximum = 190;
            downloadtimer.Start();
        }

        public static async void dwnl()
        {
            
            IWebProxy defWebProxy = WebRequest.DefaultWebProxy;
            File.Delete("MD5Basetest.txt");
            defWebProxy.Credentials = CredentialCache.DefaultCredentials;
            var c = new WebClient { Proxy = defWebProxy };
            c.Headers.Add("User-agent", "Mozilla/4.0 ");
            switch (pakiet)
            {
                case 1: // pakiet 5-9
                    string url1 = "https://virusshare.com/hashfiles/VirusShare_00005.md5";
                    string url2 = "https://virusshare.com/hashfiles/VirusShare_00006.md5";
                    string url3 = "https://virusshare.com/hashfiles/VirusShare_00007.md5";
                    string url4 = "https://virusshare.com/hashfiles/VirusShare_00008.md5";
                    string url5 = "https://virusshare.com/hashfiles/VirusShare_00009.md5";
                    // Tutaj umieść wywołanie metody DownloadFileAsync
                    c.DownloadFileAsync(new Uri(url1), "MD5Basetest.txt"); // pierwsza lista

                    Thread.Sleep(15000);
                    c.DownloadFileAsync(new Uri(url2), "MD5BaseSTM.txt"); // druga lista
                    Thread.Sleep(35000);

                    string[] a = File.ReadAllLines("MD5Basetest.txt");
                    string[] b = File.ReadAllLines("MD5BaseSTM.txt");
                    string[] combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url3), "MD5BaseSTM.txt"); // trzecia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url4), "MD5BaseSTM.txt"); // czwarta lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // PIĄTA lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // ostatnia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    string[] hashinput = { "1ext" };
                    string[] hashout = File.ReadAllLines("hashdata");
                    combined = new string[hashinput.Length + hashout.Length];
                    Array.Copy(hashout, combined, hashout.Length);
                    Array.Copy(hashinput, 0, combined, hashout.Length, hashinput.Length);
                    File.WriteAllLines("hashdata", combined);
                    a = File.ReadAllLines("MD5Base.txt");
                    b = File.ReadAllLines("MD5Basetest.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    //File.Copy("MD5Base.txt", "KopiaMD5.txt");
                    File.Delete("MD5Base.txt");
                    File.WriteAllLines("MD5Base.txt", combined);
                    MessageBox.Show("Your updated virus database is initalized. Please restart your computer");
                    break;
                case 2:

                    url1 = "https://virusshare.com/hashfiles/VirusShare_00010.md5";
                    url2 = "https://virusshare.com/hashfiles/VirusShare_00011.md5";
                    url3 = "https://virusshare.com/hashfiles/VirusShare_00012.md5";
                    url4 = "https://virusshare.com/hashfiles/VirusShare_00013.md5";
                    url5 = "https://virusshare.com/hashfiles/VirusShare_00014.md5";
                    // Tutaj umieść wywołanie metody DownloadFileAsync
                    c.DownloadFileAsync(new Uri(url1), "MD5Basetest.txt"); // pierwsza lista

                    Thread.Sleep(15000);
                    c.DownloadFileAsync(new Uri(url2), "MD5BaseSTM.txt"); // druga lista
                    Thread.Sleep(35000);

                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url3), "MD5BaseSTM.txt"); // trzecia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url4), "MD5BaseSTM.txt"); // czwarta lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // PIĄTA lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // ostatnia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    string[] hashinput2 = { "2ext" };
                    hashout = File.ReadAllLines("hashdata");
                    combined = new string[hashinput2.Length + hashout.Length];
                    Array.Copy(hashout, combined, hashout.Length);
                    Array.Copy(hashinput2, 0, combined, hashout.Length, hashinput2.Length);
                    File.WriteAllLines("hashdata", combined);
                    a = File.ReadAllLines("MD5Base.txt");
                    b = File.ReadAllLines("MD5Basetest.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    //File.Copy("MD5Base.txt", "KopiaMD5.txt");
                    File.Delete("MD5Base.txt");
                    File.WriteAllLines("MD5Base.txt", combined);
                    MessageBox.Show("Your updated virus database is initalized. Please restart your computer");
                    break;
                case 3: // instalacja trzeciej listy
                    url1 = "https://virusshare.com/hashfiles/VirusShare_00015.md5";
                    url2 = "https://virusshare.com/hashfiles/VirusShare_00016.md5";
                    url3 = "https://virusshare.com/hashfiles/VirusShare_00017.md5";
                    url4 = "https://virusshare.com/hashfiles/VirusShare_00018.md5";
                    url5 = "https://virusshare.com/hashfiles/VirusShare_00019.md5";
                    // Tutaj umieść wywołanie metody DownloadFileAsync
                    c.DownloadFileAsync(new Uri(url1), "MD5Basetest.txt"); // pierwsza lista

                    Thread.Sleep(15000);
                    c.DownloadFileAsync(new Uri(url2), "MD5BaseSTM.txt"); // druga lista
                    Thread.Sleep(35000);

                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url3), "MD5BaseSTM.txt"); // trzecia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url4), "MD5BaseSTM.txt"); // czwarta lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // PIĄTA lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // ostatnia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    string[] hashinput3 = { "2ext" };
                    hashout = File.ReadAllLines("hashdata");
                    combined = new string[hashinput3.Length + hashout.Length];
                    Array.Copy(hashout, combined, hashout.Length);
                    Array.Copy(hashinput3, 0, combined, hashout.Length, hashinput3.Length);
                    File.WriteAllLines("hashdata", combined);
                    a = File.ReadAllLines("MD5Base.txt");
                    b = File.ReadAllLines("MD5Basetest.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    //File.Copy("MD5Base.txt", "KopiaMD5.txt");
                    File.Delete("MD5Base.txt");
                    File.WriteAllLines("MD5Base.txt", combined);
                    MessageBox.Show("Your updated virus database is initalized. Please restart your computer");
                    break;
                case 4:
                    url1 = "https://virusshare.com/hashfiles/VirusShare_00020.md5";
                    url2 = "https://virusshare.com/hashfiles/VirusShare_00021.md5";
                    url3 = "https://virusshare.com/hashfiles/VirusShare_00022.md5";
                    url4 = "https://virusshare.com/hashfiles/VirusShare_00023.md5";
                    url5 = "https://virusshare.com/hashfiles/VirusShare_00024.md5";
                    // Tutaj umieść wywołanie metody DownloadFileAsync
                    c.DownloadFileAsync(new Uri(url1), "MD5Basetest.txt"); // pierwsza lista

                    Thread.Sleep(15000);
                    c.DownloadFileAsync(new Uri(url2), "MD5BaseSTM.txt"); // druga lista
                    Thread.Sleep(35000);

                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url3), "MD5BaseSTM.txt"); // trzecia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url4), "MD5BaseSTM.txt"); // czwarta lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // PIĄTA lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    c.DownloadFileAsync(new Uri(url5), "MD5BaseSTM.txt"); // ostatnia lista
                    Thread.Sleep(35000);
                    a = File.ReadAllLines("MD5Basetest.txt");
                    b = File.ReadAllLines("MD5BaseSTM.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    File.WriteAllLines("MD5Basetest.txt", combined);
                    string[] hashinput4 = { "2ext" };
                    hashout = File.ReadAllLines("hashdata");
                    combined = new string[hashinput4.Length + hashout.Length];
                    Array.Copy(hashout, combined, hashout.Length);
                    Array.Copy(hashinput4, 0, combined, hashout.Length, hashinput4.Length);
                    File.WriteAllLines("hashdata", combined);
                    a = File.ReadAllLines("MD5Base.txt");
                    b = File.ReadAllLines("MD5Basetest.txt");
                    combined = new string[a.Length + b.Length];
                    Array.Copy(a, combined, a.Length);
                    Array.Copy(b, 0, combined, a.Length, b.Length);
                    //File.Copy("MD5Base.txt", "KopiaMD5.txt");
                    File.Delete("MD5Base.txt");
                    File.WriteAllLines("MD5Base.txt", combined);
                    MessageBox.Show("Your updated virus database is initalized. Please restart your computer");
                    break;

                
            }   
        }

        private void downloadtimer_Tick(object sender, EventArgs e)
        {
            try
            {
                progressD.Value = progressD.Value + 1;
                if (progressD.Value > 189)
                {
                    MessageBox.Show("Downloaded, please wait 2 minutes to initalize new database.");
                    progressD.Value = 0;
                    downloadtimer.Stop();
                    pictureBox1.Visible = false;


                }
            }
            catch (ArgumentOutOfRangeException)
            {
                downloadtimer.Stop();
                pictureBox1.Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            button2.Enabled = false;
            pakiet = 2;
            Thread download = new Thread(dwnl);
            download.Start();
            progressD.Maximum = 190;
            downloadtimer.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            pakiet = 3;
            Thread download = new Thread(dwnl);
            download.Start();
            progressD.Maximum = 190;
            downloadtimer.Start();
            pictureBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            pakiet = 4;
            Thread download = new Thread(dwnl);
            download.Start();
            progressD.Maximum = 190;
            downloadtimer.Start();
            pictureBox1.Visible = true;
        }
        
    }
}
