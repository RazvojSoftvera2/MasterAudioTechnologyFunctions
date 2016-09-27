using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using System.Xml;
using MetroFramework;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class Track : UserControl
    {
        public string TrackName { get; set; }
        public string TrackFileName { get; set; }
        public Color TrackColor { get; set; }

        public int TrackLen { get; set; }

        public List<WaveViewer> Tracks;
        public List<long> Times;
        public List<bool> Playing;

        public WaveOut WaveOut;
        public WaveOffsetStream WaveOffsetStream;
        public WaveFileReader WaveFileReader;
        public float TrackVolume = (float)0.7;

        private Timeline _timeline;

        public Track(string name, string fileName, Color color, Timeline tl)
        {
            InitializeComponent();
            InitializeTrack(name, fileName, color, tl);

            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();

            pnlWaveViewer.AutoScrollMinSize = new Size(2000, 1000);
        }


        public void setStyle()
        {
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode styleNode = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode themeNode = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            MetroColorStyle style = (MetroColorStyle)Int32.Parse(styleNode.InnerText);
            MetroThemeStyle theme = (MetroThemeStyle)Int32.Parse(themeNode.InnerText);

            btnCloseTrack.Style = style;
            btnCloseTrack.Theme = theme;
            btnChange.Style = style;
            btnChange.Theme = theme;
            lblTrackName.Style = style;
            lblTrackName.Theme = theme;
            pnlInfo.Style = style;
            pnlInfo.Theme = theme;
            pnlWaveViewer.Style = style;
            pnlWaveViewer.Theme = theme;

            UpdateStyles();
        }

        private void InitializeTrack(string name, string fileName, Color color, Timeline tl)
        {
            TrackName = name;
            TrackFileName = fileName;
            TrackColor = color;

            if (tl != null)
            {
                _timeline = tl;
            }

            lblTrackName.Text = TrackName;

            WaveOut = new WaveOut();
            WaveFileReader = new WaveFileReader(TrackFileName);
            WaveOffsetStream = new WaveOffsetStream(WaveFileReader);
            WaveOut.Init(WaveOffsetStream);
            WaveOut.Volume = TrackVolume;
            
            TrackLen = (int)WaveOffsetStream.Length / 10000;

            if (Tracks != null && Tracks.Count > 0)
                foreach (var wvTrack in Tracks)
                    InitializeWaveViewer(wvTrack);
        }

        public void addSound(int startPosition)
        {
            WaveViewer wvTrack = new WaveViewer();
            InitializeWaveViewer(wvTrack);

            pnlWaveViewer.Controls.Add(wvTrack);
            wvTrack.Location = new Point(startPosition, 0);
            
            int startPositionTime = startPosition * 55;
            Tracks.Add(wvTrack);
            Times.Add(startPositionTime);
            Playing.Add(false);
        }

        private void InitializeWaveViewer(WaveViewer wvTrack)
        {
            wvTrack.WaveStream = new WaveFileReader(TrackFileName);
            wvTrack.PenColor = TrackColor;
            wvTrack.Height = pnlWaveViewer.Height;
            wvTrack.Width = TrackLen;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNewTrack editTrack = new AddNewTrack(TrackName, TrackFileName, TrackColor);
            if (editTrack.ShowDialog() != DialogResult.OK)
                return;

            InitializeTrack(editTrack.TrackName, editTrack.TrackFileName, editTrack.TrackColor, null);
        }

        public void Play()
        {
            if (WaveOut == null)
                return;

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

            WaveOut.Pause();
        }

        public void Stop()
        {
            if (WaveOut == null)
                return;

            WaveOut.Stop();
            WaveOffsetStream.CurrentTime = new TimeSpan(0);
        }




        private void BtnX_Click(object sender, EventArgs e)
        {
            if (WaveOut != null)
            {
                WaveOut.Stop();
                WaveOffsetStream.CurrentTime = new TimeSpan(0);
            }

            Timeline timeline = (Timeline)Parent.Parent;

            if (timeline.GetNumberOfTracks() == 1)
            {
                frmMatf parent = (frmMatf)(Parent.Parent).Parent.Parent;
                parent.resetTimer();
            }

            timeline.removeTrack(this);
        }

        public void RemoveWave(WaveViewer wv)
        {
            pnlWaveViewer.Controls.Remove(wv);
            int i = Tracks.IndexOf(wv);
            Tracks.RemoveAt(i);
            Times.RemoveAt(i);
            Playing.RemoveAt(i);
        }

        public void MoveWave(WaveViewer wv)
        {
            int i = Tracks.IndexOf(wv);
            Times[i] = wv.Location.X * 55;
        }

        private void pnlWaveViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            switch (Timeline.TrackMode)
            {
                case Timeline.TrackEditMode.Edit:
                    addSound(e.X);
                    break;
                case Timeline.TrackEditMode.Play:
                    Skip(e.Location.X);
                    break;
            }
        }

        public void Skip(int x, WaveViewer wave = null)
        {
            Timeline timeline = (Timeline)Parent.Parent;
            frmMatf frmMatf = (frmMatf)Parent.Parent.Parent.Parent;
            int wavePosition = 0;

            if (wave != null)
                wavePosition = wave.Location.X;

            timeline.Stop();
            frmMatf.Timer = new TimeSpan(0, 0, 0, 0, (x + wavePosition) * 55);
            timeline.Play();
        }

        public Panel PnlWaveViewer { get { return pnlWaveViewer; } protected set { } }


        public void DisableChange()
        {
            btnChange.Enabled = false;
            btnCloseTrack.Enabled = false;
        }

        public void EnableChange()
        {
            btnChange.Enabled = true;
            btnCloseTrack.Enabled = true;
        }
    }
}
