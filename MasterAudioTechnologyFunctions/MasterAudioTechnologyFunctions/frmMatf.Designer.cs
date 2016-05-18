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
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlVolume = new System.Windows.Forms.Panel();
            this.pnlSong = new System.Windows.Forms.Panel();
            this.btnFile = new MetroFramework.Controls.MetroButton();
            this.fileMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveProjectAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importWavmp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAsWavmp3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnView = new MetroFramework.Controls.MetroButton();
            this.viewMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.themesAndButtonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new MetroFramework.Controls.MetroButton();
            this.helpMenu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeLine = new MasterAudioTechnologyFunctions.Timeline.Timeline();
            this.pnlTopBar.SuspendLayout();
            this.pnlPlay.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.pnlSong.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.viewMenu.SuspendLayout();
            this.helpMenu.SuspendLayout();
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
            this.pnlTopBar.Leave += new System.EventHandler(this.pnlMenu_Leave);
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
            this.pnlVolume.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlVolume.Location = new System.Drawing.Point(0, 0);
            this.pnlVolume.Name = "pnlVolume";
            this.pnlVolume.Size = new System.Drawing.Size(113, 207);
            this.pnlVolume.TabIndex = 4;
            // 
            // pnlSong
            // 
            this.pnlSong.AutoScroll = true;
            this.pnlSong.BackColor = System.Drawing.Color.Transparent;
            this.pnlSong.Controls.Add(this.timeLine);
            this.pnlSong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSong.Location = new System.Drawing.Point(20, 60);
            this.pnlSong.Name = "pnlSong";
            this.pnlSong.Size = new System.Drawing.Size(866, 391);
            this.pnlSong.TabIndex = 4;
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
            // timeLine
            // 
            this.timeLine.BackColor = System.Drawing.Color.DarkGray;
            this.timeLine.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLine.Location = new System.Drawing.Point(0, 0);
            this.timeLine.Name = "timeLine";
            this.timeLine.Size = new System.Drawing.Size(866, 31);
            this.timeLine.TabIndex = 0;
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
            this.pnlSong.ResumeLayout(false);
            this.fileMenu.ResumeLayout(false);
            this.viewMenu.ResumeLayout(false);
            this.helpMenu.ResumeLayout(false);
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
    }
}

