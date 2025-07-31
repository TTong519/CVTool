using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CVTool
{
    public partial class Contour : UserControl
    {
        public Contour()
        {
            InitializeComponent();
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageBox1.Image = new Bitmap(openFileDialog1.FileName).ToMat();
            }
        }

        private void imageBox2_Click(object sender, EventArgs e)
        {
            Mat mat = imageBox1.Image as Mat;
            CvInvoke.CvtColor(mat, mat, Emgu.CV.CvEnum.ColorConversion.Rgb2Gray);
            VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
            Mat hierarchy = new Mat();
            CvInvoke.FindContours(mat, contours, hierarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);
            CvInvoke.CvtColor(mat, mat, Emgu.CV.CvEnum.ColorConversion.Gray2Bgr);
            CvInvoke.DrawContours(mat, contours, -1, new MCvScalar(0, 0, 255), 5);
            imageBox2.Image = mat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CvInvoke.Imwrite(saveFileDialog1.FileName + ".png", imageBox2.Image as Mat);
            }
        }
    }
}
