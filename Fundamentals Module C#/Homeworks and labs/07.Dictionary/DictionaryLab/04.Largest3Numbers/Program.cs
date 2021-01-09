using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> sortList = numList.OrderByDescending(n => n).ToList();

            for (int i = 0; i < 3; i++)
            {
                if (i == sortList.Count )
                {
                    break;
                }
                Console.Write($"{sortList[i]} ");
            }





        }
    }
}
