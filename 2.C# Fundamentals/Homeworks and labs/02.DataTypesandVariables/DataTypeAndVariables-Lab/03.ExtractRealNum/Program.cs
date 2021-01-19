using System;

namespace _03.ExtractRealNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum= 0M;
            for (int i = 0; i < n; i++)
            {
                 totalSum += decimal.Parse(Console.ReadLine());
                
            }
            Console.WriteLine(totalSum);
        }
    }
}
