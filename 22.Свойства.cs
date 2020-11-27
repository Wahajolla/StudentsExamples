using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class TestOfPerson
    {
        void Test()
        {
            Person person = new Person();
            person.Name = "A";
            string s = person.Name;
            person.textTest = "a";
            person.NameClosed = "A";
            string a = person.NameClosed;
        }
    }

    class Person
    {
        public string textTest;
        private string name;
        private string nameClosed;
        private int Iq;
        public int Age { get; set; }

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
        public string NameClosed
        {
            get
            {
                return nameClosed;
            }
        }

        public int LogicTest
        {
            get
            {
                return Iq;
            }
            set
            {
                if(value>5)
                {
                    Iq = value;
                }
            }
        }
    }
}
