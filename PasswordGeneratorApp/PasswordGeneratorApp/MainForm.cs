using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtLength.Text, out int length) && length >= 8)
            {
                string password = GeneratePassword(length);
                txtPassword.Text = password;
            }
            else
            {
                MessageBox.Show("Некорректная длина. Пароль должен быть не менее 8 символов.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private string GeneratePassword(int length)
        {
            const string allChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!*$%";
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            // Гарантированное добавление обязательных символов
            password.Append("abcdefghijklmnopqrstuvwxyz"[random.Next(26)]);
            password.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[random.Next(26)]);
            password.Append("0123456789"[random.Next(10)]);
            password.Append("!*$%"[random.Next(4)]);

            // Заполнение оставшихся символов
            for (int i = password.Length; i < length; i++)
            {
                password.Append(allChars[random.Next(allChars.Length)]);
            }

            // Перемешивание символов
            return new string(password.ToString().ToCharArray()
                .OrderBy(_ => random.Next()).ToArray());
        }
    }
}
