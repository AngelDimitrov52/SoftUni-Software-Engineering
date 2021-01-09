using System;

namespace Weather2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());

            if (a < 5.0)
            {
                Console.WriteLine("unknown");
            }
            else if (a <=11.9)
            {
                Console.WriteLine("Cold");
            }
            else if (a <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            else if (a <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            else if (a <= 25.9)
            {
                Console.WriteLine("Warm");
            }

            else if (a <= 35.00)
            {
                Console.WriteLine("Hot");
            }

            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
