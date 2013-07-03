/* 
    Cata Launcher
    Copyright (C) 2011-2013  Mitchell Kutchuk

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.

*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Threading;
using System.Diagnostics;
using System.IO;
using CataLauncher.Properties;
using System.Security.Cryptography;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace CataLauncher
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitPictureBox_MouseEnter(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButton;
        }

        private void MinimizePictureBox_MouseEnter(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButton;
        }

        private void exitPictureBox_MouseLeave(object sender, EventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButtonNoHover;
        }

        private void MinimizePictureBox_MouseLeave(object sender, EventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButtonNoHover;
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MinimizePictureBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void playButtonPictureBox_MouseEnter(object sender, EventArgs e)
        {
            playButtonPictureBox.Image = Properties.Resources.Play_Hover;
        }

        private void playButtonPictureBox_MouseLeave(object sender, EventArgs e)
        {
            playButtonPictureBox.Image = Properties.Resources.PlayNoHover;
        }

        private void playButtonPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            playButtonPictureBox.Image = Properties.Resources.PlayButtonPress;
        }

        private void playButtonPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            playButtonPictureBox.Image = Properties.Resources.Play_Hover;
        }

        private void exitPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButtonPress;
        }

        private void exitPictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            exitPictureBox.Image = Properties.Resources.ExitButton;
        }

        private void MinimizePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButtonPress;
        }

        private void MinimizePictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            MinimizePictureBox.Image = Properties.Resources.MinimizeButton;
        }

        private void playButtonPictureBox_Click(object sender, EventArgs e)
        {

            string wowExe = WoW.ExecutableLocation;

            if (!string.IsNullOrEmpty(wowExe) && File.Exists(wowExe))
            {
                Process.Start(wowExe);

                this.Close();
            }
            else
            {
                MessageBox.Show(this, "Could not find WoW.exe!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private delegate void UpdateProgress(int percent, long bytesReceived, long totalBytesReceive);
        private delegate void MakeVisibleInvisible(bool visible);

        private readonly string tempPath = Path.GetTempFileName();

        private void MainForm_Load(object sender, EventArgs e)
        {

            int btnCtr = 0;

            if (!string.IsNullOrEmpty(Settings.Default.WebsiteUrl))
            {

                CataButton btn = new CataButton();
                btn.Size = new Size(97, 39);
                btn.Name = "webButton";
                btn.ButtonText = "Website";
                btn.Location = new Point((97 * btnCtr) + 25, 469);
                btn.Click += (s, args) => Process.Start(Settings.Default.WebsiteUrl);

                Controls.Add(btn);

                btn.BringToFront();

                btnCtr++;

            }

            if (!string.IsNullOrEmpty(Settings.Default.ForumsUrl))
            {

                CataButton btn = new CataButton();
                btn.Size = new Size(97, 39);
                btn.Name = "frmButton";
                btn.ButtonText = "Forums";
                btn.Location = new Point((97 * btnCtr) + 25, 469);
                btn.Click += (s, args) => Process.Start(Settings.Default.ForumsUrl);

                Controls.Add(btn);

                btn.BringToFront();

                btnCtr++;

            }

            if (!string.IsNullOrEmpty(Settings.Default.VoteUrl))
            {

                CataButton btn = new CataButton();
                btn.Size = new Size(97, 39);
                btn.Name = "voteBtn";
                btn.ButtonText = "Vote";
                btn.Location = new Point((97 * btnCtr) + 25, 469);
                btn.Click += (s, args) => Process.Start(Settings.Default.VoteUrl);

                Controls.Add(btn);

                btn.BringToFront();

                btnCtr++;

            }

            if (!string.IsNullOrEmpty(Settings.Default.DonateUrl))
            {

                CataButton btn = new CataButton();
                btn.Size = new Size(97, 39);
                btn.Name = "donateBtn";
                btn.ButtonText = "Donate";
                btn.Location = new Point((97 * btnCtr) + 25, 469);
                btn.Click += (s, args) => Process.Start(Settings.Default.DonateUrl);

                Controls.Add(btn);

                btn.BringToFront();

            }

            if (string.IsNullOrEmpty(Settings.Default.WowLocation) || !Directory.Exists(Settings.Default.WowLocation))
            {

                if (!string.IsNullOrEmpty(WoW.Directory))
                {
                    Settings.Default.WowLocation = WoW.Directory;
                    Settings.Default.Save();
                }
                else
                {
                    using (SettingsForm form = new SettingsForm())
                        form.ShowDialog();
                }

            }

            TransparencyKey = Color.Lime;

            downloadBar1.BarState = DownloadBar.DownloadBarState.Setup;

            checkServerStatusBackgroundWorker.RunWorkerAsync();

            try
            {

                string path = WoW.RealmListLocation;

                if (!string.IsNullOrEmpty(path) && File.Exists(path))
                {
                    using (StreamWriter writer = new StreamWriter(path))
                    {

                        writer.WriteLine(Settings.Default.realmlist);
                        writer.Flush();

                        writer.Close();

                    }
                }

                if (Settings.Default.patchDownloadURL != String.Empty)
                    startDownloadBackgroundWorker.RunWorkerAsync();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Cata Launcher", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void startDownloadBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            WebClient client = new WebClient();

            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);

            client.DownloadFileAsync(new Uri(Settings.Default.patchDownloadURL), tempPath);
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new UpdateProgress(UpdateProgressbar), new object[] { e.ProgressPercentage, e.BytesReceived, e.TotalBytesToReceive });
        }

        private void UpdateProgressbar(int percent, long bytesReceived, long totalBytesToReceive)
        {

            string received = String.Empty;
            string total = String.Empty;

            if (int.Parse(bytesReceived.ToString()) >= 1073741824)
                received = String.Format("{0:0.00}gb", double.Parse(bytesReceived.ToString()) / 1024 / 1024 / 1024);

            else if (int.Parse(bytesReceived.ToString()) >= 1048576)
                received = String.Format("{0:0.00}mb", double.Parse(bytesReceived.ToString()) / 1024 / 1024);

            else
                received = String.Format("{0:0.00}kb", double.Parse(bytesReceived.ToString()) / 1024);


            if (int.Parse(totalBytesToReceive.ToString()) >= 1073741824)
                total = String.Format("{0:0.00}gb", double.Parse(totalBytesToReceive.ToString()) / 1024 / 1024 / 1024);

            else if (int.Parse(totalBytesToReceive.ToString()) >= 1048576)
                total = String.Format("{0:0.00}mb", double.Parse(totalBytesToReceive.ToString()) / 1024 / 1024);

            else
                total = String.Format("{0:0.00}kb", double.Parse(totalBytesToReceive.ToString()) / 1024);

            string progress = String.Format("Download Progress: {0} / {1}", received, total);

            downloadProgressLabel.Text = progress;

            downloadBar1.Value = percent;
        }

        private Queue<PatchFileInfo> patchQueue = new Queue<PatchFileInfo>();

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            bool anyDownloads = false;

            string loc = WoW.DataDirectory;

            if (!string.IsNullOrEmpty(loc) && Directory.Exists(loc))
            {
                using (StreamReader reader = new StreamReader(tempPath))
                {

                    string line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] ex = line.Split(' ');


                        string path = Path.Combine(loc, ex[1]);

                        bool proceed = true;

                        if (File.Exists(path))
                        {

                            //Compare MD5 Hashes

                            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                            {

                                using (MD5 md5 = new MD5CryptoServiceProvider())
                                {

                                    byte[] retVal = md5.ComputeHash(fs);

                                    fs.Close();

                                    StringBuilder sb = new StringBuilder();

                                    foreach (byte b in retVal)
                                    {
                                        sb.Append(string.Format("{0:X2}", b));
                                    }

                                    if (ex[2] == sb.ToString())
                                    {
                                        proceed = false;
                                    }

                                }

                            }

                        }

                        if (proceed)
                        {

                            WebClient downloadPatches = new WebClient();

                            downloadPatches.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadPatches_DownloadFileCompleted);
                            downloadPatches.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadPatches_DownloadProgressChanged);


                            PatchFileInfo pfi = new PatchFileInfo(ex[0], path);

                            object obj = pfi;

                            downloadBar1.Invoke((MethodInvoker)delegate
                            {
                                downloadBar1.BarState = DownloadBar.DownloadBarState.Playable;
                            });


                            if (!anyDownloads)
                                downloadPatches.DownloadFileAsync(new Uri(ex[0]), path, obj);
                            else
                                patchQueue.Enqueue(pfi);

                            anyDownloads = true;
                        }
                    }
                }
            }

            if (!anyDownloads)
                this.Invoke(new MakeVisibleInvisible(DownloadCompleted), new object[] { false });
            else
                this.Invoke(new MakeVisibleInvisible(DownloadCompleted), new object[] { true });

        }

        private void downloadPatches_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {

            if (patchQueue.Count != 0)
            {
                PatchFileInfo pfi = patchQueue.Dequeue();

                WebClient downloadPatches = new WebClient();

                downloadPatches.DownloadFileCompleted += new AsyncCompletedEventHandler(downloadPatches_DownloadFileCompleted);
                downloadPatches.DownloadProgressChanged += new DownloadProgressChangedEventHandler(downloadPatches_DownloadProgressChanged);

                downloadPatches.DownloadFileAsync(new Uri(pfi.url), pfi.file);

            }
            else
                this.Invoke(new MakeVisibleInvisible(DownloadCompleted), new object[] { false });
        }

        private void DownloadCompleted(bool visible)
        {
            if (visible)
            {
                downloadProgressLabel.Visible = true;
                downloadBar1.BarState = DownloadBar.DownloadBarState.Available;
                playButtonPictureBox.Enabled = false;
                playButtonPictureBox.Image = Properties.Resources.PlayButtonDisabled;
            }
            else
            {
                downloadProgressLabel.Visible = false;
                downloadBar1.BarState = DownloadBar.DownloadBarState.Playable;
                playButtonPictureBox.Enabled = true;
                playButtonPictureBox.Image = Properties.Resources.PlayNoHover;
            }
        }

        private void downloadPatches_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            this.Invoke(new UpdateProgress(UpdateProgressbar), new object[] { e.ProgressPercentage, (int)e.BytesReceived, (int)e.TotalBytesToReceive });
        }

        private class PatchFileInfo
        {
            public string url { get; set; }
            public string file { get; set; }
            public string md5hash { get; set; }

            public PatchFileInfo(string URL, string File)
            {
                url = URL;
                file = File;
            }
        }

        private void checkServerStatusBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            bool status = false;

            try
            {
                TcpClient client = new TcpClient();

                client.Connect(Settings.Default.server, Settings.Default.port);

                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }

            statusLabel.Invoke((MethodInvoker)delegate
            {
                if (status)
                {
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Online";
                }
                else
                {
                    statusLabel.ForeColor = Color.Red;
                    statusLabel.Text = "Offline";
                }
            });
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void creditsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            using (Credits credits = new Credits())
                credits.ShowDialog();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void menuBar1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SettingsForm sForm = new SettingsForm())
            {
                sForm.ShowDialog();
            }
        }
    }
}
