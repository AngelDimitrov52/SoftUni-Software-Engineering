using System;

namespace _03.ExtraktFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] road = Console.ReadLine().Split("\\", StringSplitOptions.RemoveEmptyEntries);

            string[] fileName = road[road.Length - 1].Split(".");
            Console.WriteLine($"File name: {fileName[0]}");
            Console.WriteLine($"File extension: {fileName[1]}");
        }
    }
}
