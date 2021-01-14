using System;
using System.Collections.Generic;

namespace _07.HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startPersons = Console.ReadLine().Split();
            Queue<string> person = new Queue<string>(startPersons);

            int n = int.Parse(Console.ReadLine());
            int count = 0;

            while (person.Count > 1)
            {
                count++;

                string kid = person.Dequeue();

                if (count == n)
                {
                    count = 0;
                    Console.WriteLine($"Removed {kid}");
                }
                else
                {
                    person.Enqueue(kid);
                }
            }
            Console.WriteLine($"Last is {person.Dequeue()}");

        }
    }
}
