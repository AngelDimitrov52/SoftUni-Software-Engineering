using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IIdentifiable> Ids = new List<IIdentifiable>();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split();
                if (comandArgs.Length == 3)
                {
                    Ids.Add(new Citizen(comandArgs[0], int.Parse(comandArgs[1]), comandArgs[2]));
                }
                else
                {
                    Ids.Add(new Robot(comandArgs[0], comandArgs[1]));
                }
            }

            comand = Console.ReadLine();

            List<IIdentifiable> filter = Ids.Where(p => p.Id.EndsWith(comand)).ToList();
            foreach (var item in filter)
            {
                Console.WriteLine(item.Id);
            }

        }
    }
}
