using System;
using System.Collections.Generic;
using System.Linq;

namespace P01.Scheduling
{
    class Program
    {
     
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries
                ).Select(int.Parse).ToArray());
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries
                ).Select(int.Parse).ToArray());

            int killThisTash = int.Parse(Console.ReadLine());

            while (true)
            {
                int thisThread = threads.Peek();
                int thisTask = tasks.Peek();

                if (thisTask == killThisTash)
                {
                    Console.WriteLine($"Thread with value {thisThread} killed task {killThisTash}");
                    break;
                }

                if (thisThread >= thisTask)
                {     
                    threads.Dequeue();
                    tasks.Pop();         
                }
                else
                {
                    threads.Dequeue();
                }
            }
            Console.WriteLine(string.Join(" ", threads));
        }
    }
}
