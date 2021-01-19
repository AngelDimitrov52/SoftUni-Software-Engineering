using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> trainList = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            int maxCapasiti = int.Parse(Console.ReadLine());

            string comand = Console.ReadLine();

            while (comand != "end")
            {
                string[] comandAgrg = comand.Split();

                if (comandAgrg[0] == "Add")
                {
                    int wagon = int.Parse(comandAgrg[1]);
                    trainList.Add(wagon);
                }
                else
                {
                    int pasajers = int.Parse(comandAgrg[0]);
                    for (int i = 0; i < trainList.Count; i++)
                    {


                        if (pasajers + trainList[i] <= maxCapasiti)
                        {
                            trainList[i] += pasajers;
                            break;
                        }

                    }
                }



                comand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", trainList));





        }
    }
}
