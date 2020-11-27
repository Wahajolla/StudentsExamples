using System;
using System.Collections.Generic;
using System.IO;

namespace StudentsExamples
{
    //Объявление класса
    class Program
    {
        int someNumber;
        //Метод класса 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            EasyExample example = new EasyExample();
            EasyExample example32 = new EasyExample();
            EasyExample example3 = new EasyExample("sf");
            EasyExample example2 = new EasyExample {text = "fhdfh" };
            example2.Test();
            Console.WriteLine(example2.text);
           
        }

        void Test()
        {
            Console.WriteLine(someNumber);
        }
    }
    class IOContoller
    {
        List<Student> student = new List<Student>();
        string path;
        public IOContoller(string path)
        {
            this.path = path;
        }

        public void Input(List<Student> students)
        {
            using(StreamWriter sr = new StreamWriter(path))
            {
                foreach (var student in students)
                {
                    sr.WriteLine(student.ToRecord());
                }
                
            }
        }

        public List<Student> Output()
        {
            List<Student> newList = new List<Student>();
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while((line = sr.ReadLine())!=null)
                {
                    Student studnet = new Student(line);
                    newList.Add(studnet);
                }

            }
            return newList;
        }
    }
    class EasyExample
    {
        public string text = "TextExample";
        public void Test()
        {
            Console.WriteLine(text);
            Test2();
        }
        public void Test2()
        {
            Console.WriteLine(text);
        }
        public EasyExample()
        {
            text = "fsfdf";
        }

       
        public EasyExample(string text)
        {
            this.text = text;
        }

        public void Tes3t()
        {
            Student student = new Student();
            student.Score;
            int[] asd = new int[3];
        }
    }


    class Student
    {
        int id;
        public int idPub;
        string FIO;
        int score;


        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if(value < 100)
                {
                    score = value;
                }
            }
        }
        //1;ФИО;50
        public Student (string text)
        {
            string[] param = text.Split(" ");
          
        }

        public Student()
        {

        }

        public string ToRecord()
        {
            return id.ToString() + ";" + FIO + ";" + score.ToString();
        }
    }
}
