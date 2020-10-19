using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class RefOut
    {
        static void ExampleChange()
        {
            int a = 1;
            Console.WriteLine($"Начальное значение переменной a = {a}");

            //Передача переменных по значению
            //После выполнения этого кода по-прежнему a = 5, так как мы передали лишь ее копию
            ChangeByValue(a);
            ChangeByRef(ref a);
            ChangeByOut(1, 2, out a);
            Console.WriteLine($"Переменная a после передачи по значению равна = {a}");
            Console.ReadKey();
        }
        // передача по значению
        static void ChangeByValue(int x)
        {
            x++;
            Console.WriteLine($"IncrementVal: {x}");
        }

        /*      Начальное значение переменной a = 1
                IncrementVal: 2
                Переменная a после передачи по значению равна = 1*/

        static void ChangeByRef(ref int x)
        {
            x++;
            Console.WriteLine($"IncrementVal: {x}");
        }

        /*      Начальное значение переменной a = 1
                IncrementVal: 2
                Переменная a после передачи по значению равна = 2*/

        static void ChangeByOut(int x, int y, out int a)
        {
            a = x + y;
        }

        /*      Начальное значение переменной a = ?
                Переменная a после передачи по значению равна = 3*/
        static void ChangeByIn(in int x, int y, out int answer)
        {
            // x = x + 10; нельзя изменить значение параметра x
            y = y + 10;
            answer = (x + y) * 2;
        }
    }
}
