using System;

namespace _02.MountainRun
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distancion = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double timeGeorgi = distancion * timeForOneMeter;
            double slow = Math.Floor(distancion / 50);
            timeGeorgi += slow * 30;

            if (record <= timeGeorgi)
            {
                double a = Math.Abs(record - timeGeorgi);
            Console.WriteLine($"No! He was {a:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {timeGeorgi:f2} seconds.");
            }



        }
    }
}
