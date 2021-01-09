using System;

namespace _05.BankCard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double total = 0;

            for (int i = 1; i <= n; i++)
            {
                double a = double.Parse(Console.ReadLine());
                if (a <= 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
               
                Console.WriteLine($"Increase: {a:f2}");
                total += a;
                
            }
            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
