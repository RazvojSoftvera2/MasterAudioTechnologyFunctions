﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using MasterAudioTechnologyFunctions.Timeline;
using MetroFramework.Forms;

namespace MasterAudioTechnologyFunctions
{
    public partial class frmMatf : MetroForm
    {
        
        public static string SoftwareName = "Master Audio Technology Functions";
        private string _openedFile;
        private bool _playing = false;
        public long Timer = 0;

        public frmMatf()
        {
            InitializeComponent();
        }

        public void SetTime(long time)
        {
            // TODO: Convert time to hh:mm:ss:fff
            // Curently presented in number of miliseconds elapsed

            //lblTimeElapsed.Text = time + "";
        }

        private void trbTime_Scroll(object sender, EventArgs e)
        {
            // Set the current position of the song to the value of trbTime in milliseconds
            // TODO: Refactor for Timeline
            //if (_waveOut != null)
            //{
            //    _waveOffsetStream.Position = trbTime.Value;
            //}
        }

        private void trbTime_MouseDown(object sender, MouseEventArgs e)
        {
            // TODO: Pause all tracks
            //Pause();
        }

        private void trbTime_MouseUp(object sender, MouseEventArgs e)
        {
            // TODO: Play all tracks
            //Play();
        }

        #region Menu
        private void btnFile_Click(object sender, EventArgs e)
        {
            fileMenu.Show(btnFile, new Point(0, btnFile.Height));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Stop current play
            //_playing = false;
            //btnPlay.Text = "Pl";
            //if (_waveOut != null)
            //{
            //    _waveOut.Stop();
            //    _waveOut.Dispose();
            //}

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MATF projects (.matf)|*.matf";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            _openedFile = dialog.FileName;
            // TODO: Load project

            //trbTime.Maximum = (int) _waveOffsetStream.Length;

            Text = SoftwareName + " - " + _openedFile;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            viewMenu.Show(btnView, new Point(0, btnView.Height));
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpMenu.Show(btnHelp, new Point(0, btnHelp.Height));
        }

        private void volumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            timeLine.ChangeVolume((float)volumeBar.Value / 100);
        }
        #endregion Menu

        #region PlayButtons
        private void btnPlay_Click_1(object sender, EventArgs e)
        {
            //  if (_playing)
            //  {
            // TODO: Pause all tracks
            //Pause();
            //      _playing = false;
            //   }
            //    else
            //    {
            // TODO: Play all tracks
            //Play();
            //       _playing = true;
            timeLine.Play();
            //    }
        }

        private void btnStop_Click_1(object sender, EventArgs e)
        {
            // TODO: Stop all tracks
            timeLine.Stop();
        }

        private void btnLoop_Click_1(object sender, EventArgs e)
        {
            /* TODO: Refactor for Timeline
            if (_looping)
            {
                _looping = false;
                //btnLoop.Text = "l";
            }
            else
            {
                _looping = true;
                //btnLoop.Text = "L";
            }*/
        }
        #endregion PlayButtons

        private void btnAddTrack_Click(object sender, EventArgs e)
        {

        }
    }
}
