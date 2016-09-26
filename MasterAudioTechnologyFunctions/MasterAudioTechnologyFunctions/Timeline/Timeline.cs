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

        public bool Looping = false;
        public bool SnapToGrid = false;

        public enum TrackEditMode
        {
            Edit,
            Delete,
            Play
        };

        public static TrackEditMode TrackMode = TrackEditMode.Edit;
        private static TrackEditMode _previousTrackMode = TrackMode;

        public Timeline()
        {
            InitializeComponent();
            _tracks = new List<Track>();
        }

        public List<Track> getTracks()
        {
            return _tracks;
        }

        public void SetStyle()
        {
            string path = "..\\..\\settings.xml";
            XmlDocument doc = new XmlDocument();

            doc.Load(path);
            XmlNode styleNode = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode themeNode = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            MetroColorStyle style = (MetroColorStyle)Int32.Parse(styleNode.InnerText);
            MetroThemeStyle theme = (MetroThemeStyle)Int32.Parse(themeNode.InnerText);

            btnAddTrack.Style = style;
            btnAddTrack.Theme = theme;
            btnDelete.Style = style;
            btnDelete.Theme = theme;
            btnEdit.Style = style;
            btnEdit.Theme = theme;
            btnSnapToGrid.Style = style;
            btnSnapToGrid.Theme = theme;
            pnlButtons.Style = style;
            pnlButtons.Theme = theme;
            pnlTracks.Style = style;
            pnlTracks.Theme = theme;
            timelineCursor.Style = style;
            timelineCursor.Theme = theme;

            foreach (var track in _tracks)
                track.setStyle();

            UpdateStyles();
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
                
                await Task.Run(() =>
                {
                    using (Mp3FileReader reader = new Mp3FileReader(addTrack.TrackFileName))
                    {
                        WaveFileWriter.CreateWaveFile(newFileName, reader);
                    }
                }).ConfigureAwait(true);

                addTrack.TrackFileName = newFileName;
            }
            #endregion MP3

            Track newTrack = new Track(addTrack.TrackName, addTrack.TrackFileName, addTrack.TrackColor, this);

            _tracks.Add(newTrack);
            newTrack.Dock = DockStyle.Bottom;
            pnlTracks.Controls.Add(newTrack);

            Height += newTrack.Height;
            pnlTracks.Height += newTrack.Height;

            timelineCursor.BringToFront();

            scrollBar.Visible = true;

            ScrollTracks();
        }

        public void addTrack(Track newTrack)
        {
            _tracks.Add(newTrack);
            newTrack.Dock = DockStyle.Bottom;
            pnlTracks.Controls.Add(newTrack);
            Height += newTrack.Height;
        }

        public void removeAllTracks()
        {
            int h = _trackHeight * _tracks.Count;
            pnlTracks.Controls.Clear();
            _tracks.Clear();
            Height -= h;
        }

        public void removeTrack(Track t)
        {
            _tracks.Remove(t);
            pnlTracks.Controls.Remove(t);
            Height -= t.Height;
            pnlTracks.Height -= t.Height;

            if (_tracks.Count == 0)
                scrollBar.Visible = false;
        }

        private void tmrSong_Tick(object sender, EventArgs e)
        {
            frmMatf parent = (frmMatf)Parent.Parent;
            var parentTimer = parent.Timer;
            var totalMilliseconds = parentTimer.TotalMilliseconds;

            parent.Timer = parentTimer.Add(new TimeSpan(0, 0, 0, 0, tmrSong.Interval));
            parent.SetTime();

            foreach (Track t in _tracks)
            {
                if (t.WaveOut == null)
                {
                    tmrSong.Enabled = false;
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
            }
            
            Point cursorPreviousLocation = timelineCursor.Location;
            timelineCursor.Location = new Point((int)totalMilliseconds / 55 - scrollBar.Value, cursorPreviousLocation.Y);

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
            parent.resetTimer();
            timelineCursor.Visible = false;

            foreach (Track t in _tracks)
                for (int i = 0; i < t.Tracks.Count; i++)
                    if (t.Playing[i])
                    {
                        t.Stop();
                        t.Playing[i] = false;
                    }

            TrackMode = _previousTrackMode;
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

            timelineCursor.Visible = true;
            timelineCursor.BringToFront();
            timelineCursor.Height = GetNumberOfTracks() * _trackHeight;

            tmrSong.Enabled = true;

            if (TrackMode != TrackEditMode.Play)
            {
                _previousTrackMode = TrackMode;
                TrackMode = TrackEditMode.Play;
            }
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

        public void DisableEdit()
        {
            btnAddTrack.Enabled = false;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;
            btnSnapToGrid.Enabled = false;

            foreach (var t in _tracks)
                t.DisableChange();
        }

        public void EnableEdit()
        {
            btnAddTrack.Enabled = true;
            btnDelete.Enabled = true;
            btnEdit.Enabled = true;
            btnSnapToGrid.Enabled = true;

            foreach (var t in _tracks)
                t.EnableChange();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            TrackMode = TrackEditMode.Edit;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            TrackMode = TrackEditMode.Delete;
        }

        public void ScrollTracks()
        {
            foreach (var t in _tracks)
                t.PnlWaveViewer.Left = -1 * scrollBar.Value;
            
            var parentTimer = ((frmMatf)Parent.Parent).Timer;
            var totalMilliseconds = parentTimer.TotalMilliseconds;

            Point cursorPreviousLocation = timelineCursor.Location;
            timelineCursor.Location = new Point((int)totalMilliseconds / 55 - scrollBar.Value, cursorPreviousLocation.Y);

            timelineCursor.BringToFront();
        }

        private void scrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            ScrollTracks();
        }

        private void btnSnapToGrid_Click(object sender, EventArgs e)
        {
            if (SnapToGrid)
            {
                SnapToGrid = false;
                btnSnapToGrid.Text = "s";
            }
            else
            {
                SnapToGrid = true;
                btnSnapToGrid.Text = "S";
            }
        }
    }
}
