
using P07.MilitaryElite.Abstractclasses;

namespace P07.MilitaryElite.Classes
{
    public class Private : Soldier, ISalarys
    {
        public Private(string id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName)
        {
            Salary = salary;
        }
        public decimal Salary { get; private set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:F2}";
        }
    }
}
