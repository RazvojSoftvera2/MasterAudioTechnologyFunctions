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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnAddTrack = new System.Windows.Forms.Button();
            this.pnlTracks = new System.Windows.Forms.Panel();
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.tmrSong = new System.Windows.Forms.Timer(this.components);
            this.pnlBottom.SuspendLayout();
            this.pnlTracks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.Color.Transparent;
            this.pnlBottom.Controls.Add(this.btnAddTrack);
            this.pnlBottom.Location = new System.Drawing.Point(0, 1);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(477, 30);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnAddTrack
            // 
            this.btnAddTrack.BackgroundImage = global::MasterAudioTechnologyFunctions.Properties.Resources.plus;
            this.btnAddTrack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTrack.Location = new System.Drawing.Point(3, 3);
            this.btnAddTrack.Name = "btnAddTrack";
            this.btnAddTrack.Size = new System.Drawing.Size(25, 23);
            this.btnAddTrack.TabIndex = 0;
            this.btnAddTrack.UseVisualStyleBackColor = true;
            // 
            // pnlTracks
            // 
            this.pnlTracks.BackColor = System.Drawing.Color.Transparent;
            this.pnlTracks.Controls.Add(this.btnAdd);
            this.pnlTracks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTracks.Location = new System.Drawing.Point(0, 0);
            this.pnlTracks.Name = "pnlTracks";
            this.pnlTracks.Size = new System.Drawing.Size(477, 31);
            this.pnlTracks.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(30, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tmrSong
            // 
            this.tmrSong.Interval = 10;
            this.tmrSong.Tick += new System.EventHandler(this.tmrSong_Tick);
            // 
            // Timeline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.Controls.Add(this.pnlTracks);
            this.Controls.Add(this.pnlBottom);
            this.Name = "Timeline";
            this.Size = new System.Drawing.Size(477, 31);
            this.pnlBottom.ResumeLayout(false);
            this.pnlTracks.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTrack;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlTracks;
        private System.Windows.Forms.Timer tmrSong;
        private MetroFramework.Controls.MetroButton btnAdd;
    }
}
