using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> planst = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] coandArgs = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);

                string plantName = coandArgs[0];
                double rarity = double.Parse(coandArgs[1]);

                if (!planst.ContainsKey(plantName))
                {
                    planst.Add(plantName, new List<double> { rarity, 0, 0 });
                }
                else
                {
                    planst[plantName][0] += rarity;
                }
            }

            string comand;
            while ((comand = Console.ReadLine()) != "Exhibition")
            {
                char[] separators = new char[] { ':', '-', ' ' };
                string[] comandArgs = comand.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string cmd = comandArgs[0];
                string plant = comandArgs[1];

                if (!planst.ContainsKey(plant))
                {
                    Console.WriteLine("error");
                    continue;
                }
                if (cmd == "Rate")
                {
                    double rating = double.Parse(comandArgs[2]);
                    planst[plant][1] += rating;
                    planst[plant][2]++;
                }
                else if (cmd == "Update")
                {
                    double newRarity = double.Parse(comandArgs[2]);
                    planst[plant][0] = newRarity;
                }
                else if (cmd == "Reset")
                {
                    planst[plant][1] = 0;
                    planst[plant][2] = 0;
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            Console.WriteLine("Plants for the exhibition:");

            foreach (var item in planst.OrderByDescending(x => x.Value[0])
                .ThenByDescending(x => x.Value[1]/x.Value[2]))
            {
                if (item.Value[1] == 0)
                {
                    Console.WriteLine($"- { item.Key}; Rarity: { item.Value[0]}; Rating: 0.00");
                }
                else
                {
                    if (item.Value[2] == 0)
                    {
                        item.Value[2] = 1;
                    }
                    double sumAvr = item.Value[1] / item.Value[2];
                    Console.WriteLine($"- { item.Key}; Rarity: { item.Value[0]}; Rating: {sumAvr:f2}");
                }
            }
        }
    }
}
