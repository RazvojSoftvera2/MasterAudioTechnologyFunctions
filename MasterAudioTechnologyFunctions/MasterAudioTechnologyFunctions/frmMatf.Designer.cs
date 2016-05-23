﻿namespace MasterAudioTechnologyFunctions
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
            this.btnLoop = new MetroFramework.Controls.MetroButton();
            this.btnPlay = new System.Windows.Forms.Button();
            this.pnlSong = new System.Windows.Forms.Panel();
            this.timeLine = new MasterAudioTechnologyFunctions.Timeline.Timeline();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.pnlTopBar.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlVolume.SuspendLayout();
            this.pnlPlay.SuspendLayout();
            this.pnlSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Controls.Add(this.lblTimeElapsed);
            this.pnlTopBar.Controls.Add(this.progressBar);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(137, 60);
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
            this.pnlSideBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideBar.Controls.Add(this.volumeBar);
            this.pnlSideBar.Controls.Add(this.label1);
            this.pnlSideBar.Controls.Add(this.pnlVolume);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideBar.Location = new System.Drawing.Point(20, 60);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(117, 368);
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
            this.pnlPlay.Controls.Add(this.btnLoop);
            this.pnlPlay.Controls.Add(this.btnStop);
            this.pnlPlay.Controls.Add(this.btnPlay);
            this.pnlPlay.Location = new System.Drawing.Point(4, 0);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(113, 30);
            this.pnlPlay.TabIndex = 3;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(66, 3);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(19, 23);
            this.btnLoop.TabIndex = 4;
            this.btnLoop.Text = "L";
            this.btnLoop.UseSelectable = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(30, 30);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlSong
            // 
            this.pnlSong.AutoScroll = true;
            this.pnlSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlSong.Controls.Add(this.timeLine);
            this.pnlSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSong.Location = new System.Drawing.Point(137, 90);
            this.pnlSong.Name = "pnlSong";
            this.pnlSong.Size = new System.Drawing.Size(687, 338);
            this.pnlSong.TabIndex = 4;
            // 
            // timeLine
            // 
            this.timeLine.BackColor = System.Drawing.Color.Transparent;
            this.timeLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLine.Location = new System.Drawing.Point(0, 0);
            this.timeLine.Name = "timeLine";
            this.timeLine.Size = new System.Drawing.Size(687, 31);
            this.timeLine.TabIndex = 0;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // btnStop
            // 
            this.btnStop.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.stop;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(30, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 3;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // frmMatf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 448);
            this.Controls.Add(this.pnlSong);
            this.Controls.Add(this.pnlTopBar);
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
        private System.Windows.Forms.Button btnPlay;
        private MetroFramework.Controls.MetroScrollBar progressBar;
        private MetroFramework.Controls.MetroTrackBar volumeBar;
        private MetroFramework.Controls.MetroLabel lblTimeElapsed;
        private MetroFramework.Controls.MetroButton btnLoop;
        private System.Windows.Forms.Button btnStop;
    }
}

