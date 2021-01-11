using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.ListManipolatorBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
             .Split(' ', StringSplitOptions.RemoveEmptyEntries)
             .Select(int.Parse)
             .ToList();

            string comand = Console.ReadLine().ToLower();

         

            while (comand != "end")
            {
                string[] comdAgr = comand.Split(" " , StringSplitOptions.RemoveEmptyEntries);
                int number1 = int.Parse(comdAgr[1]);

                if (comdAgr[0] == "add")
                {
                    numbersList.Add(number1);
                }
                else if (comdAgr[0] == "remove")
                {
                    numbersList.Remove(number1);
                }
                else if (comdAgr[0] == "removeat")
                {
                    numbersList.RemoveAt(number1);
                }
                else if (comdAgr[0] == "insert")
                {
                    int index = int.Parse(comdAgr[2]);
                    numbersList.Insert(index,number1);
                }
              
                comand = Console.ReadLine().ToLower();
            }
            Console.WriteLine(string.Join(" ",numbersList));
        }





    }
}

