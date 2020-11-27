
using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    interface Work
    {
        void Work();
        
    }

    class NewStudent : System.Collections.IComparer
    {
        public int Compare(object x, object y)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }
    class Converting
    {
        static void Main(string[] args)
        {
            HighStudent student = new HighStudent("Tom", "Microsoft");
            Student mainInfoStudent = student;
            Console.WriteLine(mainInfoStudent.Name);
            Console.ReadKey();
            NewStudent student1 = new NewStudent();
            Student newStudent = new Student("Tom");
            HighStudent highStudent = newStudent;
            HighStudent highStudent = (HighStudent)newStudent;



            Student person = new Student("Tom");
            HighStudent emp = person as HighStudent;
            if (emp == null)
            {
                Console.WriteLine("Преобразование прошло неудачно");
            }
            else
            {
                Console.WriteLine(emp.JobTitle);
            }



            Student person = new Student("Tom");
            try
            {
                HighStudent emp = (HighStudent)person;
                Console.WriteLine(emp.JobTitle);
            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }



            Student person = new Student("Tom");
            if (person is HighStudent)
            {
                HighStudent emp = (HighStudent)person;
                Console.WriteLine(emp.JobTitle);
            }
            else
            {
                Console.WriteLine("Преобразование не допустимо");
            }
        }
    }
}
