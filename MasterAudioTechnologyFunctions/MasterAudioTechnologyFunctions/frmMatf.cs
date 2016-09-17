using System;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using MasterAudioTechnologyFunctions.Timeline;

namespace MasterAudioTechnologyFunctions
{
    public partial class frmMatf : MetroForm
    {

        public static string SoftwareName = "Master Audio Technology Functions";
        private string _openedFile;
        private bool _playing = false; //TODO: Do we need _playing at this scope? Are we using only _playing in Timeline?
        //public long Timer = 0;
        public TimeSpan Timer = new TimeSpan();
        //TODO: do a refactoring to a relative path: and to a childrens also!
        string dir = Directory.GetCurrentDirectory();
        private string _settingsPath = "..\\..\\settings.xml";

        private string _projectName;
        private bool _hasSaved = false;

        public frmMatf()
        {
            InitializeComponent();
            this.StyleManager = metroStyleManager;
            this.pnlSong.Parent = this;
            setStyle();
        }

        public void setStyle()
        {
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
                System.IO.FileInfo file = new System.IO.FileInfo(_settingsPath);
                file.Delete();
                MetroMessageBox.Show(this, "The settings.xml file is corrupted! Please restart the application.",
                                "File corrupted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            XmlNode styleN = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode themeN = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            XmlNode widthN = doc.DocumentElement.SelectSingleNode("/settings/size/width");
            XmlNode heightN = doc.DocumentElement.SelectSingleNode("/settings/size/height");

            //za slucaj da ne moze da procita kako valja: corrupted file 

            if (styleN == null || themeN == null || heightN == null || widthN == null)
            {
                System.IO.FileInfo file = new System.IO.FileInfo(_settingsPath);
                file.Delete();
                MetroMessageBox.Show(this, "The settings.xml file is corrupted! Please restart the application.",
                                "File corrupted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        // TODO: Place label inside Timeline
        internal void SetTime(TimeSpan timer)
        {
            lblTimeElapsed.Text = timer.Minutes.ToString("D2") + ":" + 
                                  timer.Seconds.ToString("D2") + ":" + 
                                  timer.Milliseconds.ToString("D3");
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
            timeLine.removeAllTracks();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "MATF projects (.matf)|*.matf";

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            
            _projectName = dialog.FileName;
            _hasSaved = true;

            Stream s = dialog.OpenFile();
            XmlReader xmlReader = XmlReader.Create(s);
            xmlReader.ReadToFollowing("tracks");
            Console.WriteLine(xmlReader.Value);
            if (!xmlReader.IsEmptyElement)
            {
                xmlReader.ReadToFollowing("track");
                while (xmlReader.Name == "track")
                {
                    Console.WriteLine(xmlReader.Value);
                    xmlReader.MoveToAttribute("name");
                    string name = xmlReader.Value;
                    Console.WriteLine(xmlReader.Value);

                    xmlReader.MoveToAttribute("filepath");
                    string filepath = xmlReader.Value;
                    Console.WriteLine(xmlReader.Value);

                    xmlReader.MoveToAttribute("color");
                    string color = xmlReader.Value;
                    Console.WriteLine(xmlReader.Value);

                    Track track = new Track(name, filepath, Color.FromArgb(int.Parse(color)), timeLine);

                    xmlReader.ReadToFollowing("times");
                    Console.WriteLine(xmlReader.Value);
                    if (!xmlReader.IsEmptyElement)
                    {
                        xmlReader.ReadToFollowing("time");

                        while (xmlReader.Name == "time")
                        {
                            Console.WriteLine(xmlReader.Value);
                            xmlReader.MoveToAttribute("value");
                            string t = xmlReader.Value;
                            Console.WriteLine(xmlReader.Value);
                            track.addSound(int.Parse(t));
                            xmlReader.Read();
                            xmlReader.Read();


                        }
                    }
                    xmlReader.ReadToFollowing("track");
                    timeLine.addTrack(track);
                }
            }



          

            xmlReader.Close();
            s.Close();
            Text = SoftwareName + " - " + _projectName;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "This is a sample audio App for audio manipulation and mixing.",
                                 "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            theme.InnerText = "" + (Int32)MetroThemeStyle.Dark;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = MetroThemeStyle.Light;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");
            theme.InnerText = "" + (Int32)MetroThemeStyle.Light;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }
        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Green;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Green;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Blue;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Blue;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void silverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Silver;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Silver;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Lime;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Lime;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void magentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Magenta;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Magenta;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void brownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Brown;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Brown;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void orangeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Orange;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Orange;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Pink;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Pink;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Purple;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Purple;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Red;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Red;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void tealToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Teal;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Teal;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.White;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.White;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }

        private void yelowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            metroStyleManager.Style = MetroColorStyle.Yellow;
            XmlDocument doc = new XmlDocument();
            doc.Load(_settingsPath);
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            style.InnerText = "" + (Int32)MetroColorStyle.Yellow;
            doc.Save(_settingsPath);
            this.timeLine.setStyle();
        }
        #endregion Menu

        #region PlayButtons
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (timeLine.GetNumberOfTracks() > 0)
                timeLine.Play();

            //disabling all editing buttons in track
            timeLine.DisableEditingOptionInTracks();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //enabling all editing buttons in track
            timeLine.EnableEditingOptionInTracks();
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
            doc.Load(_settingsPath);

            XmlNode width = doc.DocumentElement.SelectSingleNode("/settings/size/width");
            XmlNode height = doc.DocumentElement.SelectSingleNode("/settings/size/height");
            width.InnerText = "" + (Int32)this.Width;
            height.InnerText = "" + (Int32)this.Height;

            doc.Save(_settingsPath);
        }

