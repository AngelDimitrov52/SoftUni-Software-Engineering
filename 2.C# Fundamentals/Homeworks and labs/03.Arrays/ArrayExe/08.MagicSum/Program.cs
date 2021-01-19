using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                int digit = arr[i];
                for (int j = i + 1 ; j < arr.Length; j++)
                {
                    if (digit + arr[j] == number)
                    {
                        Console.WriteLine($"{digit} {arr[j]}");
                    }
                  
                }
            }





        }
    }
}
