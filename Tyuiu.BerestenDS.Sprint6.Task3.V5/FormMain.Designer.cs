namespace Tyuiu.BerestenDS.Sprint6.Task3.V5
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
            label1 = new Label();
            textBoxData = new TextBox();
            label3 = new Label();
            buttonDone = new Button();
            buttonHelp = new Button();
            dataGridViewMatrix = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).BeginInit();
            SuspendLayout();
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(661, 60);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(201, 299);
            textBoxResult.TabIndex = 1;
            textBoxResult.TextChanged += buttonDone_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(661, 28);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 2;
            label1.Text = "Результат :";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(26, 25);
            textBoxData.Multiline = true;
            textBoxData.Name = "textBoxData";
            textBoxData.ReadOnly = true;
            textBoxData.Size = new Size(373, 334);
            textBoxData.TabIndex = 4;
            textBoxData.Text = resources.GetString("textBoxData.Text");
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 2);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Info :";
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(670, 401);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 29);
            buttonDone.TabIndex = 6;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(597, 401);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(49, 29);
            buttonHelp.TabIndex = 7;
            buttonHelp.Text = "Help";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // dataGridViewMatrix
            // 
            dataGridViewMatrix.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix.Location = new Point(405, 25);
            dataGridViewMatrix.Name = "dataGridViewMatrix";
            dataGridViewMatrix.RowHeadersVisible = false;
            dataGridViewMatrix.RowHeadersWidth = 51;
            dataGridViewMatrix.Size = new Size(221, 334);
            dataGridViewMatrix.TabIndex = 8;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 450);
            Controls.Add(dataGridViewMatrix);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(label3);
            Controls.Add(textBoxData);
            Controls.Add(label1);
            Controls.Add(textBoxResult);
            MaximizeBox = false;
            Name = "FormMain";
            Text = "Beresten Denis ";
            Load += FormMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxResult;
        private Label label1;
        private TextBox textBoxData;
        private Label label3;
        private Button buttonDone;
        private Button buttonHelp;
        private DataGridView dataGridViewMatrix;
        private DataGridView LoadDateGrid;
    }
}
