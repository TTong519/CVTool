using Emgu.CV;
using Emgu.CV.Structure;
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
    public partial class InRange : UserControl
    {
        public InRange()
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Mat output = new Mat();
                Mat temp = new Mat();
                CvInvoke.CvtColor(imageBox1.Image, temp, Emgu.CV.CvEnum.ColorConversion.Rgb2Bgr);
                CvInvoke.InRange(temp, (ScalarArray)new MCvScalar(trackBar1.Value, trackBar2.Value, trackBar3.Value), (ScalarArray)new MCvScalar(trackBar4.Value, trackBar5.Value, trackBar6.Value), output);
                imageBox2.Image = output;
            }
            else if (radioButton2.Checked)
            {
                Mat output = new Mat();
                Mat temp = new Mat();
                CvInvoke.CvtColor(imageBox1.Image, temp, Emgu.CV.CvEnum.ColorConversion.Rgb2Bgr);
                CvInvoke.InRange(temp, (ScalarArray)new MCvScalar(trackBar1.Value, trackBar2.Value, trackBar3.Value), (ScalarArray)new MCvScalar(trackBar4.Value, trackBar5.Value, trackBar6.Value), output);
                imageBox2.Image = output;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                trackBar1.Maximum = 180;
                trackBar2.Maximum = 100;
                trackBar3.Maximum = 100;
                trackBar4.Maximum = 180;
                trackBar5.Maximum = 100;
                trackBar6.Maximum = 100;
            }
            else
            {
                trackBar1.Maximum = 255;
                trackBar2.Maximum = 255;
                trackBar3.Maximum = 255;
                trackBar4.Maximum = 255;
                trackBar5.Maximum = 255;
                trackBar6.Maximum = 255;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                trackBar1.Maximum = 180;
                trackBar2.Maximum = 255;
                trackBar3.Maximum = 255;
                trackBar4.Maximum = 180;
                trackBar5.Maximum = 255;
                trackBar6.Maximum = 255;
            }
            else
            {
                trackBar1.Maximum = 255;
                trackBar2.Maximum = 255;
                trackBar3.Maximum = 255;
                trackBar4.Maximum = 255;
                trackBar5.Maximum = 255;
                trackBar6.Maximum = 255;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CvInvoke.Imwrite(saveFileDialog1.FileName + ".png", imageBox2.Image);
            }
        }
    }
}
