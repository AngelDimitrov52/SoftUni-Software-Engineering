using System;

namespace _05.SweatcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double spase = double.Parse(Console.ReadLine());

            string comand = Console.ReadLine();
            int counter = 0;

            while (comand != "End")
            {
                double a = double.Parse(comand);
                if (counter % 2 == 0 && counter != 0)
                {
                    a *= 1.10;
                }

                spase -= a;

                if (spase < 0)
                {
                    Console.WriteLine($"No more space!");
                    break;
                }
                counter++;
                comand = Console.ReadLine();
            }

            if (spase >= 0)
            {
                Console.WriteLine($"Congratulations! All suitcases are loaded!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");

        }
    }
}