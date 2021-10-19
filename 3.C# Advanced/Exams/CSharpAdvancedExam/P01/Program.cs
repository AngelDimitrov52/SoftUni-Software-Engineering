using System;
using System.Collections.Generic;
using System.Linq;

namespace P01
{
    class Program
    {
        static void Main(string[] args)
        {
            int orcCount = int.Parse(Console.ReadLine());
            Queue<int> walls = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            Queue<Stack<int>> orcArmy = new Queue<Stack<int>>();
            for (int i = 1; i <= orcCount; i++)
            {
                Stack<int> first = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
                orcArmy.Enqueue(first);

                if (i % 3 == 0)
                {
                    int n = int.Parse(Console.ReadLine());
                    walls.Enqueue(n);
                }
            }

            while (walls.Count > 0 && orcArmy.Count != 0)
            {
                int wall = walls.Peek();
                Stack<int> orcPover = orcArmy.Dequeue();

                while (orcPover.Count != 0)
                {
                    int orc = orcPover.Peek();
                    if (wall > orc)
                    {
                        wall -= orc;
                        orcPover.Pop();

                    }
                    else if (wall == orc)
                    {
                        wall = 0;
                        orcPover.Pop();
                        walls.Dequeue();
                    }
                    else
                    {
                        orc -= wall;
                        wall = 0;

                        orcPover.Pop();
                        orcPover.Push(orc);
                        walls.Dequeue();
                    }
                    if (wall == 0)
                    {

                        if (walls.Count == 0)
                        {
                            orcArmy.Enqueue(orcPover);
                            break;
                        }
                        wall = walls.Peek();
                    }
                }
            }

            if (orcArmy.Count > 0)
            {
                int[] print = orcArmy.Last().ToArray();
                Console.WriteLine($"The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: {string.Join(", ", print)}");
            }
            else
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: {string.Join(", ", walls)}");
            }


        }
    }
}
