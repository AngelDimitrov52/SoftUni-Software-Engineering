using System;

namespace _01.ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            double tottalPrice = 0;
            double priceNotTax = 0;
            double totaTax = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                if (comand == "special")
                {
                    totaTax = tottalPrice * 0.20;
                    tottalPrice += tottalPrice * 0.20;
                    tottalPrice -= tottalPrice * 0.10;
                    break;
                }
                else if (comand == "regular")
                {
                    totaTax = tottalPrice * 0.20;
                    tottalPrice += tottalPrice * 0.20;
                    break;
                }

                double price = double.Parse(comand);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                tottalPrice += price;
                priceNotTax = tottalPrice;
            }
            if (tottalPrice == 0)
            {
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {priceNotTax:f2}$");
                Console.WriteLine($"Taxes: {totaTax:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {tottalPrice:f2}$");
            }
        }

    }
}

