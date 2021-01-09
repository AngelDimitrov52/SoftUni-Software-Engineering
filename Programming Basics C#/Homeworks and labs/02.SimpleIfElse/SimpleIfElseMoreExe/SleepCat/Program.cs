using System;

namespace SleepCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int pochivni = int.Parse(Console.ReadLine());

            int raboti = 365 - pochivni;
            double totalmin = raboti * 63 + pochivni * 127;

            if (totalmin<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                double a = 30000 - totalmin;
                double h =Math.Floor( a / 60);
                double m = a % 60;

                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                double a = totalmin - 30000;
                double h = Math.Floor(a/60);
                double m = a % 60;

                Console.WriteLine($"{h} hours and {m} minutes more for play");
            }
        }
    }
}
