using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IBirthable> list = new List<IBirthable>();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split();
                string type = comandArgs[0];

                if (type == "Pet")
                {
                    list.Add(new Pet(comandArgs[1], comandArgs[2]));
                }
                else if (type == "Citizen")
                {
                    list.Add(new Citizen(comandArgs[1], int.Parse(comandArgs[2]), comandArgs[3], comandArgs[4]));
                }
            }
            comand = Console.ReadLine();

            List<IBirthable> filter = list.Where(p => p.Birthdate.EndsWith(comand)).ToList();

            foreach (var item in filter)
            {
                Console.WriteLine(item.Birthdate);
            }

        }
    }
}
