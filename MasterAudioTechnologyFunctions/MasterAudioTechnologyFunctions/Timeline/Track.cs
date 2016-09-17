using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;
using System.Xml;
using MetroFramework;
using MasterAudioTechnologyFunctions.SoundTouchWrapper;

namespace MasterAudioTechnologyFunctions.Timeline
{
    public partial class Track : UserControl
    {
        public string TrackName { get; set; }
        public string TrackFileName { get; set; }
        public Color TrackColor { get; set; }

        public string DefaultNote { get; set; }

        public int TrackLen { get; set; }

        public List<WaveViewer> Tracks;
        public List<long> Times;

        // public bool Playing = false;
        public List<bool> Playing;

        public WaveOut WaveOut;
        public WaveOffsetStream WaveOffsetStream;
        public WaveFileReader WaveFileReader;
        public float TrackVolume = (float)0.7;
        
        private Timeline _timeline; //TODO: Refactor so we use the parent of track instead of a private field.

        public List<string> Notes;

        

        public Track(Timeline tl, string Note)
        {
            InitializeComponent();
            _timeline = tl;
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();

            //TODO: Change so that it doesn't use tl // PD
            frmMatf aFrmMatf = (frmMatf)tl.Parent.Parent;
            Notes = aFrmMatf.Notes;
            cmbbNotes.Items.AddRange(Notes.ToArray());
            cmbbNotes.SelectedItem = "C4 ";
        }

        public Track(string name, string fileName, Color color, Timeline tl, string Note)
        {
            InitializeComponent();
            InitializeTrack(name, fileName, color, tl);
            Tracks = new List<WaveViewer>();
            Times = new List<long>();
            Playing = new List<bool>();
            setStyle();
            //TODO: Change so that it doesn't use tl // PD
            frmMatf aFrmMatf = (frmMatf)tl.Parent.Parent;
            Notes = aFrmMatf.Notes;
            cmbbNotes.Items.AddRange(Notes.ToArray());
            cmbbNotes.SelectedItem = Note;
            DefaultNote = Note;
        }

        public void setStyle()
        {
            XmlDocument doc = new XmlDocument();
            string dir = System.IO.Directory.GetCurrentDirectory();
            doc.Load("..\\..\\settings.xml");
            XmlNode style = doc.DocumentElement.SelectSingleNode("/settings/visual/style");
            XmlNode theme = doc.DocumentElement.SelectSingleNode("/settings/visual/theme");

            this.BtnX.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.BtnX.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);

            this.btnEdit.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.btnEdit.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);


