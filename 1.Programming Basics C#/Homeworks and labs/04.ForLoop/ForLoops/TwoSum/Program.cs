using System;

namespace _09.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()) ;

            int left = 0;
            int right = 0;
            
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                left += a;

            }
            for (int i = 1; i <= n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                right += b;

            }

            if (right == left)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                int s = Math.Abs(left -right);
                Console.WriteLine($"No, diff = {s}");
            }


        }
    }
}
