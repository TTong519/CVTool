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

namespace CVTool
{
    public partial class Diff : UserControl
    {
        public Diff()
        {
            InitializeComponent();
        }
        private void imageBox1_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                imageBox1.Image = bitmap.ToMat();
            }
        }

        private void imageBox3_Click(object sender, EventArgs e)
        {
            Mat mat = imageBox1.Image as Mat;
            //convert toys to grayscale so we can detect the black border to split the image
            Mat imageGray = new Mat();
            CvInvoke.CvtColor(mat, imageGray, ColorConversion.Bgr2Gray);

            //threshold any non-black pixel
            CvInvoke.Threshold(imageGray, imageGray, 1, 255, ThresholdType.Binary);

            //find contour outline of each image
            VectorOfVectorOfPoint imCtrs = new VectorOfVectorOfPoint();
            Mat heirarchy = new Mat();
            CvInvoke.FindContours(imageGray, imCtrs, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            if (imCtrs.Size != 2) throw new Exception("Pair of Images not found");

            //find the bounding rect representing each image
            Rectangle im1rect = CvInvoke.BoundingRectangle(imCtrs[0]);
            Rectangle im2rect = CvInvoke.BoundingRectangle(imCtrs[1]);

            //make sure they are the same size
            im1rect.Size = im2rect.Size;

            //load the ROI's of each image from the corresponding roi rect
            Mat im1 = new Mat(mat as Mat, im1rect);
            Mat im2 = new Mat(mat as Mat, im2rect);

            //find the difference between each color image
            Mat diff = new Mat();
            CvInvoke.AbsDiff(im1, im2, diff);

            //we no longer care what colors are different, only that there is a difference
            //thus, convert this to grayscale for a threshold
            Mat diffGray = new Mat();
            CvInvoke.CvtColor(diff, diffGray, ColorConversion.Bgr2Gray);

            //blur to remove artifacts/disconnects
            CvInvoke.GaussianBlur(diffGray, diffGray, new Size(5, 5), 0);

            //make every pixel that is significantly different white
            CvInvoke.Threshold(diffGray, diffGray, 30, 255, ThresholdType.Binary);

            //find contour outline of each difference
            VectorOfVectorOfPoint differences = new VectorOfVectorOfPoint();
            CvInvoke.FindContours(diffGray, differences, heirarchy, RetrType.External, ChainApproxMethod.ChainApproxNone);

            MCvScalar outlineColor = new MCvScalar(255, 255, 255);

            for (int i = 0; i < differences.Size; i++)
            {
                //get bounds of the contour
                Rectangle bounds = CvInvoke.BoundingRectangle(differences[i]);

                //edit bounds to give a bit of padding around rectangle
                //THIS LINE IS UNNECCESSARY:
                bounds = new Rectangle(bounds.X - 5, bounds.Y - 5, bounds.Width + 10, bounds.Height + 10);

                //because im1 and im2 are ROIs on toys, will draw on toys
                CvInvoke.Rectangle(im1, bounds, outlineColor, 1);
                CvInvoke.Rectangle(im2, bounds, outlineColor, 1);
            }
            imageBox3.Image = mat;
        }
    }
}
