using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ResersAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            int num = int.Parse(Console.ReadLine());
            numbers.Reverse();

            Func<int, int, bool> func = (del, number) => del % number != 0;

            numbers = numbers.Where(n=> func(n, num)).ToList();
            Console.WriteLine(string.Join(" ",numbers));
                
        }
    }
}
