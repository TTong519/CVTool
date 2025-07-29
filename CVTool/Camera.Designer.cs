namespace CVTool
{
    partial class Camera
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
            saveFileDialog1 = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.Location = new Point(0, 0);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(485, 383);
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            imageBox1.Click += imageBox1_Click;
            // 
            // Camera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageBox1);
            Name = "Camera";
            Size = new Size(485, 383);
            Load += Camera_Load;
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private SaveFileDialog saveFileDialog1;
    }
}
