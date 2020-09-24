using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsExamples
{
    class ConsoleIO
    {
        static void main(string[] args)
        {

            //Встраивание переменной в вывод
            string words = "Привет мир";
            Console.WriteLine(words); //Вывод переменной
            Console.WriteLine(24.5);
            Console.ReadKey(); //Ожидание ввода любого символа







            //Встраивание множества переменных в вывод
            string name = "Виталя";
            int age = 17;
            double height = 3;
            Console.WriteLine($"Имя: {name}  Возраст: {age}  Рост: {height}м");
            Console.ReadKey();






            //Альтернативное встраивание множества переменных в вывод
            string name2 = "Брат Витали";
            int age2 = 34;
            double height2 = 1.2;
            Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1}м", name2, height2, age2);
            Console.ReadKey();


            //Форматирование чисел с запятой
            string name3 = "Брат Витали с другим ростом";
            int age3 = 34;
            double height3 = 1.1231242;
            Console.WriteLine("Имя: {0}  Возраст: {2}  Рост: {1:f2}м", name3, height3, age3);
            Console.ReadKey();

            //Форматирование с процентами
            string name4 = "брата Витали с другим ростом";
            decimal prettyBoy = 1.46m;
            Console.WriteLine("Красота {0}  {1:P13}м", name3, prettyBoy);
            Console.ReadKey();



            //Ввод в консоль
            Console.Write("Введите свое имя: ");
            string nameOutput = Console.ReadLine();
            Console.WriteLine($"Привет, {nameOutput}");
            Console.ReadKey();





            //Класс Convert
            Console.Write("Введите желаемый размер зарплаты: ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Ваша будущая зарплата C# разработчика: {salary}$");
            Console.ReadKey();
            //Еще примеры преобразований 
          /*Convert.ToBoolean(value)
            Convert.ToByte(value)
            Convert.ToChar(value) 
            Convert.ToDecimal(value)
            Convert.ToDouble(value)
            Convert.ToInt16(value)
            Convert.ToInt32(value)
            Convert.ToInt64(value)
            Convert.ToSByte(value)
            Convert.ToSingle(value)
            Convert.ToUInt16(value)
            Convert.ToUInt32(value)
            Convert.ToUInt64(value)*/











            //Метод Parse
            Console.Write("Введите желаемый размер зарплаты в миллионах: ");
            int salaryMillion = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ваша будущая зарплата главы Microsoft: {salaryMillion}$");
            Console.ReadKey();




            //Метод TryParse
            string inputString = Console.ReadLine();
            int numberToParse;
            bool result = int.TryParse(inputString, out numberToParse);
            Console.WriteLine(result);
          /*Если преобразование удачно -
            result = true, numberToParse = число, что было введено*/

        }
    }
}
