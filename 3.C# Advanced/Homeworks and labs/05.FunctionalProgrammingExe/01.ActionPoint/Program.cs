using System;

namespace _01.ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Action<string[]> print = n => Console.WriteLine(string.Join(
                Environment.NewLine, n));

            print(names);

        }
    }
}
