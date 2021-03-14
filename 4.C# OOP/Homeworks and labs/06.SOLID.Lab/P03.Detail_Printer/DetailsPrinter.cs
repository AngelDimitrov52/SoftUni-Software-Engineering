using System;
using System.Collections.Generic;
using System.Text;

namespace P03.DetailPrinter
{
    public class DetailsPrinter
    {
        private IList<IPersons> employees;

        public DetailsPrinter(IList<IPersons> employees)
        {
            this.employees = employees;
        }

        public void PrintDetails()
        {
            foreach (Employee employee in this.employees)
            {
                employee.Print();
            }
        }
    }
}
