using System;
using System.Drawing;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            if (text == "square")
            {

                double square = a * a;
                Console.WriteLine($"{square:f3}");
            }
            else if (text == "rectangle")
            {
                double b = double.Parse(Console.ReadLine());
                double rectangle = a * b;
                Console.WriteLine($"{rectangle:f3}");
            }
            else if (text == "circle")
            {
                double circle = Math.PI * a * a;
                Console.WriteLine($"{circle:f3}");
            }
            else if (text == "triangle")
            {
                double b = double.Parse(Console.ReadLine());

                double triangle = a * b / 2.0;
                Console.WriteLine($"{triangle:f3}");
            }
        }
    }
}
