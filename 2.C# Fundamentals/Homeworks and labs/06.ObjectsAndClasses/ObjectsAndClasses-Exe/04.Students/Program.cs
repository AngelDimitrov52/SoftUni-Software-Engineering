using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Students> studentsList = new List<Students>();

            for (int i = 0; i < n; i++)
            {
                string[] comandArgs = Console.ReadLine().Split();
                string firstName = comandArgs[0];
                string lastName = comandArgs[1];
                double grade = double.Parse(comandArgs[2]);

                Students student = new Students(firstName,lastName,grade);
                studentsList.Add(student);
            }

         studentsList = studentsList.OrderBy(x => x.Grade).ToList();
            studentsList.Reverse();

            foreach (Students item in studentsList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}: {item.Grade:f2}");
            }


        }
    }

    class Students
    {
        public Students(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }


    }
}
