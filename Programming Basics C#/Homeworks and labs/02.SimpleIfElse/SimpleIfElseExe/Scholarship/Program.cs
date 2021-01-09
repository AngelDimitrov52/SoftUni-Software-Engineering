using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double dohod = double.Parse(Console.ReadLine());
            double sredenUspeh = double.Parse(Console.ReadLine());
            double minZaplata = double.Parse(Console.ReadLine());

            double socStipendiq = Math.Floor(minZaplata * 0.35);
            double otlStipendiq = Math.Floor(sredenUspeh*25);
            double a = 0.0; 

            if (sredenUspeh < 4.50)
            {
                Console.WriteLine("You cannot get a scholarship!");
            }

            if (sredenUspeh >= 4.50 && sredenUspeh <5.50)
            {
                if (dohod >= minZaplata)
                {
                    Console.WriteLine("You cannot get a scholarship!");
                }

                else
                {
                    Console.WriteLine($"You get a Social scholarship {socStipendiq} BGN");
                }

            }
            if (sredenUspeh>=5.50)
            {
                if (dohod < minZaplata)
                {
                     a = Math.Max(socStipendiq,otlStipendiq);
                }
                 if (a == socStipendiq)
                {
                    Console.WriteLine($"You get a Social scholarship {socStipendiq} BGN");
                }
                else if (a == otlStipendiq)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {otlStipendiq} BGN");
                }

                else
                {
                  Console.WriteLine($"You get a scholarship for excellent results {otlStipendiq} BGN");
                }

            }


        }
    }
}
