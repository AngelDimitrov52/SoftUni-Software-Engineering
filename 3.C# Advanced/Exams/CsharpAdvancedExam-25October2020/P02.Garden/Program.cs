using System;
using System.Linq;

namespace P02.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse).ToArray();
            int n = dimensions[0];
            int m = dimensions[1];
            int[,] matrix = new int[n, m];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    matrix[row, col] = 0;
                }
            }

            string comand;
            while ((comand = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] comandArs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                int row = comandArs[0];
                int col = comandArs[1];

                if (row > n - 1 || row < 0 || col < 0 || col > m - 1)
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int i = 0; i < n; i++)
                {
                    matrix[row, i]++;
                }
                for (int i = 0; i < m ; i++)
                {
                    matrix[i, col]++;
                }
                matrix[row, col]--;

            }

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    if (col == m - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else
                    {
                    Console.Write(matrix[row,col] + " ");

                    }
                }
                Console.WriteLine();
            }
        }
    }
}
