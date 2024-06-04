using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tulpep.NotificationWindow;
using System.Media;
using System.Threading;
using System.IO.Compression;
using System.Security.Permissions;
using System.Diagnostics;
using System.Security;
using System.Net;
using System.Net.NetworkInformation;

namespace pcCleaner
{
    public partial class Form1 : Form
    {
        Thread RTprot = new Thread(RTP); //{ IsBackground = true };
        
        Thread ucheck = new Thread(updatecheck);
        public static string userName = System.Environment.UserName;
        public static bool online = false;
        public static string version = "BASE-01";
        public Form1()
        {
            InitializeComponent();
            if(MessageBox.Show("Do you want to update your virus database?","pccleaner",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Checking...");
                ucheck.Start();
            }
            else
            {
                MessageBox.Show("Okay. Remember , if you don't update virus database your real time protection is disabled");
                button1.Enabled = false;
                protegent.Text = "RTP is not enabled";
            }
            

        }

        public static string GetMD5FromFIle(string filepath)
        {
            using (var md5 = MD5.Create())
            {
                try
                {
                    using (var stream = File.OpenRead(filepath))
                    {
                        return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty).ToLower();
                    }
                }
                catch (IOException)
                {
                    return "IOException";
                }
                catch (UnauthorizedAccessException)
                {
                    PopupNotifier popup = new PopupNotifier();
                    popup.Image = Properties.Resources.imageVirus;
                    popup.TitleText = "Exception";
                    popup.ContentText = "Real time protection run into error your PC is not protected";
                    popup.TitleColor = Color.Red;
                    popup.Popup();
                    MessageBox.Show("UnauthorizedAccessException", "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return "UAException";
                }
            }
        }



        private async void BTNScan_Click(object sender, EventArgs e)
        {
            if(online = false)
            {
                MessageBox.Show("Update avalibe");
            }
            SoundPlayer playersoundvirus = new SoundPlayer(Properties.Resources.virus_det);
            var md5signatures = File.ReadAllLines("MD5Base.txt");
            if (md5signatures.Contains(tbMD5.Text))
            {
                lblstatus.Text = "Infected!";

                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.imageVirus;
                popup.TitleText = "VIRUS DETECTED!";
                popup.ContentText = "File that you scaned have a virus! ID: " + tbMD5.Text;
                popup.TitleColor = Color.Red;
                playersoundvirus.Play();
                popup.Popup();
                MessageBox.Show("This file is infected. Delete it now!", "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            else
            {
                lblstatus.Text = "No viruses detected";
                MessageBox.Show("This file has not a virus", "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if ("d41d8cd98f00b204e9800998ecf8427e---" == tbMD5.Text)
            {
                lblstatus.Text = "Infected!";
                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.imageVirus;
                popup.TitleText = "VIRUS DETECTED!";
                popup.ContentText = "File that you scaned have a virus! ID: " + "debug file";
                popup.TitleColor = Color.Red;
                playersoundvirus.Play();
                popup.Popup();
                MessageBox.Show("This file is infected. Delete it now!", "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void browseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All | *.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbMD5.Text = GetMD5FromFIle(ofd.FileName);
            }
        }

        private void passwordCheckerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var Form2 = new password_chk();
            lblstatus.Text = "Password N.A";
            Form2.Activate();
        }

        private void passwordCheckerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var Form2 = new password_chk();
            lblstatus.Text = "Password N.A";
            Form2.Activate();
            Form2.Show();
        }
        public async static void RTP()
        {
            try
            {
                DirectoryInfo drive = new DirectoryInfo(@"C:\");
                DirectoryInfo users = new DirectoryInfo(@"C:\Users\" + userName);
                FileInfo[] files = users.GetFiles();
                DirectoryInfo[] dirs = users.GetDirectories();
                Queue<string> toscan = new Queue<string>();
                var path = "tester.txt";
                string md5 = "0";
                md5 = Form1.GetMD5FromFIle(path);
                StreamReader reader = new StreamReader(path);
                SoundPlayer playersoundvirus = new SoundPlayer(Properties.Resources.virus_det);
                var signatures = File.ReadAllLines("MD5Base.txt");
                while (true)
                {
                    files = users.GetFiles();
                    Thread.Sleep(250);
                    foreach (FileInfo f in files)
                    {
                        Thread.Sleep(100);
                        path = f.FullName;
                        md5 = Form1.GetMD5FromFIle(path);
                        if (signatures.Contains(md5))
                        {

                            
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.imageVirus;
                            popup.TitleText = "VIRUS DETECTED!";
                            popup.ContentText = "Real time protection detected a virus in path: " + path;
                            popup.TitleColor = Color.Red;
                            popup.Popup();
                            playersoundvirus.Play();
                            MessageBox.Show("This file is infected. Delete it now! : " + path, "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            popup.Popup();
                            break;



                        }

                    }
                    foreach (DirectoryInfo d in dirs) // skan wszystkich folderow
                    {

                        Thread.Sleep(100);

                        FileInfo[] dfiles = d.GetFiles();
                        DirectoryInfo[] d2 = d.GetDirectories();
                        foreach (DirectoryInfo dir in d2) // skan folderów na drugim levelu
                        {
                            FileInfo[] f2 = dir.GetFiles();
                            Thread.Sleep(100);
                            foreach (FileInfo f in f2)
                            {
                                Thread.Sleep(100);
                                path = f.FullName;
                                md5 = Form1.GetMD5FromFIle(path);
                                if (signatures.Contains(md5))
                                {


                                    PopupNotifier popup = new PopupNotifier();
                                    popup.Image = Properties.Resources.imageVirus;
                                    popup.TitleText = "VIRUS DETECTED!";
                                    popup.ContentText = "Real time protection detected a virus in path: " + path;
                                    popup.TitleColor = Color.Red;
                                    popup.Popup();
                                    playersoundvirus.Play();
                                    MessageBox.Show("This file is infected. Delete it now! : " + path, "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    popup.Popup();
                                    break;



                                }
                            }
                        }
                        foreach (FileInfo f in dfiles)
                        {
                            Thread.Sleep(100);
                            path = f.FullName;
                            md5 = Form1.GetMD5FromFIle(path);
                            if (signatures.Contains(md5))
                            {


                                PopupNotifier popup = new PopupNotifier();
                                popup.Image = Properties.Resources.imageVirus;
                                popup.TitleText = "VIRUS DETECTED!";
                                popup.ContentText = "Real time protection detected a virus in path: " + path;
                                popup.TitleColor = Color.Red;
                                popup.Popup();
                                playersoundvirus.Play();
                                MessageBox.Show("This file is infected. Delete it now! : " + path, "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                popup.Popup();
                                break;



                            }
                        }
                    }

                }
            }
            catch (ThreadAbortException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while handling RTP ", "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show(ex.ToString(), "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                MessageBox.Show("You are not protected ", "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Thread.CurrentThread.Priority = ThreadPriority.Lowest;
                Thread.Sleep(9999);
                if (MessageBox.Show("You are not protected ", "PCcleaner", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Abort)
                {
                    
                    Application.ExitThread();
                }
                else
                {
                    Application.Restart();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(online != true)
            {
                MessageBox.Show("Virus database is not updated.");
                button1.Enabled = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.prot_good;
                button1.Enabled = false;
                protegent.Text = "you are protected";
                protegent.ForeColor = Color.DeepSkyBlue;
                RTprot.Start();
                RTprot.Priority = ThreadPriority.Highest;
                Thread Monitorac = new Thread(monitor);
                Monitorac.Start();
                Thread monitorproces = new Thread(Process_monitor);
                monitorproces.Start();
            }

            
        }
        public async static void monitor()
        {
            // Nadanie uprawnień do monitorowania systemu plików
            FileSystemWatcher watcher = new FileSystemWatcher();
            FileSystemWatcher fsw = new FileSystemWatcher();
            watcher.Path = @"C:\Users\" + userName + @"\downloads";
            watcher.Filter = "*.*"; // Filtruj tylko pliki z rozszerzeniem .exe
            watcher.NotifyFilter = NotifyFilters.FileName;

            // Subskrybuj zdarzenie dla nowych plików
            watcher.Created += new FileSystemEventHandler(OnFileCreated);
            fsw.Changed += new FileSystemEventHandler(OnChanged);
            fsw.Path = watcher.Path;


            // Rozpocznij monitorowanie
            watcher.EnableRaisingEvents = true;


        }
        private static void OnFileCreated(object source, FileSystemEventArgs e)
        {
            string fileName = e.FullPath;
            SoundPlayer playersoundvirus = new SoundPlayer(Properties.Resources.virus_det);
            var signatures = File.ReadAllLines("MD5Base.txt");
            // Tutaj możesz dodać kod reagujący na próbę uruchomienia pliku
            var md5 = Form1.GetMD5FromFIle(fileName);
            // Skanowanie pliku
            if (signatures.Contains(md5))
            {


                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.imageVirus;
                popup.TitleText = "VIRUS DETECTED!";
                popup.ContentText = "Real time file monitor detected a virus in path: " + fileName;
                popup.TitleColor = Color.Red;
                popup.Popup();
                playersoundvirus.Play();
                MessageBox.Show("This file is infected. Delete it now! : " + fileName, "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                popup.Popup();




            }
        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            string fileName = e.FullPath;
            SoundPlayer playersoundvirus = new SoundPlayer(Properties.Resources.virus_det);
            var signatures = File.ReadAllLines("MD5Base.txt");
            // Tutaj możesz dodać kod reagujący na próbę uruchomienia pliku
            var md5 = Form1.GetMD5FromFIle(fileName);
            // Skanowanie pliku
            if (signatures.Contains(md5))
            {


                PopupNotifier popup = new PopupNotifier();
                popup.Image = Properties.Resources.imageVirus;
                popup.TitleText = "VIRUS DETECTED!";
                popup.ContentText = "Real time file monitor detected a virus in path: " + fileName;
                popup.TitleColor = Color.Red;
                popup.Popup();
                playersoundvirus.Play();
                MessageBox.Show("This file is infected. Delete it now! : " + fileName, "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                popup.Popup();




            }
        }
        public static async void Process_monitor()
        {
            while (true)
            {
                Thread.Sleep(5);
                Process[] processes = Process.GetProcesses();
                foreach (Process process in processes)
                {
                    try
                    {
                        string Fpath = process.MainModule.FileName;
                        var signatures = File.ReadAllLines("MD5Base.txt");
                        Thread.Sleep(100);
                        var md5 = Form1.GetMD5FromFIle(Fpath);
                        if (signatures.Contains(md5))
                        {

                            SoundPlayer playersoundvirus = new SoundPlayer(Properties.Resources.virus_det);
                            PopupNotifier popup = new PopupNotifier();
                            popup.Image = Properties.Resources.imageVirus;
                            popup.TitleText = "VIRUS DETECTED!";
                            popup.ContentText = "Real time process monitor detected a virus in path: " + Fpath;
                            popup.TitleColor = Color.Red;
                            popup.Popup();
                            playersoundvirus.Play();
                            MessageBox.Show("This file is infected. Delete it now! : " + Fpath, "PCcleaner", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            popup.Popup();
                            break;



                        }

                    }
                    catch (Exception ex)
                    {

                    }
                }
            }
        }

        private void safeunzipToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public static async void updatecheck() //system pobierania wszystkiego
        {
            try
            {
                try
                {
                    IWebProxy defWebProxy = WebRequest.DefaultWebProxy;
                    defWebProxy.Credentials = CredentialCache.DefaultCredentials;
                    var c = new WebClient { Proxy = defWebProxy };
                    c.Headers.Add("User-agent", "Mozilla/4.0 ");
                    string url1 = "https://virusshare.com/hashfiles/VirusShare_00000.md5";
                    string url2 = "https://virusshare.com/hashfiles/VirusShare_00001.md5";
                    string url3 = "https://virusshare.com/hashfiles/VirusShare_00002.md5";
                    string url4 = "https://virusshare.com/hashfiles/VirusShare_00003.md5";
                    string url5 = "https://virusshare.com/hashfiles/VirusShare_00004.md5";
                    string url6 = "https://virusshare.com/hashfiles/VirusShare_00005.md5";
                    string uv = "https://pccleaner-net.glitch.me/version.txt"; // link do wersji bazy wirusuw

                    c.DownloadFileAsync(new Uri(uv), "version.txt");
                    //var oVersion = await c.DownloadStringTaskAsync(new Uri(uv));
                    Thread.Sleep(3000);
                    
                    var oVersion = File.ReadAllText("version.txt");
                    //oVersion = c.DownloadString(new Uri(uv));
                    if(oVersion == "")
                    {
                        online = false;
                        if(MessageBox.Show("Error while initalizing update","PCcleaner update checker",MessageBoxButtons.RetryCancel,MessageBoxIcon.Stop) == DialogResult.Retry)
                        {
                            
                        }
                        else
                        {
                            
                            Thread.CurrentThread.Abort();
                        }
                    }
                    if (!File.Exists("MD5Base.txt"))
                    {
                        MessageBox.Show("Detected try of delete virus database. Updating");
                    }
                    else if(oVersion == version)
                    {
                        online = true;
                        MessageBox.Show("There are no updates");
                        Thread.CurrentThread.Abort();
                    }
                    MessageBox.Show("Update detected!");
                    await Task.Run(() =>
                    {
                        
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
                        
                        File.Move(@"MD5Basetest.txt", @"MD5Base.txt");
                        MessageBox.Show("Virus databases updated succesfully!");
                        online = true;
                        Thread.CurrentThread.Abort();
                    });
                }
                catch (System.Net.WebException ex)
                {
                    MessageBox.Show("Error while initalizing update. Please try again later.","PCCleaner auto update thread",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    Thread.CurrentThread.Abort();
                }
                catch (System.IO.DirectoryNotFoundException ex)
                {
                    Thread.CurrentThread.Abort();
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show("Error while downloading virus database. Please run Pccleaner as administator", "Pc cleaner", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Thread.CurrentThread.Abort();
                }
                catch (ThreadAbortException)
                {
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex, "pc cleaner", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            catch (ThreadAbortException)
            {

            }
            
            
        }

        private void extensionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var For3 = new download_extension();
            For3.Activate();
            For3.Show();

        }
    }
}
