using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Collections
    {
        void Test()
        {
            ArrayList list = new ArrayList();
            list.Add(2.3); // заносим в список объект типа double
            list.Add(55); // заносим в список объект типа int
            list.AddRange(new string[] { "Hello", "world" }); // заносим в список строковый массив
                                                              // перебор значений
            foreach (object o in list)
            {
                Console.WriteLine(o);
            }

            // удаляем первый элемент
            list.RemoveAt(0);
            // переворачиваем список
            list.Reverse();
            // получение элемента по индексу
            Console.WriteLine(list[0]);
            // перебор значений
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadLine();





            List<int> numbers = new List<int>() { 1, 2, 3, 45 };
            numbers.Add(6); // добавление элемента

            numbers.AddRange(new int[] { 7, 8, 9 });

            numbers.Insert(0, 666); // вставляем на первое место в списке число 666

            numbers.RemoveAt(1); //  удаляем второй элемент

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            List<Collections> cols = new List<Collections>(3);
            cols.Add(new Collections() {});
            cols.Add(new Collections() {});
            cols.Add(new Collections() {});


        }
    }
}
