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
    public partial class Blur : UserControl
    {
        public Blur()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                imageBox1.Image = bitmap.ToMat();
            }
        }

        private void imageBox2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0: // 2D Filter
                    Mat output = new Mat();
                    CvInvoke.Blur(imageBox1.Image, output, new Size(trackBar1.Value, trackBar1.Value), new Point(-1, -1), Emgu.CV.CvEnum.BorderType.Default);
                    imageBox2.Image = output;
                    break;
                case 1: // Bilateral Filter
                    Mat outputBilateral = new Mat();
                    CvInvoke.BilateralFilter(imageBox1.Image, outputBilateral, trackBar1.Value, trackBar1.Value * 5, trackBar1.Value * 5);
                    imageBox2.Image = outputBilateral;
                    break;
                case 2: // Gaussian Filter
                    Mat outputGaussian = new Mat();
                    CvInvoke.GaussianBlur(imageBox1.Image, outputGaussian, new Size(trackBar1.Value, trackBar1.Value), 0);
                    imageBox2.Image = outputGaussian;
                    break;
                case 3: // Median Filter
                    Mat outputMedian = new Mat();
                    CvInvoke.MedianBlur(imageBox1.Image, outputMedian, trackBar1.Value);
                    imageBox2.Image = outputMedian;
                    break;
                case 4: // Stack Blur
                    Mat outputStack = new Mat();
                    CvInvoke.StackBlur(imageBox1.Image, outputStack, new(trackBar1.Value, trackBar1.Value));
                    imageBox2.Image = outputStack;
                    break;
            }
        }

        private void Blur_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CvInvoke.Imwrite(saveFileDialog1.FileName + ".png", imageBox2.Image);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