            this.lblTrackName.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.lblTrackName.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlInfo.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlInfo.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);
            this.pnlWaveViewer.Style = (MetroColorStyle)Int32.Parse(style.InnerText);
            this.pnlWaveViewer.Theme = (MetroThemeStyle)Int32.Parse(theme.InnerText);

            this.UpdateStyles();
        }

        //TODO: Where and for what is this used?
        public long getTrackLength()
        {
            return WaveOffsetStream.Length;
        }

        private void InitializeTrack(string name, string fileName, Color color, Timeline tl)
        {
            TrackName = name;
            TrackFileName = fileName;
            TrackColor = color;
            
            if (tl!=null)
            {
                _timeline = tl;
            }

            lblTrackName.Text = TrackName;

            WaveOut = new WaveOut();
            WaveFileReader = new WaveFileReader(TrackFileName);
            WaveOffsetStream = new WaveOffsetStream(WaveFileReader);
            WaveOut.Init(WaveOffsetStream);
            WaveOut.Volume = TrackVolume;

            //TrackLen = (int)WaveFileReader.TotalTime.TotalSeconds*10;
            TrackLen = (int)WaveOffsetStream.Length/10000;
            //MessageBox.Show(WaveFileReader.TotalTime.TotalMilliseconds + "");
            //TODO: Replace 10000 with something concrete 
            //MessageBox.Show(WaveOffsetStream.Length / 10000 + "");

            if (Tracks != null && Tracks.Count > 0)
                foreach (var wvTrack in Tracks)
                    InitializeWaveViewer(wvTrack);
        }

        public void addSound(int startPosition)
        {
            WaveViewer wvTrack = new WaveViewer();
            InitializeWaveViewer(wvTrack);

            pnlWaveViewer.Controls.Add(wvTrack);
            wvTrack.Location = new Point(startPosition, 0);

            int startPositionTime = startPosition * 55; //lenght in millsec/graphical lenght is about 55
            Tracks.Add(wvTrack);
            Times.Add(startPositionTime);
            Playing.Add(false);
        }

        private void InitializeWaveViewer(WaveViewer wvTrack)
        {
            wvTrack.WaveStream = WaveFileReader;
            wvTrack.PenColor = TrackColor;
            wvTrack.Height = pnlWaveViewer.Height;
            wvTrack.Width = TrackLen;
            //wvTrack.FitToScreen();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //TODO: change so that it doesn't use _timeline //PD
            AddNewTrack editTrack = new AddNewTrack(TrackName, TrackFileName, TrackColor, (frmMatf)_timeline.Parent.Parent);
            if (editTrack.ShowDialog() != DialogResult.OK)
                return;

            InitializeTrack(editTrack.TrackName, editTrack.TrackFileName, editTrack.TrackColor, null);
        }

        //TODO: Where and for what is this used?
        public void Update(long globalTime)
        {
            foreach(long l in Times)
            {
                if(l == globalTime)
                {
                    Play();
                }
            }
        }

        public void Play()
        {
            if (WaveOut == null)
                return;

            //Playing = true;
            //btnPlay.Text = "Pa";
            //tmrSong.Enabled = true;

            if (WaveOut.GetPosition() == 0)
            {
                try
                {
                    WaveOut.Play();
                }
                catch
                {

                }
            }
            else
            {
                WaveOut.Resume();
            }
        }

        public void Pause()
        {
            if (WaveOut == null)
                return;

            //Playing = false;
            //btnPlay.Text = "Pl";
            //tmrSong.Enabled = false;

            WaveOut.Pause();
        }

        public void Stop()
        {
            if (WaveOut == null)
                return;

            WaveOut.Stop();
            WaveOffsetStream.CurrentTime = new TimeSpan(0);
        }

        private void BtnX_Click(object sender, EventArgs e)
        {
            _timeline.removeTrack(this);
        }


        public void RemoveWave(WaveViewer wv)
        {
            pnlWaveViewer.Controls.Remove(wv);
            int i = Tracks.IndexOf(wv);
            Tracks.RemoveAt(i);
            Times.RemoveAt(i);
            Playing.RemoveAt(i);
        }

        public void MoveWave(WaveViewer wv)
        {
            int i = Tracks.IndexOf(wv);
            Times[i] = wv.Location.X;
        }

        private void pnlWaveViewer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;
            
            switch (frmMatf.TrackMode)
            {
                case frmMatf.TrackEditMode.Edit:
                    int start = e.X;
                    addSound(start);
                    break;
    
            }
        }
        
        private void cmbbNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (WaveOut == null || cmbbNotes.Items.Count <= 0)
                return;

            SoundTouchSharp soundTouch = new SoundTouchSharp();
            int numChannels = WaveOffsetStream.WaveFormat.Channels;

            soundTouch.CreateInstance();

            soundTouch.SetSampleRate((int)WaveFileReader.SampleCount);
            soundTouch.SetChannels(numChannels);

            soundTouch.SetPitchSemiTones(12.0f);

            soundTouch.SetSetting(SoundTouchSharp.SoundTouchSettings.SETTING_USE_QUICKSEEK, 0);
            soundTouch.SetSetting(SoundTouchSharp.SoundTouchSettings.SETTING_USE_AA_FILTER, 0);

            uint numSamples;
            int bytesRead = 0;
            const int buffSize = 4;
            byte[] buffer = new byte[buffSize];
            float[] fBuffer = new float[buffSize / 4];
            uint buffSizeSamples = (uint)(buffSize / numChannels);

            WaveFormat w = new WaveFormat((int)(WaveFileReader.SampleCount / numChannels), numChannels);

            using (WaveFileWriter fw = new WaveFileWriter("temp.wav", w))
            {
                int offset = 0;

                while ((bytesRead = WaveFileReader.Read(buffer, 0, buffer.Length)) > 0)
                {
                    numSamples = (uint)(bytesRead / numChannels);

                    Buffer.BlockCopy(buffer, 0, fBuffer, 0, fBuffer.Length);

                    soundTouch.PutSamples(fBuffer, numSamples);

                    do
                    {
                        numSamples = soundTouch.ReceiveSamples(fBuffer, buffSizeSamples);
                        //Buffer.BlockCopy(fBuffer, 0, buffer, 0, buffer.Length);
                        int numBytes = (int)(numSamples * numChannels);
                        fw.Write(buffer, 0, numBytes);
                        offset += numBytes;
                    } while (numSamples != 0);
                }
                
                soundTouch.Flush();
                do
                {
                    numSamples = soundTouch.ReceiveSamples(fBuffer, buffSizeSamples);
                    //Buffer.BlockCopy(fBuffer, 0, buffer, 0, buffer.Length);
                    int numBytes = (int)(numSamples * numChannels);
                    fw.Write(buffer, 0, numBytes);
                    offset += numBytes;
                } while (numSamples != 0);
            }
            //int samplesProcessed = 0;

            //do
            //{
            //    samplesProcessed = soundTouch.ReceiveSamples(convertOutputBuffer.Floats, outBufferSizeFloats);
                
            //    if (samplesProcessed > 0)
            //    {
            //        TimeSpan currentBufferTime = WaveFileReader.CurrentTime;

            //        // ** Play samples that came out of SoundTouch by adding them to AdvancedBufferedWaveProvider - the buffered player 
            //        m_inputProvider.AddSamples(convertOutputBuffer.Bytes, 0, (int)samplesProcessed * sizeof(float) * format.Channels, currentBufferTime);
            //        // **********************************************************************
            //    }
            //} while (samplesProcessed != 0);
        }

        public static float[] ConvertByteToFloat(byte[] array)
        {
            float[] floatArr = new float[array.Length / 4];
            for (int i = 0; i < floatArr.Length; i++)
            {
                if (BitConverter.IsLittleEndian)
                {
                    Array.Reverse(array, i * 4, 4);
                }
                floatArr[i] = BitConverter.ToSingle(array, i * 4);
            }
            return floatArr;
        }
    }
}
