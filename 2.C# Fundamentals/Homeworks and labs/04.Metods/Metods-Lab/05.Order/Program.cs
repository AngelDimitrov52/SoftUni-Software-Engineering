using System;

namespace _05.Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string produt = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            PrintPrice(produt, quantity);





        }

        private static void PrintPrice(string produt, int quantity)
        {
            double price = 0.0;
            if (produt == "coffee")
            {
                price = 1.50;
            }
            else if (produt == "water")
            {
                price = 1.00;
            }
            else if (produt == "coke")
            {
                price = 1.40;
            }
            else if (produt == "snacks")
            {
                price = 2.00;
            }
            Console.WriteLine($"{price*quantity:f2}");
        }
    }
}
