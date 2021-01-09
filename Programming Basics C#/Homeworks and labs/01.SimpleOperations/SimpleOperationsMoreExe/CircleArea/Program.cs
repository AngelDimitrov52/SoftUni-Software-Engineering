using System;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double perimtur = 2 * Math.PI * r;
            double area = Math.PI * r * r;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimtur:f2}");
        }
    }
}
