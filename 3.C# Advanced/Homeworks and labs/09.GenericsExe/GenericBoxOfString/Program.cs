using System;
using System.Collections.Generic;

namespace GenericBoxOfString
{
   public class Program
    {
        static void Main(string[] args)
        {
            List<Box<string>> boxes = new List<Box<string>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string value = Console.ReadLine();
                Box<string> box = new Box<string>(value);
                boxes.Add(box);
            }

            foreach (var box in boxes)
            {
                Console.WriteLine(box);
            }
        }
    }
}
