using System;

namespace _01.Honey
{
    class Program
    {
        static void Main(string[] args)
        {
            int bee = int.Parse(Console.ReadLine());
            int flower = int.Parse(Console.ReadLine());

            double totalHoney = bee * flower * 0.21;

            double piti = Math.Floor( totalHoney / 100);
            double ostatuk = totalHoney % 100;

            Console.WriteLine($"{piti} honeycombs filled.");
            Console.WriteLine($"{ostatuk:f2} grams of honey left.");
        }
    }
}
