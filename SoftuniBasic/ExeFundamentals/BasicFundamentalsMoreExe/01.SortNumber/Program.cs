using System;

namespace _01.SortNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double[] numbers = { num1, num2, num3 };
            Array.Sort(numbers);
            for (int i = 2; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }

        }
    }
}
