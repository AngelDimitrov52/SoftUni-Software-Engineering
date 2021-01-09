using System;
using System.Linq;

namespace _01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string comand;
            while ((comand = Console.ReadLine()) != "Travel")
            {
                string[] comandArgs = comand.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string cmd = comandArgs[0];

                if (cmd == "Add Stop")
                {
                    int index = int.Parse(comandArgs[1]);
                    string wordString = comandArgs[2];
                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, wordString);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmd == "Remove Stop")
                {
                    int startIndex = int.Parse(comandArgs[1]);
                    int endindex = int.Parse(comandArgs[2]);
                    if (startIndex >= 0 && startIndex < stops.Length && endindex >= 0 && endindex < stops.Length)
                    {
                        stops = stops.Remove(startIndex, endindex - startIndex + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmd == "Switch")
                {
                    string oldString = comandArgs[1];
                    string newString = comandArgs[2];

                    stops = stops.Replace(oldString, newString);

                    Console.WriteLine(stops);
                }
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
