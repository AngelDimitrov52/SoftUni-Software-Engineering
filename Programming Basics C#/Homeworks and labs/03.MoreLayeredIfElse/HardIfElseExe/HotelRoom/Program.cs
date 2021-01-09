using System;

namespace HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            double nights = double.Parse(Console.ReadLine());

            double priceApart = 0.0;
            double priceStudio = 0.0;

            if (mount == "May" || mount == "October")
            {
                priceStudio = 50.0;
                priceApart = 65.0;
                if (nights > 7 && nights <= 14)
                {
                    priceStudio *= 0.95;
                }
                else if (nights > 14)
                {
                    priceStudio *= 0.7;
                }
            }
            else if (mount == "June" || mount == "September")
            {
                priceStudio = 75.20;
                priceApart = 68.70;
                if (nights > 14)
                {
                    priceStudio *= 0.8;
                }
            }
            else if (mount == "July" || mount == "August")
            {
                priceStudio = 76.0;
                priceApart = 77.0;
            }
            if (nights >14)
            {
                priceApart *= 0.9;
            }
            double totalApart = nights * priceApart;
            double totalStudio = nights * priceStudio;

            Console.WriteLine($"Apartment: {totalApart:f2} lv.");
            Console.WriteLine($"Studio: {totalStudio:f2} lv.");
        }
    }
}
