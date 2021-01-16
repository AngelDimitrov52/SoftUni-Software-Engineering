using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int queantity = int.Parse(Console.ReadLine());
            int[] clients = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> orders = new Queue<int>(clients);

            int bestClient = int.MinValue;

            for (int i = 0; i < clients.Length; i++)
            {
                int client = orders.Dequeue();
                if (bestClient < client)
                {
                    bestClient = client;
                }
                orders.Enqueue(client);
            }
            Console.WriteLine(bestClient);

            bool flag = false;

            int count = orders.Count;
            for (int i = 0; i < count; i++)
            {
                int client = orders.Dequeue();
                if (queantity < client)
                {
                    flag = true;
                    break;
                }
                queantity -= client;
            }
            if (flag == false)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                Console.WriteLine(string.Join(" ",orders));
            }
        }
    }
}
