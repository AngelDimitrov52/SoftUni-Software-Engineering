﻿using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            int sum =(int) Math.Ceiling( (double)n / p);

            Console.WriteLine(sum);
        }
    }
}
