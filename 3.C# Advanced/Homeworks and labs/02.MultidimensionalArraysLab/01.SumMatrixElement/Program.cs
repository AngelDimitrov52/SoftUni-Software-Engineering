using System;
using System.Linq;

namespace _01.SumMatrixElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = rowCol[0];
            int cols = rowCol[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    sum += matrix[row, col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(sum);

        }
    }
}
