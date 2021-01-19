using System;

namespace _01.IntegerOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            num1 = num1 + num2;
            int sum = num1 / (num3);
            int totalSum = sum * num4;
            Console.WriteLine(totalSum);
        }
    }
}
