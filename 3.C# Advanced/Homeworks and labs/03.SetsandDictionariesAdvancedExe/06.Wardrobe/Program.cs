using System;
using System.Collections.Generic;

namespace _06.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Dictionary<string, int>> clothes =
                new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split(new string[] { " -> " , ","} 
                , StringSplitOptions.RemoveEmptyEntries);
                string color = comand[0];
                if (!clothes.ContainsKey(color))
                {
                    clothes.Add(color, new Dictionary<string, int>());
                }
                for (int j = 1; j < comand.Length; j++)
                {
                    if (!clothes[color].ContainsKey(comand[j]))
                    {
                        clothes[color].Add(comand[j], 0);
                    }
                    clothes[color][comand[j]]++;
                }
            }
            string[] find = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string findColor = find[0];
            string findDres = find[1];

            foreach (var colors in clothes)
            {
                Console.WriteLine($"{colors.Key} clothes:");

                foreach (var item in colors.Value)
                {
                    Console.Write($"* {item.Key} - {item.Value}");
                    if (findColor == colors.Key && findDres == item.Key)
                    {
                        Console.Write($" (found!)");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
