using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> peoples = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string comand;
            while ((comand = Console.ReadLine()) != "Party!")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string critery = comandArgs[1];

                if (critery == "StartsWith")
                {
                    string index = comandArgs[2];
                    if (cmd == "Remove")
                    {
                        peoples = peoples.Where(n => !n.StartsWith(index)).ToList();
                    }
                    else if (cmd == "Double")
                    {
                        string[] doubles = peoples.Where(n => n.StartsWith(index)).ToArray();
                        peoples.AddRange(doubles);
                    }
                }
                else if (critery == "EndsWith")
                {
                    string index = comandArgs[2];
                    if (cmd == "Remove")
                    {
                        peoples = peoples.Where(n => !n.EndsWith(index)).ToList();
                    }
                    else if (cmd == "Double")
                    {
                        string[] doubles = peoples.Where(n => n.EndsWith(index)).ToArray();
                        peoples.AddRange(doubles);
                    }
                }
                else if (critery == "Length")
                {
                    int index = int.Parse(comandArgs[2]);
                    if (cmd == "Remove")
                    {
                        peoples = peoples.Where(n => n.Length == index).ToList();
                    }
                    else if (cmd == "Double")
                    {
                        string[] doubles = peoples.Where(n => n.Length == index).ToArray();
                        peoples.AddRange(doubles);
                    }
                }

            }
            Console.WriteLine(string.Join(", ", peoples.OrderBy(n=>n)));
        }
    }
}
