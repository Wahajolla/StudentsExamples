using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Inheretance
    {

        static void Main(string[] args)
        {
            Student student = new Student ("Blab");
            student.Display();
            student = new HighStudent { Name = "Bleb" };
            student.Display();
            student = new GraduatedStudent { Name = "Blob", JobTitle = "DevOps" };
            Console.Read();
        }

    }

    class Student
    {

        public string _id { get; set; }
        public string Id;
        private string _name;
   
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void Display()
        {
            Console.WriteLine(Name);
        }

        public string DisplatToConsole()
        {
            return _id + Name;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public Student(string name)
        {
            _name = name;
        }
    }

    class HighStudent : Student
    {
        private string _jobTitle;

        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public HighStudent(string name, string JobTitle)
        : base(name)
        {
            _jobTitle = JobTitle;
        }
    }

    sealed class GraduatedStudent : HighStudent
    {
        private string _diplomaTitle;
        public string Diploma
        {
            get { return _diplomaTitle; }
            set { _diplomaTitle = value; }
        }

        public string LastJob
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }
        }

        public string LastJobCorrect
        {
            get { return JobTitle; }
            set { JobTitle = value; }
        }
    }

    class StudentIO
    {
        public List<Student> students;
        
        public void Read()
        {

            Student newStudent = new Student();
            students.Add()

        }

        public void Write()
        {
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
