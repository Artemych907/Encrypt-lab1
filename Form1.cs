using Project;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Encrypt
{
    public partial class Form1 : Form
    {
        Dictionary<char, double> _inputDict = new Dictionary<char, double>();
        Dictionary<char, double> _primaryDict = new Dictionary<char, double>
        {
            { '�', 10.98},
            { '�' , 8.45 },
            { '�' , 8.01 },
            { '�' , 7.37 },
            { '�' , 6.70 },
            { '�' , 6.32 },
            { '�' , 5.47 },
            { '�' , 4.75},
            { '�' , 4.54 },
            { '�' ,  4.34},
            { '�' ,  3.49},
            { '�' ,  3.21},
            { '�' ,  2.98},
            { '�' ,  2.81},
            { '�' ,  2.62},
            { '�' ,  2.01},
            { '�' ,  1.90},
            { '�' ,  1.74},
            { '�' ,  1.69},
            { '�' ,  1.64},
            { '�' ,  1.59},
            { '�' ,  1.45},
            { '�' ,  1.21},
            { '�' ,  0.97},
            { '�' ,  0.94},
            { '�' ,  0.72},
            { '�' ,  0.64},
            { '�' ,  0.49},
            { '�' ,  0.36},
            { '�' ,  0.33},
            { '�' ,  0.27},
            { '�' ,  0.04},
            { '�' ,  0.02}
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            if (radioCaesar.Checked)
            {
                outputTextBox.Text = new Caesar((int)caesarKey.Value).Encrypt(inputTextBox.Text);
            }
            if (radioTritemius.Checked)
            {
                outputTextBox.Text = new Tritemius(tritemKey.Text).Encrypt(inputTextBox.Text);
            }
            if (radioMonoCode.Checked)
            {
                outputTextBox.Text = new MonoEncoder().Encrypt(inputTextBox.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            inputTextBox.Text = outputTextBox.Text;
            if (radioCaesar.Checked)
            {
                Dictionary<int, double> sumArray = new Dictionary<int, double>();

                for (int i = 1; i < _primaryDict.Keys.Count; i++)
                {
                    var decryptText = new Caesar(-i).Encrypt(inputTextBox.Text);
                    double value;
                    sumArray[i] = decryptText.ToLower().Sum(ch => _primaryDict.TryGetValue(ch, out value) ? value : 0);
                }

                var caesarKey = sumArray.OrderByDescending(x => x.Value).First().Key;

                MessageBox.Show($"���� ���������� : {caesarKey}", "Success", MessageBoxButtons.OK);

                outputTextBox.Text = new Caesar(caesarKey * (-1)).Encrypt(inputTextBox.Text);
                //outputTextBox.Text = new Caesar((int)caesarKey.Value).Decrypt(inputTextBox.Text = outputTextBox.Text);

                //MessageBox.Show($"���� ���������� : {caesarKey}", "Success", MessageBoxButtons.OK);
            }
            if (radioTritemius.Checked)
            {
                outputTextBox.Text = new Tritemius(tritemKey.Text).Decrypt(inputTextBox.Text);
            }
            if (radioMonoCode.Checked)
            {
                outputTextBox.Text = new MonoEncoder().Decrypt(inputTextBox.Text);
            }
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                var textFromFile = File.ReadAllText(explorer.FileName, Encoding.Default);

                inputTextBox.Text = textFromFile;
            }
        }

        private void Key_TextChanged(object sender, EventArgs e, int inputKey)
        {
            //int inputKey;
            //if (int.TryParse(sender.ToString().Substring(sender.ToString().LastIndexOf(" ")), out inputKey))
            //{
            //    if (inputKey > 0 && inputKey < 10)
            //    {
            //        caesarKeyTextBox.Text = inputKey.ToString();
            //        return;
            //    }

            //}
            //caesarKeyTextBox.Text = string.Empty;
        }

        
        private void saveBtn_Click(object sender, EventArgs e)
        {
            var explorer = new OpenFileDialog();

            if (explorer.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(explorer.FileName, outputTextBox.Text);

                MessageBox.Show($"���� {explorer.FileName}  ������� ��������!", "Success", MessageBoxButtons.OK);

                outputTextBox.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<char, double> dict1 = FrequentCounter.countAppearencesOfLetter(inputTextBox.Text);

            // ��������� ����� �� ������� TextBox � ������� ������ Dictionary
            Dictionary<char, double> dict2 = FrequentCounter.countAppearencesOfLetter(outputTextBox.Text);

            // ������� ��������� FrequentDictForm, ��������� ��� Dictionary
            FrequentDictForm form = new FrequentDictForm(dict1, dict2);

            // ���������� �����
            form.Show();
            //var (dict1, dict2) = FrequentCounter.CountAppearancesOfLetters(inputTextBox.Text, outputTextBox.Text);
            //new FrequentDictForm(FrequentCounter.countAppearencesOfLetter(inputTextBox.Text));
            //new FrequentDictForm(FrequentCounter.countAppearencesOfLetter(outputTextBox.Text)).Show();
            //new FrequentDictForm(FrequentCounter.countAppearencesOfLetter(inputTextBox.Text,outputTextBox.Text)).Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void caesarKey_ValueChanged(object sender, EventArgs e)
        {
            int inputKey;
            if (int.TryParse(sender.ToString().Substring(sender.ToString().LastIndexOf(" ")), out inputKey))
            {
                if (inputKey > 0 && inputKey < 10)
                {
                    caesarKey.Text = inputKey.ToString();
                    return;
                }

            }
            caesarKey.Text = string.Empty;
        }

        //private void tritemKeyTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    string inputText = tritemKeyTextBox.Text;
        //    inputText = string.Empty;
        //}
    }
}