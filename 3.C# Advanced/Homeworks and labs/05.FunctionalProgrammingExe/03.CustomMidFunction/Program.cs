using System;
using System.Linq;

namespace _03.CustomMidFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> smallNum = n => n.Min();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int minNum = smallNum(numbers);
            Console.WriteLine(minNum);
        }
    }
}
