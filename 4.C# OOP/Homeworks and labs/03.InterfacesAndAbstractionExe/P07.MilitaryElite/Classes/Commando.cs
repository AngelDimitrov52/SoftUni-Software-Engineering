using P07.MilitaryElite.Abstractclasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Classes
{
    public class Commando : Corps
    {
        private List<Mission> missions;
        public Commando(string id, string firstName, string lastName, decimal salary, string corps)
           : base(id, firstName, lastName, salary, corps)
        {
            missions = new List<Mission>();
        }
        public List<Mission> Missions
        {
            get => missions;
            set
            {
                missions = value;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}");
            sb.AppendLine($"Corps: {CorpsName}");
            sb.AppendLine("Missions:");
            foreach (var item in this.missions)
            {
                sb.AppendLine($"  {item}");
            }
            return sb.ToString().Trim();
        }
    }
}
