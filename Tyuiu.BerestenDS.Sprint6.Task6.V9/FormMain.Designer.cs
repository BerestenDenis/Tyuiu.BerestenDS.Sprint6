namespace Tyuiu.BerestenDS.Sprint6.Task6.V9
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            textBoxLoad = new TextBox();
            textBoxResult = new TextBox();
            buttonOpenFile = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            openFileDialogTask = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // textBoxLoad
            // 
            textBoxLoad.Location = new Point(10, 132);
            textBoxLoad.Multiline = true;
            textBoxLoad.Name = "textBoxLoad";
            textBoxLoad.Size = new Size(380, 374);
            textBoxLoad.TabIndex = 0;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(483, 132);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(389, 372);
            textBoxResult.TabIndex = 1;
            // 
            // buttonOpenFile
            // 
            buttonOpenFile.Image = (Image)resources.GetObject("buttonOpenFile.Image");
            buttonOpenFile.Location = new Point(12, 6);
            buttonOpenFile.Name = "buttonOpenFile";
            buttonOpenFile.Size = new Size(43, 36);
            buttonOpenFile.TabIndex = 2;
            toolTip1.SetToolTip(buttonOpenFile, "Выберите нужный файл\r\n");
            buttonOpenFile.UseVisualStyleBackColor = true;
            buttonOpenFile.Click += buttonOpenFile_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = (Image)resources.GetObject("buttonDone.Image");
            buttonDone.Location = new Point(73, 6);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(50, 36);
            buttonDone.TabIndex = 3;
            buttonDone.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(819, 5);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(53, 37);
            buttonHelp.TabIndex = 4;
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(10, 48);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(845, 68);
            textBox3.TabIndex = 5;
            textBox3.Text = resources.GetString("textBox3.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 119);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 6;
            label1.Text = "File";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(819, 119);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 7;
            label2.Text = "Result";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialogTask";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Help";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 506);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(buttonOpenFile);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxLoad);
            Name = "FormMain";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLoad;
        private TextBox textBoxResult;
        private Button buttonOpenFile;
        private Button buttonDone;
        private Button buttonHelp;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip1;
    }
}
