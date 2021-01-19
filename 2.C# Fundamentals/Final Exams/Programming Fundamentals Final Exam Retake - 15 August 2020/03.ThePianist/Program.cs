using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, List<string>> peaces = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] Args = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string peace = Args[0];
                string cmposer = Args[1];
                string key = Args[2];

                peaces.Add(peace, new List<string> { cmposer, key });
            }
            string comand;
            while ((comand = Console.ReadLine())!= "Stop")
            {
                string[] comandArgs = comand.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];
                string piece = comandArgs[1];

                if (cmd == "Add")
                {
                    string composer = comandArgs[2];
                    string key = comandArgs[3];
                    if (!peaces.ContainsKey(piece))
                    {
                        peaces.Add(piece, new List<string> { composer, key });
                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{ piece} is already in the collection!");
                    }

                }
                else if (cmd == "Remove")
                {
                    if (peaces.ContainsKey(piece))
                    {
                        peaces.Remove(piece);
                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }

                }
                else if (cmd == "ChangeKey")
                {
                    string newKey = comandArgs[2];
                    if (peaces.ContainsKey(piece))
                    {
                        peaces[piece][1] = newKey;
                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            foreach (var item in peaces.OrderBy(x=>x.Key).ThenBy(x=>x.Value[0]))
            {
                Console.WriteLine($"{item.Key} -> Composer: {item.Value[0]}, Key: {item.Value[1]}");
            }
        }
    }
}
