using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            if (stop > 10)
            {
                int sum = n * stop;
                Console.WriteLine($"{n} X {stop} = {sum}");
            }
            for (int i = stop; i <= 10; i++)
            {
                int sum = n * i;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
