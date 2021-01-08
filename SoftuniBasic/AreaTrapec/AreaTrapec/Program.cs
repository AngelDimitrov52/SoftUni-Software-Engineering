using System;

namespace AreaTrapec
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Celzii = ");
            var c = double.Parse(Console.ReadLine());
            var f = c * 1.8 + 32;
             f =  Math.Round(f, 2);
            Console.WriteLine("Farenhait = " + f);

        }
    }
}
