namespace MasterAudioTechnologyFunctions
{
    partial class frmMatf
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
            this.components = new System.ComponentModel.Container();
            this.pnlTopBar = new System.Windows.Forms.Panel();
            this.lblTimeElapsed = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroScrollBar();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.volumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlVolume = new System.Windows.Forms.Panel();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.pnlSong = new System.Windows.Forms.Panel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.btnFile = new MetroFramework.Controls.MetroButton();
            this.btnPlay = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnLoop = new MetroFramework.Controls.MetroButton();
            this.timeLine = new MasterAudioTechnologyFunctions.Timeline.Timeline();
            this.pnlTopBar.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlVolume.SuspendLayout();
            this.pnlPlay.SuspendLayout();
            this.pnlSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Controls.Add(this.lblTimeElapsed);
            this.pnlTopBar.Controls.Add(this.progressBar);
            this.pnlTopBar.Location = new System.Drawing.Point(139, 91);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(687, 30);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.Leave += new System.EventHandler(this.pnlMenu_Leave);
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimeElapsed.Location = new System.Drawing.Point(6, 5);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(73, 19);
            this.lblTimeElapsed.TabIndex = 6;
            this.lblTimeElapsed.Text = "00:00:000";
            this.lblTimeElapsed.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.LargeChange = 10;
            this.progressBar.Location = new System.Drawing.Point(85, 14);
            this.progressBar.Maximum = 100;
            this.progressBar.Minimum = 0;
            this.progressBar.MouseWheelBarPartitions = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.progressBar.ScrollbarSize = 10;
            this.progressBar.Size = new System.Drawing.Size(599, 10);
            this.progressBar.TabIndex = 5;
            this.progressBar.UseSelectable = true;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.volumeBar);
            this.pnlSideBar.Controls.Add(this.label1);
            this.pnlSideBar.Controls.Add(this.pnlVolume);
            this.pnlSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideBar.Location = new System.Drawing.Point(20, 91);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(117, 334);
            this.pnlSideBar.TabIndex = 2;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.ForeColor = System.Drawing.Color.Transparent;
            this.volumeBar.Location = new System.Drawing.Point(3, 120);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(108, 23);
            this.volumeBar.TabIndex = 7;
            this.volumeBar.Text = "volumeBar";
            this.volumeBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Master Volume";
            // 
            // pnlVolume
            // 
            this.pnlVolume.Controls.Add(this.pnlPlay);
            this.pnlVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVolume.Location = new System.Drawing.Point(0, 0);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(117, 100);
            this.pnlVolume.TabIndex = 4;
            // 
            // pnlPlay
            // 
            this.pnlPlay.BackColor = System.Drawing.Color.White;
            this.pnlPlay.Controls.Add(this.btnLoop);
            this.pnlPlay.Controls.Add(this.btnStop);
            this.pnlPlay.Controls.Add(this.btnPlay);
            this.pnlPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlay.Location = new System.Drawing.Point(0, 0);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(117, 100);
            this.pnlPlay.TabIndex = 3;
            // 
            // pnlSong
            // 
            this.pnlSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSong.AutoScroll = true;
            this.pnlSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlSong.Controls.Add(this.timeLine);
            this.pnlSong.Location = new System.Drawing.Point(139, 125);
            this.pnlSong.MinimumSize = new System.Drawing.Size(30, 30);
            this.pnlSong.Name = "pnlSong";
            this.pnlSong.Size = new System.Drawing.Size(687, 300);
            this.pnlSong.TabIndex = 4;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnFile);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(20, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(804, 25);
            this.pnlMenu.TabIndex = 1;
            this.pnlMenu.UseCustomBackColor = true;
            this.pnlMenu.UseCustomForeColor = true;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.White;
            this.btnFile.Location = new System.Drawing.Point(0, 0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(73, 25);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "File";
            this.btnFile.UseCustomBackColor = true;
            this.btnFile.UseCustomForeColor = true;
            this.btnFile.UseSelectable = true;
            this.btnFile.UseStyleColors = true;
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 100);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PL";
            this.btnPlay.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnPlay.UseCustomBackColor = true;
            this.btnPlay.UseCustomForeColor = true;
            this.btnPlay.UseSelectable = true;
            this.btnPlay.UseStyleColors = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnStop
            // 
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Location = new System.Drawing.Point(30, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 100);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "S";
            this.btnStop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnStop.UseCustomBackColor = true;
            this.btnStop.UseCustomForeColor = true;
            this.btnStop.UseSelectable = true;
            this.btnStop.UseStyleColors = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoop.Location = new System.Drawing.Point(60, 0);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(30, 100);
            this.btnLoop.TabIndex = 7;
            this.btnLoop.Text = "L";
            this.btnLoop.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLoop.UseCustomBackColor = true;
            this.btnLoop.UseCustomForeColor = true;
            this.btnLoop.UseSelectable = true;
            this.btnLoop.UseStyleColors = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // timeLine
            // 
            this.timeLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLine.BackColor = System.Drawing.Color.White;
            this.timeLine.Location = new System.Drawing.Point(0, 0);
            this.timeLine.Name = "timeLine";
            this.timeLine.Size = new System.Drawing.Size(684, 31);
            this.timeLine.TabIndex = 0;
            // 
            // frmMatf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 448);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSong);
            this.Controls.Add(this.pnlSideBar);
            this.Name = "frmMatf";
            this.Text = "Master Audio Technology Functions";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.pnlVolume.ResumeLayout(false);
            this.pnlPlay.ResumeLayout(false);
            this.pnlSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlVolume;
        private System.Windows.Forms.Panel pnlSong;
        private Timeline.Timeline timeLine;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private System.Windows.Forms.Panel pnlPlay;
        private MetroFramework.Controls.MetroScrollBar progressBar;
        private MetroFramework.Controls.MetroTrackBar volumeBar;
        private MetroFramework.Controls.MetroLabel lblTimeElapsed;
        private MetroFramework.Controls.MetroPanel pnlMenu;
        private MetroFramework.Controls.MetroButton btnFile;
        private MetroFramework.Controls.MetroButton btnPlay;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnLoop;
    }
}

