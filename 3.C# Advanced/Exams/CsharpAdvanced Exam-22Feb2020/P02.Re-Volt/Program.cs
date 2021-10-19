using System;

namespace P02.Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int comandCount = int.Parse(Console.ReadLine());
            int myRow = 0;
            int myCol = 0;
            bool isWon = false;

            char[,] matrix = new char[n, n];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string elements = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = elements[col];
                    if (elements[col] == 'f')
                    {
                        myRow = row;
                        myCol = col;
                    }
                }
            }

            for (int i = 0; i < comandCount; i++)
            {
                string comand = Console.ReadLine();
                matrix[myRow, myCol] = '-';

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

                if (myRow < 0)
                {
                    myRow = n - 1;
                }
                else if (myRow > n - 1)
                {
                    myRow = 0;
                }
                else if (myCol < 0)
                {
                    myCol = n - 1;
                }
                else if (myCol > n-1)
                {
                    myCol = 0;
                }

                if (matrix[myRow, myCol] == 'B')
                {
                 
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

                    if (myRow < 0)
                    {
                        myRow = n - 1;
                    }
                    else if (myRow > n - 1)
                    {
                        myRow = 0;
                    }
                    else if (myCol < 0)
                    {
                        myCol = n - 1;
                    }
                    else if (myCol > n - 1)
                    {
                        myCol = 0;
                    }
                }
                if (matrix[myRow, myCol] == 'T')
                {
                    
                    if (comand == "up")
                    {
                        myRow++;
                    }
                    else if (comand == "down")
                    {
                        myRow--;
                    }
                    else if (comand == "left")
                    {
                        myCol++;
                    }
                    else if (comand == "right")
                    {
                        myCol--;
                    }
                    if (myRow < 0)
                    {
                        myRow = n - 1;
                    }
                    else if (myRow > n - 1)
                    {
                        myRow = 0;
                    }
                    else if (myCol < 0)
                    {
                        myCol = n - 1;
                    }
                    else if (myCol > n - 1)
                    {
                        myCol = 0;
                    }

                }

                if (matrix[myRow, myCol] == 'F')
                {
                    matrix[myRow, myCol] = 'f';
                    Console.WriteLine("Player won!");
                    isWon = true;
                    break;

                }

                matrix[myRow, myCol] = 'f';
            }
            if (isWon == false)
            {
                Console.WriteLine("Player lost!");
            }

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
