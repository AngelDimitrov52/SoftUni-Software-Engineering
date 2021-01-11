using System;

namespace _04SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = n1; i <= n2; i++)
            {
                for (int m = n1; m <= n2; m++)
                {
                    counter++;
                    if (m + i == magic)
                    {
                        Console.WriteLine($"Combination N:{counter} ({i} + {m} = {magic})");
                        return;
                    }

                }

            }
            Console.WriteLine($"{counter} combinations - neither equals {magic}");

        }
    }
}
