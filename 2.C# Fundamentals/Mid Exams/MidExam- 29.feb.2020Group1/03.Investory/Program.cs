using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Investory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventoryList = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string com;
            while ((com = Console.ReadLine()) != "Craft!")
            {
                string[] comandArgs = com.Split(" - ", StringSplitOptions.RemoveEmptyEntries);
                string comand = comandArgs[0];
                string item = comandArgs[1];

                if (comand == "Collect")
                {
                    bool isItIn = inventoryList.Contains(item);
                    if (!isItIn)
                    {
                        inventoryList.Add(item);
                    }
                }
                else if (comand == "Drop")
                {
                    bool isItIn = inventoryList.Contains(item);
                    if (isItIn)
                    {
                        inventoryList.Remove(item);
                    }
                }
                else if (comand == "Combine Items")
                {
                    string[] combine = item.Split(":");
                    string old = combine[0];
                    string newItem = combine[1];

                    bool isItIn = inventoryList.Contains(old);
                    if (isItIn)
                    {
                        int count = inventoryList.FindIndex(x => x == old);
                        inventoryList.Insert(count + 1, newItem);
                    }
                }
                else if (comand == "Renew")
                {
                    bool isItIn = inventoryList.Contains(item);

                    if (isItIn)
                    {
                        int count = inventoryList.FindIndex(x => x == item);
                        inventoryList.Add(item);
                        inventoryList.RemoveAt(count);
                    }


                }



            }

            Console.WriteLine(string.Join(", ",  inventoryList));




        }
    }
}
