using System;
using System.Windows.Forms;

namespace FractionCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Получение числителей и знаменателей из текстовых полей
                int numerator1 = int.Parse(textBoxNumerator1.Text);
                int denominator1 = int.Parse(textBoxDenominator1.Text);
                int numerator2 = int.Parse(textBoxNumerator2.Text);
                int denominator2 = int.Parse(textBoxDenominator2.Text);

                // Проверка знаменателей
                if (denominator1 == 0 || denominator2 == 0)
                {
                    MessageBox.Show("Знаменатель не может быть равен нулю.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Получение выбранной операции
                string operation = comboBoxOperation.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(operation))
                {
                    MessageBox.Show("Выберите операцию.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Вычисление результата
                int resultNumerator = 0;
                int resultDenominator = 0;

                switch (operation)
                {
                    case "+":
                        resultNumerator = numerator1 * denominator2 + numerator2 * denominator1;
                        resultDenominator = denominator1 * denominator2;
                        break;
                    case "-":
                        resultNumerator = numerator1 * denominator2 - numerator2 * denominator1;
                        resultDenominator = denominator1 * denominator2;
                        break;
                    case "*":
                        resultNumerator = numerator1 * numerator2;
                        resultDenominator = denominator1 * denominator2;
                        break;
                    case "/":
                        if (numerator2 == 0)
                        {
                            MessageBox.Show("Деление на ноль невозможно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        resultNumerator = numerator1 * denominator2;
                        resultDenominator = denominator1 * numerator2;
                        break;
                    default:
                        MessageBox.Show("Недопустимая операция.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                }

                // Сокращение дроби
                int gcd = GCD(resultNumerator, resultDenominator);
                resultNumerator /= gcd;
                resultDenominator /= gcd;

                // Вывод результата
                if (Math.Abs(resultNumerator) >= Math.Abs(resultDenominator))
                {
                    int wholePart = resultNumerator / resultDenominator;
                    int remainder = resultNumerator % resultDenominator;

                    if (remainder == 0)
                    {
                        labelResult.Text = $"Результат: {wholePart}";
                    }
                    else
                    {
                        labelResult.Text = $"Результат: {wholePart} {Math.Abs(remainder)}/{Math.Abs(resultDenominator)}";
                    }
                }
                else
                {
                    labelResult.Text = $"Результат: {resultNumerator}/{resultDenominator}";
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числители и знаменатели.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }
    }
}
