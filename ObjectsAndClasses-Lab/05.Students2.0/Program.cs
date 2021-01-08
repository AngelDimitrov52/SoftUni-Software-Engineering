using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> studentList = new List<Students>();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] comandArg = comand.Split();

                string firstName = comandArg[0];
                string lastName = comandArg[1];
                int age = int.Parse(comandArg[2]);
                string homeTown = comandArg[3];

                Students student = studentList
                    .FirstOrDefault(x => x.FirstName == firstName && x.LastName == lastName);

                if (student == null)
                {
                    
                    studentList.Add(new Students(firstName, lastName, age, homeTown));
                }
                else
                {
                    student.FirstName = firstName;
                    student.LastName = lastName;
                    student.Age = age;
                    student.HomeTown = homeTown;
                }



                

                comand = Console.ReadLine();
            }
            string comand2 = Console.ReadLine();

            List<Students> filterList = studentList.Where(x => x.HomeTown == comand2).ToList();

            foreach (Students item in filterList)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is {item.Age} years old.");
            }


        }
    }
    class Students
    {
        public Students(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }

    }
}
