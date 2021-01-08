using System;

namespace MinSec
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());

            int all = sec1 + sec2 + sec3;
            int min = all / 60;
            int sec = all % 60;

            if (sec < 10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {


                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
