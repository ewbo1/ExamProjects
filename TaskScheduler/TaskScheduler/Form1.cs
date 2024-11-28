using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace TaskScheduler
{
    public partial class Form1 : Form
    {
        // Класс задачи
        public class Task
        {
            public string Type { get; set; }
            public string Description { get; set; }
            public DateTime Date { get; set; }

            public override string ToString()
            {
                return $"[{Date.ToString("dd.MM.yyyy")}] ({Type}) {Description}";
            }
        }

        private readonly List<Task> tasks = new List<Task>(); // Список задач

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            // Проверка ввода
            if (string.IsNullOrWhiteSpace(textBoxType.Text) ||
                string.IsNullOrWhiteSpace(textBoxDescription.Text) ||
                !DateTime.TryParseExact(textBoxDate.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date))
            {
                MessageBox.Show("Пожалуйста, заполните все поля корректно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Добавление задачи
            tasks.Add(new Task
            {
                Type = textBoxType.Text,
                Description = textBoxDescription.Text,
                Date = date
            });

            MessageBox.Show("Задача успешно добавлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshTaskList();
            ClearInputFields();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Удаление выбранной задачи
            if (listBoxTasks.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите задачу для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tasks.RemoveAt(listBoxTasks.SelectedIndex);
            MessageBox.Show("Задача успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshTaskList();
        }

        private void RefreshTaskList()
        {
            listBoxTasks.Items.Clear();
            foreach (var task in tasks)
            {
                listBoxTasks.Items.Add(task.ToString());
            }
        }

        private void ClearInputFields()
        {
            textBoxType.Clear();
            textBoxDescription.Clear();
            textBoxDate.Clear();
        }
    }
}
