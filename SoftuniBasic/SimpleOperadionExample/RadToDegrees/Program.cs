using System;

namespace RadToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radiani = double.Parse(Console.ReadLine());
            double degrees = radiani * 180 / Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
