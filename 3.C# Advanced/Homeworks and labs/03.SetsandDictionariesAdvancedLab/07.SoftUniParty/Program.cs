using System;
using System.Collections.Generic;

namespace _07.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> members = new HashSet<string>();

            string comand;
            while ((comand = Console.ReadLine()) != "PARTY")
            {
                members.Add(comand);
            }
            while ((comand = Console.ReadLine()) != "END")
            {
                members.Remove(comand);
            }
            Console.WriteLine(members.Count);
            foreach (var item in members)
            {
                char[] ch = item.ToCharArray();
                if (char.IsDigit(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
            foreach (var item in members)
            {
                char[] ch = item.ToCharArray();
                if (char.IsLetter(ch[0]))
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
