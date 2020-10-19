using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class ViewContext
    {
        static int a = 9; // переменная уровня класса

        static void Main(string[] args) // начало контекста метода Main
        {
            int b = a - 1; // переменная уровня метода

            { // начало контекста блока кода

                int c = b - 1; // переменная уровня блока кода

            }  // конец контекста блока кода, переменная с уничтожается

            //так нельзя, переменная c определена в блоке кода
            //Console.WriteLine(c);

            //так нельзя, переменная d определена в другом методе
            //Console.WriteLine(d);

            Console.Read();

        } // конец контекста метода Main, переменная b уничтожается

        void Display() // начало контекста метода Display
        {
            // переменная a определена в контексте класса, поэтому доступна
            int d = a + 1;

        } // конец конекста метода Display, переменная d уничтожается

        static void Test(string[] args)
        {
            int a = 5; // скрывает переменную a, которая объявлена на уровне класса
            Console.WriteLine(a); // 5
        }
    }
}
