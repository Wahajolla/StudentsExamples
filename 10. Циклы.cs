using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Loops
    {
        static void Main(string[] args)
        {
            //Цикл for

            /* for ([инициализация счетчика]; [условие];[изменение счетчика])
            {
                // действия
            }*/

            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine($"Квадрат числа {i} равен {i * i}");
            }

            //Бесконечный цикл - нет условия
            //int i = 0;
            //for (; ; )
            //{
            //    Console.WriteLine($"Квадрат числа {++i} равен {i * i}");
            //}

            //Отсутсвие блоков
            int i = 0;
            for (; i < 9;)
            {
                Console.WriteLine($"Квадрат числа {++i} равен {i * i}");
            }

            //Цикл while
            int i = 6;
            while (i > 0)
            {
                Console.WriteLine(i);
                i--;
            }



            //Цикл do while
            int i = -1;
            do
            {
                Console.WriteLine(i);
                i--;
            }
            while (i > 0);


            //Операторы continue и break
            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    break;
                Console.WriteLine(i);
            }


            for (int i = 0; i < 9; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
