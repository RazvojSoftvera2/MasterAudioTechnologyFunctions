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
        public long Timer = 0;
        
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

            //TODO: Refactor for Timeline
            
            foreach(Track t in _tracks)
            {
                if (t.WaveOut == null)
                {
                    tmrSong.Enabled = false;
                    return;
                }

                foreach(int time in t.Times)
                {
                    if(!t.Playing && Timer >= time && Timer <= time+t.TrackLen)
                    {
                        Console.Out.WriteLine("TEST1");
                        t.Playing = true;
                        t.Play();
                    }

                    if(t.Playing && Timer > time+t.TrackLen)
                    {
                        Console.Out.WriteLine("TEST2");
                        t.Stop();
                        t.Playing = false;
                    }
                }

                Timer += 1;

                frmMatf parent = (frmMatf)Parent.Parent;
                parent.SetTime(Timer);

                // Song has ended
                //if (t.WaveOffsetStream.Position >= t.WaveOffsetStream.Length)
                //{
                //    t.Stop();
                //    tmrSong.Enabled = false;

                //    if (_looping)
                //    {
                //        t.Play();
                //        tmrSong.Enabled = true;
                //    }
                //}

                // Song is still playing
                //if (t.WaveOffsetStream.Position < t.WaveOffsetStream.Length)
                //{
                //    TimeSpan time = t.WaveOffsetStream.CurrentTime;
                //  //  frmMatf.lblTimeElapsed.Text = time.ToString(@"mm\:ss\:fff");
                //    frmMatf.SetTimer(time.ToString(@"mm\:ss\:fff");
                //    trbTime.Value = (int)WaveOffsetStream.Position;
                //}
            }


           

        }

        public void Play()
        {
            tmrSong.Enabled = true;
            
        }
    }
}
