using System;
using System.Linq;

namespace _01.DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n,n];
            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }
            int firstDia = 0;
            int secondDia = 0;

            for (int col = 0; col < n; col++)
            {
                firstDia += matrix[col, col];
            }
            for (int row = 0; row <n; row++)
            {
                int col = n - row - 1;
                secondDia += matrix[row, col];
                
            }
            Console.WriteLine(Math.Abs(firstDia-secondDia));
        }
    }
}
