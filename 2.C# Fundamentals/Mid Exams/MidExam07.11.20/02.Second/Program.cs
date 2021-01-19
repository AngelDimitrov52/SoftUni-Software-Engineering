using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Second
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sukrovishteList = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList(); ;

            string comand;
            while ((comand = Console.ReadLine()) != "Yohoho!")
            {
                string[] camandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string firstComand = camandArgs[0];

                if (firstComand == "Loot")
                {
                    for (int i = 1; i <= camandArgs.Length - 1; i++)
                    {
                        bool IsIn = sukrovishteList.Contains(camandArgs[i]);

                        if (!IsIn)
                        {
                            sukrovishteList.Insert(0, camandArgs[i]);
                        }
                    }
                }
                else if (firstComand == "Drop")
                {
                    int index = int.Parse(camandArgs[1]);
                    if (index >= 0 && index < sukrovishteList.Count)
                    {
                        string element = sukrovishteList[index];
                        sukrovishteList.RemoveAt(index);
                        sukrovishteList.Add(element);
                    }
                }
                else if (firstComand == "Steal")
                {
                    int index = Math.Abs(int.Parse(camandArgs[1]));
                  
                    if (index > sukrovishteList.Count - 1)
                    {
                        Console.WriteLine(string.Join(", ", sukrovishteList));
                        sukrovishteList.RemoveRange(0, sukrovishteList.Count);
                    }
                  
                    else
                    {
                        int secndex = (sukrovishteList.Count - 1) - index;
                        List<string> listad = new List<string>();
                        for (int i = secndex + 1; i < sukrovishteList.Count; i++)
                        {
                            
                            listad.Add(sukrovishteList[i]);

                        }
                        Console.WriteLine(string.Join(", ", listad));
                        sukrovishteList.RemoveRange(secndex + 1, index);
                    }

                }

            }
            if (sukrovishteList.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                double sum = 0.0;
                for (int i = 0; i < sukrovishteList.Count; i++)
                {
                    sum += sukrovishteList[i].Length;
                }
                double avarage = (sum * 1.0) / sukrovishteList.Count;
                Console.WriteLine($"Average treasure gain: {avarage:f2} pirate credits.");
            }





        }
    }
}
