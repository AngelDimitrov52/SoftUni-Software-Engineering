using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Zad3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> emails = new Dictionary<string, List<string>>();

            string comand = Console.ReadLine();
            while (comand != "Statistics")
            {
                string[] comandArgs = comand.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string userName = comandArgs[1];

                if (cmd == "Add")
                {
                    if (emails.ContainsKey(userName))
                    {
                        Console.WriteLine($"{userName} is already registered");
                    }
                    else
                    {
                        emails.Add(userName, new List<string>());
                    }
                }
                else if (cmd == "Send")
                {
                    string email = comandArgs[2];
                    emails[userName].Add(email);
                }
                else if (cmd == "Delete")
                {
                    if (emails.ContainsKey((userName)))
                    {
                        emails.Remove(userName);
                    }
                    else
                    {
                        Console.WriteLine($"{userName} not found!");
                    }
                }
                comand = Console.ReadLine();
            }
            
            Console.WriteLine($"Users count: {emails.Count}");
            foreach (var item in emails.OrderByDescending(x=> x.Value.Count).ThenBy(x=>x.Key))
            {
                Console.WriteLine(item.Key);
                foreach (var val in item.Value)
                {
                    Console.WriteLine($" - {val}");
                }
            }
        }
    }
}
