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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMatf));
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pnlTopBar = new MetroFramework.Controls.MetroPanel();
            this.lblTimeElapsed = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroScrollBar();
            this.pnlSideBar = new MetroFramework.Controls.MetroPanel();
            this.volumeLabel = new MetroFramework.Controls.MetroLabel();
            this.volumeBar = new MetroFramework.Controls.MetroTrackBar();
            this.pnlVolume = new MetroFramework.Controls.MetroPanel();
            this.pnlPlay = new MetroFramework.Controls.MetroPanel();
            this.btnLoop = new MetroFramework.Controls.MetroButton();
            this.btnStop = new MetroFramework.Controls.MetroButton();
            this.btnPlay = new MetroFramework.Controls.MetroButton();
            this.pnlSong = new MetroFramework.Controls.MetroPanel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pnlMenu = new MetroFramework.Controls.MetroPanel();
            this.btnAbout = new MetroFramework.Controls.MetroButton();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.btnFile = new MetroFramework.Controls.MetroButton();
            this.menuFile = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWAVMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportWAVMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.themesStylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stylesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.silverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brownToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orangeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tealToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yelowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLine = new MasterAudioTechnologyFunctions.Timeline.Timeline();
            this.pnlTopBar.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlVolume.SuspendLayout();
            this.pnlPlay.SuspendLayout();
            this.pnlSong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.menuView.SuspendLayout();
            this.menuAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmrMain
            // 
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // pnlTopBar
            // 
            this.pnlTopBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTopBar.BackColor = System.Drawing.Color.White;
            this.pnlTopBar.Controls.Add(this.lblTimeElapsed);
            this.pnlTopBar.Controls.Add(this.progressBar);
            this.pnlTopBar.HorizontalScrollbarBarColor = true;
            this.pnlTopBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTopBar.HorizontalScrollbarSize = 10;
            this.pnlTopBar.Location = new System.Drawing.Point(139, 91);
            this.pnlTopBar.Name = "pnlTopBar";
            this.pnlTopBar.Size = new System.Drawing.Size(724, 30);
            this.pnlTopBar.TabIndex = 1;
            this.pnlTopBar.UseStyleColors = true;
            this.pnlTopBar.VerticalScrollbarBarColor = true;
            this.pnlTopBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTopBar.VerticalScrollbarSize = 10;
            // 
            // lblTimeElapsed
            // 
            this.lblTimeElapsed.AutoSize = true;
            this.lblTimeElapsed.BackColor = System.Drawing.SystemColors.Control;
            this.lblTimeElapsed.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblTimeElapsed.Location = new System.Drawing.Point(6, 5);
            this.lblTimeElapsed.Name = "lblTimeElapsed";
            this.lblTimeElapsed.Size = new System.Drawing.Size(73, 19);
            this.lblTimeElapsed.TabIndex = 8;
            this.lblTimeElapsed.Text = "00:00:000";
            this.lblTimeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTimeElapsed.UseStyleColors = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.LargeChange = 10;
            this.progressBar.Location = new System.Drawing.Point(81, 10);
            this.progressBar.Maximum = 100;
            this.progressBar.Minimum = 0;
            this.progressBar.MouseWheelBarPartitions = 10;
            this.progressBar.Name = "progressBar";
            this.progressBar.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.progressBar.ScrollbarSize = 10;
            this.progressBar.Size = new System.Drawing.Size(637, 10);
            this.progressBar.TabIndex = 5;
            this.progressBar.UseSelectable = true;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.White;
            this.pnlSideBar.Controls.Add(this.volumeLabel);
            this.pnlSideBar.Controls.Add(this.volumeBar);
            this.pnlSideBar.Controls.Add(this.pnlVolume);
            this.pnlSideBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlSideBar.HorizontalScrollbar = true;
            this.pnlSideBar.HorizontalScrollbarBarColor = true;
            this.pnlSideBar.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSideBar.HorizontalScrollbarSize = 10;
            this.pnlSideBar.Location = new System.Drawing.Point(20, 91);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(117, 370);
            this.pnlSideBar.TabIndex = 2;
            this.pnlSideBar.VerticalScrollbar = true;
            this.pnlSideBar.VerticalScrollbarBarColor = true;
            this.pnlSideBar.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSideBar.VerticalScrollbarSize = 10;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.volumeLabel.Location = new System.Drawing.Point(5, 34);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(109, 19);
            this.volumeLabel.TabIndex = 8;
            this.volumeLabel.Text = "Master Volume";
            this.volumeLabel.UseStyleColors = true;
            // 
            // volumeBar
            // 
            this.volumeBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeBar.ForeColor = System.Drawing.Color.Transparent;
            this.volumeBar.Location = new System.Drawing.Point(5, 51);
            this.volumeBar.Name = "volumeBar";
            this.volumeBar.Size = new System.Drawing.Size(108, 23);
            this.volumeBar.TabIndex = 7;
            this.volumeBar.Text = "volumeBar";
            this.volumeBar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.volumeBar.UseCustomBackColor = true;
            this.volumeBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.volumeBar_Scroll);
            // 
            // pnlVolume
            // 
            this.pnlVolume.Controls.Add(this.pnlPlay);
            this.pnlVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVolume.HorizontalScrollbarBarColor = true;
            this.pnlVolume.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlVolume.HorizontalScrollbarSize = 10;
            this.pnlVolume.Location = new System.Drawing.Point(0, 0);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(117, 30);
            this.pnlVolume.TabIndex = 4;
            this.pnlVolume.VerticalScrollbarBarColor = true;
            this.pnlVolume.VerticalScrollbarHighlightOnWheel = false;
            this.pnlVolume.VerticalScrollbarSize = 10;
            // 
            // pnlPlay
            // 
            this.pnlPlay.BackColor = System.Drawing.Color.White;
            this.pnlPlay.Controls.Add(this.btnLoop);
            this.pnlPlay.Controls.Add(this.btnStop);
            this.pnlPlay.Controls.Add(this.btnPlay);
            this.pnlPlay.HorizontalScrollbarBarColor = true;
            this.pnlPlay.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlPlay.HorizontalScrollbarSize = 10;
            this.pnlPlay.Location = new System.Drawing.Point(0, 0);
            this.pnlPlay.Name = "pnlPlay";
            this.pnlPlay.Size = new System.Drawing.Size(117, 30);
            this.pnlPlay.TabIndex = 3;
            this.pnlPlay.VerticalScrollbarBarColor = true;
            this.pnlPlay.VerticalScrollbarHighlightOnWheel = false;
            this.pnlPlay.VerticalScrollbarSize = 10;
            // 
            // btnLoop
            // 
            this.btnLoop.AutoSize = true;
            this.btnLoop.BackColor = System.Drawing.SystemColors.Control;
            this.btnLoop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLoop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLoop.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLoop.Location = new System.Drawing.Point(62, 0);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.Size = new System.Drawing.Size(30, 30);
            this.btnLoop.TabIndex = 7;
            this.btnLoop.Text = "L";
            this.btnLoop.UseSelectable = true;
            this.btnLoop.UseStyleColors = true;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStop.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnStop.Location = new System.Drawing.Point(32, 0);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(30, 30);
            this.btnStop.TabIndex = 6;
            this.btnStop.Text = "S";
            this.btnStop.UseSelectable = true;
            this.btnStop.UseStyleColors = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AutoSize = true;
            this.btnPlay.BackColor = System.Drawing.SystemColors.Control;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlay.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(32, 30);
            this.btnPlay.TabIndex = 5;
            this.btnPlay.Text = "PL";
            this.btnPlay.UseSelectable = true;
            this.btnPlay.UseStyleColors = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // pnlSong
            // 
            this.pnlSong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSong.AutoScroll = true;
            this.pnlSong.BackColor = System.Drawing.Color.White;
            this.pnlSong.Controls.Add(this.timeLine);
            this.pnlSong.HorizontalScrollbar = true;
            this.pnlSong.HorizontalScrollbarBarColor = true;
            this.pnlSong.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlSong.HorizontalScrollbarSize = 10;
            this.pnlSong.Location = new System.Drawing.Point(139, 125);
            this.pnlSong.MinimumSize = new System.Drawing.Size(30, 30);
            this.pnlSong.Name = "pnlSong";
            this.pnlSong.Size = new System.Drawing.Size(724, 336);
            this.pnlSong.TabIndex = 4;
            this.pnlSong.VerticalScrollbar = true;
            this.pnlSong.VerticalScrollbarBarColor = true;
            this.pnlSong.VerticalScrollbarHighlightOnWheel = false;
            this.pnlSong.VerticalScrollbarSize = 10;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.SystemColors.Control;
            this.pnlMenu.Controls.Add(this.btnAbout);
            this.pnlMenu.Controls.Add(this.btnView);
            this.pnlMenu.Controls.Add(this.btnFile);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.HorizontalScrollbarBarColor = true;
            this.pnlMenu.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlMenu.HorizontalScrollbarSize = 10;
            this.pnlMenu.Location = new System.Drawing.Point(20, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(841, 25);
            this.pnlMenu.TabIndex = 8;
            this.pnlMenu.VerticalScrollbar = true;
            this.pnlMenu.VerticalScrollbarBarColor = true;
            this.pnlMenu.VerticalScrollbarHighlightOnWheel = false;
            this.pnlMenu.VerticalScrollbarSize = 10;
            // 
            // btnAbout
            // 
            this.btnAbout.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAbout.Location = new System.Drawing.Point(146, 0);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 25);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseSelectable = true;
            this.btnAbout.UseStyleColors = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnView
            // 
            this.btnView.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnView.Location = new System.Drawing.Point(73, 0);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(73, 25);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View";
            this.btnView.UseSelectable = true;
            this.btnView.UseStyleColors = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFile.Location = new System.Drawing.Point(0, 0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(73, 25);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "File";
            this.btnFile.UseSelectable = true;
            this.btnFile.UseStyleColors = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // menuFile
            // 
            this.menuFile.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.newProjectToolStripMenuItem,
            this.saveProjectToolStripMenuItem,
            this.saveProjectAsToolStripMenuItem,
            this.importWAVMP3ToolStripMenuItem,
            this.exportWAVMP3ToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(168, 158);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.newProjectToolStripMenuItem.Text = "New project";
            // 
            // saveProjectToolStripMenuItem
            // 
            this.saveProjectToolStripMenuItem.Name = "saveProjectToolStripMenuItem";
            this.saveProjectToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveProjectToolStripMenuItem.Text = "Save project";
            // 
            // saveProjectAsToolStripMenuItem
            // 
            this.saveProjectAsToolStripMenuItem.Name = "saveProjectAsToolStripMenuItem";
            this.saveProjectAsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.saveProjectAsToolStripMenuItem.Text = "Save project as";
            // 
            // importWAVMP3ToolStripMenuItem
            // 
            this.importWAVMP3ToolStripMenuItem.Name = "importWAVMP3ToolStripMenuItem";
            this.importWAVMP3ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.importWAVMP3ToolStripMenuItem.Text = "Import WAV/MP3";
            // 
            // exportWAVMP3ToolStripMenuItem
            // 
            this.exportWAVMP3ToolStripMenuItem.Name = "exportWAVMP3ToolStripMenuItem";
            this.exportWAVMP3ToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exportWAVMP3ToolStripMenuItem.Text = "Export WAV/MP3";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuView
            // 
            this.menuView.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesStylesToolStripMenuItem});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(152, 26);
            // 
            // themesStylesToolStripMenuItem
            // 
            this.themesStylesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themesToolStripMenuItem,
            this.stylesToolStripMenuItem});
            this.themesStylesToolStripMenuItem.Name = "themesStylesToolStripMenuItem";
            this.themesStylesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.themesStylesToolStripMenuItem.Text = "Themes & styles";
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
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // stylesToolStripMenuItem
            // 
            this.stylesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.silverToolStripMenuItem,
            this.limeToolStripMenuItem,
            this.magentaToolStripMenuItem,
            this.brownToolStripMenuItem,
            this.orangeToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.purpleToolStripMenuItem,
            this.redToolStripMenuItem,
            this.tealToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.yelowToolStripMenuItem});
            this.stylesToolStripMenuItem.Name = "stylesToolStripMenuItem";
            this.stylesToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.stylesToolStripMenuItem.Text = "Styles";
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // silverToolStripMenuItem
            // 
            this.silverToolStripMenuItem.Name = "silverToolStripMenuItem";
            this.silverToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.silverToolStripMenuItem.Text = "Silver";
            this.silverToolStripMenuItem.Click += new System.EventHandler(this.silverToolStripMenuItem_Click);
            // 
            // limeToolStripMenuItem
            // 
            this.limeToolStripMenuItem.Name = "limeToolStripMenuItem";
            this.limeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.limeToolStripMenuItem.Text = "Lime";
            this.limeToolStripMenuItem.Click += new System.EventHandler(this.limeToolStripMenuItem_Click);
            // 
            // magentaToolStripMenuItem
            // 
            this.magentaToolStripMenuItem.Name = "magentaToolStripMenuItem";
            this.magentaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.magentaToolStripMenuItem.Text = "Magenta";
            this.magentaToolStripMenuItem.Click += new System.EventHandler(this.magentaToolStripMenuItem_Click);
            // 
            // brownToolStripMenuItem
            // 
            this.brownToolStripMenuItem.Name = "brownToolStripMenuItem";
            this.brownToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.brownToolStripMenuItem.Text = "Brown";
            this.brownToolStripMenuItem.Click += new System.EventHandler(this.brownToolStripMenuItem_Click);
            // 
            // orangeToolStripMenuItem
            // 
            this.orangeToolStripMenuItem.Name = "orangeToolStripMenuItem";
            this.orangeToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.orangeToolStripMenuItem.Text = "Orange";
            this.orangeToolStripMenuItem.Click += new System.EventHandler(this.orangeToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // tealToolStripMenuItem
            // 
            this.tealToolStripMenuItem.Name = "tealToolStripMenuItem";
            this.tealToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.tealToolStripMenuItem.Text = "Teal";
            this.tealToolStripMenuItem.Click += new System.EventHandler(this.tealToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // yelowToolStripMenuItem
            // 
            this.yelowToolStripMenuItem.Name = "yelowToolStripMenuItem";
            this.yelowToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.yelowToolStripMenuItem.Text = "Yellow";
            this.yelowToolStripMenuItem.Click += new System.EventHandler(this.yelowToolStripMenuItem_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuAbout.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.Size = new System.Drawing.Size(108, 48);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // timeLine
            // 
            this.timeLine.AutoScroll = true;
            this.timeLine.BackColor = System.Drawing.SystemColors.Control;
            this.timeLine.Location = new System.Drawing.Point(0, 0);
            this.timeLine.Margin = new System.Windows.Forms.Padding(4);
            this.timeLine.Name = "timeLine";
            this.timeLine.Size = new System.Drawing.Size(1724, 31);
            this.timeLine.TabIndex = 0;
            // 
            // frmMatf
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(881, 483);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlTopBar);
            this.Controls.Add(this.pnlSong);
            this.Controls.Add(this.pnlSideBar);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(450, 374);
            this.Name = "frmMatf";
            this.Text = "Master Audio Technology Functions";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.ResizeEnd += new System.EventHandler(this.frmMatf_ResizeEnd);
            this.pnlTopBar.ResumeLayout(false);
            this.pnlTopBar.PerformLayout();
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            this.pnlVolume.ResumeLayout(false);
            this.pnlPlay.ResumeLayout(false);
            this.pnlPlay.PerformLayout();
            this.pnlSong.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.menuFile.ResumeLayout(false);
            this.menuView.ResumeLayout(false);
            this.menuAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Timeline.Timeline timeLine;
        private System.Windows.Forms.Timer tmrMain;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroScrollBar progressBar;
        private MetroFramework.Controls.MetroTrackBar volumeBar;
        private MetroFramework.Controls.MetroLabel lblTimeElapsed;
        private MetroFramework.Controls.MetroPanel pnlMenu;
        private MetroFramework.Controls.MetroButton btnFile;
        private MetroFramework.Controls.MetroButton btnPlay;
        private MetroFramework.Controls.MetroButton btnStop;
        private MetroFramework.Controls.MetroButton btnLoop;
        private MetroFramework.Controls.MetroLabel volumeLabel;
        private MetroFramework.Controls.MetroPanel pnlTopBar;
        private MetroFramework.Controls.MetroPanel pnlSideBar;
        private MetroFramework.Controls.MetroPanel pnlVolume;
        private MetroFramework.Controls.MetroPanel pnlSong;
        private MetroFramework.Controls.MetroPanel pnlPlay;
        private MetroFramework.Controls.MetroButton btnView;
        private MetroFramework.Controls.MetroButton btnAbout;
        private MetroFramework.Controls.MetroContextMenu menuFile;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveProjectAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importWAVMP3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportWAVMP3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu menuView;
        private System.Windows.Forms.ToolStripMenuItem themesStylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stylesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu menuAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem silverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem magentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brownToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orangeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tealToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yelowToolStripMenuItem;
    }
}

