using System;
using System.Collections.Generic;

namespace Assignment_3
{
    /*
     
                                            4.
    Инициализирайте масив от 10 работника и ги сортирайте по заплата в намаляващ ред. 
     
    */
    class Program
    {
        static void Main(string[] args)
        {
            List<Worker> students = new List<Worker>
            {
                new Worker("Angel", 1200), new Worker("Alexandra", 1200),
                new Worker("Niki", 1200), new Worker("Ivan", 4200),
                new Worker("Petar", 5600), new Worker("Alexandur", 720),
                new Worker("Maria", 3100), new Worker("Georgy", 3800),
                new Worker("Ivalina", 650), new Worker("Kamen", 1200)
            };

            Worker_SortBySalaryByDescendingOrder eDsc = new Worker_SortBySalaryByDescendingOrder(); 
            students.Sort(eDsc);

            students.ForEach(Student => Console.WriteLine(Student.Salary));
        }
    }
}
