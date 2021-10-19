using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Selling
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] matrix = new char[n, n];

            int myRow = 0;
            int myCol = 0;
            int firstRow = -1;
            int firstCol = -1;
            int secondRow = -1;
            int secondCol = -1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                    if (elements[col] == 'S')
                    {
                        myRow = row;
                        myCol = col;
                    }
                    if (firstRow == -1)
                    {
                        if (elements[col] == 'B')
                        {
                            firstRow = row;
                            firstCol = col;
                        }
                    }
                    if (firstRow > -1)
                    {
                        if (elements[col] == 'B')
                        {
                            secondRow = row;
                            secondCol = col;
                        }
                    }
                }
            }
            int coutFood = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                matrix[myRow, myCol] = '.';

                if (comand == "up")
                {
                    myRow--;
                }
                else if (comand == "down")
                {
                    myRow++;
                }
                else if (comand == "left")
                {
                    myCol--;
                }
                else if (comand == "right")
                {
                    myCol++;
                }

                if (myRow < 0 || myRow > n - 1 || myCol < 0 || myCol > n - 1)
                {
                    Console.WriteLine("Game over!");
                    break;
                }
                if (matrix[myRow,myCol] == '*')
                {
                    coutFood++;
                }

                if (myRow == firstRow && myCol == firstCol)
                {
                    matrix[myRow, myCol] = '.';
                    myRow = secondRow;
                    myCol = secondCol;
                    matrix[myRow, myCol] = 'S';
                    continue;
                }
                if (myRow == secondRow && myCol == secondCol)
                {
                    matrix[myRow, myCol] = '.';
                    myRow = firstRow;
                    myCol = firstCol;
                    matrix[myRow, myCol] = 'S';
                    continue;
                }
                matrix[myRow, myCol] = 'S';
                if (coutFood == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");
                    break;
                }
            }
            Console.WriteLine($"Food eaten: {coutFood}");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}