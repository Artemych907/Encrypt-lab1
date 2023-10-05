namespace Encrypt
{
    partial class Form1
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
            btnEncode = new Button();
            radioCaesar = new RadioButton();
            inputTextBox = new TextBox();
            outputTextBox = new TextBox();
            button2 = new Button();
            label1 = new Label();
            btnOpenFile = new Button();
            radioTritemius = new RadioButton();
            radioMonoCode = new RadioButton();
            saveBtn = new Button();
            button3 = new Button();
            caesarKey = new NumericUpDown();
            tritemKey = new TextBox();
            ((System.ComponentModel.ISupportInitialize)caesarKey).BeginInit();
            SuspendLayout();
            // 
            // btnEncode
            // 
            btnEncode.Location = new Point(22, 713);
            btnEncode.Margin = new Padding(4, 2, 4, 2);
            btnEncode.Name = "btnEncode";
            btnEncode.Size = new Size(266, 111);
            btnEncode.TabIndex = 0;
            btnEncode.Text = "Зашифровать";
            btnEncode.UseVisualStyleBackColor = true;
            btnEncode.Click += btnEncode_Click;
            // 
            // radioCaesar
            // 
            radioCaesar.AutoSize = true;
            radioCaesar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioCaesar.Location = new Point(1047, 629);
            radioCaesar.Margin = new Padding(4, 2, 4, 2);
            radioCaesar.Name = "radioCaesar";
            radioCaesar.Size = new Size(256, 49);
            radioCaesar.TabIndex = 1;
            radioCaesar.TabStop = true;
            radioCaesar.Text = "Шифр Цезаря";
            radioCaesar.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            inputTextBox.Location = new Point(11, 23);
            inputTextBox.Margin = new Padding(4, 2, 4, 2);
            inputTextBox.Multiline = true;
            inputTextBox.Name = "inputTextBox";
            inputTextBox.ScrollBars = ScrollBars.Vertical;
            inputTextBox.Size = new Size(862, 527);
            inputTextBox.TabIndex = 2;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(930, 23);
            outputTextBox.Margin = new Padding(4, 2, 4, 2);
            outputTextBox.Multiline = true;
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = ScrollBars.Vertical;
            outputTextBox.Size = new Size(862, 527);
            outputTextBox.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(293, 713);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(254, 111);
            button2.TabIndex = 4;
            button2.Text = "Расшифровать";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(1047, 582);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(339, 45);
            label1.TabIndex = 5;
            label1.Text = "Методы шифрования";
            // 
            // btnOpenFile
            // 
            btnOpenFile.Location = new Point(22, 585);
            btnOpenFile.Margin = new Padding(4, 2, 4, 2);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(266, 102);
            btnOpenFile.TabIndex = 7;
            btnOpenFile.Text = "Открыть файл";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += btnOpenFile_Click;
            // 
            // radioTritemius
            // 
            radioTritemius.AutoSize = true;
            radioTritemius.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioTritemius.Location = new Point(1047, 685);
            radioTritemius.Margin = new Padding(4, 2, 4, 2);
            radioTritemius.Name = "radioTritemius";
            radioTritemius.Size = new Size(374, 49);
            radioTritemius.TabIndex = 8;
            radioTritemius.TabStop = true;
            radioTritemius.Text = "Алгоритм Тритемиуса";
            radioTritemius.UseVisualStyleBackColor = true;
            // 
            // radioMonoCode
            // 
            radioMonoCode.AutoSize = true;
            radioMonoCode.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            radioMonoCode.Location = new Point(1047, 748);
            radioMonoCode.Margin = new Padding(4, 2, 4, 2);
            radioMonoCode.Name = "radioMonoCode";
            radioMonoCode.Size = new Size(662, 49);
            radioMonoCode.TabIndex = 9;
            radioMonoCode.TabStop = true;
            radioMonoCode.Text = "Алгоритм моно алфавитной подстановки";
            radioMonoCode.UseVisualStyleBackColor = true;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(293, 585);
            saveBtn.Margin = new Padding(4, 2, 4, 2);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(254, 102);
            saveBtn.TabIndex = 10;
            saveBtn.Text = "Сохранить файл";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(628, 655);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(266, 102);
            button3.TabIndex = 11;
            button3.Text = "Частотный словарь";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // caesarKey
            // 
            caesarKey.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            caesarKey.Location = new Point(1429, 629);
            caesarKey.Name = "caesarKey";
            caesarKey.Size = new Size(311, 50);
            caesarKey.TabIndex = 12;
            caesarKey.ValueChanged += caesarKey_ValueChanged;
            // 
            // tritemKey
            // 
            tritemKey.Location = new Point(1428, 695);
            tritemKey.Name = "tritemKey";
            tritemKey.Size = new Size(312, 39);
            tritemKey.TabIndex = 13;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1790, 881);
            Controls.Add(tritemKey);
            Controls.Add(caesarKey);
            Controls.Add(button3);
            Controls.Add(saveBtn);
            Controls.Add(radioMonoCode);
            Controls.Add(radioTritemius);
            Controls.Add(btnOpenFile);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(outputTextBox);
            Controls.Add(inputTextBox);
            Controls.Add(radioCaesar);
            Controls.Add(btnEncode);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)caesarKey).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEncode;
        private RadioButton radioCaesar;
        private TextBox inputTextBox;
        private TextBox outputTextBox;
        private Button button2;
        private Label label1;
        private Button btnOpenFile;
        private RadioButton radioTritemius;
        private RadioButton radioMonoCode;
        private Button saveBtn;
        private Button button3;
        private NumericUpDown caesarKey;
        private TextBox tritemKey;
    }
}