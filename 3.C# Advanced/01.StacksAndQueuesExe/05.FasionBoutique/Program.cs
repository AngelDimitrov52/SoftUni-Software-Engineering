using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.FasionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quantity = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int max = int.Parse(Console.ReadLine());

            Stack<int> clouts = new Stack<int>(quantity);

            int counter = 1;
            int sum = 0;

            while (clouts.Any())
            {
                int dres = clouts.Peek();
                if (dres + sum > max)
                {
                    
                    sum = 0;
                    counter++;
                }
                else
                {
                    sum += dres;
                    clouts.Pop();
                }
            }
            Console.WriteLine(counter);
        }
    }
}
