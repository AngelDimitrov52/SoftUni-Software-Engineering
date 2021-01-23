using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SetsofElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nM = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            HashSet<int> hashSetN = new HashSet<int>();
            for (int i = 0; i < nM[0]; i++)
            {
                hashSetN.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> elemints = new HashSet<int>();
            for (int i = 0; i < nM[1]; i++)
            {
                    elemints.Add(int.Parse(Console.ReadLine()));  
            }

            Console.WriteLine(string.Join(" ", hashSetN.Intersect(elemints)));
        }
    }
}
