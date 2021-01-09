using System;

namespace _04.SumAndDrive
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            int b = int.Parse(Console.ReadLine());

            while (k <= b)
            {
                Console.WriteLine(k);
                k = 2 * k + 1;
            }
        }
    }
}
