using System;
using System.Collections.Generic;

namespace P03.DetailPrinter
{
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Angel");
            Manager manager = new Manager("Dany", new List<string>() { "File", "Data", "Web" });



            DetailsPrinter detailsPrinter = new DetailsPrinter(new List<IPersons>() { employee, manager });
            detailsPrinter.PrintDetails();
        }
    }
}
