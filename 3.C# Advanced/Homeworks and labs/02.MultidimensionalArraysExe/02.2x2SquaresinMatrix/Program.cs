using System;
using System.Linq;

namespace _02._2x2SquaresinMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
           
            string[,] matrix = new string[nums[0], nums[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
               string[] digits = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = digits[col];
                }
            }
          
            int equalDigits = 0;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] &&
                        matrix[row, col] == matrix[row + 1, col] &&
                         matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        equalDigits++;
                    }
                }
            }
            Console.WriteLine(equalDigits);
        }
    }
}
