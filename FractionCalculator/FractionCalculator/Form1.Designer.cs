namespace FractionCalculator
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка всех используемых ресурсов.
        /// </summary>
        /// <param name="disposing">True, если управляемые ресурсы должны быть удалены; иначе False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически сгенерированный конструктором форм Windows

        private void InitializeComponent()
        {
            this.textBoxNumerator1 = new System.Windows.Forms.TextBox();
            this.textBoxDenominator1 = new System.Windows.Forms.TextBox();
            this.textBoxNumerator2 = new System.Windows.Forms.TextBox();
            this.textBoxDenominator2 = new System.Windows.Forms.TextBox();
            this.comboBoxOperation = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNumerator1
            // 
            this.textBoxNumerator1.Location = new System.Drawing.Point(12, 12);
            this.textBoxNumerator1.Name = "textBoxNumerator1";
            this.textBoxNumerator1.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerator1.TabIndex = 0;
            this.textBoxNumerator1.Text = "Числитель 1";
            // 
            // textBoxDenominator1
            // 
            this.textBoxDenominator1.Location = new System.Drawing.Point(12, 38);
            this.textBoxDenominator1.Name = "textBoxDenominator1";
            this.textBoxDenominator1.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenominator1.TabIndex = 1;
            this.textBoxDenominator1.Text = "Знаменатель 1";
            // 
            // textBoxNumerator2
            // 
            this.textBoxNumerator2.Location = new System.Drawing.Point(12, 64);
            this.textBoxNumerator2.Name = "textBoxNumerator2";
            this.textBoxNumerator2.Size = new System.Drawing.Size(100, 20);
            this.textBoxNumerator2.TabIndex = 2;
            this.textBoxNumerator2.Text = "Числитель 2";
            // 
            // textBoxDenominator2
            // 
            this.textBoxDenominator2.Location = new System.Drawing.Point(12, 90);
            this.textBoxDenominator2.Name = "textBoxDenominator2";
            this.textBoxDenominator2.Size = new System.Drawing.Size(100, 20);
            this.textBoxDenominator2.TabIndex = 3;
            this.textBoxDenominator2.Text = "Знаменатель 2";
            // 
            // comboBoxOperation
            // 
            this.comboBoxOperation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperation.FormattingEnabled = true;
            this.comboBoxOperation.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.comboBoxOperation.Location = new System.Drawing.Point(135, 50);
            this.comboBoxOperation.Name = "comboBoxOperation";
            this.comboBoxOperation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperation.TabIndex = 4;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(275, 49);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(97, 23);
            this.buttonCalculate.TabIndex = 5;
            this.buttonCalculate.Text = "Вычислить";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(12, 123);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(55, 13);
            this.labelResult.TabIndex = 6;
            this.labelResult.Text = "Результат:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.comboBoxOperation);
            this.Controls.Add(this.textBoxDenominator2);
            this.Controls.Add(this.textBoxNumerator2);
            this.Controls.Add(this.textBoxDenominator1);
            this.Controls.Add(this.textBoxNumerator1);
            this.Name = "Form1";
            this.Text = "Калькулятор дробей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNumerator1;
        private System.Windows.Forms.TextBox textBoxDenominator1;
        private System.Windows.Forms.TextBox textBoxNumerator2;
        private System.Windows.Forms.TextBox textBoxDenominator2;
        private System.Windows.Forms.ComboBox comboBoxOperation;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelResult;
    }
}
