using System;

namespace VegetableExchange
{
    class Program
    {
        static void Main(string[] args)
        {
            double vegetablePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            double vegetableNumber = double.Parse(Console.ReadLine());
            double fruitNumber = double.Parse(Console.ReadLine());

            double bill = (vegetableNumber * vegetablePrice + fruitNumber * fruitPrice) / 1.94;



            Console.WriteLine($"{bill:f2}");
        }
    }
}
