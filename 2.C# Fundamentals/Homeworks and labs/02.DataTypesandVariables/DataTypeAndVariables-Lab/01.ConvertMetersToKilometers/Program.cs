using System;

namespace _01.ConvertMetersToKilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal Meters = int.Parse(Console.ReadLine());

            decimal kilometres = Meters / 1000;
            Console.WriteLine($"{kilometres:f2}");
        }
    }
}
