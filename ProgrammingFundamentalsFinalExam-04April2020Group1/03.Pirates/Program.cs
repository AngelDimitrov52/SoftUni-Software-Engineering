using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cityDic = new Dictionary<string, List<int>>();
            string comand;
            while ((comand = Console.ReadLine()) != "Sail")
            {
                string[] comandArgs = comand.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string cityName = comandArgs[0];
                int population = int.Parse(comandArgs[1]);
                int gold = int.Parse(comandArgs[2]);

                List<int> PopAndGold = new List<int>();

                if (!cityDic.ContainsKey(cityName))
                {
                    PopAndGold.Add(population);
                    PopAndGold.Add(gold);
                    cityDic.Add(cityName, PopAndGold);
                }
                else
                {
                    cityDic[cityName][0] += population;
                    cityDic[cityName][1] += gold;
                }
            }
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string cityName = comandArgs[1];
                if (cmd == "Plunder")
                {
                    int killPeople = int.Parse(comandArgs[2]);
                    int killGold = int.Parse(comandArgs[3]);

                    cityDic[cityName][0] -= killPeople;
                    cityDic[cityName][1] -= killGold;

                    Console.WriteLine($"{cityName} plundered!" +
                        $" {killGold} gold stolen, {killPeople} citizens killed.");

                    if (cityDic[cityName][0] <= 0 || cityDic[cityName][1] <= 0)
                    {
                        Console.WriteLine($"{cityName} has been wiped off the map!");
                        cityDic.Remove(cityName);
                    }

                }
                else if (cmd == "Prosper")
                {
                    int upGold = int.Parse(comandArgs[2]);
                    if (upGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cityDic[cityName][1] += upGold;
                        int totalGold = cityDic[cityName][1];
                        Console.WriteLine($"{upGold} gold added to the city treasury." +
                            $" {cityName} now has {totalGold} gold.");
                    }
                }
            }

            Console.WriteLine($"Ahoy, Captain! There are {cityDic.Count} wealthy settlements to go to:");

            foreach (var item in cityDic.OrderByDescending(x=>x.Value[1]).ThenBy(k=>k.Key))
            { 
                if (cityDic.Count == 0)
                {
                    Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
                }
                else
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value[0]} citizens, Gold: {item.Value[1]} kg");
                }
            }
        }

    }
}
