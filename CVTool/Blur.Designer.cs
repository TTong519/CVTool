namespace CVTool
{
    partial class Blur
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
            comboBox1 = new ComboBox();
            imageBox2 = new Emgu.CV.UI.ImageBox();
            openFileDialog1 = new OpenFileDialog();
            trackBar1 = new TrackBar();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.Fixed3D;
            imageBox1.Location = new Point(39, 65);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(296, 296);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 8;
            imageBox1.TabStop = false;
            imageBox1.Click += imageBox1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "2DFilter", "Bilateral", "Gaussnian", "Median", "Stack" });
            comboBox1.Location = new Point(389, 198);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 10;
            comboBox1.Text = "Choose Operation";
            // 
            // imageBox2
            // 
            imageBox2.BorderStyle = BorderStyle.Fixed3D;
            imageBox2.Location = new Point(552, 65);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(296, 296);
            imageBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox2.TabIndex = 9;
            imageBox2.TabStop = false;
            imageBox2.Click += imageBox2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(315, 367);
            trackBar1.Maximum = 25;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(264, 45);
            trackBar1.TabIndex = 11;
            trackBar1.TickFrequency = 2;
            trackBar1.Value = 3;
            // 
            // Blur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(trackBar1);
            Controls.Add(imageBox1);
            Controls.Add(comboBox1);
            Controls.Add(imageBox2);
            Name = "Blur";
            Size = new Size(903, 426);
            Load += Blur_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private ComboBox comboBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private OpenFileDialog openFileDialog1;
        private TrackBar trackBar1;
    }
}
