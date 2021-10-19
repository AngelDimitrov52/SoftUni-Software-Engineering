
using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class Employee : IPersons
    {
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; set; }
        public virtual void Print()
        {
            Console.WriteLine($"Employee name - " + Name);
            Console.WriteLine();
        }


    }
}
