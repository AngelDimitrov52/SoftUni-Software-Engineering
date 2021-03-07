using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Abstractclasses
{
    public abstract class Soldier
    {
        public Soldier(string id, string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Id { get; private set; }
    }
}
