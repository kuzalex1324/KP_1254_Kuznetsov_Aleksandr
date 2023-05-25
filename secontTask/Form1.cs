using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace secontTask
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //чтобы в самом начале не было видно окошечка с краткими ответами
            AnswerGroupBox.Visible = false;
            people = ConvertToPersons("person.json");

            foreach(Person person in people)
            {
                PersonCB.Items.Add(person.GetTitle());
            }
        }

        int k = 0;
        List<RadioButton> list1 = new List<RadioButton>();
        private void AutoAnswers_Click(object sender, EventArgs e)
        {
            NameTB.Text = "Саша";
            SecondNameTB.Text = "Кузнецов";
            GroupNumberTB.Text = GetRandomNumber(0, 1000).ToString();
            AgeNumUpDown.Value = GetRandomNumber(18, 30);

            List<CheckBox> list = new List<CheckBox>();
            list.Add(checkBox1);
            list.Add(checkBox2);
            list.Add(checkBox3);
            list.Add(checkBox4);
            foreach (CheckBox checkbox in list)
            {
                if (GetRandomNumber(1, 2) == 1)
                {
                    checkbox.Checked = true;
                    k = k + 1;

                }
                else
                {
                    checkbox.Checked = false;
                }
                if (k < 1)
                {
                    checkBox1.Checked = true;
                }
            }

            list1.Add(radioButton1);
            list1.Add(radioButton2);
            list1.Add(radioButton3);
            list1.Add(radioButton4);
            foreach (RadioButton radioButton in list1)
            {
                if (GetRandomNumber(1, 2) == 2)
                {
                    radioButton.Checked = true;
                    break;
                }
                else
                {
                    radioButton.Checked = false;
                }
            }

            switch (GetRandomNumber(1, 4))
            {
                case 1:
                    CarDiskComBox.SelectedIndex = 0;
                    break;
                case 2:
                    CarDiskComBox.SelectedIndex = 1;
                    break;
                case 3:
                    CarDiskComBox.SelectedIndex = 2;
                    break;
                case 4:
                    CarDiskComBox.SelectedIndex = 3;
                    break;
            }

            NumOfCarsNUD.Value = GetRandomNumber(1, 15);
            InterestSB.Value = GetRandomNumber(70, 100);
            label11.Text = InterestSB.Value.ToString();
        }
        //чтобы при скролле изменялось значение
        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            label11.Text = e.NewValue.ToString();
        }

        //список пёрсонов, которые будут сохраняться по кнопке сохранить.
        List<Person> people = new List<Person>();

        private void SaveAnswers_Click(object sender, EventArgs e)
        {
            string CountryAnswer = string.Empty;
            foreach (RadioButton radioButton in list1)
            {
                if (radioButton.Checked == true)
                {
                    CountryAnswer = radioButton.Text;
                    break;
                }

            }
            //создал список чекнутых чекбоксов
            List<CheckBox> list3 = new List<CheckBox>() { checkBox1, checkBox2, checkBox3, checkBox4 };
            List<string> Carcase = new List<string>();
            foreach (CheckBox checkBox in list3)
            {
                if (checkBox.Checked == true)
                {
                    Carcase.Add(checkBox.Text);
                }

            }

            Person person = new Person(NameTB.Text, SecondNameTB.Text, Convert.ToInt32(GroupNumberTB.Text), (int)AgeNumUpDown.Value, CountryAnswer, Carcase, CarDiskComBox.Text, (int)NumOfCarsNUD.Value, InterestSB.Value);
            PersonCB.Items.Add(person.GetTitle());
            people.Add(person);

            File.WriteAllText("person.json", ConvertListToJsonString(people));

        }

        //метод по получению рандомного числа
        static Random random = new Random();
        static int GetRandomNumber(int to, int from)
        {
            return random.Next(to, from + 1);
        }

        //метод по удалению кол-ва символов с конца строки
        public static string RemoveLastChar(string str, int count)
        {
            if (str.Length > 0)
            {
                str = str.Remove(str.Length - count);
                return str;
            }
            else
            {
                return str;
            }
        }


        private void LoadAnswers_Click(object sender, EventArgs e)
        {
            foreach (Person person in people)
            {
                if (PersonCB.Text == person.GetTitle())
                {
                    AnswerGroupBox.Visible = true;
                    AnswerGroupBox.Text = PersonCB.Text;
                    Answer1.Text = person.Country;
                    Answer2.Text = person.ListToString();
                    Answer3.Text = person.CarDisk;
                    Answer4.Text = person.CarAmount.ToString();
                    Answer5.Text = person.Interest.ToString();
                    Answer6.Text = person.Age.ToString();

                }
            }

        }

        private void ClearAnswers_Click(object sender, EventArgs e)
        {
            File.Delete("person.json");
            PersonCB.Items.Clear();
            PersonCB.Text = string.Empty;
            AnswerGroupBox.Visible = false;

        }

        //Конвертировать список объектов в json формат
        //Проходится по каждому объекту в списке persons, конверитрует их в json строку, разъеденяет запятыми и добавляет [] по бокам
        private string ConvertListToJsonString(List<Person> people)
        {
            string jsonString = "[";
            foreach (Person person in people)
            {
                jsonString += person.ConvertToJson() + ",";
            }
            jsonString = RemoveLastChar(jsonString, 1);
            jsonString += "]";
            return jsonString;
        }

        //Парсит json строку и возвращает список объектов
        private static List<Person> ConvertToPersons(string fileName)
        {
            //Проверка существует ли файл, если нет, то вернёт пустой список
            if (File.Exists(fileName))
            {
                //Создаём объект без полей, в который потом будем вписывать данные
                List<Person> persons = new List<Person>();
                //Считывает данные из файла в строку
                string jsonIputString = File.ReadAllText(fileName);
                //Проходимся по каждому символу в строке и если он равен '{', значит это новый объект и мы его инициализируем
                for (int i = 0; i < jsonIputString.Length; i++)
                {
                    //Инициализация объекта
                    Person person = new Person();

                    if (jsonIputString[i] == '{')
                    {
                        //Текущая позиция проходчика по строке
                        int currentPos = i;
                        //Просто вспомогательные переменные
                        int start = 0;
                        int end = 0;
                        //Флаг, который озночает когда у нас закончились поля для объекта
                        bool breakFlag = false;
                        //Пока не закончились поля, мы их парсим
                        while (!breakFlag)
                        {
                            //Создаём новый список в виде ключ-значение, где первый элемент списка - ключ, второй - значение
                            List<string> key_value = new List<string>();
                            //Ищем вхождение ' " ' в строку и копируем в ключ все символы между первым вхождением в строку ' " ' и вторым
                            start = jsonIputString.IndexOf('"', currentPos);
                            currentPos = start + 1;
                            end = jsonIputString.IndexOf('"', currentPos);
                            //Добавляем скопированную подстроку в ключ
                            key_value.Add(jsonIputString.Substring(start + 1, end - start - 1));
                            currentPos = end + 1;
                            //Находим вхождение ' : ' в строку, копируем все символы до запятой после него, это и будет значение
                            start = jsonIputString.IndexOf(':', currentPos);
                            currentPos = start + 1;
                            //Условие на проверку, не является ли значение массивом, если да, то проходчик ищет не запятую, а конеч массмва
                            if (jsonIputString[currentPos] == '[')
                            {
                                end = jsonIputString.IndexOf(']', currentPos) + 1;
                            }
                            else
                            {

                                end = jsonIputString.IndexOf(',', currentPos);
                                //Если проходчик не нашёл запятую, значит это коннец json файла, и для конца значния мы ищем не запятую, а ' } '
                                if (end == -1)
                                {
                                    end = jsonIputString.IndexOf('}', currentPos);
                                    breakFlag = true;
                                }
                                //Иначе, если он нашёл запятую, но перед запятой был ' } ', это значит, что это конец объекта, но не всего массива объектов
                                else if (jsonIputString[end - 1] == '}')
                                {
                                    end -= 1;
                                    breakFlag = true;
                                }

                            }
                            //Добавляем значение в список ключ-значение
                            key_value.Add(jsonIputString.Substring(start + 1, end - start - 1));
                            currentPos = end + 1;
                            //Проверяем, что за ключ мы получили и по нему присваеваем значение объекту
                            switch (key_value[0])
                            {
                                case "Name":
                                    //Сабстринг нужен, чтобы в значение не присваивалось значение в скобках
                                    person.Name = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "LastName":
                                    person.Lastname = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "GroupNumber":
                                    person.GroupNumber = Convert.ToInt32(key_value[1]);
                                    break;
                                case "Age":
                                    person.Age = Convert.ToInt32(key_value[1]);
                                    break;
                                case "Country":
                                    person.Country = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "CarCase":
                                    //Конвертация string массива в обычный
                                    key_value[1] = key_value[1].Remove(key_value[1].Length - 1, 1).Remove(0, 1);
                                    List<string> CarCaseList = new List<string>();
                                    foreach (string carcase in key_value[1].Split(','))
                                    {
                                        CarCaseList.Add(carcase.Remove(carcase.Length - 1, 1).Remove(0, 1));
                                    }
                                    person.CarCase = CarCaseList;
                                    break;
                                case "CarDisk":
                                    person.CarDisk = key_value[1].Substring(1, key_value[1].Length - 2);
                                    break;
                                case "CarAmount":
                                    person.CarAmount = Convert.ToInt32(key_value[1]);
                                    break;
                                case "Interest":
                                    person.Interest = Convert.ToInt32(key_value[1]);
                                    break;

                            }
                        }
                        //Добавляем в список persons person
                        persons.Add(person);
                    }

                }
                return persons;
            }
            else
            {
                return new List<Person>();
            }
        }
    }
}
