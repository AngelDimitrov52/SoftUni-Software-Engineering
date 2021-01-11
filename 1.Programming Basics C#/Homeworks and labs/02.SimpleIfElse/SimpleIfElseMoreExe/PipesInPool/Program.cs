using System;

namespace PipesInPool
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double p1full = p1 * h;
            double p2full = p2 * h;
            double ptotal = p1full + p2full;

            if (ptotal <= v )
            {
                double nebasein = ptotal/v * 100;
                double proventp1 = p1full / ptotal * 100;
                double proventp2 = p2full / ptotal * 100;
                Console.WriteLine($"The pool is {nebasein:f2}% full." +
                    $" Pipe 1: {proventp1:f2}%. Pipe 2: {proventp2:f2}%.");

            }
            else
            {
                double a = ptotal - v;
                Console.WriteLine($"For {h} hours the pool overflows with {a:f2} liters.");
            }

        }
    }
}
