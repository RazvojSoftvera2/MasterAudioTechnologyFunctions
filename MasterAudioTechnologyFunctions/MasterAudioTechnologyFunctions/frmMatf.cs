using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Xml;
using System.IO;

namespace MasterAudioTechnologyFunctions
{
    public partial class frmMatf : MetroForm
    {
        public static string ApplicationName = "Master Audio Technology Functions";
        public TimeSpan Timer = new TimeSpan();
        private string _openedFile;
        private string _settingsPath = "..\\..\\settings.xml";

        public frmMatf()
        {
            InitializeComponent();
            setStyle();
        }

        public void setStyle()
        {
            StyleManager = metroStyleManager;

            //settings loading
            XmlDocument doc = new XmlDocument();
            try
            {
                doc.Load(_settingsPath);
            }
            catch (FileNotFoundException)
            {
                XmlElement settings = doc.CreateElement(string.Empty, "settings", string.Empty);
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

                doc.Save(_settingsPath);
            }
            catch (Exception)
            {
                FileInfo file = new FileInfo(_settingsPath);
                file.Delete();
                MetroMessageBox.Show(this, "The settings.xml file is corrupted! Please restart the application.",
                                "File corrupted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            XmlNode styleN = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode themeN = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            XmlNode widthN = doc.DocumentElement.SelectSingleNode("/settings/size/width");
            XmlNode heightN = doc.DocumentElement.SelectSingleNode("/settings/size/height");

            //corrupt file
            if (styleN == null || themeN == null || heightN == null || widthN == null)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(_settingsPath);
                file.Delete();
                MetroMessageBox.Show(this, "The settings.xml file is corrupted! Please restart the application.",
                                "File corrupted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
            else
            {
                metroStyleManager.Style = (MetroColorStyle)Int32.Parse(styleN.InnerText);
                metroStyleManager.Theme = (MetroThemeStyle)Int32.Parse(themeN.InnerText);
                Width = Int32.Parse(widthN.InnerText);
                Height = Int32.Parse(heightN.InnerText);
            }
        }
        
        internal void SetTime()
        {
            lblTimeElapsed.Text = Timer.Minutes.ToString("D2") + ":" + 
                                  Timer.Seconds.ToString("D2") + ":" + 
                                  Timer.Milliseconds.ToString("D3");
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
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MATF projects (.matf)|*.matf";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            _openedFile = dialog.FileName;
            // TODO: Load project

            //trbTime.Maximum = (int) _waveOffsetStream.Length;

            Text = ApplicationName + " - " + _openedFile;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample audio App for audio manipulation and mixing.",
                                 "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region MetroStyle

        private void SetTheme(MetroThemeStyle themeStyle)
        {
            metroStyleManager.Theme = themeStyle;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            theme.InnerText = "" + (Int32)themeStyle;
            doc.Save(_settingsPath);
            timeLine.SetStyle();
        }

        private void SetStyle(MetroColorStyle colorStyle)
        {
            metroStyleManager.Style = colorStyle;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)colorStyle;
            doc.Save(_settingsPath);
            timeLine.SetStyle();
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(MetroThemeStyle.Dark);
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTheme(MetroThemeStyle.Light);
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Green);
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Blue);
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Silver);
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Lime);
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Magenta);
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Brown);
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Orange);
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Pink);
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Purple);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Red);
        }

        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Teal);
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.White);
        }

        private void yelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetStyle(MetroColorStyle.Yellow);
        }
        #endregion MetroStyle

        #endregion Menu

        #region PlayButtons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (timeLine.GetNumberOfTracks() == 0)
                return;

            timeLine.Play();
            timeLine.DisableEdit();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //enabling all editing buttons in track
            timeLine.EnableEdit();
            // TODO: Stop all tracks

            timeLine.Stop();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (timeLine.Looping)
            {
                timeLine.Looping = false;
                btnLoop.Text = "l";
            }
            else
            {
                timeLine.Looping = true;
                btnLoop.Text = "L";
            }
        }

        #endregion PlayButtons

        private void volumeBar_Scroll(object sender, ScrollEventArgs e)
        {
            timeLine.ChangeVolume((float)volumeBar.Value / 100);
        }

        public void resetTimer()
        {
            Timer = new TimeSpan(0);
            SetTime();
        }

        private void frmMatf_ResizeEnd(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load(_settingsPath);

            XmlNode width = doc.DocumentElement.SelectSingleNode("/settings/size/width");
            XmlNode height = doc.DocumentElement.SelectSingleNode("/settings/size/height");
            width.InnerText = "" + (Int32)this.Width;
            height.InnerText = "" + (Int32)this.Height;

            doc.Save(_settingsPath);
        }
    }
}
