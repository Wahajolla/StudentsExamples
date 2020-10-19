using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Conversions
    {
        static void Main(string[] args)
        {
            //Преобразование типов 
            //Результат - 74
            byte a = 4;
            int b = a + 70;

            //Не скомпилируется
            byte a1 = 4;
            byte b1 = a1 + 70;  // ошибка - не удается преобразовать int в byte

            //Скомпилируется
            byte a2 = 4;
            byte b2 = (byte) (a2 + 70);


            //с = 121 из за усечения старших битов
            int a = 33;
            int b = 600;
            byte c = (byte)(a + b);

        }

    }
}
