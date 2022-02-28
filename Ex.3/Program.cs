using System;
using System.Collections.Generic;

namespace Assignment_2
{
    /*
    
                                        3. 
    Инициализирайте масив от 10 студента и ги сортирайте по оценка в нарастващ ред.
    Използвайте интерфейса System.IComparable.

    */
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Angel", 5), new Student("Alexandra", 3),
                new Student("Niki", 6), new Student("Ivan", 4),
                new Student("Petar", 6), new Student("Alexandur", 5),
                new Student("Maria", 6), new Student("Georgy", 6),
                new Student("Ivalina", 3), new Student("Kamen", 4)
            };
            students.Sort();
            students.ForEach(Student => Console.WriteLine(Student.Grade));
        }
    }
}
