using System;

namespace _04.Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;
          


            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a % 2 == 0)
                {
                    p1++;
                }
                if (a % 3 == 0)
                {
                    p2++;
                }
                if (a % 4 == 0)
                {
                    p3++;
                }
          
            }
            p1 = p1 * 1.0 / n * 100;
            p2 = p2 * 1.0 / n * 100;
            p3 = p3 * 1.0 / n * 100;
           

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
          

        }
    }
}
