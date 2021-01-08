using System;

namespace _03.FloatingEuality
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstFl = double.Parse(Console.ReadLine());
            double secondFl = double.Parse(Console.ReadLine());
            double epsilon = 0.000001;
            bool sravnenie;
            if (firstFl < secondFl)
            {
                double temp = firstFl;
                firstFl = secondFl;
                secondFl = temp;
            }
            if (firstFl - secondFl < epsilon)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }
}
