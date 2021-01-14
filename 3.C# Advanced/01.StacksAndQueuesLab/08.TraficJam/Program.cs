using System;
using System.Collections.Generic;

namespace _08.TraficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> car = new Queue<string>();
            int count = 0;
            string comand;
            while ((comand = Console.ReadLine()) != "end")
            {
                if (comand == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (car.Count > 0)
                        {
                            Console.WriteLine($"{car.Dequeue()} passed!");
                            count++;
                        }
                    }
                }
                else
                {
                    car.Enqueue(comand);
                }
            }
            Console.WriteLine($"{count} cars passed the crossroads.");


        }
    }
}
