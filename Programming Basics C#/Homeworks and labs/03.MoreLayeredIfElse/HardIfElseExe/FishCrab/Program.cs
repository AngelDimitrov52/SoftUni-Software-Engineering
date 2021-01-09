using System;

namespace FishCrab
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double price = 0.0;

          
            switch (season)
            {
                case "Spring":
                    price = 3000;
                    if (number<=6)
                    {
                        price = price * 0.90;

                    }
                    else if (number >=7 && number <= 11)
                    {
                        price = price * 0.85;
                    }
                    else
                    {
                        price = price * 0.75;
                    }
                    if (number%2 ==0)
                    {
                        price = price * 0.95;
                    }

                break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    if (number <= 6)
                    {
                        price = price * 0.90;

                    }
                    else if (number >= 7 && number <= 11)
                    {
                        price = price * 0.85;
                    }
                    else
                    {
                        price = price * 0.75;
                    }
                    if (number % 2 == 0 && season == "Summer" )
                    {
                        price = price * 0.95;
                    }

                    break;
                case "Winter":
                    price = 2600;
                    if (number <= 6)
                    {
                        price = price * 0.90;

                    }
                    else if (number >= 7 && number <= 11)
                    {
                        price = price * 0.85;
                    }
                    else
                    {
                        price = price * 0.75;
                    }
                    if (number % 2 == 0)
                    {
                        price = price * 0.95;
                    }

                    break;

            }
            if (budget >= price)
            { double a = budget - price;
                Console.WriteLine($"Yes! You have {a:f2} leva left.");
            }
            else
            {
                double a = price - budget;
                Console.WriteLine($"Not enough money! You need {a:f2} leva.");
            }




        }
    }
}
