using System;

namespace Voleyboall
{
    class Program
    {
        static void Main(string[] args)
        {
            string godina = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double weakSofia = 48 - h;
            weakSofia *= (3.0 / 4);
            double praznici = p *  (2.0 / 3);
            
            double totalGame = praznici + weakSofia + h;

            if (godina == "leap")
            {
                totalGame *= 1.15;
            }

            Console.WriteLine(Math.Floor(totalGame));
        }
    }
}
