﻿namespace MasterAudioTechnologyFunctions.Timeline
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
            this.lblName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.cdColorPicker = new System.Windows.Forms.ColorDialog();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblName.Location = new System.Drawing.Point(9, 62);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbName.Location = new System.Drawing.Point(56, 62);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Text = "New Track";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(12, 117);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(144, 23);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "Choose color";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 146);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(71, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(85, 146);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(71, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(12, 88);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(144, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Choose sound file";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // AddNewTrack
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(166, 190);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog cdColorPicker;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOpen;
    }
}