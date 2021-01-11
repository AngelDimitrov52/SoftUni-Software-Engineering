using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double holidayPrice = double.Parse(Console.ReadLine());
            int pazels = int.Parse(Console.ReadLine());
            int barbies = int.Parse(Console.ReadLine());
            int tediis = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int truks = int.Parse(Console.ReadLine());

            double total = pazels * 2.60 + barbies * 3 + tediis * 4.10 + minions * 8.20 + truks * 2;


            double num = pazels + barbies + tediis + minions + truks;
            if (num >= 50)
            {
                total *= (1 - 0.25);
            }
            
            double naem = total * (1- 0.10);
           
            if (holidayPrice > naem)
            {
                double a = holidayPrice - naem;
                Console.WriteLine($"Not enough money! {a:f2} lv needed.");
            }
           else 
            {
                double b = naem - holidayPrice;
                Console.WriteLine($"Yes! {b:f2} lv left.");
            }


        }
    }
}
