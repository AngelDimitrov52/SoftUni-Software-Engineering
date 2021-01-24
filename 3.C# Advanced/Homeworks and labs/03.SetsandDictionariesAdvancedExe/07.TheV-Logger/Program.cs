using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> vloggers =
                new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, HashSet<string>> vloggersFollowers =
                new Dictionary<string, HashSet<string>>();

            string comand;
            while ((comand = Console.ReadLine()) != "Statistics")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (comandArgs.Length > 3)
                {
                    if (!vloggers.ContainsKey(comandArgs[0]))
                    {

                        vloggers.Add(comandArgs[0], new Dictionary<string, int>());
                        vloggers[comandArgs[0]].Add("followers", 0);
                        vloggers[comandArgs[0]].Add("followings", 0);

                        vloggersFollowers.Add(comandArgs[0], new HashSet<string>());
                    }
                }
                else
                {
                    if (vloggers.ContainsKey(comandArgs[0]) && vloggers.ContainsKey(comandArgs[2]))
                    {
                        if (comandArgs[0] != comandArgs[2])
                        {
                            if (!vloggersFollowers[comandArgs[2]].Contains(comandArgs[0]))
                            {

                                vloggers[comandArgs[2]]["followers"]++;
                                vloggers[comandArgs[0]]["followings"]++;

                                vloggersFollowers[comandArgs[2]].Add(comandArgs[0]);
                            }
                        }
                    }
                }
            }

            int counter = 0;
            Console.WriteLine($"The V-Logger has a total of {vloggersFollowers.Count} vloggers in its logs.");
            foreach (var item in vloggers.OrderByDescending(x => x.Value["followers"])
                .ThenBy(x => x.Value["followings"]))
            {
                counter++;
                Console.WriteLine($"{counter}. {item.Key} : {item.Value["followers"]} followers," +
                    $" {item.Value["followings"]} following");

                if (counter == 1)
                {
                    foreach (var hash in vloggersFollowers[item.Key].OrderBy(x => x))
                    {
                        Console.WriteLine($"*  {hash}");
                    }
                }

            }

        }
    }
}
