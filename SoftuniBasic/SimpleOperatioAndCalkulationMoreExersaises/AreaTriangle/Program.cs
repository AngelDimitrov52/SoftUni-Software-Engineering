using System;

namespace AreaTriangle
{
    class Program
    {
        static void Main(string[] args)
        {

            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = b * h / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
