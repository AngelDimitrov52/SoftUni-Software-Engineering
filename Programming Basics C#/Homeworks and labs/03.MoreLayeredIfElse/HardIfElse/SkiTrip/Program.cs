using System;

namespace SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            string room = Console.ReadLine();
            string ocenka = Console.ReadLine();

            double price = 0.0;

            if (room == "room for one person")
            {
                price = 18.00;
            }
            else if (room == "apartment")
            {
                price = 25.00;
                if (day<10)
                {
                    price = price * 0.70;
                }
                else if (day >15)
                {
                    price = price / 2;
                }
                else
                {
                    price = price * 0.65;
                }

            }
            else if (room == "president apartment")
            {
                price = 35.00;
                if (day < 10)
                {
                    price = price * 0.90;
                }
                else if (day > 15)
                {
                    price = price * 0.80;
                }
                else
                {
                    price = price * 0.85;
                }

            }
            double total = (day - 1) * price;
            if (ocenka == "positive")
            {
                total = total * 1.25;
            }
            else if (ocenka == "negative")
            {
                total = total * 0.90;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}
