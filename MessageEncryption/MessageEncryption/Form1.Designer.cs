namespace MessageEncryption
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
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.numericUpDownKey = new System.Windows.Forms.NumericUpDown();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 29);
            this.textBoxInput.Multiline = true;
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(360, 80);
            this.textBoxInput.TabIndex = 0;
            // 
            // numericUpDownKey
            // 
            this.numericUpDownKey.Location = new System.Drawing.Point(12, 135);
            this.numericUpDownKey.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownKey.Name = "numericUpDownKey";
            this.numericUpDownKey.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownKey.TabIndex = 1;
            this.numericUpDownKey.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(148, 132);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(224, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифровать";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(12, 190);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ReadOnly = true;
            this.textBoxOutput.Size = new System.Drawing.Size(360, 80);
            this.textBoxOutput.TabIndex = 3;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(12, 13);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(113, 13);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Введите текст:";
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(12, 119);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(100, 13);
            this.labelKey.TabIndex = 5;
            this.labelKey.Text = "Шаг шифрования:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(12, 174);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(119, 13);
            this.labelOutput.TabIndex = 6;
            this.labelOutput.Text = "Зашифрованный текст:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.numericUpDownKey);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Шифратор сообщений";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKey)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.NumericUpDown numericUpDownKey;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelOutput;
    }
}
