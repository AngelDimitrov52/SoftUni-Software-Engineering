using System;
using System.Collections.Generic;

namespace GenericCountMethodStrings
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Box<double>> boxes = new List<Box<double>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                double value = double.Parse(Console.ReadLine());
                Box<double> box = new Box<double>(value);
                boxes.Add(box);
            }
            double element = double.Parse(Console.ReadLine());
            Console.WriteLine(GetCout(boxes, element));
        }
        public static int GetCout<T>(List<Box<T>> list, T element)
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
