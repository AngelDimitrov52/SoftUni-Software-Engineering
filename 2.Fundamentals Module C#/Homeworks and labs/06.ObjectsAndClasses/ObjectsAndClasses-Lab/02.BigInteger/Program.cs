using System;
using System.Numerics;

namespace _02.BigIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger bigNum = new BigInteger();
            bigNum = 1;
            for (int i = 1; i <= n; i++)
            {
                bigNum *= i;
            }
            Console.WriteLine(bigNum);


        }
    }
}
