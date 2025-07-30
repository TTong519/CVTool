using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVTool
{
    public partial class ImageOperations1img : UserControl
    {
        public ImageOperations1img()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void imageBox2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 3:
                    Mat notOutput = new Mat();
                    CvInvoke.BitwiseNot(imageBox1.Image, notOutput);
                    imageBox2.Image = notOutput;
                    break;
                case 4:
                    Mat ROTLoutput = new Mat();
                    CvInvoke.Rotate(imageBox1.Image, ROTLoutput, Emgu.CV.CvEnum.RotateFlags.Rotate90CounterClockwise);
                    imageBox2.Image = ROTLoutput;
                    break;
                case 5:
                    Mat ROTRoutput = new Mat();
                    CvInvoke.Rotate(imageBox1.Image, ROTRoutput, Emgu.CV.CvEnum.RotateFlags.Rotate90Clockwise);
                    imageBox2.Image = ROTRoutput;
                    break;
                case 1:
                    Mat hsvOutput = new Mat();
                    CvInvoke.CvtColor(imageBox1.Image, hsvOutput, Emgu.CV.CvEnum.ColorConversion.Rgb2Hsv);
                    imageBox2.Image = hsvOutput;
                    break;
                case 0:
                    Mat bgrOutput = new Mat();
                    CvInvoke.CvtColor(imageBox1.Image, bgrOutput, Emgu.CV.CvEnum.ColorConversion.Rgb2Bgr);
                    imageBox2.Image = bgrOutput;
                    break;
                case 2:
                    Mat grayOutput = new Mat();
                    CvInvoke.CvtColor(imageBox1.Image, grayOutput, Emgu.CV.CvEnum.ColorConversion.Gray2Rgb);
                    imageBox2.Image = grayOutput;
                    break;
            }
        }

        private void imageBox1_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                imageBox1.Image = bitmap.ToMat();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CvInvoke.Imwrite(saveFileDialog1.FileName + ".png", imageBox2.Image);
            }
        }
    }
}
