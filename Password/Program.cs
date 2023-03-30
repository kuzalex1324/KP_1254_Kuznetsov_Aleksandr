using System;

namespace Password
{
    internal class Program
    {
        static Random random = new Random();
        static int passwordLength = 16;
        static int passwordDigitsAmount = 8;
        static int passwordLettersAmount = 8;
        static bool passwordIsUpperCaseNeeded = true;
        static bool passwordIsSpecialSymbolsNeeded = true;
        static string password;
        static void Main(string[] args)
        {
            //Обработка флагов
            CheckFlags(args);

            if (IsPasswordCorrect())
            {
                password = getPassword(passwordLength, passwordDigitsAmount, passwordLettersAmount, passwordIsUpperCaseNeeded, passwordIsSpecialSymbolsNeeded);
            }

            Console.WriteLine(password);
        }

        static string getPassword(int length, int digitsAmount, int lettersAmount, bool isUpperCaseNeeded, bool isSpecialSymbolsNeeded)
        {
            string password = "";
            for (int i = 0; i < digitsAmount; i++)
            {
                password += getDigitChar();
            }

            if (isUpperCaseNeeded)
            {
                for (int i = 0; i < lettersAmount; i++)
                {
                    if (getRandomNumber(1, 2) == 1)
                    {
                        password += getUpperCaseChar();
                    }
                    else
                    {
                        password += getLowerCaseChar();
                    }
                }
            }
            else
            {
                for (int i = 0; i < lettersAmount; i++)
                {
                    password += getLowerCaseChar();
                }
            }

            if (isSpecialSymbolsNeeded)
            {
                for (int i = 0; i < length - digitsAmount - lettersAmount; i++)
                {
                    password += getSpecialSymbolChar();
                }
            }

            return Shuffle(password);
        }

        //Обработка флагов
        static void CheckFlags(string[] args)
        {
            if (args.Length != 0)
            {
                foreach (string arg in args)
                {
                    if (arg[0] != '-')
                    {
                        passwordLength = Convert.ToInt32(args[0]);
                    }

                    if (arg[0] == '-' && arg[1] != '-') // "-u" "-s" '-us" "-su"
                    {
                        foreach (char letter in arg)
                        {
                            if (letter == 'u') passwordIsUpperCaseNeeded = false;
                            if (letter == 's') passwordIsSpecialSymbolsNeeded = false;
                        }
                    }
                    if ((arg[0] == '-') && (arg[1] == '-')) //"--lenght=60"
                    {
                        string[] splitedArg = arg.Split('='); //splitedArg = ["--lenght","60"]
                        if (splitedArg[0] == "--lenght") passwordLength = int.Parse(splitedArg[1]);
                        if (splitedArg[0] == "--digits") passwordDigitsAmount = int.Parse(splitedArg[1]);
                        if (splitedArg[0] == "--letters") passwordLettersAmount = int.Parse(splitedArg[1]);
                        if (splitedArg[0] == "--uppercase") passwordIsUpperCaseNeeded = false;
                        if (splitedArg[0] == "--special") passwordIsSpecialSymbolsNeeded = false;
                    }
                }

            }
        }

        static string Shuffle(string password) //password = "123456abc" // password[0] = '1'
        {
            for (int i = 0; i < passwordLength; i++)
            {
                int randomPos = getRandomNumber(0, passwordLength - 1);
                char mark = password[randomPos];
                password = password.Remove(randomPos, 1);
                password = password.Insert(0, mark.ToString());
            }
            return password;
        }
        static bool IsPasswordCorrect()
        {
            if (passwordLength < (passwordDigitsAmount + passwordLettersAmount))
                throw new Exception("Ошибка!!! Количество запрашиваемых символов больше длины пароля");
            else if (!passwordIsSpecialSymbolsNeeded && (passwordDigitsAmount + passwordLettersAmount) != passwordLength)
                throw new Exception("Ошибка!!! Недостаточное кол-во символов.");
            else return true;
        }

        static int getRandomNumber(int from, int to)
        {
            return random.Next(from, to + 1);
        }

        static char getDigitChar()
        {
            return Convert.ToChar(getRandomNumber(0, 9).ToString());
        }

        static char getLowerCaseChar()
        {
            return Convert.ToChar(getRandomNumber(97, 122));
        }

        static char getUpperCaseChar()
        {
            return Convert.ToChar(getRandomNumber(65, 90));
        }

        static char getSpecialSymbolChar()
        {
            return Convert.ToChar(getRandomNumber(21, 46));
        }
    }
}
