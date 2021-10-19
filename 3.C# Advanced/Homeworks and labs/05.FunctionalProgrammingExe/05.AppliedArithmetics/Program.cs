using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nubers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            Dictionary<string, Func<int, int>> funcs = new Dictionary<string, Func<int, int>>();
            funcs.Add("add", n => n + 1);
            funcs.Add("multiply", n => n * 2);
            funcs.Add("subtract", n => n - 1);

            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                if (comand == "print")
                {
                    Console.WriteLine( string.Join(" ",nubers));
                }
                else
                {
                   nubers = nubers.Select(funcs[comand]).ToList();
                }
            }

        }
    }
}
