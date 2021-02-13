using System;
using System.Collections.Generic;

namespace P05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            string comand;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] comandArgs = comand.Split(" ");
                string name = comandArgs[0];
                int age = int.Parse(comandArgs[1]);
                string town = comandArgs[2];

                persons.Add(new Person(name, age, town));
            }
            int index = int.Parse(Console.ReadLine());

            Person curentPerson = persons[index - 1];

            int countOfMatches = 0;
            int numberOfNot = 0;

            for (int i = 0; i < persons.Count; i++)
            {
                if (curentPerson.CompareTo(persons[i]) == 0)
                {
                    countOfMatches++;
                }
                else
                {
                    numberOfNot++;
                }
            }

            if (countOfMatches == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{countOfMatches} {numberOfNot} {persons.Count}");
            }

        }
    }
}
