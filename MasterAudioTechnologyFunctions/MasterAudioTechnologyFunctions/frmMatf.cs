using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MasterAudioTechnologyFunctions
{
    public partial class frmMatf : Form
    {
        private string _productName = "Master Audio Technology Functions";
        private string _openedFile;

        private WaveOut _waveOut;
        private WaveOffsetStream _waveOffsetStream;
        private WaveFileReader _waveFileReader;
        

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
            dialog.Filter = "Waveform audio files (.wav)|*.wav|MATF projects (.matf)|*.matf";
            dialog.ShowDialog();

            _openedFile = dialog.FileName;

            _waveOut = new WaveOut();
            _waveFileReader = new WaveFileReader(_openedFile);
            _waveOffsetStream = new WaveOffsetStream(_waveFileReader);
            _waveOut.Init(_waveOffsetStream);
            Console.Out.WriteLine(trbTime.Maximum);
            trbTime.Maximum = (int) _waveOffsetStream.Length;
            Console.Out.WriteLine(trbTime.Maximum);
            

            Text = _productName + " - " + _openedFile;



            // Set the maximum value of trbTime to the number of miliseconds of the song duration

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
                // Pause
                _playing = false;
                btnPlay.Text = "Pa";
                tmrSong.Enabled = false;
                
                if(_waveOut != null)
                {
                    _waveOut.Pause();
                }
                
            }
            else
            {
                // Play
                _playing = true;
                btnPlay.Text = "Pl";
                tmrSong.Enabled = true;
                if (_waveOut != null)
                {
                    if (_waveOut.GetPosition() == 0)
                    {
                        _waveOut.Play();
                    }
                    else
                    {
                        _waveOut.Resume();
                    }
                }


            }
        }

      

        private void btnStop_Click(object sender, EventArgs e)
        {
            // Stop
            _playing = false;
            btnPlay.Text = "Pl";
            tmrSong.Enabled = false;
            if (_waveOut != null)
            {
                _waveOut.Stop();
                _waveOffsetStream.CurrentTime = new TimeSpan(0);

                trbTime.Value = 0;

                TimeSpan time = _waveOffsetStream.CurrentTime;
                lblTimeElapsed.Text = time.ToString(@"mm\:ss\:fff");
            }


            //_waveOut.Dispose();
            //_waveFileReader = new WaveFileReader(_openedFile);
            //_waveOffsetStream = new WaveOffsetStream(_waveFileReader);
            //_waveOut.Init(_waveOffsetStream);
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

            if(_waveOut != null && _waveOffsetStream.Position >= _waveOffsetStream.Length)
            {
                btnStop_Click(this, null);
                tmrSong.Enabled = false;

                if(_looping)
                {
                    btnPlay_Click(this, null);
                    tmrSong.Enabled = true;
                }
            }
            
            if(_waveOut != null && _waveOffsetStream.Position < _waveOffsetStream.Length)
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
    }
}
