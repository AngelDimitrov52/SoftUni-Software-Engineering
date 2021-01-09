using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> targetList = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToList();
            string comand;
            while ((comand = Console.ReadLine()) != "End")
            {
                string[] comandArgs = comand.Split();
                string com = comandArgs[0];
                int index = int.Parse(comandArgs[1]);
                int value = int.Parse(comandArgs[2]);

                if (com == "Shoot")
                {
                    if (index < 0 || index >= targetList.Count)
                    {
                        continue;
                    }
                    else
                    {
                        targetList[index] -= value;
                        if (targetList[index] <= 0)
                        {
                            targetList.RemoveAt(index);
                        }
                    }
                }
                else if (com == "Add")
                {
                    if (index < 0 || index >= targetList.Count)
                    {
                        Console.WriteLine("Invalid placement!");
                        

                    }
                    else
                    {
                        targetList.Insert(index, value);
                    }

                }
                else if (com == "Strike")
                {
                    int start = index - value;
                    int end = index + value;
                    if (start < 0 || end >= targetList.Count)
                    {
                        Console.WriteLine("Strike missed!");
                       
                    }
                    else
                    {
                        targetList.RemoveRange(start, value * 2 + 1);
                    }



                }


            }
            Console.WriteLine(string.Join("|", targetList));
        }
    }
}
