using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shop =
                new Dictionary<string, Dictionary<string, double>>();

            string comand;
            while ((comand = Console.ReadLine()) != "Revision")
            {
                string[] comandArgs = comand.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string city = comandArgs[0];
                string product = comandArgs[1];
                double price = double.Parse(comandArgs[2]);

                if (!shop.ContainsKey(city))
                {
                    shop.Add(city, new Dictionary<string, double>());
                }
                shop[city].Add(product, price);
            }
            foreach (var city in shop.OrderBy(k => k.Key))
            {
                Console.WriteLine(city.Key + "->");

                foreach (var item in city.Value)
                {
                    Console.WriteLine($"Product: {item.Key}, Price: {item.Value}");
                }
            }
        }
    }
}
