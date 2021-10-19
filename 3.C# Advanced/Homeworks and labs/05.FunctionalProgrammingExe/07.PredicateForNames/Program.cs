using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Func<string, int, bool> func =
                (name, lenght) => name.Length <= lenght;
            List<string> filter = names.Where((name) => func(name,n)).ToList();

            Action<List<string>> printer = lis =>
            Console.WriteLine(string.Join(Environment.NewLine, lis));

            printer(filter);

        }
    }
}
