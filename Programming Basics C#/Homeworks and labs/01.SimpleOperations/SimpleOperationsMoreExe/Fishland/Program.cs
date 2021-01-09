using System;

namespace Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double skumriqPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudKg = double.Parse(Console.ReadLine());
            double safridKg = double.Parse(Console.ReadLine());
            double midiKg = double.Parse(Console.ReadLine());

            double palamudPrice = skumriqPrice * (1 + 0.6);
            double safridPrice = cacaPrice * (1+0.8);
            double midiPrice = 7.50;

            double bill = palamudKg * palamudPrice + safridKg * safridPrice + midiKg * midiPrice;
            
            Console.WriteLine($"{bill:f2}");
                
                

        }
    }
}
