namespace MasterAudioTechnologyFunctions.Timeline
{
    partial class Timeline
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAddTrack = new MetroFramework.Controls.MetroButton();
            this.timelineCursor = new MasterAudioTechnologyFunctions.Timeline.TimelineCursor();
            this.pnlTracks = new MetroFramework.Controls.MetroPanel();
            this.tmrSong = new System.Windows.Forms.Timer(this.components);
            this.pnlButtons = new MetroFramework.Controls.MetroPanel();
            this.scrollBar = new MetroFramework.Controls.MetroScrollBar();
            this.btnSnapToGrid = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.BackColor = System.Drawing.Color.White;
            this.btnAddTrack.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.add;
            this.btnAddTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddTrack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddTrack.Location = new System.Drawing.Point(80, 3);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(25, 25);
            this.btnAddTrack.TabIndex = 0;
            this.btnAddTrack.UseSelectable = true;
            this.btnAddTrack.UseStyleColors = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // timelineCursor
            // 
            this.timelineCursor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelineCursor.Location = new System.Drawing.Point(0, 47);
            this.timelineCursor.Name = "timelineCursor";
            this.timelineCursor.Size = new System.Drawing.Size(2, 10);
            this.timelineCursor.TabIndex = 3;
            this.timelineCursor.UseCustomBackColor = true;
            this.timelineCursor.UseSelectable = true;
            this.timelineCursor.UseStyleColors = true;
            this.timelineCursor.Visible = false;
            // 
            // pnlTracks
            // 
            this.pnlTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTracks.HorizontalScrollbarBarColor = true;
            this.pnlTracks.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTracks.HorizontalScrollbarSize = 10;
            this.pnlTracks.Location = new System.Drawing.Point(0, 46);
            this.pnlTracks.Name = "pnlTracks";
            this.pnlTracks.Size = new System.Drawing.Size(477, 3);
            this.pnlTracks.TabIndex = 0;
            this.pnlTracks.UseStyleColors = true;
            this.pnlTracks.VerticalScrollbarBarColor = false;
            this.pnlTracks.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTracks.VerticalScrollbarSize = 10;
            // 
            // tmrSong
            // 
            this.tmrSong.Tick += new System.EventHandler(this.tmrSong_Tick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.scrollBar);
            this.pnlButtons.Controls.Add(this.btnSnapToGrid);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnEdit);
            this.pnlButtons.Controls.Add(this.btnAddTrack);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.HorizontalScrollbarBarColor = true;
            this.pnlButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlButtons.HorizontalScrollbarSize = 10;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(477, 46);
            this.pnlButtons.TabIndex = 2;
            this.pnlButtons.UseStyleColors = true;
            this.pnlButtons.VerticalScrollbarBarColor = true;
            this.pnlButtons.VerticalScrollbarHighlightOnWheel = false;
            this.pnlButtons.VerticalScrollbarSize = 10;
            // 
            // scrollBar
            // 
            this.scrollBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.scrollBar.LargeChange = 10;
            this.scrollBar.Location = new System.Drawing.Point(0, 31);
            this.scrollBar.Maximum = 3999;
            this.scrollBar.Minimum = 0;
            this.scrollBar.MouseWheelBarPartitions = 10;
            this.scrollBar.Name = "scrollBar";
            this.scrollBar.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.scrollBar.ScrollbarSize = 15;
            this.scrollBar.Size = new System.Drawing.Size(477, 15);
            this.scrollBar.TabIndex = 8;
            this.scrollBar.UseSelectable = true;
            this.scrollBar.Value = 1;
            this.scrollBar.Visible = false;
            this.scrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.scrollBar_Scroll);
            // 
            // btnSnapToGrid
            // 
            this.btnSnapToGrid.BackColor = System.Drawing.SystemColors.Control;
            this.btnSnapToGrid.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.snap;
            this.btnSnapToGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSnapToGrid.Location = new System.Drawing.Point(49, 3);
            this.btnSnapToGrid.Name = "btnSnapToGrid";
            this.btnSnapToGrid.Size = new System.Drawing.Size(25, 25);
            this.btnSnapToGrid.TabIndex = 7;
            this.btnSnapToGrid.UseSelectable = true;
            this.btnSnapToGrid.UseStyleColors = true;
            this.btnSnapToGrid.Click += new System.EventHandler(this.btnSnapToGrid_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.btnDelete.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.remove;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(25, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.UseStyleColors = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.edit;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(1, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(25, 25);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlTracks);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.timelineCursor);
            this.Name = "Timeline";
            this.Size = new System.Drawing.Size(477, 49);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private TimelineCursor timelineCursor;
        private MetroFramework.Controls.MetroPanel pnlTracks;
        private System.Windows.Forms.Timer tmrSong;
        private MetroFramework.Controls.MetroButton btnAddTrack;
        private MetroFramework.Controls.MetroPanel pnlButtons;
        private MetroFramework.Controls.MetroButton btnSnapToGrid;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroScrollBar scrollBar;
    }
}
