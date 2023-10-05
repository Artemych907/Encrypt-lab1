using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public static class FrequentCounter
    {
        const string ALPHABET = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        public static Dictionary<char, double> countAppearencesOfLetter(string text)
        {
            var freqDict = new Dictionary<char, double>(ALPHABET.Length);
            var lowerText = text.ToLower();

            foreach (var ch in ALPHABET)
            {
                freqDict[ch] = 0;
            }

            foreach (var letter in lowerText)
            {
                if (ALPHABET.Contains(letter.ToString()))
                {
                    var counter = lowerText.Count(ch => ch == letter);
                    freqDict[letter] = Math.Round(((double)counter / lowerText.Length) * 100, 2);
                }

            }

            return freqDict;
        }
        //public static (Dictionary<char, double> text1Dict, Dictionary<char, double> text2Dict)
        //CountAppearancesOfLetters(string text1, string text2)
        //{
        //    var freqDict1 = CountAppearancesOfLetter(text1);
        //    var freqDict2 = CountAppearancesOfLetter(text2);

        //    return (freqDict1, freqDict2);
        //}
        //private static Dictionary<char, double> CountAppearancesOfLetter(string text)
        //{
        //    var freqDict = new Dictionary<char, double>(ALPHABET.Length);
        //    var lowerText = text.ToLower();

        //    foreach (var ch in ALPHABET)
        //    {
        //        freqDict[ch] = 0;
        //    }

        //    foreach (var letter in lowerText)
        //    {
        //        if (ALPHABET.Contains(letter.ToString()))
        //        {
        //            var counter = lowerText.Count(ch => ch == letter);
        //            freqDict[letter] = Math.Round(((double)counter / lowerText.Length) * 100, 2);
        //        }
        //    }

        //    return freqDict;
        //}
    }
    
    //public static Dictionary<char, double> countAppearencesOfLetter(string input, string output)
    //{
    //    var freqDict = new Dictionary<char, double>(ALPHABET.Length);
    //    var lowerText = input.ToLower();
    //    lowerText = output.ToLower();

    //    foreach (var ch in ALPHABET)
    //    {
    //        freqDict[ch] = 0;
    //    }

    //    foreach (var letter in lowerText)
    //    {
    //        if (ALPHABET.Contains(letter.ToString()))
    //        {
    //            var counter = lowerText.Count(ch => ch == letter);
    //            freqDict[letter] = Math.Round(((double)counter / lowerText.Length) * 100, 2);
    //        }

    //    }

    //    return freqDict;
    //}
}

