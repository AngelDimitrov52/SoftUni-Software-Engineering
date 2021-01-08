using System;


namespace SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string produkt = Console.ReadLine();
            string town = Console.ReadLine();
            double kg = double.Parse(Console.ReadLine());

            double price = 0.0;
            
            switch (town)
            {
                case "Sofia":
                    if (produkt == "coffee")
                    {
                        price = 0.50;
                    }
                    else if (produkt == "water")
                    {
                        price = 0.80;
                    }
                    else if (produkt == "beer")
                    {
                        price = 1.20;
                    }
                    else if (produkt == "sweets")
                    {
                        price = 1.45;
                    }
                    else if (produkt == "peanuts")
                    {
                        price = 1.60;
                    }

                    break;
                case "Plovdiv":
                    if (produkt == "coffee")
                    {
                        price = 0.40;
                    }
                    else if (produkt == "water")
                    {
                        price = 0.70;
                    }
                    else if (produkt == "beer")
                    {
                        price = 1.15;
                    }
                    else if (produkt == "sweets")
                    {
                        price = 1.3;
                    }
                    else if (produkt == "peanuts")
                    {
                        price = 1.50;
                    }

                    break;
                case "Varna":
                    if (produkt == "coffee")
                    {
                        price = 0.45;
                    }
                    else if (produkt == "water")
                    {
                        price = 0.70;
                    }
                    else if (produkt == "beer")
                    {
                        price = 1.10;
                    }
                    else if (produkt == "sweets")
                    {
                        price = 1.35;
                    }
                    else if (produkt == "peanuts")
                    {
                        price = 1.55;
                    }

                    break;
            }
            double total = price * kg;
            Console.WriteLine(total);
                
        }
    }
}
