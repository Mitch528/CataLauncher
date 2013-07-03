namespace CataLauncher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startDownloadBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.downloadProgressLabel = new System.Windows.Forms.Label();
            this.serverStatusLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.checkServerStatusBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.playButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.deathWingPictureBox = new System.Windows.Forms.PictureBox();
            this.launcherOuterPictureBox = new System.Windows.Forms.PictureBox();
            this.MinimizePictureBox = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.downloadBar1 = new CataLauncher.DownloadBar();
            this.menuBar1 = new CataLauncher.MenuBar();
            this.menuStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathWingPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.launcherOuterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem1,
            this.aboutToolStripMenuItem2});
            this.menuStrip.Location = new System.Drawing.Point(1, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(97, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem1
            // 
            this.fileToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            this.fileToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem1.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem2
            // 
            this.aboutToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem2});
            this.aboutToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem2.Name = "aboutToolStripMenuItem2";
            this.aboutToolStripMenuItem2.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem2.Text = "About";
            // 
            // creditsToolStripMenuItem2
            // 
            this.creditsToolStripMenuItem2.BackColor = System.Drawing.Color.Black;
            this.creditsToolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.creditsToolStripMenuItem2.Name = "creditsToolStripMenuItem2";
            this.creditsToolStripMenuItem2.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem2.Text = "Credits";
            this.creditsToolStripMenuItem2.Click += new System.EventHandler(this.creditsToolStripMenuItem2_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.aboutToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem1});
            this.aboutToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            // 
            // creditsToolStripMenuItem1
            // 
            this.creditsToolStripMenuItem1.BackColor = System.Drawing.Color.Black;
            this.creditsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
            this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem1.Text = "Credits";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem});
            this.fileMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.BackColor = System.Drawing.Color.Black;
            this.exitMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitMenuItem.Text = "Exit";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.creditsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.menuStrip);
            this.panel1.Location = new System.Drawing.Point(12, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 27);
            this.panel1.TabIndex = 7;
            // 
            // startDownloadBackgroundWorker
            // 
            this.startDownloadBackgroundWorker.WorkerReportsProgress = true;
            this.startDownloadBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.startDownloadBackgroundWorker_DoWork);
            // 
            // downloadProgressLabel
            // 
            this.downloadProgressLabel.AutoSize = true;
            this.downloadProgressLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.downloadProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.downloadProgressLabel.ForeColor = System.Drawing.Color.White;
            this.downloadProgressLabel.Location = new System.Drawing.Point(182, 592);
            this.downloadProgressLabel.Name = "downloadProgressLabel";
            this.downloadProgressLabel.Size = new System.Drawing.Size(133, 16);
            this.downloadProgressLabel.TabIndex = 9;
            this.downloadProgressLabel.Text = "Download Progress: ";
            this.downloadProgressLabel.Visible = false;
            // 
            // serverStatusLabel
            // 
            this.serverStatusLabel.AutoSize = true;
            this.serverStatusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.serverStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverStatusLabel.ForeColor = System.Drawing.Color.White;
            this.serverStatusLabel.Location = new System.Drawing.Point(12, 602);
            this.serverStatusLabel.Name = "serverStatusLabel";
            this.serverStatusLabel.Size = new System.Drawing.Size(101, 18);
            this.serverStatusLabel.TabIndex = 10;
            this.serverStatusLabel.Text = "Server Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Red;
            this.statusLabel.Location = new System.Drawing.Point(110, 602);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(50, 18);
            this.statusLabel.TabIndex = 11;
            this.statusLabel.Text = "Offline";
            // 
            // checkServerStatusBackgroundWorker
            // 
            this.checkServerStatusBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.checkServerStatusBackgroundWorker_DoWork);
            // 
            // playButtonPictureBox
            // 
            this.playButtonPictureBox.Image = global::CataLauncher.Properties.Resources.PlayNoHover;
            this.playButtonPictureBox.Location = new System.Drawing.Point(650, 530);
            this.playButtonPictureBox.Name = "playButtonPictureBox";
            this.playButtonPictureBox.Size = new System.Drawing.Size(140, 78);
            this.playButtonPictureBox.TabIndex = 5;
            this.playButtonPictureBox.TabStop = false;
            this.playButtonPictureBox.Click += new System.EventHandler(this.playButtonPictureBox_Click);
            this.playButtonPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.playButtonPictureBox_MouseDown);
            this.playButtonPictureBox.MouseEnter += new System.EventHandler(this.playButtonPictureBox_MouseEnter);
            this.playButtonPictureBox.MouseLeave += new System.EventHandler(this.playButtonPictureBox_MouseLeave);
            this.playButtonPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.playButtonPictureBox_MouseUp);
            // 
            // deathWingPictureBox
            // 
            this.deathWingPictureBox.BackgroundImage = global::CataLauncher.Properties.Resources.Deathwing2;
            this.deathWingPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deathWingPictureBox.Location = new System.Drawing.Point(12, 54);
            this.deathWingPictureBox.Name = "deathWingPictureBox";
            this.deathWingPictureBox.Size = new System.Drawing.Size(781, 454);
            this.deathWingPictureBox.TabIndex = 4;
            this.deathWingPictureBox.TabStop = false;
            // 
            // launcherOuterPictureBox
            // 
            this.launcherOuterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.launcherOuterPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("launcherOuterPictureBox.Image")));
            this.launcherOuterPictureBox.Location = new System.Drawing.Point(0, 30);
            this.launcherOuterPictureBox.Name = "launcherOuterPictureBox";
            this.launcherOuterPictureBox.Size = new System.Drawing.Size(803, 603);
            this.launcherOuterPictureBox.TabIndex = 3;
            this.launcherOuterPictureBox.TabStop = false;
            // 
            // MinimizePictureBox
            // 
            this.MinimizePictureBox.Image = global::CataLauncher.Properties.Resources.MinimizeButtonNoHover;
            this.MinimizePictureBox.Location = new System.Drawing.Point(756, 4);
            this.MinimizePictureBox.Name = "MinimizePictureBox";
            this.MinimizePictureBox.Size = new System.Drawing.Size(19, 19);
            this.MinimizePictureBox.TabIndex = 2;
            this.MinimizePictureBox.TabStop = false;
            this.MinimizePictureBox.Click += new System.EventHandler(this.MinimizePictureBox_Click);
            this.MinimizePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseDown);
            this.MinimizePictureBox.MouseEnter += new System.EventHandler(this.MinimizePictureBox_MouseEnter);
            this.MinimizePictureBox.MouseLeave += new System.EventHandler(this.MinimizePictureBox_MouseLeave);
            this.MinimizePictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MinimizePictureBox_MouseUp);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Image = global::CataLauncher.Properties.Resources.ExitButtonNoHover;
            this.exitPictureBox.Location = new System.Drawing.Point(779, 4);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(19, 19);
            this.exitPictureBox.TabIndex = 1;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            this.exitPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseDown);
            this.exitPictureBox.MouseEnter += new System.EventHandler(this.exitPictureBox_MouseEnter);
            this.exitPictureBox.MouseLeave += new System.EventHandler(this.exitPictureBox_MouseLeave);
            this.exitPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.exitPictureBox_MouseUp);
            // 
            // downloadBar1
            // 
            this.downloadBar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("downloadBar1.BackgroundImage")));
            this.downloadBar1.BarState = CataLauncher.DownloadBar.DownloadBarState.Setup;
            this.downloadBar1.Location = new System.Drawing.Point(27, 528);
            this.downloadBar1.Name = "downloadBar1";
            this.downloadBar1.Size = new System.Drawing.Size(602, 48);
            this.downloadBar1.TabIndex = 19;
            this.downloadBar1.Value = 0D;
            // 
            // menuBar1
            // 
            this.menuBar1.ButtonColor = System.Drawing.Color.White;
            this.menuBar1.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.menuBar1.Location = new System.Drawing.Point(0, 0);
            this.menuBar1.MenuBarText = "Cata Launcher";
            this.menuBar1.Name = "menuBar1";
            this.menuBar1.Size = new System.Drawing.Size(803, 32);
            this.menuBar1.TabIndex = 18;
            this.menuBar1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuBar1_MouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(803, 629);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.downloadBar1);
            this.Controls.Add(this.serverStatusLabel);
            this.Controls.Add(this.downloadProgressLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playButtonPictureBox);
            this.Controls.Add(this.deathWingPictureBox);
            this.Controls.Add(this.launcherOuterPictureBox);
            this.Controls.Add(this.MinimizePictureBox);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.menuBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "WoW Launcher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deathWingPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.launcherOuterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.PictureBox MinimizePictureBox;
        private System.Windows.Forms.PictureBox launcherOuterPictureBox;
        private System.Windows.Forms.PictureBox deathWingPictureBox;
        private System.Windows.Forms.PictureBox playButtonPictureBox;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker startDownloadBackgroundWorker;
        private System.Windows.Forms.Label downloadProgressLabel;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        private System.Windows.Forms.Label serverStatusLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.ComponentModel.BackgroundWorker checkServerStatusBackgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem2;
        private MenuBar menuBar1;
        private DownloadBar downloadBar1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
    }
}

