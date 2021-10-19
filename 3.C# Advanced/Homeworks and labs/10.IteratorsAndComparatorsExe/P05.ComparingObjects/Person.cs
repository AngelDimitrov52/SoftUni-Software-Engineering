using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace P05.ComparingObjects
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            Name = name;
            Age = age;
            Town = town;
        }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(Person obj)
        {
            if (Name.CompareTo(obj.Name) == 0)
            {
                if (Age.CompareTo(obj.Age) == 0)
                {
                   return Town.CompareTo(obj.Town);
                }
                return Age.CompareTo(obj.Age);
            }
            return Name.CompareTo(obj.Name);
        }

    }
}
