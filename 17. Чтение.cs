using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Примеры
{
    interface Disposable
    {
        void Dispose();
    }
    class ReadWrite
    {
        static void Main(string[] args)
        {
            int a = 0;
            try
            {
                a = int.Parse(Console.ReadLine());

            }
            catch
            {
                Console.WriteLine("Ошибка");
            }

            bool check = int.TryParse(Console.ReadLine(), out a);
            if(check)
            {
                Console.WriteLine("Нет ошибки");
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            string writePath = @"hta.txt";
         string writePath = Directory.GetCurrentDirectory() + "1.txt";
            string text = "Привет мир!\nПока мир...";
            try
            {
                FileStream file = new FileStream(writePath, FileAccess.Read);
                StreamReader sr = new StreamReader(file);
                using (StreamWriter sw = new StreamWriter(writePath, false, System.Text.Encoding.Default))
                {
                    sw.WriteLine(text);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine("Запись!");
                }
                using (StreamReader sr = new StreamReader(writePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
                sr.Dispose();
                //1 2
                //3 4 5
                string[] strings = File.ReadAllLines(writePath); //Другой способ
                int[][] array = new int[strings.Length][];
                for (int i = 0; i < strings.Length; i++)
                {
                    string[] rawData = strings[i].Split(" ");
                    array[i] = new int[rawData.Length];
                    for (int j = 0; j< rawData.Length; i++)
                    {
                        array[i][j] = int.Parse(rawData[j]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
