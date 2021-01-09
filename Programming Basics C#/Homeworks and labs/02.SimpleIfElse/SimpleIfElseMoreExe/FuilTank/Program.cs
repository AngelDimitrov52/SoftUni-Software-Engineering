using System;

namespace FuilTank
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());

            if (fuel == "Diesel")
                
            {
                fuel = "diesel";
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else if (fuel == "Gasoline")
                
            {
                fuel = "gasoline";
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else if (fuel == "Gas")
            {
                fuel = "gas";
                if (liters >= 25)
                {
                    Console.WriteLine($"You have enough {fuel}.");
                }
                else
                {
                    Console.WriteLine($"Fill your tank with {fuel}!");
                }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
