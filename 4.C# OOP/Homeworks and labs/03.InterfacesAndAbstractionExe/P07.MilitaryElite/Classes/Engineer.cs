using P07.MilitaryElite.Abstractclasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Classes
{
    class Engineer : Corps
    {
        private List<Repair> repairs;
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps)
           : base(id, firstName, lastName, salary, corps)
        {
            repairs = new List<Repair>();
        }
        public List<Repair> Repairs
        {
            get => repairs;
            set
            {
                repairs = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {CorpsName}");
            sb.AppendLine("Repairs:");
            foreach (var item in this.repairs)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().Trim();
        }
    }
}
