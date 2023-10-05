using Encrypt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class MonoEncoder : ICipher
    {
        const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯабвгдеёжзийклмнопрстуфхцчшщъыьэюя";
        private const string REVERSE_ALPHABET = "ЯЮЭЬЫЪЩШЧЦХФУТСРПОНМЛКЙИЗЖЁЕДГВБАяюэьыъщшчцхфутсрпонмлкйизжёедгвба";
        private static Dictionary<char, char> cryptAlphabet;

        public string Encrypt(string plainText)
        {
            string outputText = string.Empty;

            foreach (var ch in plainText)
            {
                var index = ALPHABET.IndexOf(ch);
                outputText += index < 0 ? ch : REVERSE_ALPHABET.ToCharArray()[index];
            }

            return outputText;
        }

        public string Decrypt(string encryptedMessage)
        {
            string outputText = string.Empty;

            foreach (var ch in encryptedMessage)
            {
                var index = REVERSE_ALPHABET.IndexOf(ch);
                outputText += index < 0 ? ch : ALPHABET.ToCharArray()[index];
            }

            return outputText;
        }
    }
}
