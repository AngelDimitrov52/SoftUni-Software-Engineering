using System;

namespace _02.PaundToDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal pound = decimal.Parse(Console.ReadLine());

            decimal dolar = pound * 1.31M;

            Console.WriteLine($"{dolar:f3}");


        }
    }
}
