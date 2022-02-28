using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Assignment_3
{
    class Worker : IComparable<Worker>
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public Worker(string name, int salary)
        {
            Name = name;
            Salary = salary;
        }

        public int CompareTo(Worker other)
        {
            throw new NotImplementedException();
        }
    }

    class Worker_SortBySalaryByDescendingOrder : IComparer<Worker>
    {

            public int Compare(Worker x, Worker y)
            {
                if (x.Salary < y.Salary) 
                    return 1;

                else if (x.Salary > y.Salary) 
                    return -1;

                else 
                    return 0;
            }
    }
}
