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
            inRange1 = new InRange();
            camera1 = new Camera();
            SuspendLayout();
            // 
            // inRange1
            // 
            inRange1.Location = new Point(60, 61);
            inRange1.Name = "inRange1";
            inRange1.Size = new Size(1068, 404);
            inRange1.TabIndex = 4;
            // 
            // camera1
            // 
            camera1.Location = new Point(83, 494);
            camera1.Name = "camera1";
            camera1.Size = new Size(441, 383);
            camera1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 921);
            Controls.Add(camera1);
            Controls.Add(inRange1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private InRange inRange1;
        private Camera camera1;
    }
}
