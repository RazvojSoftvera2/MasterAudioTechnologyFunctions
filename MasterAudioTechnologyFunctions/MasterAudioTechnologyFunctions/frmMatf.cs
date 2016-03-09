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
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Waveform audio files (.wav)|*.wav|MATF projects (.matf)|*.matf";
            dialog.ShowDialog();

            _openedFile = dialog.FileName;
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

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnLoop_Click(object sender, EventArgs e)
        {

        }
        #endregion PlayButtons

        private void tmrSong_Tick(object sender, EventArgs e)
        {
            // Set trbTime to the number of miliseconds that since the start of the song
            // Set the text of lblTimeElapsed to correct time since the start of the song
            // Time format: mm:ss:milliseconds
        }

        private void trbTime_Scroll(object sender, EventArgs e)
        {
            // Set the current position of the song to the value of trbTime in milliseconds
        }
    }
}
