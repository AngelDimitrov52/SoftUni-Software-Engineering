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
            char[,] bakery = new char[n, n];

            int myRow = 0;
            int myCol = 0;
            int firstRow = -1;
            int firstCol = -1;
            int secondRow = -1;
            int secondCol = -1;

            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                string elements = Console.ReadLine();

                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    bakery[row, col] = elements[col];
                    if (elements[col] == 'S')
                    {
                        myRow = row;
                        myCol = col;
                    }
                    if (firstRow == -1)
                    {
                        if (elements[col] == 'O')
                        {
                            firstRow = row;
                            firstCol = col;
                        }
                    }
                    if (firstRow > -1)
                    {
                        if (elements[col] == 'O')
                        {
                            secondRow = row;
                            secondCol = col;
                        }
                    }
                }
            }
            int sum = 0;
            while (true)
            {
                string comand = Console.ReadLine();
                bakery[myRow, myCol] = '-';

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
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;
                }

                if (myRow == firstRow && myCol == firstCol)
                {
                    bakery[myRow, myCol] = '-';
                    myRow = secondRow;
                    myCol = secondCol;
                    bakery[myRow, myCol] = 'S';
                    continue;
                }
                if (myRow == secondRow && myCol == secondCol)
                {
                    bakery[myRow, myCol] = '-';
                    myRow = firstRow;
                    myCol = firstCol;
                    bakery[myRow, myCol] = 'S';
                    continue;
                }

                char thisElement = bakery[myRow, myCol];

                if (Char.IsDigit(thisElement))
                {
                    sum += int.Parse(thisElement.ToString());
                }
                if (sum >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    bakery[myRow, myCol] = 'S';
                    break;
                }
                bakery[myRow, myCol] = 'S';

            }

            Console.WriteLine($"Money: {sum}");

            for (int row = 0; row < bakery.GetLength(0); row++)
            {
                for (int col = 0; col < bakery.GetLength(1); col++)
                {
                    Console.Write(bakery[row, col]);
                }
                Console.WriteLine();
            }

        }
    }
}
