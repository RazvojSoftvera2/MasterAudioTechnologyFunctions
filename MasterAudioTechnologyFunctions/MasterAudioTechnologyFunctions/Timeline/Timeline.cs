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
                frmMatf parent = (frmMatf)Parent.Parent;
                if (t.Tracks.Count != 0)
                {
                    for (int i = 0; i < t.Tracks.Count; i++)
                    {
                        long time = t.Times.ElementAt(i);

                        if (!t.Playing[i] && parent.Timer >= time && parent.Timer <= time + t.TrackLen)
                        {
                            //Console.Out.WriteLine("TEST1");
                            t.Playing[i] = true;
                            t.Play();
                        }

                        if (t.Playing[i] && parent.Timer > time + t.TrackLen)
                        {
                            //Console.Out.WriteLine("TEST2");
                            t.Stop();
                            t.Playing[i] = false;
                        }
                    }
                }
                
                //Treba prebaciti da frmMatf povecava Timer kako se ne bi
                //svaki put povecavao za onoliko koliko ima traka
                parent.Timer += 1;
                parent.SetTime(parent.Timer);
            }

       

/*
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
                        //Console.Out.WriteLine("TEST1");
                        t.Playing = true;
                        t.Play();
                    }

                    if(t.Playing && Timer > time+t.TrackLen)
                    {
                        //Console.Out.WriteLine("TEST2");
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

    */
           

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
           

            /*
            foreach(Track t in _tracks)
            {
                if(t.Playing)
                {
                    t.Stop();
                    t.Playing = false;
                }
            }
            */
        }

        public void Play()
        {
            //Iz nekog razloga mora svaka od traka jednom da "odsvira" pre nego sto
            // moze da stvarno pusti ton
            foreach (Track t in _tracks)
            {
                t.Play();
                t.Stop();

            }
            tmrSong.Enabled = true;
            
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
