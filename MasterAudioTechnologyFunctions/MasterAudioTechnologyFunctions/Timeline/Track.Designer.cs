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
            this.pnlInfo = new MetroFramework.Controls.MetroPanel();
            this.cmbbNotes = new MetroFramework.Controls.MetroComboBox();
            this.BtnX = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.pnlWaveViewer = new MetroFramework.Controls.MetroPanel();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.BackColor = System.Drawing.SystemColors.Control;
            this.lblTrackName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrackName.Location = new System.Drawing.Point(-2, -1);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(68, 19);
            this.lblTrackName.TabIndex = 1;
            this.lblTrackName.Text = "New Track";
            this.lblTrackName.UseStyleColors = true;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.cmbbNotes);
            this.pnlInfo.Controls.Add(this.BtnX);
            this.pnlInfo.Controls.Add(this.btnEdit);
            this.pnlInfo.Controls.Add(this.lblTrackName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.HorizontalScrollbarBarColor = true;
            this.pnlInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInfo.HorizontalScrollbarSize = 10;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(92, 61);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.VerticalScrollbarBarColor = true;
            this.pnlInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInfo.VerticalScrollbarSize = 10;
            // 
            // cmbbNotes
            // 
            this.cmbbNotes.AutoCompleteCustomSource.AddRange(new string[] {
            "C1",
            "C#1",
            "D1",
            "D#1",
            "E1",
            "F1",
            "F#1",
            "G1",
            "G#1",
            "A1",
            "A#1",
            "B1",
            "C2",
            "C#2",
            "D2",
            "D#2",
            "E2",
            "F2",
            "F#2",
            "G2",
            "G#2",
            "A2",
            "A#2",
            "B2",
            "C3",
            "C#3",
            "D3",
            "D#3",
            "E3",
            "F3",
            "F#3",
            "G3",
            "G#3",
            "A3",
            "A#3",
            "B3",
            "C4",
            "C#4",
            "D4",
            "D#4",
            "E4",
            "F4",
            "F#4",
            "G4",
            "G#",
            "A4",
            "A#4",
            "B4",
            "C5",
            "C#5",
            "D5",
            "D#5",
            "E5",
            "F5",
            "F#5",
            "G5",
            "G#5",
            "A5",
            "A#5",
            "B5",
            "C6",
            "C#6",
            "D6",
            "D#6",
            "E6",
            "F6",
            "F#6",
            "G6",
            "G#6",
            "A6",
            "A#6",
            "B6",
            "C7",
            "C#7",
            "D7",
            "D#7",
            "E7",
            "F7",
            "F#7",
            "G7",
            "G#7",
            "A7",
            "A#7",
            "B7",
            "C8",
            "C#8",
            "D8",
            "D#8",
            "E8",
            "F8",
            "F#8",
            "G8",
            "G#8",
            "A8",
            "A#8",
            "B8",
            "C9"});
            this.cmbbNotes.FormattingEnabled = true;
            this.cmbbNotes.ItemHeight = 23;
            this.cmbbNotes.Location = new System.Drawing.Point(2, 21);
            this.cmbbNotes.Name = "cmbbNotes";
            this.cmbbNotes.Size = new System.Drawing.Size(86, 29);
            this.cmbbNotes.TabIndex = 2;
            this.cmbbNotes.UseSelectable = true;
            this.cmbbNotes.UseStyleColors = true;
            this.cmbbNotes.SelectedIndexChanged += new System.EventHandler(this.cmbbNotes_SelectedIndexChanged);
            // 
            // BtnX
            // 
            this.BtnX.Location = new System.Drawing.Point(66, -1);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(26, 19);
            this.BtnX.TabIndex = 5;
            this.BtnX.Text = "X";
            this.BtnX.UseSelectable = true;
            this.BtnX.UseStyleColors = true;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(3, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 19);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlWaveViewer
            // 
            this.pnlWaveViewer.BackColor = System.Drawing.SystemColors.Control;
            this.pnlWaveViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWaveViewer.HorizontalScrollbarBarColor = true;
            this.pnlWaveViewer.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlWaveViewer.HorizontalScrollbarSize = 10;
            this.pnlWaveViewer.Location = new System.Drawing.Point(92, 0);
            this.pnlWaveViewer.Name = "pnlWaveViewer";
            this.pnlWaveViewer.Size = new System.Drawing.Size(557, 61);
            this.pnlWaveViewer.TabIndex = 2;
            this.pnlWaveViewer.VerticalScrollbarBarColor = true;
            this.pnlWaveViewer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlWaveViewer.VerticalScrollbarSize = 10;
            this.pnlWaveViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWaveViewer_MouseUp);
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
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton BtnX;
        private MetroFramework.Controls.MetroComboBox cmbbNotes;
    }
}
