using System;

namespace _04.PrintTrangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int start = 1;
            for (int i = 1; i <= number; i++)
            {
                PrintLine(1, i);
            }
            for (int i = number - 1; i >= 1; i--)
            {
                PrintLine(1, i);

            }
        


        }

        private static void PrintLine(int a, int i)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
