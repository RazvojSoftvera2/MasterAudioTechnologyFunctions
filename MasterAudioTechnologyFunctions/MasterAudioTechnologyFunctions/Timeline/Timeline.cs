using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Xml;
using System.IO;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class Timeline : UserControl
    {
        private List<Track> _tracks;
        private bool _looping = false;
        private float _masterVolume = (float)0.7;

        public enum TrackEditMode
        {
            Select,
            Edit,
            Delete
        };

        public static TrackEditMode TrackMode = TrackEditMode.Select;

        public Timeline()
        {
            InitializeComponent();
            _tracks = new List<Track>();
            setStyle();
        }

        public void setStyle()
        {
            string path = "..\\..\\settings.xml";
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            try
            {
                doc.Load(path);
            }
            catch (FileNotFoundException e)
            {
                XmlElement settings = doc.CreateElement(string.Empty, "settings", string.Empty);
                doc.AppendChild(settings);

                XmlElement visual = doc.CreateElement(string.Empty, "visual", string.Empty);
                settings.AppendChild(visual);

                XmlElement themeNode = doc.CreateElement(string.Empty, "theme", string.Empty);
                XmlText themeColor = doc.CreateTextNode("" + (Int32)MetroThemeStyle.Light);
                themeNode.AppendChild(themeColor);
                visual.AppendChild(themeNode);

                XmlElement styleNode = doc.CreateElement(string.Empty, "style", string.Empty);
                XmlText styleColor = doc.CreateTextNode(""+(Int32)MetroColorStyle.Blue);
                styleNode.AppendChild(styleColor);
                visual.AppendChild(styleNode);

                doc.Save(path);
            }
            catch (Exception)
            {
                throw;
            }
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");

            this.btnAddTrack.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.btnAddTrack.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlBottom.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlBottom.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlTracks.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlTracks.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);

            foreach (var track in _tracks)
                track.setStyle();

            this.UpdateStyles();
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            AddNewTrack addTrack = new AddNewTrack();
            if (addTrack.ShowDialog() != DialogResult.OK)
                return;

            Track newTrack = new Track(addTrack.TrackName, addTrack.TrackFileName, addTrack.TrackColor, this);

            _tracks.Add(newTrack);
            newTrack.Dock = DockStyle.Bottom;
            pnlTracks.Controls.Add(newTrack);

            Height += newTrack.Height;
        }

        public void removeTrack(Track t)
        {
            _tracks.Remove(t);
            pnlTracks.Controls.Remove(t);
            Height -= t.Height;
        }

        private void tmrSong_Tick(object sender, EventArgs e)
        {
            // Set trbTime to the number of miliseconds that since the start of the song
            // Set the text of lblTimeElapsed to correct time since the start of the song
            // Time format: mm:ss:milliseconds

            frmMatf parent = (frmMatf)Parent.Parent;

            foreach (Track t in _tracks)
            {
                if (t.WaveOut == null)
                {
                    tmrSong.Enabled = false;
                    parent.disableTmrMain();
                    return;
                }

                if (t.Tracks.Count != 0)
                {
                    for (int i = 0; i < t.Tracks.Count; i++)
                    {
                        long time = t.Times.ElementAt(i);
                        var totalMilliseconds = parent.Timer.TotalMilliseconds;

                        if (!t.Playing[i] && totalMilliseconds >= time && totalMilliseconds <= time + t.TrackLen)
                        {
                            t.Playing[i] = true;
                            t.Play();
                        }

                        if (t.Playing[i] && totalMilliseconds > time + t.TrackLen)
                        {
                            t.Stop();
                            t.Playing[i] = false;
                        }
                    }
                }
            }

            // Remove previous line
           // DrawVerticalLine((int)parent.Timer.TotalMilliseconds + 92);

            //parent.Timer += tmrSong.Interval;
            //parent.Timer = parent.Timer.Add(new TimeSpan(0, 0, 0, 0, tmrSong.Interval));
            //parent.SetTime(parent.Timer);

            // Draw new line
            // TODO: Remove hardcoding of pnlWaveViewer X position
            // 92: X position of pnlWaveViewer
         //   DrawVerticalLine((int)parent.Timer.TotalMilliseconds + 92);
        }

        public void Stop()
        {

            tmrSong.Enabled = false;
            

            frmMatf parent = (frmMatf)Parent.Parent;
            parent.disableTmrMain();
           
           // parent.Timer = new TimeSpan(0);
           // parent.SetTime(parent.Timer);
            parent.resetTimer();

            foreach (Track t in _tracks)
            {
                for (int i = 0; i < t.Tracks.Count; i++)
                {
                    if (t.Playing[i])
                    {
                        t.Stop();
                        t.Playing[i] = false;
                    }
                }
            }
        }

        public void Play()
        {
            // TODO: Iz nekog razloga mora svaka od traka jednom da "odsvira" pre nego sto
            // moze da stvarno pusti ton
            foreach (Track t in _tracks)
            {
                t.Play();
                t.Stop();
            }

            tmrSong.Enabled = true;
            frmMatf parent = (frmMatf)this.Parent.Parent;
            parent.enableTmrMain();
        }

        private void DrawVerticalLine(int x)
        {
            ControlPaint.DrawReversibleLine(PointToScreen(new Point(x, 0)), PointToScreen(new Point(x, Height)), Color.Gray);
        }

        public void ChangeVolume(float change)
        {
            float _masterVolumeOld = _masterVolume;
            if (change == 0)
                _masterVolume = (float) 0.01;
            else
                _masterVolume = change;

            foreach (var track in _tracks)
            {
                track.TrackVolume *= _masterVolume/_masterVolumeOld;

                if (track.TrackVolume > 1)
                {
                    track.WaveOut.Volume = 1;
                    track.TrackVolume = 1;
                }
                else 
                    track.WaveOut.Volume = track.TrackVolume;
            }
        }
    }
}
