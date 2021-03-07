using P07.MilitaryElite.Abstractclasses;
using P07.MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Classes
{
    class Spy : Soldier, IcodeNumber
    {
        public Spy(string id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            CodeNumber = codeNumber;
        }
        public int CodeNumber { get; private set; }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id}" + Environment.NewLine +
                    $"Code Number: {CodeNumber}";

        }
    }
}
