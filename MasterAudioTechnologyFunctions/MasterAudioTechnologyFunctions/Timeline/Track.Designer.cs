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
            this.BtnX = new MetroFramework.Controls.MetroButton();
            this.BtnDelete = new MetroFramework.Controls.MetroButton();
            this.EditBtn = new MetroFramework.Controls.MetroButton();
            this.BtnSelect = new MetroFramework.Controls.MetroButton();
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
            this.lblTrackName.Location = new System.Drawing.Point(-3, -1);
            this.lblTrackName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(74, 20);
            this.lblTrackName.TabIndex = 1;
            this.lblTrackName.Text = "New Track";
            this.lblTrackName.UseStyleColors = true;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInfo.Controls.Add(this.BtnX);
            this.pnlInfo.Controls.Add(this.BtnDelete);
            this.pnlInfo.Controls.Add(this.EditBtn);
            this.pnlInfo.Controls.Add(this.BtnSelect);
            this.pnlInfo.Controls.Add(this.btnEdit);
            this.pnlInfo.Controls.Add(this.lblTrackName);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlInfo.HorizontalScrollbarBarColor = true;
            this.pnlInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlInfo.HorizontalScrollbarSize = 12;
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(122, 75);
            this.pnlInfo.TabIndex = 0;
            this.pnlInfo.VerticalScrollbarBarColor = true;
            this.pnlInfo.VerticalScrollbarHighlightOnWheel = false;
            this.pnlInfo.VerticalScrollbarSize = 13;
            // 
            // BtnX
            // 
            this.BtnX.Location = new System.Drawing.Point(88, -1);
            this.BtnX.Margin = new System.Windows.Forms.Padding(4);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(35, 23);
            this.BtnX.TabIndex = 5;
            this.BtnX.Text = "X";
            this.BtnX.UseSelectable = true;
            this.BtnX.UseStyleColors = true;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.SystemColors.Control;
            this.BtnDelete.Location = new System.Drawing.Point(76, 21);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(39, 28);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseSelectable = true;
            this.BtnDelete.UseStyleColors = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.Location = new System.Drawing.Point(40, 21);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(36, 28);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseSelectable = true;
            this.EditBtn.UseStyleColors = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.BackColor = System.Drawing.SystemColors.Control;
            this.BtnSelect.Location = new System.Drawing.Point(4, 21);
            this.BtnSelect.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(36, 28);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseSelectable = true;
            this.BtnSelect.UseStyleColors = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.Control;
            this.btnEdit.Location = new System.Drawing.Point(4, 48);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 23);
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
            this.pnlWaveViewer.HorizontalScrollbarSize = 12;
            this.pnlWaveViewer.Location = new System.Drawing.Point(122, 0);
            this.pnlWaveViewer.Margin = new System.Windows.Forms.Padding(4);
            this.pnlWaveViewer.Name = "pnlWaveViewer";
            this.pnlWaveViewer.Size = new System.Drawing.Size(743, 75);
            this.pnlWaveViewer.TabIndex = 2;
            this.pnlWaveViewer.VerticalScrollbarBarColor = true;
            this.pnlWaveViewer.VerticalScrollbarHighlightOnWheel = false;
            this.pnlWaveViewer.VerticalScrollbarSize = 13;
            this.pnlWaveViewer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlWaveViewer_MouseUp);
            // 
            // Track
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlWaveViewer);
            this.Controls.Add(this.pnlInfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Track";
            this.Size = new System.Drawing.Size(865, 75);
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblTrackName;
        private MetroFramework.Controls.MetroPanel pnlInfo;
        private MetroFramework.Controls.MetroPanel pnlWaveViewer;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton BtnDelete;
        private MetroFramework.Controls.MetroButton EditBtn;
        private MetroFramework.Controls.MetroButton BtnSelect;
        private MetroFramework.Controls.MetroButton BtnX;
    }
}
