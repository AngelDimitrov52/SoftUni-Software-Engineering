using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOfProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> products = new List<string>(n);

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                products.Add(text);
            }
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
                
        }
    }
}
