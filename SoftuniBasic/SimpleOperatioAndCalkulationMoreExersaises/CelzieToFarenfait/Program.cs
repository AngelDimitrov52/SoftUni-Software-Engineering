using System;

namespace CelzieToFarenfait
{
    class Program
    {
        static void Main(string[] args)
        {
            double celzii = double.Parse(Console.ReadLine());
            double farenfait = celzii * 1.8000 + 32;
            Console.WriteLine($"{farenfait:f2}");
        }
    }
}
