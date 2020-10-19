using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class MathExample
    {
        static void main(string[] args) // объявление нового метода
        {
            //Abs(double value): возвращает абсолютное значение для аргумента value
           var result = Math.Abs(-12.4); // 12.4

            //Acos(double value): возвращает арккосинус value. Параметр value должен иметь значение от -1 до 1
            double result2 = Math.Acos(1); // 0

            //Asin(double value) : возвращает арксинус value.Параметр value должен иметь значение от -1 до 1
            double result3 = Math.Asin(1);

            //BigMul(int x, int y) : возвращает произведение x* y в виде объекта long
            long result4 = Math.BigMul(1, 1000);

            //Ceiling(double value): возвращает наименьшее целое число с плавающей точкой, которое не меньше value
            double result5 = Math.Ceiling(2.45d);

            //Cos(double d) : возвращает косинус угла d
            double result6 = Math.Cos(2.45d);

            //Cosh(double d) : возвращает гиперболический косинус угла d
            double result7 = Math.Cosh(2.45d);

            //DivRem(int a, int b, out int result): возвращает результат от деления a/b, а остаток помещается в параметр result
            int a = 0;
            double result8 = Math.DivRem(4, 3, out a);

            //Floor(decimal d): возвращает наибольшее целое число, которое не больше d
            double result9 = Math.Floor(2.6d);
        }
    }
}
