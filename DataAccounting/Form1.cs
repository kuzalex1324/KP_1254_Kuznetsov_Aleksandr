using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataAccounting
{
    public partial class Form1 : Form
    {
        public static List<Account> accounts = new List<Account>();
        public Form1()
        {
            InitializeComponent();
        }

        string RunApp(string path, string args) //D:\c#projects\PasswordGenerator\PasswordGenerator\bin\Debug
        {
            // Создание объекта для запуска внешнего приложения
            Process process = new Process();

            process.StartInfo.FileName = path;                  // указание пути к файлу запускаемой программы
            process.StartInfo.Arguments = args;                // передача аргументов запускаемой программы
            process.StartInfo.UseShellExecute = false;          // false требуется, чтобы можно было читать из вывода запущенного приложения
            process.StartInfo.RedirectStandardOutput = true;    // true требуется, чтобы можно было читать из стандартного вывода запущенного приложения
            process.StartInfo.RedirectStandardError = true;     // true требуется, чтобы можно было читать из ошибки запущенного приложения
            process.StartInfo.CreateNoWindow = true;            // отключаем создание окна (на всякий случай)

            // Запускаем приложение
            bool started = process.Start();
            if (!started)
            {
                Console.WriteLine("Ошибка запуска приложения!");
                throw new Exception("Ошибка запуска приложения!");
            }

            // Читамем вывод приложения
            string output = process.StandardOutput.ReadToEnd();

            // Дождаемся окончания работы приложения и выходим
            process.WaitForExit();

            return output;
        }

        private void BTNGeneratePassword_Click(object sender, EventArgs e)
        {
            //Праматры для пароля
            string args = "--length=" + NUDPasswordLenght.Value.ToString();
            if (CBCapitalLetters.Checked)
            {
                args += " -u";
            }
            if (CBSpecialSymbols.Checked)
            {
                args += " -s";
            }
            if (CBLettersAmount.Checked)
            {
                args += " --letters=" + NUDNumberOfLetters.Value.ToString();
            }
            if (CBDigitsAmount.Checked)
            {
                args += " --digits=" + NUDNumberOfDigits.Value.ToString();
            }
            //Запускаем приложение, путь относительный
            TBPassword.Text = RunApp("PasswordGenerator\\PasswordGenerator\\bin\\Debug\\PasswordGenerator.exe", args);
        }

        private void BTNGeneratorLogina_Click(object sender, EventArgs e)
        {
            TBLogin.Text = TBName.Text + TBLastName.Text;
            TBLogin.Text =  Account.Translate(TBLogin.Text);
        }
        private void BTNSaveAnswer_Click(object sender, EventArgs e)
        {
            Account account = new Account(TBName.Text, TBLastName.Text, TBLogin.Text, TBPassword.Text, DTPBirthDate.Value);
            LBAccounts.Items.Add(account.ToString());
            accounts.Add(account);
        }

        private void LBAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = LBAccounts.SelectedItem.ToString();
            foreach (Account account in accounts)
            {
                if (account.ToString() == item)
                {
                    TBName.Text = account.firtsName;
                    TBLastName.Text = account.lastName;
                    TBLogin.Text = account.login;
                    TBPassword.Text = account.password;
                    DTPBirthDate.Value = account.birthDate;
                }
            }
        }
    }
}
