using System;
using System.Linq;

namespace _04.FindEvenOfOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int start = numbers[0];
            int end = numbers[1];
            string comand = Console.ReadLine();

            Predicate<int> predicate = n => true;
            if (comand == "odd")
            {
                predicate = n => n % 2 != 0;
            }
            else if (comand == "even")
            {
                predicate = n => n % 2 == 0;
            }

            for (int i = start; i <= end; i++)
            {
                if (predicate(i))
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
