namespace CVTool
{
    partial class Diff
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imageBox1 = new Emgu.CV.UI.ImageBox();
            imageBox3 = new Emgu.CV.UI.ImageBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox3).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.Fixed3D;
            imageBox1.Location = new Point(76, 88);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(342, 563);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            imageBox1.Click += imageBox1_Click;
            // 
            // imageBox3
            // 
            imageBox3.BorderStyle = BorderStyle.Fixed3D;
            imageBox3.Location = new Point(632, 88);
            imageBox3.Name = "imageBox3";
            imageBox3.Size = new Size(313, 563);
            imageBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox3.TabIndex = 2;
            imageBox3.TabStop = false;
            imageBox3.Click += imageBox3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Diff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageBox3);
            Controls.Add(imageBox1);
            Name = "Diff";
            Size = new Size(1071, 700);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox3;
        private OpenFileDialog openFileDialog1;
    }
}
