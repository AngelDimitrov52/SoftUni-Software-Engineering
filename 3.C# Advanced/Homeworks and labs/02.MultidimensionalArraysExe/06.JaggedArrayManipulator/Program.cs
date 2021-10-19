using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] array = new double[n][];

            for (int row = 0; row < n; row++)
            {
                int[] colValue = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();
                array[row] = new double[colValue.Length];
                for (int col = 0; col < colValue.Length; col++)
                {
                    array[row][col] = colValue[col];
                }
            }

            for (int row = 0; row < array.Length - 1; row++)
            {

                if (array[row].Length == array[row + 1].Length)
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        array[row][col] *= 2;
                        array[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < array[row].Length; col++)
                    {
                        array[row][col] /= 2;

                    }
                    for (int col = 0; col < array[row + 1].Length; col++)
                    {
                        array[row + 1][col] /= 2;

                    }
                }
            }
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split();
                string cmd = comandArgs[0];
                int row = int.Parse(comandArgs[1]);
                int col = int.Parse(comandArgs[2]);
                int value = int.Parse(comandArgs[3]);

                bool isValid = row >= 0 && row < array.Length &&
                    col >= 0 && col < array[row].Length; ;
                if (isValid)
                {
                    if (cmd == "Add")
                    {
                        array[row][col] += value;
                    }
                    else
                    {
                        array[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ",array[row]));
            }

        }
    }
}
