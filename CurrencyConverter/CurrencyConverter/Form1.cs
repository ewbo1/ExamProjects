using System;
using System.Windows.Forms;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        // Курсы валют относительно RUB
        private readonly (string Name, double Rate)[] ExchangeRates =
        {
            ("RUB", 1),    // Рубль
            ("USD", 113),  // Доллар
            ("EUR", 119),  // Евро
            ("GBP", 143),  // Фунт
            ("KZT", 0.23), // Тенге
            ("CNY", 15)    // Юань
        };

        public Form1()
        {
            InitializeComponent();
            PopulateComboBoxes();
        }

        private void PopulateComboBoxes()
        {
            // Заполняем ComboBox списком валют
            foreach (var currency in ExchangeRates)
            {
                comboBoxFrom.Items.Add(currency.Name);
                comboBoxTo.Items.Add(currency.Name);
            }

            // Устанавливаем валюты по умолчанию
            comboBoxFrom.SelectedIndex = 0; // RUB
            comboBoxTo.SelectedIndex = 1;   // USD
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            try
            {
                // Получаем выбранные валюты
                int fromIndex = comboBoxFrom.SelectedIndex;
                int toIndex = comboBoxTo.SelectedIndex;

                if (fromIndex == -1 || toIndex == -1)
                {
                    MessageBox.Show("Пожалуйста, выберите валюты для конвертации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получаем сумму для конвертации
                if (!double.TryParse(textBoxAmount.Text, out double amount) || amount < 0)
                {
                    MessageBox.Show("Введите корректное положительное число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Выполняем конвертацию
                double result = amount * ExchangeRates[fromIndex].Rate / ExchangeRates[toIndex].Rate;

                // Выводим результат
                labelResult.Text = $"{amount} {ExchangeRates[fromIndex].Name} = {Math.Round(result, 4)} {ExchangeRates[toIndex].Name}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
