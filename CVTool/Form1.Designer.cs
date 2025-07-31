namespace CVTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cvMathTwoImg1 = new CVMathTwoImg();
            inRange1 = new InRange();
            SuspendLayout();
            // 
            // cvMathTwoImg1
            // 
            cvMathTwoImg1.Location = new Point(12, 35);
            cvMathTwoImg1.Name = "cvMathTwoImg1";
            cvMathTwoImg1.Size = new Size(1306, 388);
            cvMathTwoImg1.TabIndex = 0;
            // 
            // inRange1
            // 
            inRange1.Location = new Point(163, 429);
            inRange1.Name = "inRange1";
            inRange1.Size = new Size(1068, 404);
            inRange1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 921);
            Controls.Add(inRange1);
            Controls.Add(cvMathTwoImg1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private ImageOperations1img imageOperations1img1;
        private CVMathTwoImg cvMathTwoImg1;
        private InRange inRange1;
    }
}
