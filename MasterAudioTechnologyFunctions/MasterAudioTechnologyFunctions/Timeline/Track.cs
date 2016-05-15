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

        public int TrackLen { get; set; }

        public bool SelectMode = true;
        public bool EditMode = false;
        public bool DeleteMode = false;

        public List<WaveViewer> Tracks;
        public List<long> Times;

        // public bool Playing = false;
        public List<bool> Playing;

        public WaveOut WaveOut;
        public WaveOffsetStream WaveOffsetStream;
        public WaveFileReader WaveFileReader;
        public float TrackVolume = (float)0.7;



        private Timeline _timeline;

        public Track(Timeline tl)
        {
            InitializeComponent();
            _timeline = tl;
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
        }

        public Track(string name, string fileName, Color color, Timeline tl)
        {
            InitializeComponent();
            InitializeTrack(name, fileName, color, tl);
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
        }

        public long getTrackLength()
        {
            return WaveOffsetStream.Length;
        }

        private void InitializeTrack(string name, string fileName, Color color, Timeline tl)
        {
            TrackName = name;
            TrackFileName = fileName;
            TrackColor = color;


            if (tl!=null)
            {
                _timeline = tl;
            }

            WaveOut = new WaveOut();
            WaveFileReader = new WaveFileReader(TrackFileName);
            WaveOffsetStream = new WaveOffsetStream(WaveFileReader);
            WaveOut.Init(WaveOffsetStream);

            lblTrackName.Text = TrackName;

            TrackLen = (int)WaveOffsetStream.Length / 10000;

        }

        public void addSound(int startPosition)
        {
            WaveViewer wvTrack = new WaveViewer();
           
            wvTrack.WaveStream = WaveFileReader;
            wvTrack.PenColor = TrackColor;
            //TODO: Replace 10000 with something concrete 
            wvTrack.Height = pnlWaveViewer.Height;
            wvTrack.Width = TrackLen;
          //  wvTrack.FitToScreen();

            pnlWaveViewer.Controls.Add(wvTrack);
            wvTrack.Location = new Point(startPosition, 0);
            
            Tracks.Add(wvTrack);
            Times.Add(startPosition);
            Playing.Add(false);
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNewTrack editTrack = new AddNewTrack(TrackName, TrackFileName, TrackColor);
            if (editTrack.ShowDialog() != DialogResult.OK)
                return;

            InitializeTrack(editTrack.TrackName, editTrack.TrackFileName, editTrack.TrackColor, null);
        }
        
        public void Update(long globalTime)
        {
            foreach(long l in Times)
            {
                if(l==globalTime)
                {
                    Play();
                }
            }
        }

        public void Play()
        {
            if (WaveOut == null)
                return;

            WaveOut.Volume = TrackVolume;

            //Playing = true;
            //btnPlay.Text = "Pa";
            //tmrSong.Enabled = true;

            if (WaveOut.GetPosition() == 0)
            {
                WaveOut.Play();
            }
            else
            {
                WaveOut.Resume();
            }
        }

        public void Pause()
        {
            if (WaveOut == null)
                return;

            //Playing = false;
            //btnPlay.Text = "Pl";
            //tmrSong.Enabled = false;

            WaveOut.Pause();
        }

        public void Stop()
        {
            if (WaveOut == null)
                return;

            //Playing = false;
            //btnPlay.Text = "Pl";
            //tmrSong.Enabled = false;

            WaveOut.Stop();
            WaveOffsetStream.CurrentTime = new TimeSpan(0);

            //trbTime.Value = 0;

            TimeSpan time = WaveOffsetStream.CurrentTime;
            //lblTimeElapsed.Text = time.ToString(@"mm\:ss\:fff");
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            _timeline.removeTrack(this);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            SelectMode = true;
            EditMode = false;
            DeleteMode = false;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            SelectMode = false;
            EditMode = true;
            DeleteMode = false;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            SelectMode = false;
            EditMode = false;
            DeleteMode = true;
        }

        public void RemoveWave(WaveViewer wv)
        {
            if (DeleteMode)
            {
                pnlWaveViewer.Controls.Remove(wv);
                int i = Tracks.IndexOf(wv);
                Tracks.RemoveAt(i);
                Times.RemoveAt(i);
                Playing.RemoveAt(i);
            }
        }

        private void pnlWaveViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if(EditMode)
                {
                    int start = e.X;
                    addSound(start);
                }
                

            }
        }


    }
}
