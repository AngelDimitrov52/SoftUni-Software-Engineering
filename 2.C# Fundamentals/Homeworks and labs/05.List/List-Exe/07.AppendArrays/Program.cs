using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> basicList = Console.ReadLine()
                                     .Split('|', StringSplitOptions.RemoveEmptyEntries)
                                     .Reverse()
                                     .ToList();


            for (int i = 0; i < basicList.Count; i++)
            {
                List<string> digitList = basicList[i]
                                          .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToList();


                for (int j = 0; j < digitList.Count; j++)
                {

                    Console.Write($"{digitList[j]} ");


                }

            }
        }
    }
}
