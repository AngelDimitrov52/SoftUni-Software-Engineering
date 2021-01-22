using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            Dictionary<double, int> count = new Dictionary<double, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!count.ContainsKey(nums[i]))
                {
                    count.Add(nums[i],0);
                }
                count[nums[i]]++;
            }
            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
