using System;

namespace _10.TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {

                bool isDivisible = IsTheDigitIsDivisible(i);
                bool heveOdd = IsTheDigitHaveoddNum(i);

                if (isDivisible && heveOdd)
                {
                    Console.WriteLine(i);
                }

            }




        }

        private static bool IsTheDigitHaveoddNum(int i)
        {
            while (i>0)
            {
            int digit = i % 10;
                i = i / 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsTheDigitIsDivisible(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                int digit = i % 10;
                sum += digit;
                i = i / 10;
                
            }
            if (sum % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
