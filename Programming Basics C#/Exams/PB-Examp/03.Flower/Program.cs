using System;

namespace _03.Flower
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int numFlower = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            //            Season    Sunflower   Daisy Lavender    Mint
            //             Spring     10          12     12       10
            //             Summer      8          8       8       12
            //             Autumn      12         6       6      6
            int num = 0;
            if (season == "Spring")
            {
                switch (flower)
                {
                    case "Sunflower":
                        num = 10;
                        break;
                    case "Daisy":
                        num = 12;
                        break;
                    case "Lavender":
                        num = 12;
                        break;
                    case "Mint":
                        num = 10;
                        break;
                }
            }
            else if (season == "Summer")
            {
                switch (flower)
                {
                    case "Sunflower":
                        num = 8;
                        break;
                    case "Daisy":
                        num = 8;
                        break;
                    case "Lavender":
                        num = 8;
                        break;
                    case "Mint":
                        num = 12;
                        break;
                }
            }
            else if (season == "Autumn")
            {
                switch (flower)
                {
                    case "Sunflower":
                        num = 12;
                        break;
                    case "Daisy":
                        num = 6;
                        break;
                    case "Lavender":
                        num = 6;
                        break;
                    case "Mint":
                        num = 6;
                        break;
                }
            }

            double totalSum = numFlower * num;

            if (season == "Summer")
            {
                totalSum *= 1.10;
            }
            else if (season =="Autumn")
            {
                totalSum *= 0.95;
            }
            else if (season == "Spring")
            {
                if (flower == "Daisy" || flower == "Mint")
                {
                    totalSum *= 1.10;
                }
            }

            Console.WriteLine($"Total honey harvested: {totalSum:f2}");
        }
    }
}
