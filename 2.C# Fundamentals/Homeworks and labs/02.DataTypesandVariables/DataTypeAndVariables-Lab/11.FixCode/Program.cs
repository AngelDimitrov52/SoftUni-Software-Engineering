using System;

namespace _11.FixCode
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Length: ");
            double lenght = double.Parse(Console.ReadLine());

            Console.Write("Width: ");
            double shirina = double.Parse(Console.ReadLine());

            Console.Write("Height: ");
            double hight = double.Parse(Console.ReadLine());

            double V = (lenght * shirina * hight)/3;
            Console.WriteLine($"Pyramid Volume: {V:f2}");

        }
    }
}
