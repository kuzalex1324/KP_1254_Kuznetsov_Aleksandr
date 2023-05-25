using System.Windows.Forms.VisualStyles;
using System.Windows.Forms;

namespace secontTask
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
            this.NameTB = new System.Windows.Forms.TextBox();
            this.SecondNameTB = new System.Windows.Forms.TextBox();
            this.GroupNumberTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeNumUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.CountryGB = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.CarcaseGB = new System.Windows.Forms.GroupBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.CarDiskComBox = new System.Windows.Forms.ComboBox();
            this.NumOfCarsNUD = new System.Windows.Forms.NumericUpDown();
            this.Question1 = new System.Windows.Forms.Label();
            this.Question2 = new System.Windows.Forms.Label();
            this.Question3 = new System.Windows.Forms.Label();
            this.Question4 = new System.Windows.Forms.Label();
            this.ClearAnswers = new System.Windows.Forms.Button();
            this.SaveAnswers = new System.Windows.Forms.Button();
            this.AutoAnswers = new System.Windows.Forms.Button();
            this.InterestSB = new System.Windows.Forms.HScrollBar();
            this.Question5 = new System.Windows.Forms.Label();
            this.PersonCB = new System.Windows.Forms.ComboBox();
            this.LoadAnswers = new System.Windows.Forms.Button();
            this.AnswerGroupBox = new System.Windows.Forms.GroupBox();
            this.Answer6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Answer5 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.Answer4 = new System.Windows.Forms.Label();
            this.Answer3 = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumUpDown)).BeginInit();
            this.CountryGB.SuspendLayout();
            this.CarcaseGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCarsNUD)).BeginInit();
            this.AnswerGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameTB
            // 
            this.NameTB.BackColor = System.Drawing.Color.White;
            this.NameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NameTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTB.Location = new System.Drawing.Point(20, 50);
            this.NameTB.Multiline = true;
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(135, 34);
            this.NameTB.TabIndex = 1;
            // 
            // SecondNameTB
            // 
            this.SecondNameTB.BackColor = System.Drawing.Color.White;
            this.SecondNameTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SecondNameTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondNameTB.Location = new System.Drawing.Point(209, 50);
            this.SecondNameTB.Multiline = true;
            this.SecondNameTB.Name = "SecondNameTB";
            this.SecondNameTB.Size = new System.Drawing.Size(163, 34);
            this.SecondNameTB.TabIndex = 25;
            // 
            // GroupNumberTB
            // 
            this.GroupNumberTB.BackColor = System.Drawing.Color.White;
            this.GroupNumberTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GroupNumberTB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupNumberTB.Location = new System.Drawing.Point(438, 50);
            this.GroupNumberTB.Multiline = true;
            this.GroupNumberTB.Name = "GroupNumberTB";
            this.GroupNumberTB.Size = new System.Drawing.Size(130, 34);
            this.GroupNumberTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(178)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(178)))), ((int)(((byte)(166)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(240, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(420, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Номер Группы";
            // 
            // AgeNumUpDown
            // 
            this.AgeNumUpDown.BackColor = System.Drawing.Color.White;
            this.AgeNumUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeNumUpDown.Location = new System.Drawing.Point(654, 54);
            this.AgeNumUpDown.Name = "AgeNumUpDown";
            this.AgeNumUpDown.Size = new System.Drawing.Size(120, 30);
            this.AgeNumUpDown.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(178)))), ((int)(((byte)(166)))));
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(670, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Возраст";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(76, 20);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Италия";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // CountryGB
            // 
            this.CountryGB.Controls.Add(this.radioButton4);
            this.CountryGB.Controls.Add(this.radioButton3);
            this.CountryGB.Controls.Add(this.radioButton2);
            this.CountryGB.Controls.Add(this.radioButton1);
            this.CountryGB.Location = new System.Drawing.Point(7, 215);
            this.CountryGB.Name = "CountryGB";
            this.CountryGB.Size = new System.Drawing.Size(232, 114);
            this.CountryGB.TabIndex = 13;
            this.CountryGB.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 89);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(78, 20);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Франия";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 63);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(74, 20);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Россия";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 37);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 20);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Германия";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 20);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "Седан";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CarcaseGB
            // 
            this.CarcaseGB.Controls.Add(this.checkBox4);
            this.CarcaseGB.Controls.Add(this.checkBox3);
            this.CarcaseGB.Controls.Add(this.checkBox2);
            this.CarcaseGB.Controls.Add(this.checkBox1);
            this.CarcaseGB.Location = new System.Drawing.Point(286, 226);
            this.CarcaseGB.Name = "CarcaseGB";
            this.CarcaseGB.Size = new System.Drawing.Size(265, 113);
            this.CarcaseGB.TabIndex = 16;
            this.CarcaseGB.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(6, 89);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(118, 20);
            this.checkBox4.TabIndex = 17;
            this.checkBox4.Text = "Внедорожник";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(6, 63);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(99, 20);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Кроссовер";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 37);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(61, 20);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "Купе";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // CarDiskComBox
            // 
            this.CarDiskComBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarDiskComBox.FormattingEnabled = true;
            this.CarDiskComBox.Items.AddRange(new object[] {
            "Vossen",
            "Ace Executive Black",
            "Forgiato Basamento",
            "Nutek",
            "Штампованные"});
            this.CarDiskComBox.Location = new System.Drawing.Point(577, 190);
            this.CarDiskComBox.Name = "CarDiskComBox";
            this.CarDiskComBox.Size = new System.Drawing.Size(219, 33);
            this.CarDiskComBox.TabIndex = 17;
            // 
            // NumOfCarsNUD
            // 
            this.NumOfCarsNUD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NumOfCarsNUD.Location = new System.Drawing.Point(577, 309);
            this.NumOfCarsNUD.Name = "NumOfCarsNUD";
            this.NumOfCarsNUD.Size = new System.Drawing.Size(219, 30);
            this.NumOfCarsNUD.TabIndex = 18;
            // 
            // Question1
            // 
            this.Question1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question1.Location = new System.Drawing.Point(7, 122);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(237, 78);
            this.Question1.TabIndex = 19;
            this.Question1.Text = "Машину какой страны вы предпочтёте к покупке?";
            // 
            // Question2
            // 
            this.Question2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question2.Location = new System.Drawing.Point(286, 114);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(265, 109);
            this.Question2.TabIndex = 20;
            this.Question2.Text = "Какой кузов машины вы предпочтетё для себя? (можете выбрать несколько вариантов)";
            // 
            // Question3
            // 
            this.Question3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question3.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question3.Location = new System.Drawing.Point(577, 114);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(265, 62);
            this.Question3.TabIndex = 21;
            this.Question3.Text = "Какие диски предпочтёте для своего авто?";
            // 
            // Question4
            // 
            this.Question4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Question4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question4.Location = new System.Drawing.Point(577, 236);
            this.Question4.Name = "Question4";
            this.Question4.Size = new System.Drawing.Size(265, 62);
            this.Question4.TabIndex = 22;
            this.Question4.Text = "Сколько автомобилей у вас было в жизни?";
            // 
            // ClearAnswers
            // 
            this.ClearAnswers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearAnswers.Location = new System.Drawing.Point(969, 509);
            this.ClearAnswers.Name = "ClearAnswers";
            this.ClearAnswers.Size = new System.Drawing.Size(235, 39);
            this.ClearAnswers.TabIndex = 23;
            this.ClearAnswers.Text = "Сброс ответов";
            this.ClearAnswers.UseVisualStyleBackColor = true;
            this.ClearAnswers.Click += new System.EventHandler(this.ClearAnswers_Click);
            // 
            // SaveAnswers
            // 
            this.SaveAnswers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveAnswers.Location = new System.Drawing.Point(320, 509);
            this.SaveAnswers.Name = "SaveAnswers";
            this.SaveAnswers.Size = new System.Drawing.Size(248, 39);
            this.SaveAnswers.TabIndex = 24;
            this.SaveAnswers.Text = "Сохранить ответы";
            this.SaveAnswers.UseVisualStyleBackColor = true;
            this.SaveAnswers.Click += new System.EventHandler(this.SaveAnswers_Click);
            // 
            // AutoAnswers
            // 
            this.AutoAnswers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoAnswers.Location = new System.Drawing.Point(951, 9);
            this.AutoAnswers.Name = "AutoAnswers";
            this.AutoAnswers.Size = new System.Drawing.Size(296, 65);
            this.AutoAnswers.TabIndex = 26;
            this.AutoAnswers.Text = "Авто ответы";
            this.AutoAnswers.UseVisualStyleBackColor = true;
            this.AutoAnswers.Click += new System.EventHandler(this.AutoAnswers_Click);
            // 
            // InterestSB
            // 
            this.InterestSB.Location = new System.Drawing.Point(150, 435);
            this.InterestSB.Maximum = 109;
            this.InterestSB.Name = "InterestSB";
            this.InterestSB.Size = new System.Drawing.Size(172, 21);
            this.InterestSB.TabIndex = 27;
            this.InterestSB.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // Question5
            // 
            this.Question5.AutoSize = true;
            this.Question5.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Question5.Location = new System.Drawing.Point(8, 363);
            this.Question5.Name = "Question5";
            this.Question5.Size = new System.Drawing.Size(567, 29);
            this.Question5.TabIndex = 28;
            this.Question5.Text = "Насколько вы заинтересованы в прохождении опроса?";
            // 
            // PersonCB
            // 
            this.PersonCB.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonCB.FormattingEnabled = true;
            this.PersonCB.Location = new System.Drawing.Point(969, 209);
            this.PersonCB.Name = "PersonCB";
            this.PersonCB.Size = new System.Drawing.Size(235, 37);
            this.PersonCB.TabIndex = 30;
            // 
            // LoadAnswers
            // 
            this.LoadAnswers.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadAnswers.Location = new System.Drawing.Point(969, 114);
            this.LoadAnswers.Name = "LoadAnswers";
            this.LoadAnswers.Size = new System.Drawing.Size(235, 69);
            this.LoadAnswers.TabIndex = 31;
            this.LoadAnswers.Text = "Загрузить ответы";
            this.LoadAnswers.UseVisualStyleBackColor = true;
            this.LoadAnswers.Click += new System.EventHandler(this.LoadAnswers_Click);
            // 
            // AnswerGroupBox
            // 
            this.AnswerGroupBox.Controls.Add(this.Answer6);
            this.AnswerGroupBox.Controls.Add(this.label9);
            this.AnswerGroupBox.Controls.Add(this.Answer5);
            this.AnswerGroupBox.Controls.Add(this.Answer2);
            this.AnswerGroupBox.Controls.Add(this.Answer4);
            this.AnswerGroupBox.Controls.Add(this.Answer3);
            this.AnswerGroupBox.Controls.Add(this.Answer1);
            this.AnswerGroupBox.Controls.Add(this.label8);
            this.AnswerGroupBox.Controls.Add(this.label7);
            this.AnswerGroupBox.Controls.Add(this.label6);
            this.AnswerGroupBox.Controls.Add(this.label5);
            this.AnswerGroupBox.Controls.Add(this.label10);
            this.AnswerGroupBox.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AnswerGroupBox.Location = new System.Drawing.Point(872, 289);
            this.AnswerGroupBox.Name = "AnswerGroupBox";
            this.AnswerGroupBox.Size = new System.Drawing.Size(401, 203);
            this.AnswerGroupBox.TabIndex = 32;
            this.AnswerGroupBox.TabStop = false;
            this.AnswerGroupBox.Text = "Ответы кратко";
            // 
            // Answer6
            // 
            this.Answer6.AutoSize = true;
            this.Answer6.Location = new System.Drawing.Point(106, 173);
            this.Answer6.Name = "Answer6";
            this.Answer6.Size = new System.Drawing.Size(0, 18);
            this.Answer6.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Возраст";
            // 
            // Answer5
            // 
            this.Answer5.AutoSize = true;
            this.Answer5.Location = new System.Drawing.Point(207, 146);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(0, 18);
            this.Answer5.TabIndex = 9;
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Location = new System.Drawing.Point(106, 54);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(0, 18);
            this.Answer2.TabIndex = 8;
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Location = new System.Drawing.Point(207, 117);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(0, 18);
            this.Answer4.TabIndex = 7;
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Location = new System.Drawing.Point(106, 85);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(0, 18);
            this.Answer3.TabIndex = 6;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Location = new System.Drawing.Point(106, 26);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(0, 18);
            this.Answer1.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Интерес прохождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(170, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Количество автомобилей";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Диски";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Кузов";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Страна";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(215, 401);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 25);
            this.label11.TabIndex = 33;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(178)))), ((int)(((byte)(166)))));
            this.ClientSize = new System.Drawing.Size(1295, 708);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.AnswerGroupBox);
            this.Controls.Add(this.LoadAnswers);
            this.Controls.Add(this.PersonCB);
            this.Controls.Add(this.Question5);
            this.Controls.Add(this.InterestSB);
            this.Controls.Add(this.AutoAnswers);
            this.Controls.Add(this.SaveAnswers);
            this.Controls.Add(this.ClearAnswers);
            this.Controls.Add(this.Question4);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.NumOfCarsNUD);
            this.Controls.Add(this.CarDiskComBox);
            this.Controls.Add(this.CarcaseGB);
            this.Controls.Add(this.CountryGB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AgeNumUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GroupNumberTB);
            this.Controls.Add(this.SecondNameTB);
            this.Controls.Add(this.NameTB);
            this.Name = "Form1";
            this.Text = "Опросник";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumUpDown)).EndInit();
            this.CountryGB.ResumeLayout(false);
            this.CountryGB.PerformLayout();
            this.CarcaseGB.ResumeLayout(false);
            this.CarcaseGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfCarsNUD)).EndInit();
            this.AnswerGroupBox.ResumeLayout(false);
            this.AnswerGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox SecondNameTB;
        private System.Windows.Forms.TextBox GroupNumberTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private NumericUpDown AgeNumUpDown;
        private Label label4;
        private RadioButton radioButton1;
        private GroupBox CountryGB;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private CheckBox checkBox1;
        private GroupBox CarcaseGB;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private ComboBox CarDiskComBox;
        private NumericUpDown NumOfCarsNUD;
        private Label Question1;
        private Label Question2;
        private Label Question3;
        private Label Question4;
        private Button ClearAnswers;
        private Button SaveAnswers;
        private Button AutoAnswers;
        private HScrollBar InterestSB;
        private Label Question5;
        private ComboBox PersonCB;
        private Button LoadAnswers;
        private GroupBox AnswerGroupBox;
        private Label label10;
        private Label label11;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label Answer5;
        private Label Answer2;
        private Label Answer4;
        private Label Answer3;
        private Label Answer1;
        private Label Answer6;
        private Label label9;
    }
}

