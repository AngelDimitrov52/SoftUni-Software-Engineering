using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Abstractclasses
{
    public abstract class Corps : Soldier, ISalarys
    {
        private string corpsName;
        public Corps(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName)
        {
            Salary = salary;
            CorpsName = corps;
        }
        public decimal Salary { get; private set; }

        public string CorpsName
        {
            get => corpsName;
            set
            {
                if (value == "Airforces")
                {
                    corpsName = value;
                }
                else if (value == "Marines")
                {
                    corpsName = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Corp");
                }
            }
        }
    }
}
