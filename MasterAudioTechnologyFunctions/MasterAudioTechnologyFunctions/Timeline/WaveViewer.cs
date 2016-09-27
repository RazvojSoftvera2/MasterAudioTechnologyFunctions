﻿using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using NAudio.Wave;

namespace MasterAudioTechnologyFunctions.Timeline
{
    /// <summary>
    /// Control for viewing waveforms
    /// </summary>
    public class WaveViewer : System.Windows.Forms.UserControl
    {
        public Color PenColor { get; set; }
        public float PenWidth { get; set; }
        public int WaveLength { get; set; }

        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;
        private WaveStream waveStream;
        private int samplesPerPixel = 128;
        private long startPosition;
        private int bytesPerSample;
        private int bytesPerSecond;
        /// <summary>
        /// Creates a new WaveViewer control
        /// </summary>
        public WaveViewer()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();
            this.DoubleBuffered = true;

            this.BackColor = Color.Gray;
            this.PenColor = Color.White;
            this.PenWidth = 1f;
        }

        /// <summary>
        /// sets the associated wavestream
        /// </summary>
        public WaveStream WaveStream
        {
            get
            {
                return waveStream;
            }
            set
            {
                waveStream = value;
                if (waveStream != null)
                {
                    bytesPerSample = (waveStream.WaveFormat.BitsPerSample / 8) * waveStream.WaveFormat.Channels;
                    bytesPerSecond = (waveStream.WaveFormat.AverageBytesPerSecond);
                }
                this.Invalidate();
            }
        }

        /// <summary>
        /// The zoom level, in samples per pixel
        /// </summary>
        public int SamplesPerPixel
        {
            get
            {
                return samplesPerPixel;
            }
            set
            {
                samplesPerPixel = Math.Max(1, value);
                this.Invalidate();
            }
        }

        /// <summary>
        /// Start position (currently in bytes)
        /// </summary>
        public long StartPosition
        {
            get
            {
                return startPosition;
            }
            set
            {
                startPosition = value;
            }
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// <see cref="Control.OnPaint"/>
        /// </summary>
        protected override void OnPaint(PaintEventArgs e)
        {
            if (waveStream != null)
            {
                waveStream.Position = 0;
                int bytesRead;
                byte[] waveData = new byte[samplesPerPixel * bytesPerSample];
                
                long tempWavePosition = waveStream.Position;
                waveStream.Position = startPosition + (e.ClipRectangle.Left * bytesPerSample * samplesPerPixel);
                waveStream.Position = tempWavePosition;
                
                using (Pen linePen = new Pen(PenColor, PenWidth))
                {
                    for (float x = e.ClipRectangle.X; x < e.ClipRectangle.Right; x += 1)
                    {
                        short low = 0;
                        short high = 0;

                        bytesRead = waveStream.Read(waveData, 0, samplesPerPixel * bytesPerSample);
                        
                        if (bytesRead == 0)
                            break;
                        for (int n = 0; n < bytesRead; n += 2)
                        {
                            short sample = BitConverter.ToInt16(waveData, n);
                            if (sample < low) low = sample;
                            if (sample > high) high = sample;
                        }
                        float lowPercent = ((((float)low) - short.MinValue) / ushort.MaxValue);
                        float highPercent = ((((float)high) - short.MinValue) / ushort.MaxValue);
                        e.Graphics.DrawLine(linePen, x, this.Height * lowPercent, x, this.Height * highPercent);
                    }
                }
            }

            base.OnPaint(e);
        }

        public void FitToScreen()
        {
            if (WaveStream == null)
                return;
            
            int samples = (int)(WaveStream.Length / bytesPerSample);
            SamplesPerPixel = samples / Width;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            
            FitToScreen();
        }
        
        private Point mousePos, startPos;
        private bool mouseDrag = false;

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (WaveStream == null)
                return;

            if (e.Button == MouseButtons.Left && Timeline.TrackMode == Timeline.TrackEditMode.Edit)
            {
                startPos = e.Location;
                mousePos = e.Location;
                mouseDrag = true;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (WaveStream == null)
                return;

            Track p = (Track)Parent.Parent;

            switch (Timeline.TrackMode)
            {
                case Timeline.TrackEditMode.Delete:
                    if (e.Button == MouseButtons.Left)
                    {
                        p.RemoveWave(this);
                    }
                    break;
                case Timeline.TrackEditMode.Edit:
                    if (mouseDrag && e.Button == MouseButtons.Left)
                    {
                        mouseDrag = false;
                        
                        Point oldLocation = Location;

                        if (mousePos.X != startPos.X)
                        {
                            int newX = oldLocation.X + e.X - startPos.X;

                            if (((Timeline)Parent.Parent.Parent.Parent).SnapToGrid)
                            {
                                int modFive = newX % 10;
                                newX = modFive == 0 ? newX : newX - modFive;
                            }

                            if (newX < 0)
                                newX = 0;

                            Location = new Point(newX, oldLocation.Y);
                            p.MoveWave(this);
                        }
                    }
                    break;
                case Timeline.TrackEditMode.Play:
                    ((Track)Parent.Parent).Skip(e.Location.X, this);
                    break;
            }
            
            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (WaveStream == null)
                return;

            if (mouseDrag && Timeline.TrackMode == Timeline.TrackEditMode.Edit)
            {
                Point oldLocation = Location;

                if (mousePos.X != startPos.X)
                {
                    int newX = oldLocation.X + e.X - startPos.X;

                    if (((Timeline)Parent.Parent.Parent.Parent).SnapToGrid)
                    {
                        int modFive = newX % 10;
                        newX = modFive == 0 ? newX : newX - modFive;
                    }

                    if (newX < 0)
                        newX = 0;

                    Location = new Point(newX, oldLocation.Y);
                    Track p = (Track)Parent.Parent;
                    p.MoveWave(this);
                }

                mousePos = e.Location;
            }

            base.OnMouseDown(e);
        }

        #region Component Designer generated code
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // WaveViewer
            // 
            this.Name = "WaveViewer";
            this.ResumeLayout(false);

        }
        #endregion
    }
}