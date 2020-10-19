using System;

namespace StudentsExamples
{
    //Объявление класса
    class Program
    {
        int someNumber;
        //Метод класса 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EasyExample example = new EasyExample();
            EasyExample example2 = new EasyExample { };
        }
    }

    class EasyExample
    {
        string text = "TextExample";
    }


    class Student
    {
      
    }
}
