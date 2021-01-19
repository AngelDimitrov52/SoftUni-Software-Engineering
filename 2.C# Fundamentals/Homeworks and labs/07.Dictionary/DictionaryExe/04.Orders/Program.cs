using System;
using System.Collections.Generic;

namespace _04.Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> products = new Dictionary<string, List<double>>();

            string comand;
            while ((comand = Console.ReadLine()) != "buy")
            {
                string[] comandArgs = comand.Split();
                string productName = comandArgs[0];
                double productPrice = double.Parse(comandArgs[1]);
                double productQuantity = double.Parse(comandArgs[2]);

                List<double> priceAndQuantity = new List<double>() { productPrice, productQuantity};
                if (!products.ContainsKey(productName))
                {
                    products.Add(productName, priceAndQuantity);
                }
                else
                {
                    products[productName][0] = productPrice;
                    products[productName][1] += productQuantity;
                    
                }
            }

            foreach (var item in products)
            {
                double totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{item.Key} -> {totalPrice:f2}");
            }
        }
    }
}
