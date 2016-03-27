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
        public string TrackName { get; set; }
        public string TrackFileName { get; set; }
        public Color TrackColor { get; set; }

        private bool _playing = false;

        private WaveOut _waveOut;
        private WaveOffsetStream _waveOffsetStream;
        private WaveFileReader _waveFileReader;

        public Track()
        {
            InitializeComponent();
        }

        public Track(string name, string fileName, Color color)
        {
            InitializeComponent();
            InitializeTrack(name, fileName, color);
        }

        private void InitializeTrack(string name, string fileName, Color color)
        {
            TrackName = name;
            TrackFileName = fileName;
            TrackColor = color;

            _waveOut = new WaveOut();
            _waveFileReader = new WaveFileReader(TrackFileName);
            _waveOffsetStream = new WaveOffsetStream(_waveFileReader);
            _waveOut.Init(_waveOffsetStream);

            lblTrackName.Text = TrackName;
            wvTrack.WaveStream = _waveFileReader;
            wvTrack.PenColor = TrackColor;

            wvTrack.FitToScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNewTrack editTrack = new AddNewTrack(TrackName, TrackFileName, TrackColor);
            if (editTrack.ShowDialog() != DialogResult.OK)
                return;

            InitializeTrack(editTrack.TrackName, editTrack.TrackFileName, editTrack.TrackColor);
        }
        
        private void Play()
        {
            if (_waveOut == null)
                return;

            _playing = true;
            //btnPlay.Text = "Pa";
            //tmrSong.Enabled = true;

            if (_waveOut.GetPosition() == 0)
            {
                _waveOut.Play();
            }
            else
            {
                _waveOut.Resume();
            }
        }

        private void Pause()
        {
            if (_waveOut == null)
                return;

            _playing = false;
            //btnPlay.Text = "Pl";
            //tmrSong.Enabled = false;

            _waveOut.Pause();
        }

        private void Stop()
        {
            if (_waveOut == null)
                return;

            _playing = false;
            //btnPlay.Text = "Pl";
            //tmrSong.Enabled = false;

            _waveOut.Stop();
            _waveOffsetStream.CurrentTime = new TimeSpan(0);

            //trbTime.Value = 0;

            TimeSpan time = _waveOffsetStream.CurrentTime;
            //lblTimeElapsed.Text = time.ToString(@"mm\:ss\:fff");
        }
    }
}
