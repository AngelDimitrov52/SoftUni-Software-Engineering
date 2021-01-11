using System;
using System.Threading;

namespace FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            int liters = int.Parse(Console.ReadLine());
            string card = Console.ReadLine();

            double fuelon = 0.0;

            if (fuel=="Gasoline")
            {
                if (card == "Yes")
                {
                    fuelon = liters * (2.22 - 0.18);
                }
                else
                {


                    fuelon = liters * 2.22;
                }
            }

            if (fuel == "Diesel")
            {
                if (card == "Yes")
                {
                    fuelon = liters * (2.33 - 0.12);
                }
                else
                {


                    fuelon = liters * 2.33;
                }
            }
            if (fuel == "Gas")
            {
                if (card == "Yes")
                {
                    fuelon = liters * (0.93 - 0.08);
                }
                else
                {


                    fuelon = liters * 0.93;
                }
            }

            if (liters >= 20 && liters <= 25)
            {
                fuelon = fuelon * 0.92;
            }
            else if (liters > 25)
            {
                fuelon = fuelon * 0.90;
            }

            Console.WriteLine($"{fuelon:f2} lv.");

        }
    }
}
