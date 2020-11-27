using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Generics
    {
        class Account<T>
        {
            public T Id { get; set; }
            public int Sum { get; set; }
        }

        class Transaction<U, V> 
        {
            public U FromAccount { get; set; }  // с какого счета перевод
            public U ToAccount { get; set; }    // на какой счет перевод
            public V Code { get; set; }         // код операции
            public int Sum { get; set; }  
            
        }

        public static void Swap<T>(ref T x, ref T y)
        { 
            
            T temp = x;
            var a = temp;
            x = y;
            y = temp;
        }

  

        private static void Main(string[] args)
        {
            int x = 7;
            int y = 25;
            Swap<int>(ref x, ref y); // или так Swap(ref x, ref y);
            Console.WriteLine($"x={x}    y={y}");   // x=25   y=7

            string s1 = "hello";
            string s2 = "bye";
            Swap<string>(ref s1, ref s2); // или так Swap(ref s1, ref s2);
            Console.WriteLine($"s1={s1}    s2={s2}"); // s1=bye   s2=hello

            Console.Read();
        }
    }
}
