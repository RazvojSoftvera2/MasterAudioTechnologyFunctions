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
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.btnHelp = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.btnFile = new MetroFramework.Controls.MetroButton();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlVolume = new System.Windows.Forms.Panel();
            this.btnLoop = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnPlay = new MetroFramework.Controls.MetroButton();
            this.playControls = new MetroFramework.Controls.MetroLabel();
            this.volumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.pnlSong = new System.Windows.Forms.Panel();
            this.timeLine = new MasterAudioTechnologyFunctions.Timeline.Timeline();
            this.fileMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWavmp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsWavmp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.themesAndButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlTopBar.SuspendLayout();
            this.pnlPlay.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlVolume.SuspendLayout();
            this.pnlSong.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.viewMenu.SuspendLayout();
            this.helpMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopBar.Controls.Add(this.pnlPlay);
            this.pnlTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopBar.Location = new System.Drawing.Point(20, 60);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(866, 30);
            this.pnlTopBar.TabIndex = 1;
            // 
            // pnlPlay
            // 
            this.pnlPlay.Controls.Add(this.btnHelp);
            this.pnlPlay.Controls.Add(this.btnView);
            this.pnlPlay.Controls.Add(this.btnFile);
            this.pnlPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPlay.Location = new System.Drawing.Point(0, 0);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(866, 30);
            this.pnlPlay.TabIndex = 2;
            // 
            // btnHelp
            // 
            this.btnHelp.Location = new System.Drawing.Point(130, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 23);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseSelectable = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(67, 4);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(56, 23);
            this.btnView.TabIndex = 1;
            this.btnView.Text = "View";
            this.btnView.UseSelectable = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.Location = new System.Drawing.Point(4, 4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(56, 23);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "File";
            this.btnFile.UseSelectable = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideBar.Controls.Add(this.pnlVolume);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideBar.Location = new System.Drawing.Point(20, 90);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(113, 361);
            this.pnlSideBar.TabIndex = 2;
            // 
            // pnlVolume
            // 
            this.pnlVolume.BackColor = System.Drawing.Color.Transparent;
            this.pnlVolume.Controls.Add(this.btnLoop);
            this.pnlVolume.Controls.Add(this.btnStop);
            this.pnlVolume.Controls.Add(this.btnPlay);
            this.pnlVolume.Controls.Add(this.playControls);
            this.pnlVolume.Controls.Add(this.volumeBar);
            this.pnlVolume.Controls.Add(this.metroLabel1);
            this.pnlVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVolume.Location = new System.Drawing.Point(0, 0);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(113, 207);
            this.pnlVolume.TabIndex = 4;
            // 
            // btnLoop
            // 
            this.btnLoop.Location = new System.Drawing.Point(73, 84);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(40, 30);
            this.btnLoop.TabIndex = 5;
            this.btnLoop.Text = "L";
            this.btnLoop.UseSelectable = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click_1);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(36, 84);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(40, 30);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "S";
            this.btnStop.UseSelectable = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click_1);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(0, 84);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(40, 30);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "PL";
            this.btnPlay.UseSelectable = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click_1);
            // 
            // playControls
            // 
            this.playControls.AutoSize = true;
            this.playControls.Location = new System.Drawing.Point(4, 61);
            this.playControls.Name = "playControls";
            this.playControls.Size = new System.Drawing.Size(89, 19);
            this.playControls.TabIndex = 2;
            this.playControls.Text = "PLay Controls";
            this.playControls.UseStyleColors = true;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.Location = new System.Drawing.Point(4, 31);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(106, 23);
            this.volumeBar.TabIndex = 1;
            this.volumeBar.Text = "volumeBar";
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Master Volume";
            this.metroLabel1.UseStyleColors = true;
            // 
            // pnlSong
            // 
            this.pnlSong.AutoScroll = true;
            this.pnlSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlSong.Controls.Add(this.metroPanel1);
            this.pnlSong.Controls.Add(this.timeLine);
            this.pnlSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSong.Location = new System.Drawing.Point(20, 60);
            this.pnlSong.Name = "pnlSong";
            this.pnlSong.Size = new System.Drawing.Size(866, 391);
            this.pnlSong.TabIndex = 4;
            // 
            // timeLine
            // 
            this.timeLine.BackColor = System.Drawing.Color.DarkGray;
            this.timeLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLine.Location = new System.Drawing.Point(0, 0);
            this.timeLine.Name = "timeLine";
            this.timeLine.Size = new System.Drawing.Size(866, 31);
            this.timeLine.TabIndex = 0;
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.importWavmp3ToolStripMenuItem,
            this.exportAsWavmp3ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(175, 158);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.newProjectToolStripMenuItem.Text = "New project";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveProjectToolStripMenuItem.Text = "Save project";
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save project as";
            // 
            // importWavmp3ToolStripMenuItem
            // 
            this.importWavmp3ToolStripMenuItem.Name = "importWavmp3ToolStripMenuItem";
            this.importWavmp3ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.importWavmp3ToolStripMenuItem.Text = "Import wav/mp3";
            // 
            // exportAsWavmp3ToolStripMenuItem
            // 
            this.exportAsWavmp3ToolStripMenuItem.Name = "exportAsWavmp3ToolStripMenuItem";
            this.exportAsWavmp3ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exportAsWavmp3ToolStripMenuItem.Text = "Export as wav/mp3";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesAndButtonsToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(184, 26);
            // 
            // themesAndButtonsToolStripMenuItem
            // 
            this.themesAndButtonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesToolStripMenuItem,
            this.buttonsToolStripMenuItem});
            this.themesAndButtonsToolStripMenuItem.Name = "themesAndButtonsToolStripMenuItem";
            this.themesAndButtonsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.themesAndButtonsToolStripMenuItem.Text = "Themes and buttons";
            // 
            // themesToolStripMenuItem
            // 
            this.themesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem});
            this.themesToolStripMenuItem.Name = "themesToolStripMenuItem";
            this.themesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.themesToolStripMenuItem.Text = "Themes";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // buttonsToolStripMenuItem
            // 
            this.buttonsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greyToolStripMenuItem});
            this.buttonsToolStripMenuItem.Name = "buttonsToolStripMenuItem";
            this.buttonsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.buttonsToolStripMenuItem.Text = "Buttons";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greenToolStripMenuItem.Text = "Green";
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            // 
            // greyToolStripMenuItem
            // 
            this.greyToolStripMenuItem.Name = "greyToolStripMenuItem";
            this.greyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.greyToolStripMenuItem.Text = "Grey";
            // 
            // helpMenu
            // 
            this.helpMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(108, 26);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 31);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(866, 360);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // frmMatf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 471);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSong);
            this.Name = "frmMatf";
            this.Text = "Master Audio Technology Functions";
            this.pnlTopBar.ResumeLayout(false);
            this.pnlPlay.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.pnlVolume.ResumeLayout(false);
            this.pnlVolume.PerformLayout();
            this.pnlSong.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.viewMenu.ResumeLayout(false);
            this.helpMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTopBar;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlVolume;
        private System.Windows.Forms.Panel pnlSong;
        private Timeline.Timeline timeLine;
        private System.Windows.Forms.Panel pnlPlay;
        private MetroFramework.Controls.MetroButton btnFile;
        private MetroFramework.Controls.MetroContextMenu fileMenu;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWavmp3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportAsWavmp3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroContextMenu viewMenu;
        private System.Windows.Forms.ToolStripMenuItem themesAndButtonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greyToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btnHelp;
        private MetroFramework.Controls.MetroContextMenu helpMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private MetroFramework.Controls.MetroTrackBar volumeBar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel playControls;
        private MetroFramework.Controls.MetroButton btnLoop;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnPlay;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}

