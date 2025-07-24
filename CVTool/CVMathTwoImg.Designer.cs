namespace CVTool
{
    partial class CVMathTwoImg
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
            imageBox2 = new Emgu.CV.UI.ImageBox();
            imageBox3 = new Emgu.CV.UI.ImageBox();
            openFileDialog1 = new OpenFileDialog();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox3).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.Fixed3D;
            imageBox1.Location = new Point(35, 56);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(296, 296);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            imageBox1.Click += imageBox1_Click;
            // 
            // imageBox2
            // 
            imageBox2.BorderStyle = BorderStyle.Fixed3D;
            imageBox2.Location = new Point(410, 56);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(296, 296);
            imageBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox2.TabIndex = 2;
            imageBox2.TabStop = false;
            imageBox2.Click += imageBox2_Click;
            // 
            // imageBox3
            // 
            imageBox3.BorderStyle = BorderStyle.Fixed3D;
            imageBox3.Location = new Point(972, 56);
            imageBox3.Name = "imageBox3";
            imageBox3.Size = new Size(296, 296);
            imageBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox3.TabIndex = 2;
            imageBox3.TabStop = false;
            imageBox3.Click += imageBox3_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "AND", "OR", "XOR", "ADD", "SUB", "MUL", "DIV" });
            comboBox1.Location = new Point(774, 195);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Choose Operation";
            // 
            // CVMathTwoImg
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(imageBox3);
            Controls.Add(imageBox2);
            Controls.Add(imageBox1);
            Name = "CVMathTwoImg";
            Size = new Size(1306, 388);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private Emgu.CV.UI.ImageBox imageBox3;
        private OpenFileDialog openFileDialog1;
        private ComboBox comboBox1;
    }
}
