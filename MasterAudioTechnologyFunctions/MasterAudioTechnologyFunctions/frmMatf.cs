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
using MasterAudioTechnologyFunctions.Timeline;
using MetroFramework.Forms;
using MetroFramework;
using System.Xml;
using System.IO;
using System.IO.IsolatedStorage;

namespace MasterAudioTechnologyFunctions
{
    public partial class frmMatf : MetroForm
    {

        public static string SoftwareName = "Master Audio Technology Functions";
        private string _openedFile;
        private bool _playing = false; //TODO: Do we need _playing at this scope? Are we using only _playing in Timeline?
        //public long Timer = 0;
        public TimeSpan Timer = new TimeSpan();

        public frmMatf()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            this.pnlSong.Parent = this;
            setStyle();
            //this.timeLine.setStyle();
        }

        public void setStyle()
        {
            string path = "..\\..\\settings.xml";
            //settings loading
            XmlDocument doc = new XmlDocument();
            //TODO: do a refactoring to a relative path: and to a childrens also!
            string dir = System.IO.Directory.GetCurrentDirectory();

            try
            {
                doc.Load(path);
            }
            catch (FileNotFoundException)
            {
                XmlElement settings = doc.CreateElement(string.Empty, "settings", string.Empty);
                //doc. = settings;
                doc.AppendChild(settings);

                //visual settings
                XmlElement visual = doc.CreateElement(string.Empty, "visual", string.Empty);
                settings.AppendChild(visual);

                XmlElement theme = doc.CreateElement(string.Empty, "theme", string.Empty);
                XmlText themeColor = doc.CreateTextNode("" + (Int32)MetroThemeStyle.Light);
                theme.AppendChild(themeColor);
                visual.AppendChild(theme);

                XmlElement style = doc.CreateElement(string.Empty, "style", string.Empty);
                XmlText styleColor = doc.CreateTextNode("" + (Int32)MetroColorStyle.Blue);
                style.AppendChild(styleColor);
                visual.AppendChild(style);

                //size settings
                XmlElement size = doc.CreateElement(string.Empty, "size", string.Empty);
                settings.AppendChild(size);

                XmlElement width = doc.CreateElement(string.Empty, "width", string.Empty);
                XmlText widthSize = doc.CreateTextNode("1125");
                width.AppendChild(widthSize);
                size.AppendChild(width);

                XmlElement height = doc.CreateElement(string.Empty, "height", string.Empty);
                XmlText heightSize = doc.CreateTextNode("550");
                height.AppendChild(heightSize);
                size.AppendChild(height);

                doc.Save(path);
            }
            catch (Exception)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(path);
                file.Delete();
                MessageBox.Show("The settings.xml file is corrupted! Please restart the application.", "File corrupted!");
                this.Close();
            }

            XmlNode styleN = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode themeN = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            XmlNode widthN = doc.DocumentElement.SelectSingleNode("/settings/size/width");
            XmlNode heightN = doc.DocumentElement.SelectSingleNode("/settings/size/height");

            //za slucaj da ne moze da procita kako valja: corrupted file 

            if (styleN == null || themeN == null || heightN == null || widthN == null)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(path);
                file.Delete();
                MessageBox.Show("The settings.xml file is corrupted! Please restart the application.", "File corrupted!");
                this.Close();
            }
            else
            {
                metroStyleManager.Style = (MetroColorStyle)Int32.Parse(styleN.InnerText);
                metroStyleManager.Theme = (MetroThemeStyle)Int32.Parse(themeN.InnerText);
                this.Width = Int32.Parse(widthN.InnerText);
                this.Height = Int32.Parse(heightN.InnerText);
            }
        }

        public void SetTime(long time)
        {
            // TODO: Convert time to hh:mm:ss:fff
            // Curently presented in number of miliseconds elapsed
            lblTimeElapsed.Text = time + "";
        }

        public void SetTime(string time)
        {
            lblTimeElapsed.Text = time;
        }

        internal void SetTime(TimeSpan timer)
        {
            lblTimeElapsed.Text = timer.Minutes.ToString("D2") + ":" + timer.Seconds.ToString("D2")
                + ":" + timer.Milliseconds.ToString("D3");
        }

        #region Menu

        private void btnFile_Click(object sender, EventArgs e)
        {
            menuFile.Show(btnFile, new Point(0, btnFile.Height));
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            menuView.Show(btnView, new Point(0, btnView.Height));
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            menuAbout.Show(btnAbout, new Point(0, btnAbout.Height));
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample audio App " +
                                       "for audio manipulation and mixing.",
                                "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            theme.InnerText = "" + (Int32)MetroThemeStyle.Dark;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroThemeStyle.Light;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            theme.InnerText = "" + (Int32)MetroThemeStyle.Light;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Green;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Green;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Blue;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Blue;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Silver;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Silver;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Lime;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Lime;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Magenta;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Magenta;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Brown;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Brown;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Orange;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Orange;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Pink;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Pink;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Purple;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Purple;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Red;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Red;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Teal;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Teal;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.White;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.White;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }

        private void yelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Yellow;
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Yellow;
            doc.Save("..\\..\\settings.xml");
            this.timeLine.setStyle();
        }
        #endregion Menu

        #region PlayButtons
        private void btnPlay_Click(object sender, EventArgs e)
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

        private void btnStop_Click(object sender, EventArgs e)
        {
            // TODO: Stop all tracks
            timeLine.Stop();

        }

        private void btnLoop_Click(object sender, EventArgs e)
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

        private void volumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            timeLine.ChangeVolume((float)volumeBar.Value / 100);
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            Timer = Timer.Add(new TimeSpan(0, 0, 0, 0, tmrMain.Interval));
            SetTime(Timer);
        }

        public void resetTimer()
        {
            Timer = new TimeSpan(0);
            SetTime(Timer);
        }

        public void enableTmrMain()
        {
            tmrMain.Enabled = true;
        }

        public void disableTmrMain()
        {
            tmrMain.Enabled = false;
        }

        private void frmMatf_ResizeEnd(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");

            XmlNode width = doc.DocumentElement.SelectSingleNode("/settings/size/width");
            XmlNode height = doc.DocumentElement.SelectSingleNode("/settings/size/height");
            width.InnerText = "" + (Int32)this.Width;
            height.InnerText = "" + (Int32)this.Height;

            doc.Save("..\\..\\settings.xml");
        }
    }
}
