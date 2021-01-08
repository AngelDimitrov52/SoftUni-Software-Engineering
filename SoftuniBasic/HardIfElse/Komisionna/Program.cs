using System;

namespace Komisionna
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double prodajbi = double.Parse(Console.ReadLine());

            double kom = 0;

            if (town == "Sofia")
            {
                if (prodajbi > 10000)
                {
                    kom = 0.12;
                }
                else if (prodajbi > 1000)
                {
                    kom = 0.08;
                }
                else if (prodajbi > 500 )
                {
                    kom = 0.07;
                }
                else if (prodajbi >= 0 )
                {
                    kom = 0.05;
                }

            }
            else if (town == "Varna")
            {
                if (prodajbi > 10000)
                {
                    kom = 0.13;
                }
                else if (prodajbi > 1000)
                {
                    kom = 0.10;
                }
                else if (prodajbi > 500)
                {
                    kom = 0.075;
                }
                else if (prodajbi >= 0)
                {
                    kom = 0.045;
                }
            }
            else if (town == "Plovdiv")
            {
                if (prodajbi > 10000)
                {
                    kom = 0.145;
                }
                else if (prodajbi > 1000)
                {
                    kom = 0.12;
                }
                else if (prodajbi > 500)
                {
                    kom = 0.08;
                }
                else if (prodajbi >= 0)
                {
                    kom = 0.055;
                }
            }

            double total = prodajbi * kom;
            if (kom == 0)
            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine($"{total:f2}");
            }
        }
    }
}
