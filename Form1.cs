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
            { 'о', 10.98},
            { 'е' , 8.45 },
            { 'а' , 8.01 },
            { 'и' , 7.37 },
            { 'н' , 6.70 },
            { 'т' , 6.32 },
            { 'с' , 5.47 },
            { 'р' , 4.75},
            { 'в' , 4.54 },
            { 'л' ,  4.34},
            { 'к' ,  3.49},
            { 'м' ,  3.21},
            { 'д' ,  2.98},
            { 'п' ,  2.81},
            { 'у' ,  2.62},
            { 'я' ,  2.01},
            { 'ы' ,  1.90},
            { 'ь' ,  1.74},
            { 'г' ,  1.69},
            { 'з' ,  1.64},
            { 'б' ,  1.59},
            { 'ч' ,  1.45},
            { 'й' ,  1.21},
            { 'х' ,  0.97},
            { 'ж' ,  0.94},
            { 'ш' ,  0.72},
            { 'ю' ,  0.64},
            { 'ц' ,  0.49},
            { 'щ' ,  0.36},
            { 'э' ,  0.33},
            { 'ф' ,  0.27},
            { 'ъ' ,  0.04},
            { 'ё' ,  0.02}
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

                MessageBox.Show($"Ключ шифрования : {caesarKey}", "Success", MessageBoxButtons.OK);

                outputTextBox.Text = new Caesar(caesarKey * (-1)).Encrypt(inputTextBox.Text);
                //outputTextBox.Text = new Caesar((int)caesarKey.Value).Decrypt(inputTextBox.Text = outputTextBox.Text);

                //MessageBox.Show($"Ключ шифрования : {caesarKey}", "Success", MessageBoxButtons.OK);
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

                MessageBox.Show($"Файл {explorer.FileName}  успешно сохранен!", "Success", MessageBoxButtons.OK);

                outputTextBox.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dictionary<char, double> dict1 = FrequentCounter.countAppearencesOfLetter(inputTextBox.Text);

            // Считываем текст из второго TextBox и создаем вторую Dictionary
            Dictionary<char, double> dict2 = FrequentCounter.countAppearencesOfLetter(outputTextBox.Text);

            // Создаем экземпляр FrequentDictForm, передавая оба Dictionary
            FrequentDictForm form = new FrequentDictForm(dict1, dict2);

            // Отображаем форму
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