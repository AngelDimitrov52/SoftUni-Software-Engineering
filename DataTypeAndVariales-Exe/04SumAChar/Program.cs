using System;

namespace _04SumAChar
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                char line = char.Parse(Console.ReadLine());
                sum += line;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
