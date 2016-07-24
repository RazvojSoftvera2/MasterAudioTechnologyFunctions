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
            this.pnlBottom = new MetroFramework.Controls.MetroPanel();
            this.timelineCursor = new MasterAudioTechnologyFunctions.Timeline.TimelineCursor();
            this.changeProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.btnAddTrack = new MetroFramework.Controls.MetroButton();
            this.pnlTracks = new MetroFramework.Controls.MetroPanel();
            this.tmrSong = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBottom.Controls.Add(this.timelineCursor);
            this.pnlBottom.Controls.Add(this.changeProgressBar);
            this.pnlBottom.Controls.Add(this.btnAddTrack);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.HorizontalScrollbarBarColor = true;
            this.pnlBottom.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBottom.HorizontalScrollbarSize = 10;
            this.pnlBottom.Location = new System.Drawing.Point(0, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(477, 28);
            this.pnlBottom.TabIndex = 1;
            this.pnlBottom.VerticalScrollbarBarColor = true;
            this.pnlBottom.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBottom.VerticalScrollbarSize = 10;
            // 
            // timelineCursor
            // 
            this.timelineCursor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timelineCursor.Location = new System.Drawing.Point(92, 0);
            this.timelineCursor.Name = "timelineCursor";
            this.timelineCursor.Size = new System.Drawing.Size(2, 10);
            this.timelineCursor.TabIndex = 3;
            this.timelineCursor.UseSelectable = true;
            this.timelineCursor.Visible = false;
            // 
            // changeProgressBar
            // 
            this.changeProgressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeProgressBar.Location = new System.Drawing.Point(0, 0);
            this.changeProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.changeProgressBar.Name = "changeProgressBar";
            this.changeProgressBar.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.changeProgressBar.Size = new System.Drawing.Size(477, 28);
            this.changeProgressBar.TabIndex = 2;
            this.changeProgressBar.Visible = false;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.BackColor = System.Drawing.Color.White;
            this.btnAddTrack.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAddTrack.Location = new System.Drawing.Point(0, 2);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(27, 23);
            this.btnAddTrack.TabIndex = 0;
            this.btnAddTrack.Text = "+";
            this.btnAddTrack.UseSelectable = true;
            this.btnAddTrack.UseStyleColors = true;
            this.btnAddTrack.Click += new System.EventHandler(this.btnAddTrack_Click);
            // 
            // pnlTracks
            // 
            this.pnlTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTracks.HorizontalScrollbarBarColor = true;
            this.pnlTracks.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlTracks.HorizontalScrollbarSize = 10;
            this.pnlTracks.Location = new System.Drawing.Point(0, 0);
            this.pnlTracks.Name = "pnlTracks";
            this.pnlTracks.Size = new System.Drawing.Size(477, 3);
            this.pnlTracks.TabIndex = 0;
            this.pnlTracks.VerticalScrollbarBarColor = true;
            this.pnlTracks.VerticalScrollbarHighlightOnWheel = false;
            this.pnlTracks.VerticalScrollbarSize = 10;
            // 
            // tmrSong
            // 
            this.tmrSong.Tick += new System.EventHandler(this.tmrSong_Tick);
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlTracks);
            this.Controls.Add(this.pnlBottom);
            this.Name = "Timeline";
            this.Size = new System.Drawing.Size(477, 31);
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroPanel pnlBottom;
        private MetroFramework.Controls.MetroPanel pnlTracks;
        private System.Windows.Forms.Timer tmrSong;
        private MetroFramework.Controls.MetroButton btnAddTrack;
        private MetroFramework.Controls.MetroProgressBar changeProgressBar;
        private TimelineCursor timelineCursor;
    }
}
