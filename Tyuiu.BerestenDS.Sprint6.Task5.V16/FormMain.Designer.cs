namespace Tyuiu.BerestenDS.Sprint6.Task5.V16
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
            label1 = new Label();
            textBox1 = new TextBox();
            buttonDone = new Button();
            buttonOpenfile = new Button();
            buttonHelp = new Button();
            dataGridViewNums = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 128);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 1;
            label1.Text = "Result :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(476, 106);
            textBox1.TabIndex = 2;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.FromArgb(0, 0, 192);
            buttonDone.Location = new Point(516, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(55, 50);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttoneDone_Click;
            // 
            // buttonOpenfile
            // 
            buttonOpenfile.BackColor = SystemColors.ActiveCaption;
            buttonOpenfile.Location = new Point(601, 11);
            buttonOpenfile.Name = "buttonOpenfile";
            buttonOpenfile.Size = new Size(78, 51);
            buttonOpenfile.TabIndex = 4;
            buttonOpenfile.Text = "Open File";
            buttonOpenfile.UseVisualStyleBackColor = false;
            buttonOpenfile.Click += buttoneOpenFile_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Yellow;
            buttonHelp.Location = new Point(708, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(57, 50);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttoneHelp_Click;
            // 
            // dataGridViewNums
            // 
            dataGridViewNums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewNums.Location = new Point(12, 151);
            dataGridViewNums.Name = "dataGridViewNums";
            dataGridViewNums.RowHeadersVisible = false;
            dataGridViewNums.RowHeadersWidth = 51;
            dataGridViewNums.Size = new Size(150, 283);
            dataGridViewNums.TabIndex = 6;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewNums);
            Controls.Add(buttonHelp);
            Controls.Add(buttonOpenfile);
            Controls.Add(buttonDone);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewNums).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox textBox1;
        private Button buttonDone;
        private Button buttonOpenfile;
        private Button buttonHelp;
        private DataGridView dataGridViewNums;
    }
}
