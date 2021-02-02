using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] peoples = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Person people = new Person();
                people.Name = peoples[0];
                people.Age = int.Parse(peoples[1]);

                family.AddMember(people);
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age );
        }
    }
}
