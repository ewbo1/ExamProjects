using System;
using System.Linq;
using System.Windows.Forms;

namespace MessageEncryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик нажатия кнопки "Зашифровать"
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            string inputText = textBoxInput.Text;
            int key = (int)numericUpDownKey.Value;

            if (!string.IsNullOrEmpty(inputText))
            {
                string encryptedText = CaesarShift(inputText, key);
                textBoxOutput.Text = encryptedText;
            }
            else
            {
                MessageBox.Show("Введите текст для шифрования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Функция шифрования методом Цезаря
        private string CaesarShift(string text, int key)
        {
            char[] result = new char[text.Length];

            string lowerAlphabet = "абвгдеёжзийклмнопрстуфхцчшщыэюя";
            string upperAlphabet = "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЫЭЮЯ";

            int lowerAlphabetLength = lowerAlphabet.Length;
            int upperAlphabetLength = upperAlphabet.Length;

            key = key % lowerAlphabetLength;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];

                if (lowerAlphabet.Contains(c))
                {
                    int index = lowerAlphabet.IndexOf(c);
                    index = (index + key + lowerAlphabetLength) % lowerAlphabetLength;
                    result[i] = lowerAlphabet[index];
                }
                else if (upperAlphabet.Contains(c))
                {
                    int index = upperAlphabet.IndexOf(c);
                    index = (index + key + upperAlphabetLength) % upperAlphabetLength;
                    result[i] = upperAlphabet[index];
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
    }
}
