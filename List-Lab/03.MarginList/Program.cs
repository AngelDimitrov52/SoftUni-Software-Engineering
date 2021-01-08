using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MarginList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> secondList = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> resultList = new List<string>();

            int n = 0;

            if (firstList.Count >= secondList.Count)
            {
                n = firstList.Count;
            }
            else
            {
                n = secondList.Count;
            }

            for (int i = 0; i < n; i++)
            {
                if (i < firstList.Count)
                {
                    resultList.Add(firstList[i]);
                }
                if (i < secondList.Count)
                {
                resultList.Add(secondList[i]);

                }
            }

            Console.WriteLine(string.Join(" ", resultList));
        }
    }
}
