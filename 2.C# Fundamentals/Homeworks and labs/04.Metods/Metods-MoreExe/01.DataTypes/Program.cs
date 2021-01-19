using System;

namespace _01.DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string digit = Console.ReadLine();

            if (type == "int")
            {
                int number = int.Parse(digit);
                PrintIntNumber(number);
            }
            else if (type == "real")
            {
                double number = double.Parse(digit);
                PrintDoubleNumber(number);
            }
            else
            {
                PrintString(digit);
            }

        }

        private static void PrintString(string digit)
        {
            Console.WriteLine($"${digit}$");
        }

        private static void PrintDoubleNumber(double number)
        {
            double sum = number * 1.5;
            Console.WriteLine($"{sum:f2}");
        }

        private static void PrintIntNumber(int number)
        {
            Console.WriteLine(number * 2);
        }
    }
}
