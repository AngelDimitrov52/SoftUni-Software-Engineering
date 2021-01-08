using System;

namespace MetriMilimetri
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string textIn = Console.ReadLine();
            string textEx = Console.ReadLine();
            double b = 0.0;
            double c = 0.0;
            if (textIn == "cm")
            {
                b = a / 100.0;
            }
            else if (textIn == "mm")
            {
                b = a / 1000.0;
            }
            else
            {
                b = a * 1;
            }

            if (textEx == "cm")
            {
                c = b * 100;
            }
            else if (textEx == "mm")
            {
                c = b * 1000; 
            }
            else
            {
                c = b * 1.0;
            }
            Console.WriteLine($"{c:f3}");

        }
    }
}
