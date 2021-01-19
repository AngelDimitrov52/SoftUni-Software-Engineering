using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int starNum = int.Parse(Console.ReadLine());
            int stopNum = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = starNum; i <= stopNum; i++)
            {
                sum += i;
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
