using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToList();
            int count = numbers.Count;
            for (int i = 0; i < count /2 ; i++)
            {
                numbers[i] += numbers[numbers.Count-1];
                numbers.RemoveAt(numbers.Count -1);
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
