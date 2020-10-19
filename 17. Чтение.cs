using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Примеры
{
    class ReadWrite
    {
        static void Main(string[] args)
        {
            string writePath = @"C:\Dir\hta.txt";
           string writePath = Directory.GetCurrentDirectory();

            string text = "Привет мир!\nПока мир...";
            try
            {
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
                string[] strings = File.ReadAllLines(writePath); //Другой способ

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
