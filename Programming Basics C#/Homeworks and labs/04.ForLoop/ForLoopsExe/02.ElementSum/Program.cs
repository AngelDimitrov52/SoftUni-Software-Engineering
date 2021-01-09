using System;

namespace _02.ElementSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;


            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (max < a)
                {
                    max = a;

                }
                sum += a;


            }
            sum = sum - max;
            if (max == sum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {Math.Abs(sum - max)}");
            }


        }
    }
}
