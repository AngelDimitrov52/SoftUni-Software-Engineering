using System;

namespace Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbul = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int koktus = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());

            double total = (magnolii * 3.25 + zumbul * 4 + rozi * 3.50 + koktus * 8) * 0.95;

            if (total >= price)
            {
                double a = Math.Floor(total  - price);
                Console.WriteLine($"She is left with {a} leva.");
            }
            else
            {
                double a = Math.Ceiling(price - total);

                Console.WriteLine($"She will have to borrow {a} leva.");
            }
        }
    }
}
