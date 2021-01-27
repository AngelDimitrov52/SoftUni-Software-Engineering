using System;
using System.Linq;

namespace _05.FilterByAge
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Person[] people = new Person[n];

            for (int i = 0; i < n; i++)
            {
                string[] dataPersons = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries);
                people[i] = new Person();
                people[i].Name = dataPersons[0];
                people[i].Age = int.Parse(dataPersons[1]);
            }

            string filter = Console.ReadLine();
            int filterAge = int.Parse(Console.ReadLine());
            string printFormat = Console.ReadLine();

            Func<Person, bool> filtering = GetFiltering(filter, filterAge);
            Action<Person> formater = GetFormater(printFormat);

            PrintPeople(people, filtering, formater);

        }

        private static void PrintPeople(Person[] dataPersons, Func<Person,
            bool> filtering, Action<Person> formater)
        {
            foreach (var person in dataPersons)
            {
                if (filtering(person))
                {
                    formater(person);
                }

            }
        }

        private static Action<Person> GetFormater(string printFormat)
        {
            switch (printFormat)
            {
                case "name":
                    return p => { Console.WriteLine($"{p.Name}"); };
                case "age":
                    return p => { Console.WriteLine($"{p.Age}"); };
                case "name age":
                    return p => { Console.WriteLine($"{p.Name} - {p.Age}"); };
                default:
                    return null;
            }
        }

        private static Func<Person, bool> GetFiltering(string filter, int filterAge)
        {
            switch (filter)
            {
                case "younger": return x => x.Age < filterAge;
                case "older": return x => x.Age >= filterAge;
                default:
                    return null;
            }
        }
    }
}
