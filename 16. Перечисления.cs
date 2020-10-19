using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Enums
    {
/*        В этих примерах каждому элементу перечисления присваивается целочисленное значение, причем первый элемент будет иметь значение 0, второй - 1 и так далее.
            Мы можем также явным образом указать значения элементов, либо указав значение первого элемента:  */  
        enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            Days day;
            day = Days.Monday;
            Console.WriteLine(day);

            Console.ReadLine();
            MathOp(0.1d, 0.2d, day);


        }

        static void MathOp(double x, double y, Days day)
        {
            double result = 0.0;
            switch (day)
            {
                case Days.Monday:
                    result = x + y;
                    break;
                case Days.Wednesday:
                    result = x - y;
                    break;
                
            }

            Console.WriteLine("Результат операции равен {0}", result);
        }
    }

    
}
