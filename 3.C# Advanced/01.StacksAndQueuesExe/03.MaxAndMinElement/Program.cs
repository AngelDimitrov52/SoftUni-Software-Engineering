using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MaxAndMinElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Stack<int> playStack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int[] comand = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int cmd = comand[0];

                if (cmd == 1)
                {
                    int addNum = comand[1];
                    playStack.Push(addNum);
                }
                else if (cmd == 2)
                {
                        if (playStack.Count > 0)
                        {
                            playStack.Pop();
                        }
                }
                else if (cmd == 3)
                {
                    if (playStack.Count > 0)
                    {
                        Console.WriteLine(playStack.Max());
                    }
                }
                else if (cmd == 4)
                {
                    if (playStack.Count > 0)
                    {
                        Console.WriteLine(playStack.Min());
                    }
                }
            }
            Console.WriteLine(string.Join(", ",playStack));
        }
    }
}
