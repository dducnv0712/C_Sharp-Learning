using System;
using System.Collections.Generic;

namespace c_Sharp_Learning.session3
{
    public class Student: Human
    {
        private string name;
        private int age;
        private DateTime birthday;
        private string nickname;
        private string cannang;

        //public string[] gallery = new  String[3];
        public List<string> phoneNumbers = new List<string>();

        public Student()
        {
        }

        public string this[int index]
        {
            get => phoneNumbers[index];
            set => phoneNumbers[index] = value;
        }

        public override string Weight
        {
            get => cannang;
            set => cannang = value;
        }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
            phoneNumbers.Add("a");
            phoneNumbers.Add("b");
            phoneNumbers.Add("c");
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get => age;
            set => age = value;
        }


    }
}