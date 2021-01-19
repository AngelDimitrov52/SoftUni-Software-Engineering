using System;

namespace _01.NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPer = int.Parse(Console.ReadLine());
            int secondPer = int.Parse(Console.ReadLine());
            int tree = int.Parse(Console.ReadLine());

            int totalPer = firstPer + secondPer + tree;

            int peopleCount = int.Parse(Console.ReadLine());

            int hourCount = 0;
            int pochivka = 0;
            while (peopleCount > 0)
            {
                peopleCount -= totalPer;
                hourCount++;

                if (hourCount % 3 == 0)
                {
                    if (peopleCount <= 0)
                    {
                        break;
                    }
                    pochivka++;
                }


            }
            Console.WriteLine($"Time needed: {pochivka + hourCount}h.");
        }
    }
}
