using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class TrueFalse
    {
        static void Main(string[] args)
        {
            //IfElse
            int num1 = 8;
            int num2 = 6;
            if (num1 > num2)//Если первое число больше второго
            {
                Console.WriteLine($"Число {num1} больше числа {num2}");
            }

            else if (num1 < num2)//Если первое число меньше второго
            {
                Console.WriteLine($"Число {num1} меньше числа {num2}");
            }

            else if(num1 > num2 && num1 == 8)//Если числа равны
            {
                Console.WriteLine($"Число {num1} больше числа {num2} и больше 8");
            }
            else
            {
                Console.WriteLine("Число num1 равно числу num2");
            }


            //Switch
            Console.WriteLine("Нажмите Y или N");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "Y":
                    Console.WriteLine("Вы нажали Y");
                    break;
                case "N":
                    Console.WriteLine("Вы нажали N");
                    break;
                default:
                    Console.WriteLine("Вы нажали совсем другое...");
                    break;
            }



            //Тернарный оператор
            int x = 3;
            int y = 2;
            Console.WriteLine("Нажмите + или -");
            string select = Console.ReadLine();

            int z = select == "+" ? (x + y) : (x - y);
            Console.WriteLine(z);




            Console.Write("Введите 1 тип");
            string S = Console.ReadLine();
                
            Console.Write("Введите 2 тип");
            int I = Convert.ToInt32( Console.ReadLine());

            Console.Write("Введите 3 тип");
            float F = Convert.ToSingle(Console.ReadLine());

            Console.Write("Введите 4 тип");
            double D = Convert.ToDouble(Console.ReadLine());
        }
    }
}
