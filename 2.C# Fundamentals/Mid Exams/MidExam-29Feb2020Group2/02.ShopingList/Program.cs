using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ShopingList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> productList = Console.ReadLine()
                .Split("!", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string comand;
            while ((comand = Console.ReadLine()) != "Go Shopping!")
            {
                string[] comandArgs = comand.Split();
                string com = comandArgs[0];
                string item = comandArgs[1];

                bool IsItExsist = productList.Contains(item);

                if (com == "Urgent")
                {
                    if (!IsItExsist)
                    {
                        productList.Insert(0, item);
                    }
                }
                else if (com == "Unnecessary")
                {
                    if (IsItExsist)
                    {
                        productList.Remove(item);
                    }
                }
                else if (com == "Correct")
                {
                    string second = comandArgs[2];
                    if (IsItExsist)
                    {
                        int where = productList.FindIndex(x => x == item);
                        productList.RemoveAt(where);
                        productList.Insert(where, second);
                    }
                }
                else if (com == "Rearrange")
                {
                    if (IsItExsist)
                    {
                        productList.Remove(item);
                        productList.Add(item);

                    }

                }


            }
            Console.WriteLine(string.Join(", ",productList));
        }
    }
}
