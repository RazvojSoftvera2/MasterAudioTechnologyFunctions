using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using System.Xml;
using NAudio.Wave;
using System.Threading.Tasks;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class Timeline : UserControl
    {
        private List<Track> _tracks;
        private float _masterVolume = 0.7f;
        private long _songDuration = 0;
        // TODO: Change from 61
        private int _trackHeight = 61;

        public enum TrackEditMode
        {
            Select,
            Edit,
            Delete
        };

        public static TrackEditMode TrackMode = TrackEditMode.Edit;
        public bool Looping = false;

        public Timeline()
        {
            InitializeComponent();
            _tracks = new List<Track>();
        }

        public void setStyle()
        {
            string path = "..\\..\\settings.xml";
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();

            doc.Load(path);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");

            this.btnAddTrack.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.btnAddTrack.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlBottom.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlBottom.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlTracks.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlTracks.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.changeProgressBar.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.changeProgressBar.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);

            foreach (var track in _tracks)
                track.setStyle();

            this.UpdateStyles();
        }

        private async void btnAddTrack_Click(object sender, EventArgs e)
        {
            AddNewTrack addTrack = new AddNewTrack();
            if (addTrack.ShowDialog() != DialogResult.OK)
                return;

            #region MP3
            if (addTrack.TrackFileName.EndsWith(".mp3"))
            {
                //do a conversion and asserts
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.Filter = "WAV files (.wav)|*.wav";
                dialog.Title = "Choose where to save converted file...";

                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    MetroMessageBox.Show(this, "Please choose file, write it's name, and select location.",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newFileName = dialog.FileName;

                this.changeProgressBar.Visible = true;
                this.Update();
                await Task.Run(() =>
                {
                    using (Mp3FileReader reader = new Mp3FileReader(addTrack.TrackFileName))
                    {
                        WaveFileWriter.CreateWaveFile(newFileName, reader);
                    }
                }).ConfigureAwait(true);
                this.changeProgressBar.Visible = false;
                this.Update();

                addTrack.TrackFileName = newFileName;
            }
            #endregion MP3

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
            var totalMilliseconds = parent.Timer.TotalMilliseconds;

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
                        long time = t.Times[i];
                        long endTime = time + (long)t.WaveFileReader.TotalTime.TotalMilliseconds;

                        if (endTime > _songDuration)
                            _songDuration = endTime;

                        if (!t.Playing[i] && totalMilliseconds >= time && totalMilliseconds <= endTime)
                        {
                            t.Playing[i] = true;
                            t.Play();
                        }

                        if (t.Playing[i] && totalMilliseconds > endTime)
                        {
                            t.Stop();
                            t.Playing[i] = false;
                        }
                    }
                }

                t.SendToBack();
            }

            // TODO: Remove hardcoding of pnlWaveViewer X position
            // 92: X position of pnlWaveViewer
            Point cursorPreviousLocation = timelineCursor.Location;
            timelineCursor.Location = new Point(92 + (int)totalMilliseconds/55, cursorPreviousLocation.Y);

            timelineCursor.BringToFront();
            
            // TODO: Change Location.X + Size.Width with duration of the song
            if (totalMilliseconds > _songDuration)
            {
                if (Looping)
                {
                    Stop();
                    Play();
                }
                else
                    Stop();
            }
        }

        public void Stop()
        {
            tmrSong.Enabled = false;

            frmMatf parent = (frmMatf)Parent.Parent;
            parent.disableTmrMain();
            parent.resetTimer();
            timelineCursor.Visible = false;

            foreach (Track t in _tracks)
                for (int i = 0; i < t.Tracks.Count; i++)
                    if (t.Playing[i])
                    {
                        t.Stop();
                        t.Playing[i] = false;
                    }
        }

        public void Play()
        {
            // TODO: Find cause and fix bug
            // Iz nekog razloga mora svaka od traka jednom
            // da "odsvira" pre nego sto moze da stvarno pusti ton
            var actualVolume = _masterVolume;
            _masterVolume = 0;
            foreach (Track t in _tracks)
            {
                t.Play();
                t.Stop();
            }
            _masterVolume = actualVolume;
            
            // TODO: Find out why BringToFront isn't working
            timelineCursor.Visible = true;
            timelineCursor.BringToFront();
            timelineCursor.Height = GetNumberOfTracks() * _trackHeight;

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

        public int GetNumberOfTracks()
        {
            return _tracks.Count;
        }

        public void DisableEditingOptionInTracks()
        {
            foreach (var track in _tracks)
            {
                track.DisableEditButtons();
            }
        }

        public void EnableEditingOptionInTracks()
        {
            foreach (var track in _tracks)
            {
                track.EnableEditButtons();
            }
        }
    }
}
