using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Gui;

namespace MasterAudioTechnologyFunctions
{
    public partial class frmMatf : Form
    {
        private string _productName = "Master Audio Technology Functions";
        private string _openedFile;

        private bool _playing = false;
        private bool _looping = false;

        public frmMatf()
        {
            InitializeComponent();

            pnlMenu.Hide();
        }

        #region Menu
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Visible)
                pnlMenu.Hide();
            else
                pnlMenu.Show();
        }

        private void pnlMenu_Leave(object sender, EventArgs e)
        {
            // pnlMenu.Hide();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            _playing = false;
            btnPlay.Text = "Pl";
            if (_waveOut != null)
            {
                _waveOut.Stop();
                _waveOut.Dispose();
            }
            
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MATF projects (.matf)|*.matf";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            _openedFile = dialog.FileName;
            // Load project

            trbTime.Maximum = (int) _waveOffsetStream.Length;
            
            Text = _productName + " - " + _openedFile;
            
            pnlMenu.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion Menu

        #region PlayButtons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (_playing)
            {
                Pause();
            }
            else
            {
                Play();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Play()
        {
            if (_waveOut == null)
                return;

            _playing = true;
            btnPlay.Text = "Pa";
            tmrSong.Enabled = true;
            
            if (_waveOut.GetPosition() == 0)
            {
                _waveOut.Play();
            }
            else
            {
                _waveOut.Resume();
            }
        }

        private void Pause()
        {
            if (_waveOut == null)
                return;

            _playing = false;
            btnPlay.Text = "Pl";
            tmrSong.Enabled = false;

            _waveOut.Pause();
        }

        private void Stop()
        {
            if (_waveOut == null)
                return;

            _playing = false;
            btnPlay.Text = "Pl";
            tmrSong.Enabled = false;

            _waveOut.Stop();
            _waveOffsetStream.CurrentTime = new TimeSpan(0);

            trbTime.Value = 0;

            TimeSpan time = _waveOffsetStream.CurrentTime;
            lblTimeElapsed.Text = time.ToString(@"mm\:ss\:fff");
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if(_looping)
            {
                _looping = false;
                btnLoop.Text = "l";
            }
            else
            {
                _looping = true;
                btnLoop.Text = "L";
            }
        }
        #endregion PlayButtons

        private void tmrSong_Tick(object sender, EventArgs e)
        {
            // Set trbTime to the number of miliseconds that since the start of the song
            // Set the text of lblTimeElapsed to correct time since the start of the song
            // Time format: mm:ss:milliseconds

            if (_waveOut == null)
            {
                tmrSong.Enabled = false;
                return;
            }

            // Song has ended
            if(_waveOffsetStream.Position >= _waveOffsetStream.Length)
            {
                Stop();
                tmrSong.Enabled = false;

                if(_looping)
                {
                    Play();
                    tmrSong.Enabled = true;
                }
            }
            
            // Song is still playing
            if(_waveOffsetStream.Position < _waveOffsetStream.Length)
            {
                TimeSpan time = _waveOffsetStream.CurrentTime;
                lblTimeElapsed.Text = time.ToString(@"mm\:ss\:fff");
                trbTime.Value = (int)_waveOffsetStream.Position;
            }
        }

        private void trbTime_Scroll(object sender, EventArgs e)
        {
            // Set the current position of the song to the value of trbTime in milliseconds
            if(_waveOut != null)
            {
                _waveOffsetStream.Position = trbTime.Value;
            }
        }

        private void trbTime_MouseDown(object sender, MouseEventArgs e)
        {
            Pause();
        }

        private void trbTime_MouseUp(object sender, MouseEventArgs e)
        {
            Play();
        }
    }
}
