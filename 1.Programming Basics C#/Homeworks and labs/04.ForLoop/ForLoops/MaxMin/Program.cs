using System;

namespace _08.MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double min = int.MaxValue ;
            double man = int.MinValue;
            for (int i = 1; i <= n; i++)
            {
              double  b = double.Parse(Console.ReadLine());
                if (min > b)
                {
                    min = b;
                }
                if (man < b)
                {
                    man = b;                }
            }
            Console.WriteLine($"Max number: {man}");
            Console.WriteLine($"Min number: {min}");



        }
    }
}
