using System;

namespace _01Sing.TheInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintNumber(n);
        }

        private static void PrintNumber(int number)
        {
            string itIs = "zero";
            if (number > 0 )
            {
                itIs = "poitive";
            }
            else if (number < 0)
            {
                itIs = "negative";
            }
            Console.WriteLine($"The number {number} is {itIs}.");
        }
    }
}
