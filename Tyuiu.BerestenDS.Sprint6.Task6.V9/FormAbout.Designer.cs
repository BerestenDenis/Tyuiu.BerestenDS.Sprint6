namespace Tyuiu.BerestenDS.Sprint6.Task6.V9
{
    partial class FormAbout
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            buttonok = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(33, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(122, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(203, 33);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(368, 184);
            textBox1.TabIndex = 1;
            textBox1.Text = "Beresten Denis \r\nИБКСБ 24-1\r\nTask 6\r\n";
            // 
            // buttonok
            // 
            buttonok.Location = new Point(503, 226);
            buttonok.Name = "buttonok";
            buttonok.Size = new Size(60, 30);
            buttonok.TabIndex = 2;
            buttonok.Text = "Dota 2";
            buttonok.UseVisualStyleBackColor = true;
            buttonok.Click += buttonok_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 261);
            Controls.Add(buttonok);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Name = "FormAbout";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ImageList imageList1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Button buttonok;
    }
}