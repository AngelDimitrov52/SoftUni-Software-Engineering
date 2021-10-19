using System;
using System.Dynamic;

namespace _09.GreadTwoValue
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int  evenSum = 0;
            int oddSum = 0;
            while (number!=0)
            {
                int digit = 0;
                digit = number % 10;
                number /= 10;
                if (digit % 2 == 0)
                {
                    evenSum += digit;
                }
                else
                {
                    oddSum += digit;
                }
            }
            Console.WriteLine(GetSumOfOddDigits(evenSum,oddSum));


        }

        private static int GetSumOfOddDigits(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}
