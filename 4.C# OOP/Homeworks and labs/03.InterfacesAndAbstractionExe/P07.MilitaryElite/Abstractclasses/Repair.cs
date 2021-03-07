using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Abstractclasses
{
    public class Repair
    {
        public Repair( string name , int hours)
        {
            Name = name;
            Hours = hours;

        }
        public string Name { get; private set; }
        public int Hours { get; private set; }

        public override string ToString()
        {
            return $"Part Name: {Name} Hours Worked: {Hours}";     
        }

    }
}
