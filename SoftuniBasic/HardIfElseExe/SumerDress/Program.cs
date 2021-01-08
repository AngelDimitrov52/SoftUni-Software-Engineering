using System;

namespace SumerDress
{
    class Program
    {
        static void Main(string[] args)
        {
            int digreas = int.Parse(Console.ReadLine());
            string day = Console.ReadLine();

            string dress = "";
            string shoes = "";

            if (day == "Morning")
            {
                if (digreas >= 10 && digreas <= 18)
                {
                     dress = "Sweatshirt";
                     shoes = "Sneakers";
                }
                else if (digreas > 18 && digreas <= 24)
                {
                     dress = "Shirt";
                    shoes = "Moccasins";
                }
                else if (digreas >= 25)
                {
                  dress = "T-Shirt";
                     shoes = "Sandals";
                }

            }
            else if (day == "Afternoon")
            {
                if (digreas >= 10 && digreas <= 18)
                {
                    dress = "Shirt";
                    shoes = "Moccasins";
                }
                else if (digreas > 18 && digreas <= 24)
                {
                    dress = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (digreas >= 25)
                {
                    dress = "Swim Suit";
                    shoes = "Barefoot";
                }

            }
            else if (day == "Evening")
            {
                dress = "Shirt";
                shoes = "Moccasins";
            }
            Console.WriteLine($"It's {digreas} degrees, get your {dress} and {shoes}.");



        }
    }
}
