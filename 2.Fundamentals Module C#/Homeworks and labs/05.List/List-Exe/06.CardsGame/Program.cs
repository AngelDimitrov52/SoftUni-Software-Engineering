using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();
            List<int> secondList = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            while (firstList.Count != 0 && secondList.Count != 0)
            {
                if (firstList[0] > secondList[0])
                {
                    int firstnumber = firstList[0];
                    int secondNum = secondList[0];
                    firstList.Add(firstnumber);
                    firstList.Add(secondNum);


                }
                else if (secondList[0] > firstList[0])
                {
                    int firstnumber = secondList[0];
                    int secondNum = firstList[0];
                    secondList.Add(firstnumber);
                    secondList.Add(secondNum);


                }
                firstList.RemoveAt(0);
                secondList.RemoveAt(0);

            }

            if (firstList.Sum() == 0)
            {
                Console.WriteLine($"Second player wins! Sum: {secondList.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstList.Sum()}");
            }

        }
    }
}
