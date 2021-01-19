using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                                    .Split()
                                    .Select(int.Parse)
                                    .ToArray();

            for (int i = 0; i < arr.Length; i++)

            {
                bool flag = true;
                int first = arr[i];
                for (int j = i+1; j < arr.Length; j++)
                {
                    

                    int second = arr[j];

                    if (second >= first)
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    Console.Write($"{arr[i]} ");
                    flag = false;
                }
            }



        }
    }
}
