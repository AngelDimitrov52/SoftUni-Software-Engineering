using System;
using System.Collections.Generic;

namespace P02.EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 100;

            try
            {
                ReadNumber(start, end);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Try again");
                ReadNumber(start, end);
            }
        }

        private static void ReadNumber(int start, int end)
        {
            List<int> numbers = new List<int>();
            numbers.Add(int.Parse(Console.ReadLine()));

            for (int i = 1; i < 10; i++)
            {
                int digit = int.Parse(Console.ReadLine());
                if (digit <= numbers[i - 1])
                {
                    throw new ArgumentException();
                }

                numbers.Add(digit);
            }
        }
    }
}
