using System;

namespace _09.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int left = 0;
            int right = 0;

            for (int i = 1; i <= n; i+=2)
            {
                int a = int.Parse(Console.ReadLine());
                left += a;
                if(i!=n)
                for (int j = 2; j <= n; j += 2)
                {
                    int b = int.Parse(Console.ReadLine());
                    right += b;
                    break;
                }
                

            }
           

            if (right == left)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {left}");
            }
            else
            {
                int s = Math.Abs(left - right);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {s}");
            }


        }
    }
}
