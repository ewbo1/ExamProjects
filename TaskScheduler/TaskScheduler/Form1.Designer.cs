using System.Windows.Forms;

namespace TaskScheduler
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox textBoxType;
        private TextBox textBoxDescription;
        private TextBox textBoxDate;
        private Button buttonAdd;
        private Button buttonDelete;
        private ListBox listBoxTasks;
        private Label labelType;
        private Label labelDescription;
        private Label labelDate;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxType = new TextBox();
            this.textBoxDescription = new TextBox();
            this.textBoxDate = new TextBox();
            this.buttonAdd = new Button();
            this.buttonDelete = new Button();
            this.listBoxTasks = new ListBox();
            this.labelType = new Label();
            this.labelDescription = new Label();
            this.labelDate = new Label();
            this.SuspendLayout();

            // textBoxType
            this.textBoxType.Location = new System.Drawing.Point(20, 30);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(250, 22);
            this.textBoxType.TabIndex = 0;

            // textBoxDescription
            this.textBoxDescription.Location = new System.Drawing.Point(20, 80);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(250, 22);
            this.textBoxDescription.TabIndex = 1;

            // textBoxDate
            this.textBoxDate.Location = new System.Drawing.Point(20, 130);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(250, 22);
            this.textBoxDate.TabIndex = 2;

            // buttonAdd
            this.buttonAdd.Location = new System.Drawing.Point(20, 170);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 30);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);

            // buttonDelete
            this.buttonDelete.Location = new System.Drawing.Point(150, 170);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(120, 30);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);

            // listBoxTasks
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 16;
            this.listBoxTasks.Location = new System.Drawing.Point(20, 220);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(250, 100);
            this.listBoxTasks.TabIndex = 5;

            // labelType
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(20, 10);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(34, 16);
            this.labelType.TabIndex = 6;
            this.labelType.Text = "Тип:";

            // labelDescription
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(20, 60);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(75, 16);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "Описание:";

            // labelDate
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(20, 110);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(41, 16);
            this.labelDate.TabIndex = 8;
            this.labelDate.Text = "Дата:";

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 350);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxType);
            this.Name = "Form1";
            this.Text = "Планировщик задач";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
