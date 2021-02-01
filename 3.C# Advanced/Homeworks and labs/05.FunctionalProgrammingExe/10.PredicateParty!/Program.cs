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
            Func<List<string>, HashSet<string>, List<string>> doublePeople = (a, b) =>
            {
                foreach (string doubled in b)
                {
                    for (int i = 0; i < a.Count * 2; i++)
                    {
                        if (i < a.Count)
                        {
                            if (a[i] == doubled)
                            {
                                a.Insert(i, doubled);
                                i++;
                            }
                        }
                    }
                    
                }

                return a;
            };
            HashSet<string> filterPeople = new HashSet<string>();
            string comand;
            while ((comand = Console.ReadLine()) != "Party!")
            {
                string[] comandArgs = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string critery = comandArgs[1];
                string index = comandArgs[2];

                if (critery == "StartsWith")
                {             
                    filterPeople = peoples.Where(n => n.StartsWith(index)).ToHashSet();
                }

                else if (critery == "EndsWith")
                {   
                    filterPeople = peoples.Where(n =>n.EndsWith(index)).ToHashSet();
                }

                else if (critery == "Length")
                {
                    int indexx = int.Parse(index);
                    filterPeople = peoples.Where(n => n.Length == indexx).ToHashSet();
                }

                if (cmd == "Remove")
                {
                    peoples = peoples.Where(n => !filterPeople.Contains(n)).ToList();
                }

                else if (cmd == "Double")
                {
                    peoples = doublePeople(peoples, filterPeople);
                }
            }

            if (peoples.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", peoples)} are going to the party!");
            }
            else
            {
                Console.WriteLine($"Nobody is going to the party!");
            }



        }
    }
}
