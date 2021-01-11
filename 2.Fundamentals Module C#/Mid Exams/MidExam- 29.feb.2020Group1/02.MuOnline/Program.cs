using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int myHelt = 100;
            int myBitcoi = 0;


            string[] roomList = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < roomList.Length; i++)
            {
                string[] roomArgs = roomList[i].Split().ToArray();
                string comand = roomArgs[0];
                int amount = int.Parse(roomArgs[1]);

                if (comand == "potion")
                {
                    int he = 100 - myHelt;
                    myHelt += amount;
                    if (myHelt > 100)
                    {
                        amount = he;
                        myHelt = 100;
                    }  
                   
                    Console.WriteLine($"You healed for {amount} hp.");
                    Console.WriteLine($"Current health: {myHelt} hp.");
                }
                else if (comand == "chest")
                {
                    myBitcoi += amount;
                    Console.WriteLine($"You found {amount} bitcoins.");
                }
                else
                {
                    myHelt -= amount;
                    if (myHelt > 0)
                    {
                        Console.WriteLine($"You slayed {comand}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {comand}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                }

            }

            Console.WriteLine($"You've made it!");
                Console.WriteLine($"Bitcoins: {myBitcoi}");
                Console.WriteLine($"Health: {myHelt}");
        }
    }
}
