using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class Family
    {
        public Family()
        {
            Persons = new List<Person>();
        }

        public List<Person> Persons { get; set; }

        
        public void AddMember(Person member)
        {
            Persons.Add(member);
        }

        public List<Person> GetOldestMember()
        {
            return Persons.Where(n => n.Age > 30).OrderBy(n => n.Name).ToList();
        }
    }
}
