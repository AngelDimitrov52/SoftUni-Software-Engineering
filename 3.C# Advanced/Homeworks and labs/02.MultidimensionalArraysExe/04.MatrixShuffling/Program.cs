using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[rowCol[0], rowCol[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            string comand;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (comandArgs[0] != "swap" || comandArgs.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                int firstRow = int.Parse(comandArgs[1]);
                int firstCol = int.Parse(comandArgs[2]);
                int secondRow = int.Parse(comandArgs[3]);
                int secondCol = int.Parse(comandArgs[4]);

                bool isValid = IsValidRow(firstRow, matrix);
                bool isValidtwo = IsValidRow(secondRow, matrix);
                bool isValidcol = isValidCol(firstCol, matrix);
                bool isValidcoltwo = isValidCol(secondCol, matrix);

                if (isValid && isValidcol && isValidcoltwo && isValidtwo)
                {
                    string firtNum = matrix[firstRow, firstCol];
                    string secondNum = matrix[secondRow, secondCol];
                    matrix[firstRow, firstCol] = secondNum;
                    matrix[secondRow, secondCol] = firtNum;

                    for (int row = 0; row < matrix.GetLength(0); row++)
                    {
                        for (int col = 0; col < matrix.GetLength(1); col++)
                        {
                            Console.Write(matrix[row,col] + " ");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }


            }
        }

        static bool isValidCol(int firstCol, string[,] matrix)
        {
            if (firstCol < matrix.GetLength(1) && firstCol >= 0)
            {
                return true;
            }
            return false;

        }

        static bool IsValidRow(int firstRow, string[,] matrix)
        {
            if (firstRow < matrix.GetLength(0) && firstRow >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
