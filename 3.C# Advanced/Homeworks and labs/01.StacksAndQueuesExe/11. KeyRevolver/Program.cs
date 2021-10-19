using System;
using System.Collections.Generic;
using System.Linq;

namespace _11._KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrce = int.Parse(Console.ReadLine());
            int sizeReloding = int.Parse(Console.ReadLine());
            int[] bulets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int cashForBulets = int.Parse(Console.ReadLine());

            Stack<int> locksValue = new Stack<int>(locks.Reverse());
            Queue<int> buetsValue = new Queue<int>(bulets.Reverse());

            int countReloding = 0;
            int countOfBulets = 0;
            while (locksValue.Any())
            {
                countOfBulets++;
                countReloding++;
                int firstlock = locksValue.Pop();
                int firstBulet = buetsValue.Dequeue();

                if (firstlock >= firstBulet)
                {
                    Console.WriteLine("Bang!");
                }
                else
                {
                    locksValue.Push(firstlock);
                    Console.WriteLine("Ping!");
                }

                if (buetsValue.Count == 0)
                {
                    break;
                }

                if (countReloding == sizeReloding)
                {
                    Console.WriteLine("Reloading");
                    countReloding = 0;
                }
            }
            if (locksValue.Count > 0)
            {
                int loscksLeft = countOfBulets * cashForBulets;
                Console.WriteLine($"Couldn't get through. Locks left: {locksValue.Count}");
            }
            else
            {
                int money = countOfBulets * bulletPrce;
                cashForBulets -= money;
                Console.WriteLine($"{buetsValue.Count} bullets left. Earned ${cashForBulets}");
            }
        }
    }
}
