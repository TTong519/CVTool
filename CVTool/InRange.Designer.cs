namespace CVTool
{
    partial class InRange
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
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            trackBar3 = new TrackBar();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            imageBox2 = new Emgu.CV.UI.ImageBox();
            trackBar4 = new TrackBar();
            trackBar5 = new TrackBar();
            trackBar6 = new TrackBar();
            button2 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.BorderStyle = BorderStyle.Fixed3D;
            imageBox1.Location = new Point(26, 38);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(296, 296);
            imageBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            imageBox1.Click += imageBox1_Click;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(390, 51);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(275, 45);
            trackBar1.TabIndex = 3;
            trackBar1.TickFrequency = 5;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(390, 102);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(275, 45);
            trackBar2.TabIndex = 4;
            trackBar2.TickFrequency = 5;
            // 
            // trackBar3
            // 
            trackBar3.Location = new Point(390, 153);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new Size(275, 45);
            trackBar3.TabIndex = 5;
            trackBar3.TickFrequency = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(390, 362);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(47, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "BGR";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(618, 362);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(47, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "HSV";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(488, 360);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Convert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageBox2
            // 
            imageBox2.BorderStyle = BorderStyle.Fixed3D;
            imageBox2.Location = new Point(747, 38);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(296, 296);
            imageBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            imageBox2.TabIndex = 2;
            imageBox2.TabStop = false;
            // 
            // trackBar4
            // 
            trackBar4.Location = new Point(390, 204);
            trackBar4.Maximum = 255;
            trackBar4.Name = "trackBar4";
            trackBar4.Size = new Size(275, 45);
            trackBar4.TabIndex = 9;
            trackBar4.TickFrequency = 5;
            // 
            // trackBar5
            // 
            trackBar5.Location = new Point(390, 255);
            trackBar5.Maximum = 255;
            trackBar5.Name = "trackBar5";
            trackBar5.Size = new Size(275, 45);
            trackBar5.TabIndex = 10;
            trackBar5.TickFrequency = 5;
            // 
            // trackBar6
            // 
            trackBar6.Location = new Point(390, 306);
            trackBar6.Maximum = 255;
            trackBar6.Name = "trackBar6";
            trackBar6.Size = new Size(275, 45);
            trackBar6.TabIndex = 11;
            trackBar6.TickFrequency = 5;
            // 
            // button2
            // 
            button2.Location = new Point(747, 354);
            button2.Name = "button2";
            button2.Size = new Size(296, 27);
            button2.TabIndex = 12;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // InRange
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button2);
            Controls.Add(trackBar6);
            Controls.Add(trackBar5);
            Controls.Add(trackBar4);
            Controls.Add(imageBox2);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(trackBar3);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(imageBox1);
            Name = "InRange";
            Size = new Size(1068, 404);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar3).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar4).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar5).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private TrackBar trackBar3;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private TrackBar trackBar4;
        private TrackBar trackBar5;
        private TrackBar trackBar6;
        private Button button2;
        private SaveFileDialog saveFileDialog1;
    }
}
