using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Methods
    {
        //Void


        //[модификаторы] тип_возвращаемого_значения название_метода([параметры])
        //{
        //    // тело метода
        //}

        static void Main(string[] args)
        {
            //название_метода(значения_для_параметров_метода);
            Method(); //Метод без параметров
            Method2("Hello there"); //Метод с параметром
            Method2(ReturnText()); //В метод с параметром передается результат, который выполнил другой метод
            Addition(2, "hello", 1, 3, 4); // Вызов метода с набором параметро
            Console.ReadKey();
        }




        static void Method()
        {
            Console.WriteLine("Ура, метод сработал");
        }

        static void Method2(string text)
        {
            Console.WriteLine(text);
        }

        static string ReturnText()
        {
            return "Hello there";
            Console.WriteLine("F"); // не выполниться, так как return выходит из метода
        }

        //Так НЕ работает
        static string ReturnTextBadVersion()
        {
            Console.WriteLine("Heh");
        }


        //Работа с массивом параметром
        static void Addition(int x, string mes, params int[] integers)
        {
            int sum = 0;
            foreach (var item in integers)
            {
                sum += item;
            }
            sum += x;
            Console.WriteLine(mes);
            Console.WriteLine(sum);
        }

        //Так НЕ работает
        static void Addition(params int[] integers, int x, string mes)
        {
        
        }

    }

}
