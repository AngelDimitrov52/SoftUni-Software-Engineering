using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mineDic = new Dictionary<string, int>(); 

            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());

                if (!mineDic.ContainsKey(resourse))
                {
                    mineDic.Add(resourse, 0);
                }
                mineDic[resourse] += quantity;

            }
            foreach (var item in mineDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
