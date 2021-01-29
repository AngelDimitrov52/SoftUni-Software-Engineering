using System;
using System.Linq;

namespace _02.KnightsOfHonor
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string> func = n => $"Sir {n}";

            string[] names = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(func)
                 .ToArray();

            Action<string[]> print = n => Console.WriteLine(string.Join(Environment.NewLine, n));
            print(names);
        }
    }
}
