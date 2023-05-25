using System.Collections.Generic;

namespace secontTask
{
    internal class Person
    {
        public string Name;
        public string Lastname;
        public int GroupNumber;
        public int Age;
        public string Country;
        public List<string> CarCase;
        public string CarDisk;
        public int CarAmount;
        public int Interest;
        public Person(string Name, string Lastname, int GroupNumber, int Age, string Country, List<string> CarCase, string CarDisk, int CarAmount, int Interest)
        {
            this.Name = Name;
            this.Lastname = Lastname;
            this.GroupNumber = GroupNumber;
            this.Age = Age;
            this.Country = Country;
            this.CarCase = CarCase;
            this.CarDisk = CarDisk;
            this.CarAmount = CarAmount;
            this.Interest = Interest;
        }
        public Person()
        {

        }


        public string ListToJsonString()
        {
            string ListString = "[";
            foreach (string item in CarCase)
            {
                ListString += "\"" + item + "\",";
            }
            ListString = Form1.RemoveLastChar(ListString, 1);
            ListString += "]";
            return ListString;
        }
        public string ListToString()
        {
            string result = "";
            foreach (string item in CarCase)
            {
                result += item + ", ";
            }
            result = result.Remove(result.Length - 2);
            return result;

        }

        public string ConvertToJson()
        {
            string jsonString = "{\"Name\":" + "\"" + Name + "\"" + ","
                + "\"LastName\":" + "\"" + Lastname + "\"" + ","
                + "\"GroupNumber\":" + GroupNumber.ToString() + ","
                + "\"Age\":" + Age.ToString() + ","
                + "\"Country\":" + "\"" + Country + "\"" + ","
                + "\"CarCase\":" + ListToJsonString() + ","
                + "\"CarDisk\":" + "\"" + CarDisk + "\"" + ","
                + "\"CarAmount\":" + CarAmount.ToString() + ","
                + "\"Interest\":" + Interest.ToString() + "}";
            return jsonString;
        }

        public string GetTitle()
        {
            return Name + " " + Lastname + " " + GroupNumber;
        }
    }
}
