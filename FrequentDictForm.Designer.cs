namespace Project
{
    partial class FrequentDictForm
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
            dataGridFreqDict = new DataGridView();
            dataGridPrimaryFreqDict = new DataGridView();
            label3 = new Label();
            label2 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            formsPlot1 = new ScottPlot.FormsPlot();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridFreqDict).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPrimaryFreqDict).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridFreqDict
            // 
            dataGridFreqDict.AllowUserToAddRows = false;
            dataGridFreqDict.AllowUserToDeleteRows = false;
            dataGridFreqDict.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridFreqDict.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridFreqDict.ColumnHeadersHeight = 40;
            dataGridFreqDict.Location = new Point(26, 99);
            dataGridFreqDict.Margin = new Padding(6, 8, 6, 8);
            dataGridFreqDict.Name = "dataGridFreqDict";
            dataGridFreqDict.ReadOnly = true;
            dataGridFreqDict.RowHeadersWidth = 82;
            dataGridFreqDict.Size = new Size(378, 745);
            dataGridFreqDict.TabIndex = 0;
            dataGridFreqDict.CellContentClick += dataGridFreqDict_CellContentClick;
            // 
            // dataGridPrimaryFreqDict
            // 
            dataGridPrimaryFreqDict.AllowUserToAddRows = false;
            dataGridPrimaryFreqDict.AllowUserToDeleteRows = false;
            dataGridPrimaryFreqDict.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridPrimaryFreqDict.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPrimaryFreqDict.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPrimaryFreqDict.Location = new Point(432, 99);
            dataGridPrimaryFreqDict.Margin = new Padding(6, 8, 6, 8);
            dataGridPrimaryFreqDict.Name = "dataGridPrimaryFreqDict";
            dataGridPrimaryFreqDict.RowHeadersWidth = 82;
            dataGridPrimaryFreqDict.ScrollBars = ScrollBars.Vertical;
            dataGridPrimaryFreqDict.Size = new Size(391, 745);
            dataGridPrimaryFreqDict.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(416, 38);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(460, 31);
            label3.TabIndex = 4;
            label3.Text = "Частотный словарь русского языка";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(26, 38);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(378, 31);
            label2.TabIndex = 3;
            label2.Text = "Для зашифрованного текста";
            // 
            // formsPlot1
            // 
            formsPlot1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            formsPlot1.Location = new Point(1283, 99);
            formsPlot1.Margin = new Padding(7, 6, 7, 6);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(980, 745);
            formsPlot1.TabIndex = 5;
            formsPlot1.Load += formsPlot1_Load;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(848, 99);
            dataGridView1.Margin = new Padding(6, 8, 6, 8);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            dataGridView1.Size = new Size(361, 745);
            dataGridView1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(877, 38);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(289, 31);
            label1.TabIndex = 7;
            label1.Text = "Для исходного текста";
            // 
            // FrequentDictForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2329, 873);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(formsPlot1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridPrimaryFreqDict);
            Controls.Add(dataGridFreqDict);
            Margin = new Padding(6, 8, 6, 8);
            Name = "FrequentDictForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrequentDict";
            ((System.ComponentModel.ISupportInitialize)dataGridFreqDict).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridPrimaryFreqDict).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridFreqDict;
        private System.Windows.Forms.DataGridView dataGridPrimaryFreqDict;
        private System.Windows.Forms.Label label3;
        private Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ScottPlot.FormsPlot formsPlot1;
        private DataGridView dataGridView1;
        private Label label1;
    }
}