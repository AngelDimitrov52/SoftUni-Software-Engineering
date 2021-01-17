using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Stack<int> stackNumbers = new Stack<int>(numbers);

            string comand;
            while ((comand = Console.ReadLine()).ToLower() != "end")
            {

                string[] comandArgs = comand.Split();
                string cmd = comandArgs[0].ToLower();
                int num1 = int.Parse(comandArgs[1]);

                if (cmd == "add")
                {
                    int num2 = int.Parse(comandArgs[2]);
                    stackNumbers.Push(num1);
                    stackNumbers.Push(num2);
                }
                else if (cmd == "remove")
                {
                    if (num1 <= stackNumbers.Count)
                    {
                        for (int i = 0; i < num1; i++)
                        {
                            stackNumbers.Pop();
                        }
                    }
                }
            }
            Console.WriteLine($"Sum: {stackNumbers.Sum()}");
        }
    }
}
