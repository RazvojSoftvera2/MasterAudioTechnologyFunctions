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

        public List<string> Notes = new List<string>()
        {
            "C1 " ,
            "C#1" ,
            "D1 " ,
            "D#1" ,
            "E1 " ,
            "F1 " ,
            "F#1" ,
            "G1 " ,
            "G#1" ,
            "A1 " ,
            "A#1" ,
            "B1 " ,
            "C2 " ,
            "C#2" ,
            "D2 " ,
            "D#2" ,
            "E2 " ,
            "F2 " ,
            "F#2" ,
            "G2 " ,
            "G#2" ,
            "A2 " ,
            "A#2" ,
            "B2 " ,
            "C3 " ,
            "C#3" ,
            "D3 " ,
            "D#3" ,
            "E3 " ,
            "F3 " ,
            "F#3" ,
            "G3 " ,
            "G#3" ,
            "A3 " ,
            "A#3" ,
            "B3 " ,
            "C4 " ,
            "C#4" ,
            "D4 " ,
            "D#4" ,
            "E4 " ,
            "F4 " ,
            "F#4" ,
            "G4 " ,
            "G# " ,
            "A4 " ,
            "A#4" ,
            "B4 " ,
            "C5 " ,
            "C#5" ,
            "D5 " ,
            "D#5" ,
            "E5 " ,
            "F5 " ,
            "F#5" ,
            "G5 " ,
            "G#5" ,
            "A5 " ,
            "A#5" ,
            "B5 " ,
            "C6 " ,
            "C#6" ,
            "D6 " ,
            "D#6" ,
            "E6 " ,
            "F6 " ,
            "F#6" ,
            "G6 " ,
            "G#6" ,
            "A6 " ,
            "A#6" ,
            "B6 " ,
            "C7 " ,
            "C#7" ,
            "D7 " ,
            "D#7" ,
            "E7 " ,
            "F7 " ,
            "F#7" ,
            "G7 " ,
            "G#7" ,
            "A7 " ,
            "A#7" ,
            "B7 " ,
            "C8 " ,
            "C#8" ,
            "D8 " ,
            "D#8" ,
            "E8 " ,
            "F8 " ,
            "F#8" ,
            "G8 " ,
            "G#8" ,
            "A8 " ,
            "A#8" ,
            "B8 " ,
            "C9 " ,
        };

        
        public Track(Timeline tl)
        {
            InitializeComponent();
            _timeline = tl;
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();
            cmbbNotes.Items.AddRange(Notes.ToArray());
        }

        public Track(string name, string fileName, Color color, Timeline tl)
        {
            InitializeComponent();
            InitializeTrack(name, fileName, color, tl);
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();
            cmbbNotes.Items.AddRange(Notes.ToArray());
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

            this.btnEdit.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.btnEdit.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);


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

            int startPositionTime = startPosition * 55; //lenght in millsec/graphical lenght is about 55
            Tracks.Add(wvTrack);
            Times.Add(startPositionTime);
            Playing.Add(false);
        }

        private void InitializeWaveViewer(WaveViewer wvTrack)
        {
            wvTrack.WaveStream = WaveFileReader;
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
            _timeline.removeTrack(this);
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
            Times[i] = wv.Location.X;
        }

        private void pnlWaveViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            
            switch (frmMatf.TrackMode)
            {
                case frmMatf.TrackEditMode.Edit:
                    int start = e.X;
                    addSound(start);
                    break;
    
            }
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