        private void saveProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!_hasSaved)
            {
                saveProjectAsToolStripMenuItem_Click(sender, e);
            }
            else
            {
                List<Track> tracks = timeLine.getTracks();
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                XmlWriter xmlWriter = XmlWriter.Create(_projectName, settings);

                int startIndex = _projectName.LastIndexOf('\\') + 1;
                int endIndex = _projectName.LastIndexOf('.');
                int length = endIndex - startIndex;
                xmlWriter.WriteStartElement("project");
                xmlWriter.WriteAttributeString("name", _projectName.Substring(_projectName.LastIndexOf('\\') + 1, length));

                xmlWriter.WriteStartElement("tracks");


                foreach (Track track in tracks)
                {
                    xmlWriter.WriteStartElement("track");
                    xmlWriter.WriteAttributeString("name", track.TrackName);
                    xmlWriter.WriteAttributeString("filepath", track.TrackFileName);
                    xmlWriter.WriteAttributeString("color", track.TrackColor.ToArgb().ToString());

                    string test = track.TrackColor.ToArgb().ToString();
                    int c = int.Parse(test);
                    Color col = Color.FromArgb(c);
                    Console.WriteLine(col);

                    xmlWriter.WriteStartElement("times");
                    foreach (long time in track.Times)
                    {
                        long newtime = time / 55;
                        xmlWriter.WriteStartElement("time");
                        xmlWriter.WriteAttributeString("value", newtime.ToString());
                        xmlWriter.WriteEndElement();

                    }
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

                xmlWriter.Close();

            }


        }

        private void saveProjectAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "MATF projects (.matf)|*.matf";

            List<Track> tracks = timeLine.getTracks();

            if (dialog.ShowDialog() != DialogResult.OK)
                return;

            if(dialog.FileName!= "")
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                Stream s = dialog.OpenFile();
                XmlWriter xmlWriter = XmlWriter.Create(s, settings);
                

                int startIndex = dialog.FileName.LastIndexOf('\\') + 1;
                int endIndex = dialog.FileName.LastIndexOf('.');
                int length = endIndex - startIndex;
                xmlWriter.WriteStartElement("project");
                xmlWriter.WriteAttributeString("name", dialog.FileName.Substring(dialog.FileName.LastIndexOf('\\') + 1, length));

                xmlWriter.WriteStartElement("tracks");
                

                foreach(Track track in tracks)
                {
                    xmlWriter.WriteStartElement("track");
                    xmlWriter.WriteAttributeString("name", track.TrackName);
                    xmlWriter.WriteAttributeString("filepath", track.TrackFileName);
                    xmlWriter.WriteAttributeString("color", track.TrackColor.ToArgb().ToString());


                    xmlWriter.WriteStartElement("times");
                    foreach (long time in track.Times)
                    {
                        long newtime = time / 55;
                        xmlWriter.WriteStartElement("time");
                        xmlWriter.WriteAttributeString("value", newtime.ToString());
                        xmlWriter.WriteEndElement();

                    }
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                }

                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndElement();

                _projectName = dialog.FileName;
                _hasSaved = true;

                xmlWriter.Close();
                s.Close();

            }

            //trbTime.Maximum = (int) _waveOffsetStream.Length;

            Text = SoftwareName + " - " + _projectName;
        }

        private void newProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeLine.removeAllTracks();
            _projectName = null;
            _hasSaved = false;

        }
    }
}
