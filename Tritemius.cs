using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Encrypt
{
    public class Tritemius : ICipher
    {

        private readonly string _key;
        const string ALPHABET = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";

        //public Tritemius(string key) => _key = string.IsNullOrEmpty(key) ? "ключ" : key;
        public Tritemius(string key)
        {
            if (key == string.Empty) _key = "ключ";
            else _key = key;
        }


        private string Encode(string text, Func<int, int, int> operation)
        {
            var sb = new StringBuilder();
            var fullAlphabet = ALPHABET.ToLower();
            for (int i = 0; i < text.Length; i++)
            {
                var ch = text[i];
                var index = fullAlphabet.IndexOf(ch);
                var kI = fullAlphabet.IndexOf(_key[i % _key.Length]);
                sb.Append(index < 0 ? ch : fullAlphabet[operation(index, kI)]);
            }

            return sb.ToString();
        }

        public string Encrypt(string plainText) => Encode(plainText, (index, keyIndex) =>
        ((index + keyIndex) + ALPHABET.Length) % ALPHABET.Length);

        public string Decrypt(string encryptedMessage) => Encode(encryptedMessage, (index, keyIndex) =>
        ((index - keyIndex) + ALPHABET.Length) % ALPHABET.Length);

    }
}
