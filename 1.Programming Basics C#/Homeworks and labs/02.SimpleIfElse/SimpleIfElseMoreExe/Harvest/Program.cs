using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int kvadratura = int.Parse(Console.ReadLine());
            double kilogramNaKvadrat = double.Parse(Console.ReadLine());
            int nujneVino = int.Parse(Console.ReadLine());
            int broiRabotnici = int.Parse(Console.ReadLine());

            double totalGrozde = (kvadratura * 0.4) * kilogramNaKvadrat;
            double totalVino = totalGrozde  / 2.5;

            if (totalVino < nujneVino)
            {
                double dani = Math.Floor(nujneVino - totalVino);
                Console.WriteLine($"It will be a tough winter! More {dani} liters wine needed.");
               
            }
            else
            {
                double a = Math.Floor(totalVino);
                Console.WriteLine($"Good harvest this year! Total wine: {a} liters.");
                double b = Math.Ceiling(totalVino - nujneVino);
                double c = Math.Ceiling(b / broiRabotnici);
                Console.WriteLine($"{b} liters left -> {c} liters per person.");
            }
        }
    }
}
