using ScottPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Project
{
    public partial class FrequentDictForm : Form
    {
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

        private Dictionary<char, double> dictionary1;
        private Dictionary<char, double> dictionary2;
        public FrequentDictForm(Dictionary<char, double> dict1, Dictionary<char, double> dict2)
        {
            InitializeComponent();
            dictionary1 = dict1;
            dictionary2 = dict2;
            DisplayDictionaries(dictionary1, dictionary2);
        }

        private void DisplayDictionaries(Dictionary<char, double> dict1, Dictionary<char, double> dict2)
        {
            var i = 1;
            dataGridView1.DataSource =
                (from pair in dict1 orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();
            i = 1;
            dataGridFreqDict.DataSource =
                (from pair in dict2 orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

            i = 1;
            dataGridPrimaryFreqDict.DataSource =
                (from pair in _primaryDict orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

            dataGridFreqDict.Columns[0].HeaderText = "Поряд.номер";
            dataGridFreqDict.Columns[1].HeaderText = "Буква";
            dataGridFreqDict.Columns[2].HeaderText = "Частота появления в %";

            dataGridPrimaryFreqDict.Columns[0].HeaderText = "Поряд.номер";
            dataGridPrimaryFreqDict.Columns[1].HeaderText = "Буква";
            dataGridPrimaryFreqDict.Columns[2].HeaderText = "Частота появления в %";

            dataGridView1.Columns[0].HeaderText = "Поряд.номер";
            dataGridView1.Columns[1].HeaderText = "Буква";
            dataGridView1.Columns[2].HeaderText = "Частота появления в %";



            double[] words = new double[0];
            double[] lettersRus = new double[0];
            double[] encryptedWords = new double[0];
            double[] encryptLetter = new double[0];
            double[] decryptedWords = new double[0];
            double[] decryptedLetter = new double[0];

            words = _primaryDict.Values.ToArray();
            lettersRus = Enumerable.Range(0, _primaryDict.Count).Select(i => (double)i).ToArray();

            encryptedWords = dict1.Values.ToArray();
            encryptedWords = encryptedWords.OrderByDescending(i => i).ToArray();
            encryptLetter = Enumerable.Range(0, dict1.Count).Select(i => (double)i).ToArray();

            decryptedWords = dict2.Values.ToArray();
            decryptedWords = decryptedWords.OrderByDescending(i => i).ToArray();
            decryptedLetter = Enumerable.Range(0, dict2.Count).Select(i => (double)i).ToArray();

            formsPlot1.Plot.XLabel("Буквы");
            formsPlot1.Plot.YLabel("Частота");
            formsPlot1.Plot.Title("График", size: 30);

            formsPlot1.Plot.AxisAuto(horizontalMargin: 0, verticalMargin: 0);


            formsPlot1.Plot.AddScatter(lettersRus, words, color: Color.Green, label: "Русский язык", markerSize: 8);
            formsPlot1.Plot.AddScatter(encryptLetter, encryptedWords, color: Color.Blue, label: "Зашифрованый", markerSize: 8);
            formsPlot1.Plot.AddScatter(decryptedLetter, decryptedWords, color: Color.Red, label: "Расшифрованый", markerSize: 8);

            formsPlot1.Plot.Legend();


            formsPlot1.Plot.AxisAuto();
            formsPlot1.Render();
            formsPlot1.Refresh();
        }
        //public FrequentDictForm(Dictionary<char, double> dataSource1, Dictionary<char, double> dataSource2)
        //{
        //    InitializeComponent();
        //    var i = 1;
        //    var textInput = (from pair in dataSource orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

        //    dataGridView1.DataSource =
        //        (from pair in dataSource1 orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();
        //    i = 1;
        //    dataGridFreqDict.DataSource =
        //        (from pair in dataSource2 orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

        //    i = 1;
        //    dataGridPrimaryFreqDict.DataSource =
        //        (from pair in _primaryDict orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

        //    dataGridFreqDict.Columns[0].HeaderText = "Поряд.номер";
        //    dataGridFreqDict.Columns[1].HeaderText = "Буква";
        //    dataGridFreqDict.Columns[2].HeaderText = "Частота появления в %";

        //    dataGridPrimaryFreqDict.Columns[0].HeaderText = "Поряд.номер";
        //    dataGridPrimaryFreqDict.Columns[1].HeaderText = "Буква";
        //    dataGridPrimaryFreqDict.Columns[2].HeaderText = "Частота появления в %";

        //    dataGridView1.Columns[0].HeaderText = "Поряд.номер";
        //    dataGridView1.Columns[1].HeaderText = "Буква";
        //    dataGridView1.Columns[2].HeaderText = "Частота появления в %";



        //    double[] words = new double[0];
        //    double[] lettersRus = new double[0];
        //    double[] encryptedWords = new double[0];
        //    double[] encryptLetter = new double[0];
        //    double[] decryptedWords = new double[0];
        //    double[] decryptedLetter = new double[0];

        //    words = _primaryDict.Values.ToArray();
        //    lettersRus = Enumerable.Range(0, _primaryDict.Count).Select(i => (double)i).ToArray();

        //    encryptedWords = dataSource1.Values.ToArray();
        //    encryptLetter = Enumerable.Range(0, dataSource1.Count).Select(i => (double)i).ToArray();

        //    decryptedWords = dataSource2.Values.ToArray();
        //    decryptedLetter = Enumerable.Range(0, dataSource2.Count).Select(i => (double)i).ToArray();

        //    formsPlot1.Plot.XLabel("Буквы");
        //    formsPlot1.Plot.YLabel("Частота");
        //    formsPlot1.Plot.Title("График");

        //    formsPlot1.Plot.AddScatter(lettersRus, words, color: Color.Green);
        //    formsPlot1.Plot.AddScatter(encryptLetter, encryptedWords, color: Color.Blue);
        //    formsPlot1.Plot.AddScatter(decryptedLetter, decryptedWords, color: Color.Yellow);


        //    formsPlot1.Plot.AxisAuto();
        //    formsPlot1.Render();
        //    formsPlot1.Refresh();


        //}

        //public FrequentDictForm(Dictionary<char, double> dataSource)
        //{
        //    InitializeComponent();
        //    var i = 1;
        //    //var textInput = (from pair in dataSource orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

        //    dataGridView1.DataSource =
        //        (from pair in dataSource orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();
        //    i = 1;
        //    dataGridFreqDict.DataSource =
        //        (from pair in dataSource orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

        //    i = 1;
        //    dataGridPrimaryFreqDict.DataSource =
        //        (from pair in _primaryDict orderby pair.Value descending select new { indexColumn = i++, letterColumn = pair.Key, countColumn = pair.Value }).ToList();

        //    dataGridFreqDict.Columns[0].HeaderText = "Поряд.номер";
        //    dataGridFreqDict.Columns[1].HeaderText = "Буква";
        //    dataGridFreqDict.Columns[2].HeaderText = "Частота появления в %";

        //    dataGridPrimaryFreqDict.Columns[0].HeaderText = "Поряд.номер";
        //    dataGridPrimaryFreqDict.Columns[1].HeaderText = "Буква";
        //    dataGridPrimaryFreqDict.Columns[2].HeaderText = "Частота появления в %";

        //    dataGridView1.Columns[0].HeaderText = "Поряд.номер";
        //    dataGridView1.Columns[1].HeaderText = "Буква";
        //    dataGridView1.Columns[2].HeaderText = "Частота появления в %";



        //    double[] words = new double[0];
        //    double[] lettersRus = new double[0];
        //    double[] encryptedWords = new double[0];
        //    double[] encryptLetter = new double[0];
        //    double[] decryptedWords = new double[0];
        //    double[] decryptedLetter = new double[0];

        //    words = _primaryDict.Values.ToArray();
        //    lettersRus = Enumerable.Range(0, _primaryDict.Count).Select(i => (double)i).ToArray();

        //    encryptedWords = dataSource.Values.ToArray();
        //    encryptedWords = encryptedWords.OrderByDescending(i => i).ToArray();
        //    encryptLetter = Enumerable.Range(0, dataSource.Count).Select(i => (double)i).ToArray();


        //    decryptedWords = dataSource.Values.ToArray();
        //    decryptedLetter = Enumerable.Range(0, dataSource.Count).Select(i => (double)i).ToArray();

        //    formsPlot1.Plot.XLabel("Буквы");
        //    formsPlot1.Plot.YLabel("Частота");
        //    formsPlot1.Plot.Title("График");

        //    formsPlot1.Plot.AddScatter(lettersRus, words, color: Color.Green);
        //    formsPlot1.Plot.AddScatter(encryptLetter, encryptedWords, color: Color.Blue);
        //    formsPlot1.Plot.AddScatter(decryptedLetter, decryptedWords, color: Color.Red);


        //    formsPlot1.Plot.AxisAuto();
        //    formsPlot1.Render();
        //    formsPlot1.Refresh();


        //}

        private void dataGridFreqDict_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void formsPlot1_Load(object sender, EventArgs e)
        {

        }
    }
}
