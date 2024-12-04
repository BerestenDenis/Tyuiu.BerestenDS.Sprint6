namespace Tyuiu.BerestenDS.Sprint6.Task1.V9
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            pictureBoxTask = new PictureBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.InitialImage = (Image)resources.GetObject("pictureBoxTask.InitialImage");
            pictureBoxTask.Location = new Point(2, 1);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(556, 203);
            pictureBoxTask.TabIndex = 0;
            pictureBoxTask.TabStop = false;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(577, 12);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(211, 378);
            textBoxResult.TabIndex = 1;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(128, 255, 128);
            buttonDone.Location = new Point(384, 375);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(99, 48);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Red;
            buttonHelp.Location = new Point(282, 375);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(84, 48);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(28, 386);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(92, 27);
            textBoxStart.TabIndex = 5;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(157, 386);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(90, 27);
            textBoxStop.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(textBoxResult);
            Controls.Add(pictureBoxTask);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Берестень Денис ИБКСБ24-1";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxTask;
        private TextBox textBoxResult;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
    }
}
