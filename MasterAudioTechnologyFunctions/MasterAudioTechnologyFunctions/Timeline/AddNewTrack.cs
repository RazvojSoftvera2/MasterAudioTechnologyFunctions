using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class AddNewTrack : Form
    {
        public string TrackName { get; set; }
        public string TrackFileName { get; set; }
        public Color TrackColor { get; set; }

        public AddNewTrack()
        {
            InitializeComponent();
        }

        public AddNewTrack(string name, string fileName, Color color)
        {
            InitializeComponent();

            TrackName = name;
            TrackFileName = fileName;
            TrackColor = color;

            cdColorPicker.Color = TrackColor;
            Text = "Edit Track";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TrackName = tbName.Text.Trim();

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
            dialog.Filter = "Waveform audio files (.wav)|*.wav";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            TrackFileName = dialog.FileName;
        }
    }
}
