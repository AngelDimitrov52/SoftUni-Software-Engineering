using System;

namespace _04.PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int prime = 2; prime <= n; prime++)
            {
                bool primeValue = true;
                for (int capital = 2; capital < prime; capital++)
                {
                    if (prime % capital == 0)
                    {
                        primeValue = false;
                        break;
                    }
                }
                Console.WriteLine($"{prime} -> {primeValue}");
            }

        }
    }
}
