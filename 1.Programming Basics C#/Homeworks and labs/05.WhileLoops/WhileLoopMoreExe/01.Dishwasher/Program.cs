using System;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int botal = int.Parse(Console.ReadLine())*750;
            int broqch = 0;
            string broiChinii = Console.ReadLine();
            int tenjeri = 0;
            int chinii = 0;
            while (broiChinii != "End")
            {
                broqch++;
                if (broqch %  3 == 0)
                {
                    botal -= int.Parse(broiChinii) * 15;
                    tenjeri += int.Parse(broiChinii);
                }
                else
                {

                botal -= int.Parse(broiChinii) * 5;
                    chinii += int.Parse(broiChinii);
                }

                if (botal < 0)
                {
                    Console.WriteLine($"Not enough detergent, {Math.Abs(botal)} ml. more necessary!");
                    break;
                }



                broiChinii = Console.ReadLine();
            }

            if (botal>=0)
            {

                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{chinii} dishes and {tenjeri} pots were washed.");
                Console.WriteLine($"Leftover detergent {botal} ml.");
            }


        }
    }
}
