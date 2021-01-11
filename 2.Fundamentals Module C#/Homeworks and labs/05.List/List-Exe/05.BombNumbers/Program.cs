using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            int[] num = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToArray();
            int bombNum = num[0];
            int range = num[1];

            while (true)
            {

            int indexOfBomb = numberList.FindIndex(n => n == bombNum);
                if (indexOfBomb == -1)
                {
                    break;
                }
            int starRemove = indexOfBomb - range;
            if (starRemove < 0)
            {
                starRemove = 0;
            }
            int endBomb = indexOfBomb + range;
            if (endBomb > numberList.Count -1)
            {
                endBomb = numberList.Count - 1;
            }

            
                for (int i = starRemove; i <= endBomb; i++)
                {
                    numberList.RemoveAt(starRemove);
                }

            }
            Console.WriteLine(numberList.Sum());
        }
    }
}
