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
            double p4 = 0;
            double p5 = 0;


            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a < 200)
                {
                    p1 ++;
                }
                else if (a >= 200 && a <400)
                {
                    p2 ++;
                }
                else if (a >= 400 && a < 600)
                {
                    p3 ++;
                }
                else if (a>=600 && a<800)
                {
                    p4 ++;
                }
                else 
                {
                    p5 ++;
                }
            }
            p1 = p1 * 1.0 / n * 100;
            p2 = p2 * 1.0 / n * 100;
            p3 = p3 * 1.0 / n * 100;
            p4 = p4 * 1.0 / n * 100;
            p5 = p5 * 1.0 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");


        }
    }
}
