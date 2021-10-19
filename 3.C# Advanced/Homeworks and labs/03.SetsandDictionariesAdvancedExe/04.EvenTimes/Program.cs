using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> numbers = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                int element = int.Parse(Console.ReadLine());

                if (!numbers.ContainsKey(element))
                {
                    numbers.Add(element, 0);
                }
                numbers[element]++;
            }

            var evenNum = numbers.First(v => v.Value % 2 == 0);
            Console.WriteLine(evenNum.Key);


        }
    }
}
