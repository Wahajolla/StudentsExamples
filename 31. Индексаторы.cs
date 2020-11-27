using System;
using System.Collections.Generic;
using System.Text;

namespace Примеры
{
    class Students
    {
        Student[] data;
        public Students()
        {
            data = new Student[5];
        }
        // индексатор
        public Student this[int index]
        {
            get
            {
                return data[index];
            }
            set
            {
                data[index] = value;
            }
        }
    }

    class Matrix
    {
        private int[,] numbers = new int[,] { { 1, 2, 4 }, { 2, 3, 6 }, { 3, 4, 8 } };
        public int this[int i, int j]
        {
            get
            {
                return numbers[i, j];
            }
            set
            {
                numbers[i, j] = value;
            }
        }
    }
}
