namespace Tyuiu.BerestenDS.Sprint6.Task2.V30
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
            textBoxStartValue = new TextBox();
            textBoxStopValue = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonHelp = new Button();
            buttonDone = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            dataGridViewFunction = new DataGridView();
            X = new DataGridViewTextBoxColumn();
            F = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).BeginInit();
            SuspendLayout();
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(24, 398);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(86, 27);
            textBoxStartValue.TabIndex = 0;
            // 
            // textBoxStopValue
            // 
            textBoxStopValue.Location = new Point(139, 398);
            textBoxStopValue.Name = "textBoxStopValue";
            textBoxStopValue.Size = new Size(93, 27);
            textBoxStopValue.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 375);
            label1.Name = "label1";
            label1.Size = new Size(88, 20);
            label1.TabIndex = 2;
            label1.Text = "Старт шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 375);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 3;
            label2.Text = "Конец шага:";
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = SystemColors.MenuHighlight;
            buttonHelp.Location = new Point(412, 387);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(84, 39);
            buttonHelp.TabIndex = 4;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.Lime;
            buttonDone.Location = new Point(519, 388);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(106, 36);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 13);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "Условия";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(18, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(600, 213);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // dataGridViewFunction
            // 
            dataGridViewFunction.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunction.Columns.AddRange(new DataGridViewColumn[] { X, F });
            dataGridViewFunction.Location = new Point(664, 36);
            dataGridViewFunction.Name = "dataGridViewFunction";
            dataGridViewFunction.RowHeadersVisible = false;
            dataGridViewFunction.RowHeadersWidth = 51;
            dataGridViewFunction.Size = new Size(121, 388);
            dataGridViewFunction.TabIndex = 8;
            // 
            // X
            // 
            X.HeaderText = "X";
            X.MinimumWidth = 6;
            X.Name = "X";
            X.ReadOnly = true;
            X.Width = 50;
            // 
            // F
            // 
            F.HeaderText = "F(x)";
            F.MinimumWidth = 6;
            F.Name = "F";
            F.ReadOnly = true;
            F.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 450);
            Controls.Add(dataGridViewFunction);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxStopValue);
            Controls.Add(textBoxStartValue);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Берестень Денис / ИБКСБ24-1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxStartValue;
        private TextBox textBoxStopValue;
        private Label label1;
        private Label label2;
        private Button buttonHelp;
        private Button buttonDone;
        private Label label3;
        private PictureBox pictureBox1;
        private DataGridView dataGridViewFunction;
        private DataGridViewTextBoxColumn X;
        private DataGridViewTextBoxColumn F;
    }
}
