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

        // public bool Playing = false;
        public List<bool> Playing;

        public WaveOut WaveOut;
        public WaveOffsetStream WaveOffsetStream;
        public WaveFileReader WaveFileReader;
        public float TrackVolume = (float)0.7;
        
        private Timeline _timeline; //TODO: Refactor so we use the parent of track instead of a private field.

        public Track(Timeline tl)
        {
            InitializeComponent();
            _timeline = tl;
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();
        }

        public Track(string name, string fileName, Color color, Timeline tl)
        {
            InitializeComponent();
            InitializeTrack(name, fileName, color, tl);
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();
        }

        public void setStyle()
        {
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");

            this.BtnX.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.BtnX.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.BtnDelete.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.BtnDelete.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.btnEdit.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.btnEdit.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.BtnSelect.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.BtnSelect.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.EditBtn.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.EditBtn.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.lblTrackName.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.lblTrackName.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlInfo.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlInfo.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlWaveViewer.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlWaveViewer.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);

            this.UpdateStyles();
        }

        //TODO: Where and for what is this used?
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

            lblTrackName.Text = TrackName;

            WaveOut = new WaveOut();
            WaveFileReader = new WaveFileReader(TrackFileName);
            WaveOffsetStream = new WaveOffsetStream(WaveFileReader);
            WaveOut.Init(WaveOffsetStream);
            WaveOut.Volume = TrackVolume;

            //TrackLen = (int)WaveFileReader.TotalTime.TotalSeconds*10;
            TrackLen = (int)WaveOffsetStream.Length/10000;
            //MessageBox.Show(WaveFileReader.TotalTime.TotalMilliseconds + "");
            //TODO: Replace 10000 with something concrete 
            //MessageBox.Show(WaveOffsetStream.Length / 10000 + "");

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

            //TODO: we should definitely replace this with non-constant value
            int startPositionTime = startPosition * 55; //length in millsec/graphical lenght is about 55
            Tracks.Add(wvTrack);
            Times.Add(startPositionTime);
            Playing.Add(false);
        }

        private void InitializeWaveViewer(WaveViewer wvTrack)
        {
            wvTrack.WaveStream = new NAudio.Wave.WaveFileReader(TrackFileName);
            wvTrack.PenColor = TrackColor;
            wvTrack.Height = pnlWaveViewer.Height;
            wvTrack.Width = TrackLen;
            //wvTrack.FitToScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            AddNewTrack editTrack = new AddNewTrack(TrackName, TrackFileName, TrackColor);
            if (editTrack.ShowDialog() != DialogResult.OK)
                return;

            InitializeTrack(editTrack.TrackName, editTrack.TrackFileName, editTrack.TrackColor, null);
        }

        //TODO: Where and for what is this used?
        public void Update(long globalTime)
        {
            foreach(long l in Times)
            {
                if(l == globalTime)
                {
                    Play();
                }
            }
        }

        public void Play()
        {
            if (WaveOut == null)
                return;

            //Playing = true;
            //btnPlay.Text = "Pa";
            //tmrSong.Enabled = true;

            if (WaveOut.GetPosition() == 0)
            {
                try
                {
                    WaveOut.Play();
                }
                catch
                {
                    //TODO: handle this empty catch
                }
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

            if (_timeline.GetNumberOfTracks() == 1)
            {
                //TODO: reset timer to 0 (problematic method of doing that)
                frmMatf parent = (frmMatf)(Parent.Parent).Parent.Parent;
                parent.disableTmrMain();
                // parent.Timer = new TimeSpan(0);
                // parent.SetTime(parent.Timer);
                parent.resetTimer();
            }

            _timeline.removeTrack(this);
        }

        private void BtnSelect_Click(object sender, EventArgs e)
        {
            Timeline.TrackMode = Timeline.TrackEditMode.Select;
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            Timeline.TrackMode = Timeline.TrackEditMode.Edit;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            Timeline.TrackMode = Timeline.TrackEditMode.Delete;
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
            // TODO: Change hardcoding of 55
            Times[i] = wv.Location.X * 55;
        }

        private void pnlWaveViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            
            switch (Timeline.TrackMode)
            {
                case Timeline.TrackEditMode.Edit:
                    int start = e.X;
                    addSound(start);
                    break;
                case Timeline.TrackEditMode.Select:
                    Console.WriteLine(e.X);
                    break;
            }
        }

        public void DisableEditButtons()
        {
            this.BtnDelete.Enabled = false;
            this.btnEdit.Enabled = false;
            this.BtnSelect.Enabled = false;
            this.EditBtn.Enabled = false;
            this.Update();
        }

        public void EnableEditButtons()
        {
            this.BtnDelete.Enabled = true;
            this.btnEdit.Enabled = true;
            this.BtnSelect.Enabled = true;
            this.EditBtn.Enabled = true;
            this.Update();
        }
    }
}
