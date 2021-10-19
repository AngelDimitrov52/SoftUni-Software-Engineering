using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, IBuyer> members = new Dictionary<string, IBuyer>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split();

                if (data.Length == 3)
                {
                    members[data[0]] = new Rebel(data[0], int.Parse(data[1]), data[2]);
                }
                else
                {
                    members[data[0]] = new Citizen(data[0], int.Parse(data[1]), data[2], data[3]);
                }
            }

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                if (members.ContainsKey(comand))
                {
                    members[comand].BuyFood();
                }
            }

            int foodSum = members.Sum(p => p.Value.Food);
            Console.WriteLine(foodSum);
        }
    }
}
