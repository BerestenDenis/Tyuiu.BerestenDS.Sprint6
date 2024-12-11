namespace Tyuiu.BerestenDS.Sprint6.Task7.V18
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
            buttonDone = new Button();
            buttonLoad = new Button();
            buttonHelp = new Button();
            panel1 = new Panel();
            buttonSave = new Button();
            panel2 = new Panel();
            dataGridViewMatrix = new DataGridView();
            panel3 = new Panel();
            dataGridViewResult = new DataGridView();
            panel4 = new Panel();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(9, 7);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(57, 51);
            buttonDone.TabIndex = 0;
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttoneDone_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(87, 7);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(59, 51);
            buttonLoad.TabIndex = 1;
            buttonLoad.Text = "File";
            buttonLoad.UseVisualStyleBackColor = true;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(968, 7);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(67, 51);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonLoad);
            panel1.Controls.Add(buttonDone);
            panel1.Location = new Point(3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1052, 66);
            panel1.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(164, 7);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(80, 51);
            buttonSave.TabIndex = 3;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridViewMatrix);
            panel2.Location = new Point(8, 162);
            panel2.Name = "panel2";
            panel2.Size = new Size(502, 342);
            panel2.TabIndex = 4;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(5, 5);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(496, 336);
            dataGridViewMatrix.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(dataGridViewResult);
            panel3.Location = new Point(516, 162);
            panel3.Name = "panel3";
            panel3.Size = new Size(535, 347);
            panel3.TabIndex = 5;
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(3, 8);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.RowHeadersWidth = 51;
            dataGridViewResult.Size = new Size(528, 337);
            dataGridViewResult.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(textBox1);
            panel4.Location = new Point(8, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(1039, 57);
            panel4.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1, 0);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1038, 79);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 523);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonLoad;
        private Button buttonHelp;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private TextBox textBox1;
        private Button buttonSave;
        private DataGridView dataGridViewMatrix;
        private DataGridView dataGridViewResult;
    }
}
