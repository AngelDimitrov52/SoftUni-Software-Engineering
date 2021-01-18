using System;
using System.Linq;

namespace _06.Jagged_ArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                matrix[row] = new int[numbers.Length];

                for (int col = 0; col < numbers.Length; col++)
                {
                    matrix[row][col] = numbers[col];
                }
            }

            string comand;
            while ((comand = Console.ReadLine()) != "END")
            {
                string[] comandArgs = comand.Split();
                string cmd = comandArgs[0];
                int row = int.Parse(comandArgs[1]);
                int col = int.Parse(comandArgs[2]);
                int num = int.Parse(comandArgs[3]);
                if (row < 0 || row > matrix.Length - 1 || col < 0 || col > matrix[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }
                if (cmd == "Add")
                {
                    matrix[row][col] += num;
                }
                else
                {
                    matrix[row][col] -= num;
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }
        }
    }
}
