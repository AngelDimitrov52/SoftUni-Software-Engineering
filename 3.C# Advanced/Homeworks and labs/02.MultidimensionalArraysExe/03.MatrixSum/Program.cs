using System;
using System.Linq;

namespace _02._2x2SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            int[,] matrix = new int[nums[0], nums[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] digits = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray(); ;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = digits[col];
                }
            }
            int maxSum = int.MinValue;
            int curentRow = -1;
            int curentCol = -1;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int thisSum = 0;
                    for (int thisRow = row; thisRow < row +3; thisRow++)
                    {
                        for (int thisCol = col; thisCol < col + 3; thisCol++)
                        {
                            thisSum += matrix[thisRow, thisCol];
                           
                        }
                    }
                    if (thisSum > maxSum)
                    {
                        maxSum = thisSum;
                        curentRow = row;
                         curentCol = col;
                    }
                }
            }
            Console.WriteLine($"Sum = {maxSum}");

            for (int thisRow = curentRow; thisRow < curentRow + 3; thisRow++)
            {
                for (int thisCol = curentCol; thisCol < curentCol + 3; thisCol++)
                {
                    Console.Write(matrix[thisRow,thisCol] + " ");

                }
                Console.WriteLine();
            }

        }
    }
}
