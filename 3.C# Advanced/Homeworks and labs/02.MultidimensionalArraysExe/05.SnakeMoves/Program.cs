
using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();
            char[,] matrix = new char[rowCol[0], rowCol[1]];

            string text = Console.ReadLine();
            Queue<char> textQueue = new Queue<char>(text);

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = textQueue.Dequeue();
                        textQueue.Enqueue(matrix[row, col]);

                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1) -1; col >= 0; col--)
                    {
                        matrix[row, col] = textQueue.Dequeue();
                        textQueue.Enqueue(matrix[row, col]);
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }
    }
}
