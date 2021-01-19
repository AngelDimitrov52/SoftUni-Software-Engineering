using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string comand;
            while ((comand=Console.ReadLine()) != "end")
            {
                string[] comandArgs = comand.Split(" : ",StringSplitOptions.RemoveEmptyEntries);
                string course = comandArgs[0];
                string studentName = comandArgs[1];

                if (!courses.ContainsKey(course))
                {
                    List<string> students = new List<string>();
                    courses.Add(course, students);
                }
                courses[course].Add(studentName);
            }
            foreach (var item in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{item.Key}: {item.Value.Count}");

                foreach (var val in item.Value.OrderBy(n=>n))
                {
                    Console.WriteLine($"-- {val}");
                }
            }
        }
    }
}
