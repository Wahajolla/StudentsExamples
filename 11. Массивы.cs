using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Arrays
    {
        static void main(string[] args)
        {
            //Одномерный массив
            //тип_переменной[] название_массива;

            int[] numbers; // Массив чисел, но без "Содержимого" - память не была выделена.

            int[] nums = new int[4]; // Массив чисел,  память выделена, все элементы = 0.

            //Способы объявления массива
            int[] nums2 = new int[4] { 1, 2, 3, 5 };

            int[] nums3 = new int[] { 1, 2, 3, 5 };

            int[] nums4 = new[] { 1, 2, 3, 5 };

            int[] nums5 = { 1, 2, 3, 5 };

            Console.WriteLine(nums5[0]); //Выведет 1
            Console.WriteLine(nums5[5]); //Будет ошибка IndexOutOfRangeException


            //Цикл foreach

            //foreach (тип_данных название_переменной in контейнер)
            //{
            //    // действия
            //}

            
            int[] numbersTest = new int[] { 1, 2, 3, 4, 5 };
            foreach (int i in numbersTest)
            {
                Console.WriteLine(i); //Выведет все элементы, перебирая их 
            }
            for (int i = 0; i < numbersTest.Length; i++)
            {
                Console.WriteLine(numbersTest[i]);//Выведет все элементы, обращаясь по индексу
            }

            //Многомерные массивы 

            //Одномерный массив
            //тип_переменной[,] название_массива;
            int[,] matrix = { { 0, 1, 2 }, { 3, 4, 5 } };


            //Способы объявления двумерного массива
            int[,] matrix1;
            int[,] matrix2 = new int[2, 3];
            int[,] matrix3 = new int[2, 3] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] matrix4 = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] matrix5 = new[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            int[,] matrix6 = { { 0, 1, 2 }, { 3, 4, 5 } };


            //Многомерные массивы 
            int[,,] complexStuff = new int[2, 3, 4];


            //Ступенчатые массивы
            int[][] gearMatrix = new int[3][];
            gearMatrix[0] = new int[2] { 1, 2 };          // выделяем память для первого подмассива
            gearMatrix[1] = new int[3] { 1, 2, 3 };       // выделяем память для второго подмассива
            gearMatrix[2] = new int[5] { 1, 2, 3, 4, 5 }; // выделяем память для третьего подмассива


            //Перебор массивов

            //Перебор двумерного массива
            int[,] mas = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };

            int rows = mas.GetUpperBound(0) + 1;
            int columns = mas.Length / rows;
            // или так
            // int columns = mas.GetUpperBound(1) + 1;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }

            //Перебор зубачтого массива
            int[][] numbersTest2 = new int[3][];
            numbersTest2[0] = new int[] { 1, 2 };
            numbersTest2[1] = new int[] { 1, 2, 3 };
            numbersTest2[2] = new int[] { 1, 2, 3, 4, 5 };
            foreach (int[] row in numbersTest2)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }

            // перебор с помощью цикла for
            for (int i = 0; i < numbersTest2.Length; i++)
            {
                for (int j = 0; j < numbersTest2[i].Length; j++)
                {
                    Console.Write($"{numbersTest2[i][j]} \t");
                }
                Console.WriteLine();
            }

            //Класс Array

            int[] arrayExample = { -4, 5, -2, -1, -5, 1, 1, 3, 2 };

            // Расположение в обратном порядке
            Array.Reverse(arrayExample);

            foreach (int number in arrayExample)
            {
                Console.Write($"{number} \t");
            }
         
            // Сортирует элементы
            Array.Sort(arrayExample);
            foreach (int number in arrayExample)
            {
                Console.Write($"{number} \t");
            }

            // Очищает массив, устанавливая для всех его элементов значение по умолчанию
            Array.Clear(arrayExample,2,2);
            foreach (int number in arrayExample)
            {
                Console.Write($"{number} \t");
            }
        }

    }
}
