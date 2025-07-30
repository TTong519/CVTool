using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#nullable disable

namespace CVTool
{
    public partial class Camera : UserControl
    {

        VideoCapture capture = new VideoCapture();
        
        public void GetFrame(object sender, EventArgs e)
        {

            if (!capture.IsOpened) return;
            if (!capture.Grab()) return;

            using Mat currentFrame = capture.QueryFrame();
            using Mat flipped = new Mat();
            CvInvoke.Flip(currentFrame, flipped, Emgu.CV.CvEnum.FlipType.Horizontal);
            imageBox1.Image = flipped.Clone();
        }
        public Camera()
        {
            InitializeComponent();
        }

        private void Camera_Load(object sender, EventArgs e)
        {
            Application.Idle += GetFrame;
            saveFileDialog1.AddExtension = true;
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CvInvoke.Imwrite(saveFileDialog1.FileName + ".png", imageBox1.Image);
            }
        }
    }
}
