using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Lootbox
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> firstLine = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Stack<int> secondLine  =new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            int totalSum = 0;

            while (true)
            {
                int first = firstLine.Peek();
                int last = secondLine.Pop();
                int sum = first + last;

                if (sum % 2 == 0)
                {
                    totalSum += sum;
                    firstLine.Dequeue();
                }
                else
                {
                    firstLine.Enqueue(last);    
                }
                if (firstLine.Count == 0)
                {
                    Console.WriteLine("First lootbox is empty");
                    break;
                }
                else if (secondLine.Count == 0)
                {
                    Console.WriteLine("Second lootbox is empty");
                    break;
                }
            }
            if (totalSum >= 100)
            {
                Console.WriteLine($"Your loot was epic! Value: {totalSum}");
            }
            else
            {
                Console.WriteLine($"Your loot was poor... Value: {totalSum}");
            }
        }
    }
}
