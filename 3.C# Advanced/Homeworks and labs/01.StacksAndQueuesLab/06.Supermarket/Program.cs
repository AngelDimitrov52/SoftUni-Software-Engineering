using System;
using System.Collections.Generic;

namespace _06.Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> clients = new Queue<string>();

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                if (comand == "Paid")
                {
                    Console.WriteLine(string.Join(Environment.NewLine, clients));
                    clients.Clear();
                }
                else
                {
                    clients.Enqueue(comand);
                }

            }
            Console.WriteLine($"{clients.Count} people remaining.");
        }
    }
}
