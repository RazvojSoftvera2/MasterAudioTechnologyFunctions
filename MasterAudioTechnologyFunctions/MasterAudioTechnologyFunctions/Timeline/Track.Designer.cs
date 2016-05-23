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
            this.BtnX = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlWaveViewer = new System.Windows.Forms.Panel();
            this.pnlInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTrackName
            // 
            this.lblTrackName.AutoSize = true;
            this.lblTrackName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrackName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTrackName.Location = new System.Drawing.Point(3, 0);
            this.lblTrackName.Name = "lblTrackName";
            this.lblTrackName.Size = new System.Drawing.Size(64, 13);
            this.lblTrackName.TabIndex = 1;
            this.lblTrackName.Text = "New Track";
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
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(92, 61);
            this.pnlInfo.TabIndex = 0;
            // 
            // BtnX
            // 
            this.BtnX.Location = new System.Drawing.Point(66, -1);
            this.BtnX.Name = "BtnX";
            this.BtnX.Size = new System.Drawing.Size(26, 20);
            this.BtnX.TabIndex = 5;
            this.BtnX.Text = "X";
            this.BtnX.UseVisualStyleBackColor = true;
            this.BtnX.Click += new System.EventHandler(this.BtnX_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(57, 17);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(29, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(30, 17);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(27, 23);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(3, 17);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(27, 23);
            this.BtnSelect.TabIndex = 2;
            this.BtnSelect.Text = "Select";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(3, 39);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(83, 19);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlWaveViewer
            // 
            this.pnlWaveViewer.BackColor = System.Drawing.Color.LightGray;
            this.pnlWaveViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWaveViewer.Location = new System.Drawing.Point(92, 0);
            this.pnlWaveViewer.Name = "pnlWaveViewer";
            this.pnlWaveViewer.Size = new System.Drawing.Size(557, 61);
            this.pnlWaveViewer.TabIndex = 2;
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

        private System.Windows.Forms.Label lblTrackName;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Panel pnlWaveViewer;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button BtnX;
    }
}
