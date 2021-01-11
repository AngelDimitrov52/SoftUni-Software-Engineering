using System;
using System.Linq;

namespace _02.TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            int[] peopleArr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool full = false;

            for (int i = 0; i < peopleArr.Length; i++)
            {
                while (true)
                {
                    if (i == peopleArr.Length - 1 && peopleArr[i] >= 4)
                    {
                        full = true;
                    }
                    if (peopleArr[i] >= 4)
                    {
                        break;
                    }
                    if (peopleCount == 0)
                    {
                        break;
                    }
                    peopleArr[i]++;
                    peopleCount--;
                }

            }
            if (full && peopleCount > 0)
            {
                Console.WriteLine($"There isn't enough space! {peopleCount} people in a queue!");
                Console.WriteLine(string.Join(" ", peopleArr));
            }
            else if (full && peopleCount == 0)
            {
                Console.WriteLine(string.Join(" ", peopleArr));
            }
            else
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(string.Join(" ", peopleArr));
            }
        }
    }
}
