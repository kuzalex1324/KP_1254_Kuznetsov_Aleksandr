namespace DataAccounting
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameLabel = new System.Windows.Forms.Label();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CBDigitsAmount = new System.Windows.Forms.CheckBox();
            this.CBLettersAmount = new System.Windows.Forms.CheckBox();
            this.BTNGeneratePassword = new System.Windows.Forms.Button();
            this.NUDNumberOfDigits = new System.Windows.Forms.NumericUpDown();
            this.NUDNumberOfLetters = new System.Windows.Forms.NumericUpDown();
            this.CBSpecialSymbols = new System.Windows.Forms.CheckBox();
            this.CBCapitalLetters = new System.Windows.Forms.CheckBox();
            this.NUDPasswordLenght = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.BTNSaveAnswer = new System.Windows.Forms.Button();
            this.BTNGeneratorLogina = new System.Windows.Forms.Button();
            this.DTPBirthDate = new System.Windows.Forms.DateTimePicker();
            this.LBAccounts = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfLetters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPasswordLenght)).BeginInit();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(53, 20);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(40, 21);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Имя";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BirthDateLabel.Location = new System.Drawing.Point(452, 20);
            this.BirthDateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(122, 21);
            this.BirthDateLabel.TabIndex = 4;
            this.BirthDateLabel.Text = "Дата рождения";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastNameLabel.Location = new System.Drawing.Point(226, 20);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 21);
            this.LastNameLabel.TabIndex = 1;
            this.LastNameLabel.Text = "Фамилия";
            // 
            // TBName
            // 
            this.TBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBName.Location = new System.Drawing.Point(23, 43);
            this.TBName.Margin = new System.Windows.Forms.Padding(2);
            this.TBName.Multiline = true;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(98, 23);
            this.TBName.TabIndex = 2;
            // 
            // TBLastName
            // 
            this.TBLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLastName.Location = new System.Drawing.Point(210, 43);
            this.TBLastName.Margin = new System.Windows.Forms.Padding(2);
            this.TBLastName.Multiline = true;
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(98, 23);
            this.TBLastName.TabIndex = 3;
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login.Location = new System.Drawing.Point(46, 89);
            this.Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(55, 21);
            this.Login.TabIndex = 6;
            this.Login.Text = "Логин";
            // 
            // TBLogin
            // 
            this.TBLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TBLogin.Location = new System.Drawing.Point(23, 111);
            this.TBLogin.Margin = new System.Windows.Forms.Padding(2);
            this.TBLogin.Multiline = true;
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(132, 23);
            this.TBLogin.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CBDigitsAmount);
            this.groupBox1.Controls.Add(this.CBLettersAmount);
            this.groupBox1.Controls.Add(this.BTNGeneratePassword);
            this.groupBox1.Controls.Add(this.NUDNumberOfDigits);
            this.groupBox1.Controls.Add(this.NUDNumberOfLetters);
            this.groupBox1.Controls.Add(this.CBSpecialSymbols);
            this.groupBox1.Controls.Add(this.CBCapitalLetters);
            this.groupBox1.Controls.Add(this.NUDPasswordLenght);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TBPassword);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(23, 164);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(284, 223);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пароль";
            // 
            // CBDigitsAmount
            // 
            this.CBDigitsAmount.AutoSize = true;
            this.CBDigitsAmount.Checked = true;
            this.CBDigitsAmount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBDigitsAmount.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBDigitsAmount.Location = new System.Drawing.Point(8, 153);
            this.CBDigitsAmount.Margin = new System.Windows.Forms.Padding(2);
            this.CBDigitsAmount.Name = "CBDigitsAmount";
            this.CBDigitsAmount.Size = new System.Drawing.Size(149, 23);
            this.CBDigitsAmount.TabIndex = 20;
            this.CBDigitsAmount.Text = "Количество цифр";
            this.CBDigitsAmount.UseVisualStyleBackColor = true;
            // 
            // CBLettersAmount
            // 
            this.CBLettersAmount.AutoSize = true;
            this.CBLettersAmount.Checked = true;
            this.CBLettersAmount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CBLettersAmount.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBLettersAmount.Location = new System.Drawing.Point(8, 124);
            this.CBLettersAmount.Margin = new System.Windows.Forms.Padding(2);
            this.CBLettersAmount.Name = "CBLettersAmount";
            this.CBLettersAmount.Size = new System.Drawing.Size(142, 23);
            this.CBLettersAmount.TabIndex = 19;
            this.CBLettersAmount.Text = "Количество букв";
            this.CBLettersAmount.UseVisualStyleBackColor = true;
            // 
            // BTNGeneratePassword
            // 
            this.BTNGeneratePassword.Location = new System.Drawing.Point(75, 188);
            this.BTNGeneratePassword.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGeneratePassword.Name = "BTNGeneratePassword";
            this.BTNGeneratePassword.Size = new System.Drawing.Size(110, 23);
            this.BTNGeneratePassword.TabIndex = 16;
            this.BTNGeneratePassword.Text = "Сгенерировать";
            this.BTNGeneratePassword.UseVisualStyleBackColor = true;
            this.BTNGeneratePassword.Click += new System.EventHandler(this.BTNGeneratePassword_Click);
            // 
            // NUDNumberOfDigits
            // 
            this.NUDNumberOfDigits.Location = new System.Drawing.Point(173, 152);
            this.NUDNumberOfDigits.Margin = new System.Windows.Forms.Padding(2);
            this.NUDNumberOfDigits.Name = "NUDNumberOfDigits";
            this.NUDNumberOfDigits.Size = new System.Drawing.Size(90, 24);
            this.NUDNumberOfDigits.TabIndex = 15;
            this.NUDNumberOfDigits.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // NUDNumberOfLetters
            // 
            this.NUDNumberOfLetters.Location = new System.Drawing.Point(173, 124);
            this.NUDNumberOfLetters.Margin = new System.Windows.Forms.Padding(2);
            this.NUDNumberOfLetters.Name = "NUDNumberOfLetters";
            this.NUDNumberOfLetters.Size = new System.Drawing.Size(90, 24);
            this.NUDNumberOfLetters.TabIndex = 14;
            this.NUDNumberOfLetters.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CBSpecialSymbols
            // 
            this.CBSpecialSymbols.AutoSize = true;
            this.CBSpecialSymbols.Location = new System.Drawing.Point(145, 96);
            this.CBSpecialSymbols.Margin = new System.Windows.Forms.Padding(2);
            this.CBSpecialSymbols.Name = "CBSpecialSymbols";
            this.CBSpecialSymbols.Size = new System.Drawing.Size(135, 20);
            this.CBSpecialSymbols.TabIndex = 11;
            this.CBSpecialSymbols.Text = "Без спецсимволов";
            this.CBSpecialSymbols.UseVisualStyleBackColor = true;
            // 
            // CBCapitalLetters
            // 
            this.CBCapitalLetters.AutoSize = true;
            this.CBCapitalLetters.Location = new System.Drawing.Point(145, 72);
            this.CBCapitalLetters.Margin = new System.Windows.Forms.Padding(2);
            this.CBCapitalLetters.Name = "CBCapitalLetters";
            this.CBCapitalLetters.Size = new System.Drawing.Size(112, 20);
            this.CBCapitalLetters.TabIndex = 9;
            this.CBCapitalLetters.Text = "Без заглавных";
            this.CBCapitalLetters.UseVisualStyleBackColor = true;
            // 
            // NUDPasswordLenght
            // 
            this.NUDPasswordLenght.Location = new System.Drawing.Point(8, 72);
            this.NUDPasswordLenght.Margin = new System.Windows.Forms.Padding(2);
            this.NUDPasswordLenght.Name = "NUDPasswordLenght";
            this.NUDPasswordLenght.Size = new System.Drawing.Size(90, 24);
            this.NUDPasswordLenght.TabIndex = 10;
            this.NUDPasswordLenght.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Длина пароля";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(8, 22);
            this.TBPassword.Margin = new System.Windows.Forms.Padding(2);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(166, 24);
            this.TBPassword.TabIndex = 0;
            // 
            // BTNSaveAnswer
            // 
            this.BTNSaveAnswer.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNSaveAnswer.Location = new System.Drawing.Point(23, 408);
            this.BTNSaveAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.BTNSaveAnswer.Name = "BTNSaveAnswer";
            this.BTNSaveAnswer.Size = new System.Drawing.Size(698, 28);
            this.BTNSaveAnswer.TabIndex = 17;
            this.BTNSaveAnswer.Text = "Сохранить";
            this.BTNSaveAnswer.UseVisualStyleBackColor = true;
            this.BTNSaveAnswer.Click += new System.EventHandler(this.BTNSaveAnswer_Click);
            // 
            // BTNGeneratorLogina
            // 
            this.BTNGeneratorLogina.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTNGeneratorLogina.Location = new System.Drawing.Point(210, 107);
            this.BTNGeneratorLogina.Margin = new System.Windows.Forms.Padding(2);
            this.BTNGeneratorLogina.Name = "BTNGeneratorLogina";
            this.BTNGeneratorLogina.Size = new System.Drawing.Size(146, 26);
            this.BTNGeneratorLogina.TabIndex = 18;
            this.BTNGeneratorLogina.Text = "Сгенерировать логин";
            this.BTNGeneratorLogina.UseVisualStyleBackColor = true;
            this.BTNGeneratorLogina.Click += new System.EventHandler(this.BTNGeneratorLogina_Click);
            // 
            // DTPBirthDate
            // 
            this.DTPBirthDate.Location = new System.Drawing.Point(431, 41);
            this.DTPBirthDate.Margin = new System.Windows.Forms.Padding(2);
            this.DTPBirthDate.Name = "DTPBirthDate";
            this.DTPBirthDate.Size = new System.Drawing.Size(182, 20);
            this.DTPBirthDate.TabIndex = 19;
            // 
            // LBAccounts
            // 
            this.LBAccounts.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LBAccounts.FormattingEnabled = true;
            this.LBAccounts.ItemHeight = 19;
            this.LBAccounts.Location = new System.Drawing.Point(431, 181);
            this.LBAccounts.Margin = new System.Windows.Forms.Padding(2);
            this.LBAccounts.Name = "LBAccounts";
            this.LBAccounts.Size = new System.Drawing.Size(279, 194);
            this.LBAccounts.TabIndex = 20;
            this.LBAccounts.SelectedIndexChanged += new System.EventHandler(this.LBAccounts_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(428, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 21);
            this.label1.TabIndex = 21;
            this.label1.Text = "Список пользователей";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(155)))), ((int)(((byte)(160)))));
            this.ClientSize = new System.Drawing.Size(743, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LBAccounts);
            this.Controls.Add(this.DTPBirthDate);
            this.Controls.Add(this.BTNGeneratorLogina);
            this.Controls.Add(this.BTNSaveAnswer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDNumberOfLetters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPasswordLenght)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BTNGeneratePassword;
        private System.Windows.Forms.NumericUpDown NUDNumberOfDigits;
        private System.Windows.Forms.NumericUpDown NUDNumberOfLetters;
        private System.Windows.Forms.CheckBox CBSpecialSymbols;
        private System.Windows.Forms.CheckBox CBCapitalLetters;
        private System.Windows.Forms.NumericUpDown NUDPasswordLenght;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.Button BTNSaveAnswer;
        private System.Windows.Forms.Button BTNGeneratorLogina;
        private System.Windows.Forms.DateTimePicker DTPBirthDate;
        private System.Windows.Forms.ListBox LBAccounts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CBDigitsAmount;
        private System.Windows.Forms.CheckBox CBLettersAmount;
    }
}

