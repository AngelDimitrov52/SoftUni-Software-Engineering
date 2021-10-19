using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>(0);

            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split(" -> ");
                string companyName = comandArgs[0];
                string id = comandArgs[1];

                List<string> idList = new List<string>();

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, idList);
                }
                bool isIn = companies[companyName].Contains(id);
                if (!isIn)
                {
                    companies[companyName].Add(id);
                }
            }

            foreach (var item in companies.OrderBy(x => x.Key))
            {
                Console.WriteLine(item.Key);

                foreach (var val in item.Value)
                {
                    Console.WriteLine($"-- {val}");
                }
            }



        }
    }
}
