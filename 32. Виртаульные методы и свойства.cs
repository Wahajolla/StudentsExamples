using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Virtuals
    {






        static void Main(string[] args)
        {
            Person p1 = new Person("Bill");
            p1.Display(); // вызов метода Display из класса Person

            Employee p2 = new Employee("Tom", "Microsoft");
            p2.Display(); // вызов метода Display из класса Person

            Console.ReadKey();
        }







        class Person
        {
            public string Name { get; set; }
            public Person(string name)
            {
                Name = name;
            }
            public virtual void Display()
            {
                Console.WriteLine(Name);
            }

            public override string ToString()
            {
                return Name;
            }
        }
        class Employee : Person
        {
            public string Company { get; set; }
            public Employee(string name, string company) : base(name)
            {
                Company = company;
            }
        }


        class OverWrittenPerson : Person
        {
            public string Company { get; set; }
            public OverWrittenPerson(string name, string company)
                : base(name)
            {
                Company = company;
            }

            public override void Display()
            {
                Console.WriteLine($"{Name} работает в {Company}");
            }
        }
    }
}
