using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class Track : UserControl
    {
        private string _name;
        private Color _color;
        private string _fileName;

        private WaveOut _waveOut;
        private WaveOffsetStream _waveOffsetStream;
        private WaveFileReader _waveFileReader;

        public Track()
        {
            InitializeComponent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNewTrack editTrack = new AddNewTrack(_name, _fileName, _color);
            if (editTrack.ShowDialog() != DialogResult.OK)
                return;

            _name = editTrack.TrackName;
            _fileName = editTrack.TrackFileName;
            _color = editTrack.TrackColor;
            
            _waveOut = new WaveOut();
            _waveFileReader = new WaveFileReader(_fileName);
            _waveOffsetStream = new WaveOffsetStream(_waveFileReader);
            _waveOut.Init(_waveOffsetStream);

            lblTrackName.Text = _name;
            wvTrack.WaveStream = _waveFileReader;
            wvTrack.PenColor = _color;

            wvTrack.FitToScreen();
        }
    }
}
