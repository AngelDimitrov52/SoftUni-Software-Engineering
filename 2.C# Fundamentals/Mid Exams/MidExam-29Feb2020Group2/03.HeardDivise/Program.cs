using System;
using System.Globalization;
using System.Linq;

namespace _03.HeardDivise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hoodArr = Console.ReadLine()
                .Split("@", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string com;
            int index = 0;
            while ((com = Console.ReadLine()) != "Love!")
            {
                string[] comArgs = com.Split();
                int jump = int.Parse(comArgs[1]);
                index += jump;
                if (index >= hoodArr.Length)
                {
                    index = 0;
                }

                if (hoodArr[index] == 0)
                {
                    Console.WriteLine($"Place {index} already had Valentine's day.");
                    continue;
                }

                hoodArr[index] -= 2;

                if (hoodArr[index] == 0)
                {
                    Console.WriteLine($"Place {index} has Valentine's day.");
                }

            }
            Console.WriteLine($"Cupid's last position was {index}.");
            bool itIs = false;
            int counte = 0;
            for (int i = 0; i < hoodArr.Length; i++)
            {
                if (hoodArr[i] != 0)
                {
                    counte++;
                    itIs = true;
                }
            }
            if (itIs)
            {
                Console.WriteLine($"Cupid has failed {counte} places.");
            }
            else
            {
                Console.WriteLine($"Mission was successful.");
            }
        }


    }
}
