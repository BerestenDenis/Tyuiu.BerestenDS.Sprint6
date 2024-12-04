namespace Tyuiu.BerestenDS.Sprint6.Task0.V4
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
            textBoxResult = new TextBox();
            pictureBoxTask = new PictureBox();
            buttonDone = new Button();
            textBoxX = new TextBox();
            buttonHelp = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.AccessibleName = "";
            textBoxResult.Location = new Point(544, 339);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(235, 27);
            textBoxResult.TabIndex = 1;
            // 
            // pictureBoxTask
            // 
            pictureBoxTask.Image = (Image)resources.GetObject("pictureBoxTask.Image");
            pictureBoxTask.Location = new Point(23, 12);
            pictureBoxTask.Name = "pictureBoxTask";
            pictureBoxTask.Size = new Size(505, 134);
            pictureBoxTask.TabIndex = 2;
            pictureBoxTask.TabStop = false;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(658, 413);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(104, 25);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // textBoxX
            // 
            textBoxX.Location = new Point(61, 339);
            textBoxX.Name = "textBoxX";
            textBoxX.Size = new Size(44, 27);
            textBoxX.TabIndex = 4;
            textBoxX.Tag = "";
            textBoxX.KeyPress += textBoxx_KeyPress;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(612, 413);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(29, 24);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonHelp);
            Controls.Add(textBoxX);
            Controls.Add(buttonDone);
            Controls.Add(pictureBoxTask);
            Controls.Add(textBoxResult);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "FormMain";
            ((System.ComponentModel.ISupportInitialize)pictureBoxTask).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxResult;
        private PictureBox pictureBoxTask;
        private Button buttonDone;
        private TextBox textBoxX;
        private Button buttonHelp;
    }
}
