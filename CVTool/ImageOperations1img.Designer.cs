namespace CVTool
{
    partial class ImageOperations1img
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
            ((System.ComponentModel.ISupportInitialize)imageBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).BeginInit();
            SuspendLayout();
            // 
            // imageBox1
            // 
            imageBox1.Location = new Point(22, 72);
            imageBox1.Name = "imageBox1";
            imageBox1.Size = new Size(296, 296);
            imageBox1.TabIndex = 2;
            imageBox1.TabStop = false;
            // 
            // imageBox2
            // 
            imageBox2.Location = new Point(528, 72);
            imageBox2.Name = "imageBox2";
            imageBox2.Size = new Size(296, 296);
            imageBox2.TabIndex = 2;
            imageBox2.TabStop = false;
            // 
            // ImageOperations1img
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(imageBox2);
            Controls.Add(imageBox1);
            Name = "ImageOperations1img";
            Size = new Size(837, 453);
            ((System.ComponentModel.ISupportInitialize)imageBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)imageBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
    }
}
