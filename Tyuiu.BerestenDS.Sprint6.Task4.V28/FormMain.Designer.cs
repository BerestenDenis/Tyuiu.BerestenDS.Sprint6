namespace Tyuiu.BerestenDS.Sprint6.Task4.V28
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
            textBoxResult = new TextBox();
            label1 = new Label();
            textBoxStart = new TextBox();
            textBoxStop = new TextBox();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            label2 = new Label();
            label3 = new Label();
            LabelInfo = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(12, 74);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(282, 423);
            textBoxResult.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 1;
            label1.Text = "Вывод :";
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(418, 21);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(139, 27);
            textBoxStart.TabIndex = 2;
            // 
            // textBoxStop
            // 
            textBoxStop.Location = new Point(600, 21);
            textBoxStop.Name = "textBoxStop";
            textBoxStop.Size = new Size(125, 27);
            textBoxStop.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.FromArgb(255, 128, 128);
            buttonSave.Location = new Point(846, 14);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(51, 36);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = SystemColors.ActiveCaption;
            buttonDone.Location = new Point(759, 14);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(63, 37);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Start";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttoneDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.Purple;
            buttonHelp.Location = new Point(919, 14);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(58, 34);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(418, 51);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 7;
            label2.Text = "Start step";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(600, 51);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 8;
            label3.Text = "Stop step";
            // 
            // LabelInfo
            // 
            LabelInfo.AutoSize = true;
            LabelInfo.Location = new Point(392, 96);
            LabelInfo.Name = "LabelInfo";
            LabelInfo.Size = new Size(67, 20);
            LabelInfo.TabIndex = 9;
            LabelInfo.Text = "Условия";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(393, 132);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(404, 341);
            textBox2.TabIndex = 10;
            textBox2.Text = "Написать программу, которая выводит таблицу значений функции:\r\nsin(8) F(x) = cos(2x) + + 2x x+2,5\r\n(произвести табулирование) f(x) на заданном диапазоне [-5; 5]\r\n";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 509);
            Controls.Add(textBox2);
            Controls.Add(LabelInfo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(buttonSave);
            Controls.Add(textBoxStop);
            Controls.Add(textBoxStart);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            Name = "FormMain";
            Text = "Denis Beresten";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxResult;
        private Label label1;
        private TextBox textBoxStart;
        private TextBox textBoxStop;
        private Button buttonSave;
        private Button buttonDone;
        private Button buttonHelp;
        private Label label2;
        private Label label3;
        private Label LabelInfo;
        private TextBox textBox2;
    }
}
