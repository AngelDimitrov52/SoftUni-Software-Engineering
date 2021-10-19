using System;
using System.Linq;

namespace _05.SquareWithMaxSum
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
            int bigestSum = int.MinValue;
            int[] firtIndex = new int[2];
            int[] secondIndex = new int[2];
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    int square = matrix[row, col] + matrix[row, col + 1]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (square > bigestSum)
                    {
                        bigestSum = square;
                        firtIndex[0] = matrix[row, col];
                        firtIndex[1] = matrix[row, col + 1];
                        secondIndex[0] = matrix[row + 1, col];
                        secondIndex[1] = matrix[row + 1, col + 1];
                    }
                }
            }
            Console.WriteLine(string.Join(" ",firtIndex));
            Console.WriteLine(string.Join(" ",secondIndex));
            Console.WriteLine(bigestSum);

        }
    }
}
