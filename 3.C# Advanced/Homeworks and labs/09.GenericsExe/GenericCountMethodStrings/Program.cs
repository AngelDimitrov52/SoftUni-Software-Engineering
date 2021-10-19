using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
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
            string element = Console.ReadLine();
            Console.WriteLine(GetCout(boxes, element));
        }
        public static int GetCout<T>(List<Box<T>> list , T element)
            where T : IComparable
        {
            int count = 0; 
            foreach (var item in list)
            {
                if (item.Value.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
