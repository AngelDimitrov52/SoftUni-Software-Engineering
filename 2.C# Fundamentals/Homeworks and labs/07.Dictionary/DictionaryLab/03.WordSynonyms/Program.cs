using System;
using System.Collections.Generic;

namespace _03.WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> elementsDic = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();

                List<string> ValueList = new List<string>();

                if (!elementsDic.ContainsKey(key))
                { 
                    elementsDic.Add(key, new List<string>());    
                }
               
                elementsDic[key].Add(value);

            }

            foreach (var item in elementsDic)
            {
                Console.WriteLine($"{item.Key} - {string.Join(", ", item.Value)}");
            }
        }
    }
}
