using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class StructExample
    {
        struct User
        {
            public string name;
            public int age;
            public void DisplayInfo()
            {
                Console.WriteLine($"Name: {name}  Age: {age}");
            }
        }
    }
}
