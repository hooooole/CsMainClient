using GitHub.secile.Video;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TcpClient
{
    public partial class video : Form
    {
        public video()
        {
            InitializeComponent();

            string[] devices = UsbCamera.FindDevices();

            if (devices.Length == 0) return; // no camera.

            // check format.
            int cameraIndex = 0;
            UsbCamera.VideoFormat[] formats = UsbCamera.GetVideoFormat(cameraIndex);
            for (int i = 0; i < formats.Length; i++) Console.WriteLine("{0}:{1}", i, formats[i]);

            // create usb camera and start.
            var camera = new UsbCamera(cameraIndex, formats[0]);
            camera.Start();

            // get image.
            // Immediately after starting the USB camera,
            // GetBitmap() fails because image buffer is not prepared yet.
            var bmp = camera.GetBitmap();

            // show image in PictureBox.
            var timer = new System.Timers.Timer(100) { SynchronizingObject = this };
            timer.Elapsed += (s, ev) => pictureBox1.Image = camera.GetBitmap();
            timer.Start();
            // release resource when close.
            this.FormClosing += (s, ev) => timer.Stop();
            this.FormClosing += (s, ev) => camera.Stop();
        }

        private void video_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_video_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
