using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CountSameValuesinArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> studentsDic = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < n; i++)
            {
                string[] students = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = students[0];
                decimal grade = decimal.Parse(students[1]);

                if (!studentsDic.ContainsKey(name))
                {
                    studentsDic.Add(name, new List<decimal>());
                }
                studentsDic[name].Add(grade);
            }
            foreach (var student in studentsDic)
            {
                Console.Write($"{student.Key} -> ");

                foreach (var grade in student.Value)
                {
                    Console.Write($"{grade:f2} ");
                }
                Console.WriteLine($"(avg: { student.Value.Average():f2})");
            }

        }
    }
}
