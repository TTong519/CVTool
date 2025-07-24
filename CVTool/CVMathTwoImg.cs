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
    public partial class CVMathTwoImg : UserControl
    {
        public CVMathTwoImg()
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

        private void imageBox2_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(openFileDialog1.FileName);
                imageBox2.Image = bitmap.ToMat();
            }
        }

        private void imageBox3_Click(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedIndex)
            {
                case 0: // AND
                    Mat ANDoutput = new Mat();
                    CvInvoke.BitwiseAnd(imageBox1.Image, imageBox2.Image, ANDoutput);
                    imageBox3.Image = ANDoutput;
                    break;
                case 1: // OR
                    Mat ORoutput = new Mat();
                    CvInvoke.BitwiseOr(imageBox1.Image, imageBox2.Image, ORoutput);
                    imageBox3.Image = ORoutput;
                    break;
                case 2: // XOR
                    Mat XORoutput = new Mat();
                    CvInvoke.BitwiseXor(imageBox1.Image, imageBox2.Image, XORoutput);
                    imageBox3.Image = XORoutput;
                    break;
                case 3: // ADD
                    Mat ADDoutput = new Mat();
                    CvInvoke.Add(imageBox1.Image, imageBox2.Image, ADDoutput);
                    imageBox3.Image = ADDoutput;
                    break;
                case 4: // SUBTRACT
                    Mat SUBoutput = new Mat();
                    CvInvoke.Subtract(imageBox1.Image, imageBox2.Image, SUBoutput);
                    imageBox3.Image = SUBoutput;
                    break;
                case 5: // MULTIPLY
                    Mat MULoutput = new Mat();
                    CvInvoke.Multiply(imageBox1.Image, imageBox2.Image, MULoutput);
                    imageBox3.Image = MULoutput;
                    break;
                case 6: // DIVIDE
                    Mat DIVoutput = new Mat();
                    CvInvoke.Divide(imageBox1.Image, imageBox2.Image, DIVoutput);
                    imageBox3.Image = DIVoutput;
                    break;
            }
        }
    }
}
