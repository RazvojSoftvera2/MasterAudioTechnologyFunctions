﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class AddNewTrack : MetroForm
    {
        public string TrackName { get; set; }
        public string TrackFileName { get; set; }
        public Color TrackColor { get; set; }
        private string SettingsPath = "..\\..\\settings.xml";
        private frmMatf aFrmMatf;
        public string Note;
        private string ProjectDefaultNote;
        public List<string> Notes;

        public AddNewTrack(frmMatf aFrmMatf)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManagerAddTrack;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cdColorPicker.Color = Color.White;
            this.aFrmMatf = aFrmMatf;
            Notes = aFrmMatf.Notes;
            cmbbNotes.Items.AddRange(Notes.ToArray());
            cmbbNotes.SelectedItem = "C4 ";
            //TODO: change to read from project file (.matf) once that is implemented //PD
            ProjectDefaultNote = "C4 ";
            setStyle();
        }

        public AddNewTrack(string name, string fileName, Color color, frmMatf aFrmMatf)
        {
            InitializeComponent();
            this.StyleManager = metroStyleManagerAddTrack;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            TrackName = name;
            TrackFileName = fileName;
            TrackColor = color;

            cdColorPicker.Color = TrackColor;
            tbName.Text = TrackName;
            Text = "Edit Track";
            this.aFrmMatf = aFrmMatf;
            Notes = aFrmMatf.Notes;
            cmbbNotes.Items.AddRange(Notes.ToArray());
            cmbbNotes.SelectedItem = "C4 ";
            //TODO: change to read from project file (.matf) once that is implemented //PD
            ProjectDefaultNote = "C4 ";
            setStyle();
        }

        public void setStyle()
        {
            //settings loading
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load(SettingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            metroStyleManagerAddTrack.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            metroStyleManagerAddTrack.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbName.Text.Trim()))
            {
                MetroMessageBox.Show(this, "Track name cannot be empty.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(TrackFileName))
            {
                MetroMessageBox.Show(this, "You must open a sound file for the track.",
                                "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TrackName = tbName.Text.Trim();
            TrackColor = cdColorPicker.Color;

            if(chkbProjectDefault.Checked)
            {
                Note = ProjectDefaultNote;
            }
            else
            {
                Note = (string)cmbbNotes.SelectedItem;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (cdColorPicker.ShowDialog() != DialogResult.OK)
                return;

            TrackColor = cdColorPicker.Color;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Waveform audio files (.wav)|*.wav|MP3 files (.mp3)|*.mp3";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            TrackFileName = dialog.FileName;
        }

        private void chkbProjectDefault_CheckedChanged(object sender, EventArgs e)
        {
            if(chkbProjectDefault.Checked)
            {
                cmbbNotes.Enabled = false;
            }
            else
            {
                cmbbNotes.Enabled = true;
            }
        }
    }
}
