using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            for (double j = 1; j <= 1000000000000000000; j++)
            {
                int number = j;
            int n = number;
            int sum = 0;

            while (number != 0)
            {
                int medicalsum = 1;
                int edinica = number % 10;
                for (int i = 1; i <= edinica; i++)
                {
                    medicalsum *= i;
                }
                sum += medicalsum;
                number /= 10;
            }
            if (sum == n)
            {
                Console.WriteLine(n);
            }
           


            }

        }
    }
}
