using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MemoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int count = 0;
            string comand;

            while ((comand = Console.ReadLine()) != "end")
            {
                string[] comandAgrs = comand.Split();
                int indexOne = int.Parse(comandAgrs[0]);
                int indexTwo = int.Parse(comandAgrs[1]);

                count++;

                bool oneTwo = indexOne == indexTwo;
                bool onetrue = indexOne < 0 || indexOne >= stringList.Count;
                bool twotrue = indexTwo < 0 || indexTwo >= stringList.Count;

                if (oneTwo || onetrue || twotrue)
                {
                    string elementToAdd = "-" + count + "a";
                    int index = (stringList.Count / 2);
                    stringList.Insert(index, elementToAdd);
                    stringList.Insert(index, elementToAdd);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    continue;
                }

                string first = stringList[indexOne];
                string second = stringList[indexTwo];

                bool IsItCorect = first == second;

                if (IsItCorect)
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {first}!");
                    stringList.Remove(first);
                    stringList.Remove(second);
                }
                else if (!IsItCorect)
                {
                    Console.WriteLine("Try again!");
                }
                if (stringList.Count == 0)
                {
                    Console.WriteLine($"You have won in {count} turns!");
                    return;
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", stringList));
        }
    }
}
