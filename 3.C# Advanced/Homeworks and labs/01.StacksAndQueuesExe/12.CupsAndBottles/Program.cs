using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.CupsAndBottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] quatityCups = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] quatityBottles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> cups = new Stack<int>(quatityCups.Reverse());
            Queue<int> bottles = new Queue<int>(quatityBottles.Reverse());
            int wastedWater = 0;

            while (cups.Any())
            {
                int firstCup = cups.Pop();
                int firstBottle = bottles.Dequeue();

                if (firstCup > firstBottle)
                {
                    firstCup -= firstBottle;
                    cups.Push(firstCup);
                }
                else
                {
                    firstBottle -= firstCup;
                    wastedWater += firstBottle;
                }
                if (bottles.Count == 0)
                {
                    break;
                }
            }
            if (cups.Count == 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ",bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ",cups)}");
            }
            Console.WriteLine($"Wasted litters of water: {wastedWater}");


        }
    }
}
