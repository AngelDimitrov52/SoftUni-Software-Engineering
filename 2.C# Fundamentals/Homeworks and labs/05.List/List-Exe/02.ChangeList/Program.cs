using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> changeList = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();
            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] camandAgrs = comand.Split();
                string doing = camandAgrs[0];
                int element = int.Parse(camandAgrs[1]);

                if (doing == "Delete")
                {
                    changeList.RemoveAll(n=> n == element);
                }
                else if (doing == "Insert")
                {
                    int index = int.Parse(camandAgrs[2]);
                    changeList.Insert(index,element);
                }




                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", changeList));
        }
    }
}
