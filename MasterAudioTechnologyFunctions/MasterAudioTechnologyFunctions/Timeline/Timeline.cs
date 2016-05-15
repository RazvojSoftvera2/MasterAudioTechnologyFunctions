using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            AddNewTrack addTrack = new AddNewTrack();
            if (addTrack.ShowDialog() != DialogResult.OK)
                return;

            Track newTrack = new Track(addTrack.TrackName, addTrack.TrackFileName, addTrack.TrackColor, this);

            _tracks.Add(newTrack);
            newTrack.Dock = DockStyle.Top;
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
                    return;
                }

                if (t.Tracks.Count != 0)
                {
                    for (int i = 0; i < t.Tracks.Count; i++)
                    {
                        long time = t.Times.ElementAt(i);

                        if (!t.Playing[i] && parent.Timer >= time && parent.Timer <= time + t.TrackLen)
                        {
                            t.Playing[i] = true;
                            t.Play();
                        }

                        if (t.Playing[i] && parent.Timer > time + t.TrackLen)
                        {
                            t.Stop();
                            t.Playing[i] = false;
                        }
                    }
                }
            }

            // Remove previous line
            DrawVerticalLine((int)parent.Timer + 92);

            parent.Timer += tmrSong.Interval;
            parent.SetTime(parent.Timer);

            // Draw new line
            // TODO: Remove hardcoding of pnlWaveViewer X position
            // 92: X position of pnlWaveViewer
            DrawVerticalLine((int)parent.Timer + 92);
        }

        public void Stop()
        {

            tmrSong.Enabled = false;

            frmMatf parent = (frmMatf)Parent.Parent;
            parent.Timer = 0;
            parent.SetTime(parent.Timer);

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
        }

        private void DrawVerticalLine(int x)
        {
            ControlPaint.DrawReversibleLine(PointToScreen(new Point(x, 0)), PointToScreen(new Point(x, Height)), Color.Gray);
        }

        public void ChangeVolume(float change)
        {
            float _masterVolumeOld = _masterVolume;
            _masterVolume = change;
            foreach (var track in _tracks)
            {
                track.TrackVolume *= _masterVolume/_masterVolumeOld;
                track.WaveOut.Volume = track.TrackVolume;
            }
        }
    }
}
