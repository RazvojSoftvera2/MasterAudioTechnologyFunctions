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
            this.lblTrackName = new System.Windows.Forms.Label();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlWaveViewer = new System.Windows.Forms.Panel();
            this.wvTrack = new MasterAudioTechnologyFunctions.Timeline.WaveViewer();
            this.pnlInfo.SuspendLayout();
            this.pnlWaveViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrackName.Location = new System.Drawing.Point(6, 8);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(82, 16);
            this.lblTrackName.TabIndex = 1;
            this.lblTrackName.Text = "New Track";
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.btnEdit);
            this.pnlInfo.Controls.Add(this.lblTrackName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(92, 61);
            this.pnlInfo.TabIndex = 0;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(9, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlWaveViewer
            // 
            this.pnlWaveViewer.Controls.Add(this.wvTrack);
            this.pnlWaveViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWaveViewer.Location = new System.Drawing.Point(92, 0);
            this.pnlWaveViewer.Name = "pnlWaveViewer";
            this.pnlWaveViewer.Size = new System.Drawing.Size(557, 61);
            this.pnlWaveViewer.TabIndex = 2;
            // 
            // wvTrack
            // 
            this.wvTrack.BackColor = System.Drawing.Color.Gray;
            this.wvTrack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvTrack.Location = new System.Drawing.Point(0, 0);
            this.wvTrack.Name = "wvTrack";
            this.wvTrack.PenColor = System.Drawing.Color.White;
            this.wvTrack.PenWidth = 1F;
            this.wvTrack.SamplesPerPixel = 128;
            this.wvTrack.Size = new System.Drawing.Size(557, 61);
            this.wvTrack.StartPosition = ((long)(0));
            this.wvTrack.TabIndex = 0;
            this.wvTrack.WaveStream = null;
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
            this.pnlWaveViewer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlWaveViewer;
        private System.Windows.Forms.Button btnEdit;
        private MasterAudioTechnologyFunctions.Timeline.WaveViewer wvTrack;
    }
}
