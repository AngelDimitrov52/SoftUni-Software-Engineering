using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, List<string>>> continents =
                new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                string[] comandArgs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = comandArgs[0];
                string countrie = comandArgs[1];
                string citi = comandArgs[2];

                if (!continents.ContainsKey(continent))
                {
                    continents.Add(continent, new Dictionary<string, List<string>>());

                }
                if (!continents[continent].ContainsKey(countrie))
                {
                    continents[continent].Add(countrie, new List<string>());
                }
                continents[continent][countrie].Add(citi);
            }

            foreach (var continenta in continents)
            {
                Console.WriteLine($"{continenta.Key}:");

                foreach (var countrie in continenta.Value)
                {
                    Console.WriteLine($"{countrie.Key} -> {string.Join(", ", countrie.Value)}");
                }
            }

        }
    }
}

