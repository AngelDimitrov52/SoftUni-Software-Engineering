using System;
using System.Linq;

namespace _09.ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Func<int, int, bool> func = (i, number) => i % number == 0;

            for (int i = 1; i <= n; i++)
            {
                if (numbers.All(d => func(i ,d)))
                {
                    Console.Write(i +" ");
                }
    
            }
        }
    }
}
