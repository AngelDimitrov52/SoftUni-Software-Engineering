using System;

namespace UsToLeva
{
    class Program
    {
        static void Main(string[] args)
        {
            double us = double.Parse(Console.ReadLine());
            double leva = us * 1.79549;
            Console.WriteLine($"{leva:f2}");
        }
    }
}
