using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Age> ageList = new List<Age>();
            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] comandArgs = comand.Split();
                string name = comandArgs[0]; 
                string id = comandArgs[1]; 
                int age = int.Parse(comandArgs[2]);

                Age person = new Age(name,id,age);
                ageList.Add(person);

                comand = Console.ReadLine();
            }
            ageList = ageList.OrderBy(x => x.Ages).ToList();

            foreach (Age item in ageList)
            {
                Console.WriteLine($"{item.Name} with ID: {item.ID} is {item.Ages} years old.");
            }
        }
    }

    class Age
    {
        public Age(string name, string iD, int age)
        {
            Name = name;
            ID = iD;
            Ages = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Ages { get; set; }


    }
}
