using System;

namespace _04.Populatin
{
    class Program
    {
        static void Main(string[] args)
        {
            int population = int.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            int gogo = 0;
            int neww= 0;
            int dead = 0;

            int counter = 0;
            for (int i = 1; i <= years; i++)
            {
                 neww = population / 10 * 2;
                population += neww;
                counter++;

                if (counter % 5 == 0)
                {
                    gogo = population/ 50 * 5;
                    population -= gogo;
                }


                 dead = population / 20 * 2;
                population -= dead;



            }

            Console.WriteLine($"Beehive population: {population}");

        }
    }
}
