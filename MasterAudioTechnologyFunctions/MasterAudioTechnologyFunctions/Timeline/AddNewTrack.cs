using MetroFramework;
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

        public AddNewTrack()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManagerAddTrack;

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Resizable = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cdColorPicker.Color = Color.White;

            setStyle();
        }

        public AddNewTrack(string name, string fileName, Color color)
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

            setStyle();
        }

        public void setStyle()
        {
            //settings loading
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
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
                MessageBox.Show("Track name cannot be empty.", frmMatf.SoftwareName);
                tbName.Focus();
                return;
            }

            if (String.IsNullOrEmpty(TrackFileName))
            {
                MessageBox.Show("You must open a sound file for the track.", frmMatf.SoftwareName);
                return;
            }

            TrackName = tbName.Text.Trim();
            TrackColor = cdColorPicker.Color;

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
