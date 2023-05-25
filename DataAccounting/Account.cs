using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccounting
{
    public class Account
    {
        public string firtsName;
        public string lastName;
        public string login;
        public string password;
        public DateTime birthDate;
        public static Dictionary<string, string> alphabetDict = new Dictionary<string, string>
        {
            ["а"] = "a",
            ["б"] = "b",
            ["в"] = "v",
            ["г"] = "g",
            ["д"] = "d",
            ["е"] = "e",
            ["ё"] = "yo",
            ["ж"] = "zh",
            ["з"] = "z",
            ["и"] = "i",
            ["й"] = "iy",
            ["к"] = "k",
            ["л"] = "l",
            ["м"] = "m",
            ["н"] = "n",
            ["о"] = "o",
            ["п"] = "p",
            ["р"] = "r",
            ["с"] = "s",
            ["т"] = "t",
            ["у"] = "u",
            ["ф"] = "f",
            ["х"] = "kh",
            ["ц"] = "ts",
            ["ч"] = "ch",
            ["ш"] = "sh",
            ["щ"] = "sch",
            ["ы"] = "y",
            ["э"] = "eh",
            ["ю"] = "you",
            ["я"] = "ya",
            ["А"] = "A",
            ["Б"] = "B",
            ["В"] = "V",
            ["Г"] = "G",
            ["Д"] = "D",
            ["Е"] = "E",
            ["Ё"] = "Yo",
            ["Ж"] = "Zh",
            ["З"] = "Z",
            ["И"] = "I",
            ["Й"] = "Iy",
            ["К"] = "K",
            ["Л"] = "L",
            ["М"] = "M",
            ["Н"] = "N",
            ["О"] = "O",
            ["П"] = "P",
            ["Р"] = "R",
            ["С"] = "S",
            ["Т"] = "T",
            ["У"] = "U",
            ["Ф"] = "F",
            ["Х"] = "Kh",
            ["Ц"] = "Ts",
            ["Ч"] = "Ch",
            ["Ш"] = "Sh",
            ["Щ"] = "Sch",
            ["Ы"] = "Y",
            ["Э"] = "Eh",
            ["Ю"] = "You",
            ["Я"] = "Ya",
            [" "] = " ",
        };
        public Account(string firtsName, string lastName, string login, string password, DateTime birthDate)
        {
            this.firtsName = firtsName;
            this.lastName = lastName;
            this.login = login;
            this.password = password;
            this.birthDate = birthDate;
        }

        public static string Translate(string word)
        {
            string translateWord = string.Empty;
            foreach (char c in word)
            {
                translateWord += alphabetDict[c.ToString()];
            }
            return translateWord;
        }

        public override string ToString()
        {
            return firtsName + " " + lastName;
        }
    }
}
