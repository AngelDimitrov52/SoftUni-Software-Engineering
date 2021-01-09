using System;

namespace Holyday
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string somewhere = "a" ;
            double poharcheno = 0;
            string home = "a";
            
            if (budget <= 100)
            {
                somewhere = "Bulgaria";
                
                if (season == "summer")
                {
                    poharcheno = budget * 0.30;
                    home = "Camp";
                }
                else
                {
                    home = "Hotel";
                    poharcheno = budget * 0.70;
                }

            }
            else if (budget >100 && budget <= 1000)
            {
                somewhere = "Balkans";

                if (season == "summer")
                {
                    poharcheno = budget * 0.40;
                    home = "Camp";
                }
                else
                {
                    home = "Hotel";
                    poharcheno = budget * 0.80;
                }


            }
            else if (budget>1000)
            {
                somewhere = "Europe";
                home = "Hotel";
                poharcheno = budget * 0.90;

            }
            Console.WriteLine($"Somewhere in {somewhere}");

            Console.WriteLine($"{home} - {poharcheno:f2}");

        }
    }
}
