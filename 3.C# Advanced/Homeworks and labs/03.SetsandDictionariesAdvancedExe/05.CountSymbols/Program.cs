using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Dictionary<char, int> times = new Dictionary<char, int>();

            for (int i = 0; i < text.Length; i++)
            {
                if (!times.ContainsKey(text[i]))
                {
                    times.Add(text[i], 0);
                }
                times[text[i]]++;
            }
            foreach (var item in times.OrderBy(v => v.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value} time/s");
            }
        }
    }
}
