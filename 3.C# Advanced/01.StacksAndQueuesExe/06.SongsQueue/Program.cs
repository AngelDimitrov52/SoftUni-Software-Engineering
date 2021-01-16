using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] startSongs = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries);
            Queue<string> songs = new Queue<string>(startSongs);

            while (songs.Any())
            {
                string comand = Console.ReadLine();

                if (comand.Contains("Add"))
                {
                    comand = comand.Remove(0, 4);
                    if (!songs.Contains(comand))
                    {
                        songs.Enqueue(comand);
                    }
                    else
                    {
                        Console.WriteLine($"{comand} is already contained!");
                    }
                }
                else if (comand == "Play")
                {
                    songs.Dequeue();
                }
                else if (comand == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }
            }
            Console.WriteLine("No more songs!");

        }
    }
}
