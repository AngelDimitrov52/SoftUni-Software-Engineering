using System;

namespace AreaOfParalelepipet
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double h = Math.Abs(x1 - x2);
            double sh = Math.Abs(y1-y2);

            double area = h * sh;
            double perimetur = 2 * (h + sh);

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimetur:f2}");

        }
    }
}
