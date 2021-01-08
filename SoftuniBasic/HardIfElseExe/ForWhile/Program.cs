using System;

namespace ForWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            while (0 < a )
            {
                double b = a * 2;
                Console.WriteLine($"Result: {b}");
                break;
            }



        }
    }
}
