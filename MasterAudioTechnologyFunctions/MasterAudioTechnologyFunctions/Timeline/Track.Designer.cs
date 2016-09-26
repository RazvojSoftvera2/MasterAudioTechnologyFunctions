using System;

namespace MasterAudioTechnologyFunctions.Timeline
{
    partial class Track
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
            this.lblTrackName = new MetroFramework.Controls.MetroLabel();
            this.pnlWaveViewer = new MetroFramework.Controls.MetroPanel();
            this.pnlInfo = new MetroFramework.Controls.MetroPanel();
            this.btnChange = new MetroFramework.Controls.MetroButton();
            this.btnCloseTrack = new MetroFramework.Controls.MetroButton();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrackName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTrackName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrackName.Location = new System.Drawing.Point(0, 0);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(68, 19);
            this.lblTrackName.TabIndex = 1;
            this.lblTrackName.Text = "New Track";
            this.lblTrackName.UseStyleColors = true;
            // 
            // pnlWaveViewer
            // 
            this.pnlWaveViewer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWaveViewer.HorizontalScrollbarBarColor = true;
            this.pnlWaveViewer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlWaveViewer.HorizontalScrollbarSize = 10;
            this.pnlWaveViewer.Location = new System.Drawing.Point(0, 22);
            this.pnlWaveViewer.Name = "pnlWaveViewer";
            this.pnlWaveViewer.Size = new System.Drawing.Size(8000, 39);
            this.pnlWaveViewer.TabIndex = 2;
            this.pnlWaveViewer.VerticalScrollbarBarColor = true;
            this.pnlWaveViewer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlWaveViewer.VerticalScrollbarSize = 10;
            this.pnlWaveViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWaveViewer_MouseUp);
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.btnChange);
            this.pnlInfo.Controls.Add(this.btnCloseTrack);
            this.pnlInfo.Controls.Add(this.lblTrackName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.HorizontalScrollbarBarColor = true;
            this.pnlInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInfo.HorizontalScrollbarSize = 10;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(649, 22);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.VerticalScrollbarBarColor = true;
            this.pnlInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInfo.VerticalScrollbarSize = 10;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.SystemColors.Control;
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnChange.Location = new System.Drawing.Point(554, 0);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(67, 20);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Change";
            this.btnChange.UseSelectable = true;
            this.btnChange.UseStyleColors = true;
            this.btnChange.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCloseTrack
            // 
            this.btnCloseTrack.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseTrack.Location = new System.Drawing.Point(621, 0);
            this.btnCloseTrack.Name = "btnCloseTrack";
            this.btnCloseTrack.Size = new System.Drawing.Size(26, 20);
            this.btnCloseTrack.TabIndex = 5;
            this.btnCloseTrack.Text = "X";
            this.btnCloseTrack.UseSelectable = true;
            this.btnCloseTrack.UseStyleColors = true;
            this.btnCloseTrack.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlWaveViewer);
            this.Controls.Add(this.pnlInfo);
            this.Name = "Track";
            this.Size = new System.Drawing.Size(649, 61);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTrackName;
        private MetroFramework.Controls.MetroPanel pnlInfo;
        private MetroFramework.Controls.MetroPanel pnlWaveViewer;
        private MetroFramework.Controls.MetroButton btnChange;
        private MetroFramework.Controls.MetroButton btnCloseTrack;
    }
}
