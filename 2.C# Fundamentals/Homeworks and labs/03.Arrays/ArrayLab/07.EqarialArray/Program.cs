using System;
using System.Linq;

namespace _07.EqarialArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();
            int[] secondArray = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int firstAraySum = 0;
            int counter = 0;
            bool flag = false;

            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    counter = i;
                    flag = true;
                    break;
                }
                firstAraySum += firstArray[i];

            }

            if (flag == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {firstAraySum}");
            }
            else
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {counter} index");
            }

        }
    }
}
