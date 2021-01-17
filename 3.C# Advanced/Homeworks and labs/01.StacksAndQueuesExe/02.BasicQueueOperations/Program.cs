using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nums = Console.ReadLine().Split();
            int n = int.Parse(nums[0]);
            int s = int.Parse(nums[1]);
            int x = int.Parse(nums[2]);

            int[] addedNums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> playQueue = new Queue<int>(addedNums);

            for (int i = 0; i < s; i++)
            {
                playQueue.Dequeue();
            }

            if (playQueue.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (playQueue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(playQueue.Min());
            }
        }
    }
}
