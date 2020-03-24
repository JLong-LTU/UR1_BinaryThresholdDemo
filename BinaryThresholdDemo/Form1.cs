using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinaryThresholdDemo
{
    public partial class Form1 : Form
    {
        VideoCapture _capture;
        Thread _captureThread;

        private int binaryThreshold = 100;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // create the capture object and processing thread
            _capture = new VideoCapture(1);
            _captureThread = new Thread(DisplayWebcam);
            _captureThread.Start();
            binaryThresholdTrackbar.Value = binaryThreshold;
            thresholdLbl.Text = $"Threshold: {binaryThreshold}";
        }

        private void DisplayWebcam()
        {
            while (_capture.IsOpened)
            {
                // frame maintenance
                Mat frame = _capture.QueryFrame();

                // resize to PictureBox aspect ratio
                int newHeight = (frame.Size.Height * sourceFramePictureBox.Size.Width) / frame.Size.Width;
                Size newSize = new Size(sourceFramePictureBox.Size.Width, newHeight);
                CvInvoke.Resize(frame, frame, newSize);

                // display the source frame image:
                DisplayImageOnForm(sourceFramePictureBox, frame);

                // grayscale the source image:
                CvInvoke.CvtColor(frame, frame, typeof(Bgr), typeof(Gray));
                DisplayImageOnForm(grayscalePictureBox, frame);

                // Apply binary threshold:
                CvInvoke.Threshold(frame, frame, binaryThreshold, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
                DisplayImageOnForm(binaryFramePictureBox, frame);
            }
        }

        private void DisplayImageOnForm(PictureBox pictureBox, Mat frame)
        {
            Invoke(new Action(() =>
            {
                pictureBox.Image = frame.Clone().Bitmap;
            }));
            Thread.Sleep(50);
        }

        private void binaryThresholdTrackbar_Scroll(object sender, EventArgs e)
        {
            binaryThreshold = binaryThresholdTrackbar.Value;
            thresholdLbl.Text = $"Threshold: {binaryThreshold}";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _captureThread.Abort();
        }
    }
}
