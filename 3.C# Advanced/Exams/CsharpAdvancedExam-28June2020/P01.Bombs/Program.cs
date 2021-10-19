using System;
using System.Collections.Generic;
using System.Linq;

namespace P02.Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> bombEfect = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());
            Stack<int> bombCasing = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray());

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            bool isDone = false;

            while (bombEfect.Count != 0 && bombCasing.Count != 0)
            {
                int efect = bombEfect.Peek();
                int casing = bombCasing.Pop();
                int sum = efect + casing;

                if (sum != 40 && sum != 60 && sum != 120)
                {
                    bombCasing.Push(casing - 5);
                    continue;
                }

                if (sum == 40)
                {
                    datura++;

                }
                else if (sum == 60)
                {
                    cherry++;
                }
                else if (sum == 120)
                {
                    smoke++;
                }
                bombEfect.Dequeue();

                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    isDone = true;
                    break;
                }
            }
            if (isDone)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (bombEfect.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {string.Join(", ", bombEfect)}");
            }

            if (bombCasing.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {string.Join(", ", bombCasing)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
