using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterials = new Dictionary<string, int>();
            keyMaterials.Add("fragments", 0);
            keyMaterials.Add("shards", 0);
            keyMaterials.Add("motes", 0);
            Dictionary<string, int> junkMaterials = new Dictionary<string, int>();

            bool flag = false;
            while (true)
            {
                string[] comandArgs = Console.ReadLine().Split();
                for (int i = 0; i < comandArgs.Length; i +=2)
                {
                    int value = int.Parse(comandArgs[i]);
                    string element = comandArgs[i + 1].ToLower();
                    if (element == "fragments")
                    {
                        keyMaterials["fragments"] += value;
                        if (keyMaterials["fragments"] >= 250)
                        {
                            keyMaterials["fragments"] -= 250;
                            Console.WriteLine("Valanyr obtained!");
                            flag = true;
                            break;
                        }
                    }
                    else if (element == "shards")
                    {
                        keyMaterials["shards"] += value;
                        if (keyMaterials["shards"] >= 250)
                        {
                            keyMaterials["shards"] -= 250;
                            Console.WriteLine("Shadowmourne obtained!");
                            flag = true;
                            break;
                        }
                    }
                    else if (element == "motes")
                    {
                        keyMaterials["motes"] += value;
                        if (keyMaterials["motes"] >= 250)
                        {
                            keyMaterials["motes"] -= 250;
                            Console.WriteLine("Dragonwrath obtained!");
                            flag = true;
                            break;
                        }
                    }
                    else
                    {
                        if (!junkMaterials.ContainsKey(element))
                        {
                            junkMaterials.Add(element, 0);
                        }
                        junkMaterials[element] += value;
                    }
                }
                if (flag)
                {
                    break;
                }
            }

            foreach (var item in keyMaterials.OrderByDescending(n => n.Value).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var item in junkMaterials.OrderBy(n=>n.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }





        }
    }
}
