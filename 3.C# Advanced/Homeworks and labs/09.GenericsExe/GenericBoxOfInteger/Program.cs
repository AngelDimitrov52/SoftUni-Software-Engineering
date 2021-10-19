using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<int>> boxes = new List<Box<int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                Box<int> box = new Box<int>(value);
                boxes.Add(box);
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
