﻿using System;
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
using NAudio.Wave;

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

        private void btnAddTrack_Click(object sender, EventArgs e)
        {
            AddNewTrack addTrack = new AddNewTrack((frmMatf)Parent.Parent);
            if (addTrack.ShowDialog() != DialogResult.OK)
                return;

            //mp3 file conversion
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
                using (Mp3FileReader reader = new Mp3FileReader(addTrack.TrackFileName))
                {
                    WaveFileWriter.CreateWaveFile(newFileName, reader);
                }
                this.changeProgressBar.Visible = false;
                this.Update();

                addTrack.TrackFileName = newFileName;
            }

            Track newTrack = new Track(addTrack.TrackName, addTrack.TrackFileName, addTrack.TrackColor, this, addTrack.Note);
            
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
                        long trackSize =(long) t.WaveFileReader.TotalTime.TotalMilliseconds;


                        if (!t.Playing[i] && totalMilliseconds >= time && totalMilliseconds <= time + trackSize)
                        {
                            t.Playing[i] = true;
                            t.Play();
                        }

                        if (t.Playing[i] && totalMilliseconds > time + trackSize)
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