using P07.MilitaryElite.Abstractclasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Classes
{
    public class LieutenantGeneral : Private
    {
        private List<Private> idsPrivate;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary)
            : base(id ,firstName , lastName , salary)
        {
            idsPrivate = new List<Private>();
        }
        public List<Private> IdsPrivate
        {
            get => idsPrivate;
            set
            {
                idsPrivate = value;
            }
        }
        public override string ToString()
        {
             StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine("Privates:");
            foreach (var item in this.idsPrivate)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().Trim();
        }
    }
}
