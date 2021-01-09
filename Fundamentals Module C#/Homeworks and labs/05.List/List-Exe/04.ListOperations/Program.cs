using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                 .Select(int.Parse)
                                 .ToList();

            string comand = Console.ReadLine();

            while (comand != "End")
            {
                string[] comandArgs = comand.Split();

                string toDo = comandArgs[0];


                if (toDo == "Add")
                {
                    numberList.Add(int.Parse(comandArgs[1]));
                }
                else if (toDo == "Insert")
                {
                    if (int.Parse(comandArgs[2]) > numberList.Count - 1 || int.Parse(comandArgs[2]) < 0)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numberList.Insert(int.Parse(comandArgs[2]), int.Parse(comandArgs[1]));

                    }
                }
                else if (toDo == "Remove")
                {
                    if (int.Parse(comandArgs[1]) > numberList.Count - 1 || int.Parse(comandArgs[1]) < 0)
                    {
                        Console.WriteLine("Invalid index");

                    }
                    else
                    {
                        numberList.RemoveAt(int.Parse(comandArgs[1]));

                    }
                }
                else if (toDo == "Shift")
                {
                    if (comandArgs[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(comandArgs[2]); i++)
                        {
                            int num = numberList[0];
                            numberList.Add(num);
                            numberList.RemoveAt(0);
                        }
                    }
                    else if (comandArgs[1] == "right")
                    {
                        for (int i = 0; i < int.Parse(comandArgs[2]); i++)
                        {
                            int num = numberList[numberList.Count - 1];
                            numberList.Insert(0, num);
                            numberList.RemoveAt(numberList.Count - 1);
                        }
                    }
                }


                comand = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
