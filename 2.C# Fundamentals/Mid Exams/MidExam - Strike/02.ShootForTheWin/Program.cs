using System;
using System.Linq;

namespace _02.ShootForTheWin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] shootArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            string comand;

            int count = 0;
            while ((comand = Console.ReadLine()) != "End")
            {
                int index = int.Parse(comand);

                if (index < 0 || index > shootArr.Length -1 || shootArr[index] == -1)
                {
                    continue;
                }

                count++;

                int digit = shootArr[index];
                shootArr[index] = -1;

                for (int i = 0; i < shootArr.Length; i++)
                {
                    if (shootArr[i] == -1)
                    {
                        continue;
                    }
                    else if (shootArr[i] > digit)
                    {
                        shootArr[i] -= digit;
                    }
                    else if (shootArr[i] <= digit)
                    {
                        shootArr[i] += digit;
                    }
                }

            }
            Console.WriteLine($"Shot targets: {count} -> {string.Join(" ", shootArr)}");


        }
    }
}
