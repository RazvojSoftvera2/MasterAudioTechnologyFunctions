namespace MasterAudioTechnologyFunctions.Timeline
{
    partial class AddNewTrack
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
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.tbName = new MetroFramework.Controls.MetroTextBox();
            this.btnColor = new MetroFramework.Controls.MetroButton();
            this.cdColorPicker = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new MetroFramework.Controls.MetroButton();
            this.btnOk = new MetroFramework.Controls.MetroButton();
            this.btnOpen = new MetroFramework.Controls.MetroButton();
            this.metroStyleManagerAddTrack = new MetroFramework.Components.MetroStyleManager(this.components);
            this.cmbbNotes = new MetroFramework.Controls.MetroComboBox();
            this.chkbProjectDefault = new MetroFramework.Controls.MetroCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerAddTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(14, 66);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 19);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            this.lblName.UseStyleColors = true;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.tbName.CustomButton.Image = null;
            this.tbName.CustomButton.Location = new System.Drawing.Point(138, 2);
            this.tbName.CustomButton.Name = "";
            this.tbName.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.tbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbName.CustomButton.TabIndex = 1;
            this.tbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbName.CustomButton.UseSelectable = true;
            this.tbName.CustomButton.Visible = false;
            this.tbName.Lines = new string[] {
        "New Track"};
            this.tbName.Location = new System.Drawing.Point(65, 66);
            this.tbName.MaxLength = 32767;
            this.tbName.Name = "tbName";
            this.tbName.PasswordChar = '\0';
            this.tbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbName.SelectedText = "";
            this.tbName.SelectionLength = 0;
            this.tbName.SelectionStart = 0;
            this.tbName.ShortcutsEnabled = true;
            this.tbName.Size = new System.Drawing.Size(156, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "New Track";
            this.tbName.UseSelectable = true;
            this.tbName.UseStyleColors = true;
            this.tbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(17, 121);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(204, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseCustomBackColor = true;
            this.btnColor.UseSelectable = true;
            this.btnColor.UseStyleColors = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(17, 186);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseCustomBackColor = true;
            this.btnCancel.UseSelectable = true;
            this.btnCancel.UseStyleColors = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(121, 186);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(100, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseCustomBackColor = true;
            this.btnOk.UseSelectable = true;
            this.btnOk.UseStyleColors = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(17, 92);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(204, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Choose sound file";
            this.btnOpen.UseCustomBackColor = true;
            this.btnOpen.UseSelectable = true;
            this.btnOpen.UseStyleColors = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // metroStyleManagerAddTrack
            // 
            this.metroStyleManagerAddTrack.Owner = this;
            // 
            // cmbbNotes
            // 
            this.cmbbNotes.Enabled = false;
            this.cmbbNotes.FormattingEnabled = true;
            this.cmbbNotes.ItemHeight = 23;
            this.cmbbNotes.Location = new System.Drawing.Point(121, 150);
            this.cmbbNotes.Name = "cmbbNotes";
            this.cmbbNotes.Size = new System.Drawing.Size(100, 29);
            this.cmbbNotes.TabIndex = 6;
            this.cmbbNotes.UseSelectable = true;
            // 
            // chkbProjectDefault
            // 
            this.chkbProjectDefault.AutoSize = true;
            this.chkbProjectDefault.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.chkbProjectDefault.Checked = true;
            this.chkbProjectDefault.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbProjectDefault.Location = new System.Drawing.Point(14, 158);
            this.chkbProjectDefault.Name = "chkbProjectDefault";
            this.chkbProjectDefault.Size = new System.Drawing.Size(101, 15);
            this.chkbProjectDefault.TabIndex = 7;
            this.chkbProjectDefault.Text = "Project Default";
            this.chkbProjectDefault.UseSelectable = true;
            this.chkbProjectDefault.CheckedChanged += new System.EventHandler(this.chkbProjectDefault_CheckedChanged);
            // 
            // AddNewTrack
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(244, 229);
            this.Controls.Add(this.chkbProjectDefault);
            this.Controls.Add(this.cmbbNotes);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddNewTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Track";
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManagerAddTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnColor;
        private System.Windows.Forms.ColorDialog cdColorPicker;
        private MetroFramework.Controls.MetroButton btnCancel;
        private MetroFramework.Controls.MetroButton btnOk;
        private MetroFramework.Controls.MetroTextBox tbName;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroButton btnOpen;
        private MetroFramework.Components.MetroStyleManager metroStyleManagerAddTrack;
        private MetroFramework.Controls.MetroCheckBox chkbProjectDefault;
        private MetroFramework.Controls.MetroComboBox cmbbNotes;
    }
}