using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> gasStation = new Queue<int[]>();
            for (int i = 0; i < n; i++)
            {
                gasStation.Enqueue(Console.ReadLine().Split().Select(int.Parse).ToArray());
            }

            for (int i = 0; i < n; i++)
            {
                int fuel = 0;
                bool isFuelEnough = true;

                for (int j = 0; j < gasStation.Count; j++)
                {
                    var curent = gasStation.Dequeue();
                    gasStation.Enqueue(curent);

                    fuel += curent[0];
                    fuel -= curent[1];

                    if (fuel < 0)
                    {
                        isFuelEnough = false;
                    }
                }

                gasStation.Enqueue(gasStation.Dequeue());
                
                if (isFuelEnough)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
        }
    }
}
