using System;

namespace _07.KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[,] matrix = new string[n, n];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string numbers = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = numbers[col].ToString();
                }
            }

            int bestCout = 0;
            bool breakFlag = true;
            int finalCaunter = 0;
            while (breakFlag)
            {
                bool flag = false;
                int kikRow = -1;
                int kikCol = -1;

                for (int row = 0; row < n; row++)
                {

                    for (int col = 0; col < n; col++)
                    {
                        int counter = 0;
                        if (matrix[row, col] == "K")
                        {

                            if (row + 2 < n && col + 1 < n)
                            {
                                if (matrix[row + 2, col + 1] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row + 2 < n && col - 1 >= 0)
                            {
                                if (matrix[row + 2, col - 1] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row - 2 >= 0 && col + 1 < n)
                            {
                                if (matrix[row - 2, col + 1] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row - 2 >= 0 && col - 1 >= 0)
                            {
                                if (matrix[row - 2, col - 1] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row + 1 < n && col + 2 < n)
                            {
                                if (matrix[row + 1, col + 2] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row + 1 < n && col - 2 >= 0)
                            {
                                if (matrix[row + 1, col - 2] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row - 1 >= 0 && col + 2 < n)
                            {
                                if (matrix[row - 1, col + 2] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (row - 1 >= 0 && col - 2 >= 0)
                            {
                                if (matrix[row - 1, col - 2] == "K")
                                {
                                    counter++;
                                }
                            }
                            if (bestCout < counter)
                            {
                                bestCout = counter;
                                kikCol = col;
                                kikRow = row;
                                flag = true;
                            }

                        }
                    }
                }
                if (flag)
                {
                    matrix[kikRow, kikCol] = "0";
                    finalCaunter++;
                    bestCout = 0;
                }
                else
                {
                    breakFlag = false;
                }

            }
            Console.WriteLine(finalCaunter);
        }
    }
}
