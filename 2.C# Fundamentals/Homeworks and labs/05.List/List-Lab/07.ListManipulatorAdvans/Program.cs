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
            bool willPrint = false;


            while (comand != "end")
            {
                string[] comdAgr = comand.Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (comdAgr[0] == "add")
                {
                    int number1 = int.Parse(comdAgr[1]);
                    numbersList.Add(number1);
                    willPrint = true;
                }
                else if (comdAgr[0] == "remove")
                {
                    int number1 = int.Parse(comdAgr[1]);
                    numbersList.Remove(number1);
                    willPrint = true;
                }
                else if (comdAgr[0] == "removeat")
                {
                    int number1 = int.Parse(comdAgr[1]);
                    numbersList.RemoveAt(number1);
                    willPrint = true;
                }
                else if (comdAgr[0] == "insert")
                {
                    int number1 = int.Parse(comdAgr[1]);
                    int index = int.Parse(comdAgr[2]);
                    numbersList.Insert(index, number1);
                    willPrint = true;
                }


                else if (comdAgr[0] == "contains")
                {
                    int number1 = int.Parse(comdAgr[1]);
                    bool ItisHere = numbersList.Contains(number1);
                    if (ItisHere)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (comdAgr[0] == "printeven")
                {
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] % 2 == 0)
                        {
                            Console.Write($"{numbersList[i]} ");
                        }
                    }
                    Console.WriteLine();

                }
                else if (comdAgr[0] == "printodd")
                {
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        if (numbersList[i] % 2 != 0)
                        {
                            Console.Write($"{numbersList[i]} ");
                        }
                    }
                    Console.WriteLine();
                }

                else if (comdAgr[0] == "getsum")
                {
                    Console.WriteLine(numbersList.Sum());
                }

                else if (comdAgr[0] == "filter")
                {
                    string condition = comdAgr[1];
                    int number = int.Parse(comdAgr[2]);
                    string result = String.Empty;
                    if (condition == "<")
                    {
                        result= string.Join(" ", numbersList.Where(n => n < number));
                        
                    }
                    else if (condition == ">")
                    {
                        result = string.Join(" ", numbersList.Where(n => n > number));
                    }
                    else if (condition == ">=")
                    {
                        result = string.Join(" ", numbersList.Where(n => n >= number));
                    }
                    else if (condition == "<=")
                    {
                        result = string.Join(" ", numbersList.Where(n => n <= number));
                    }
                    Console.WriteLine(result);
                }





                comand = Console.ReadLine().ToLower();
            }
            if (willPrint == true)
            {
                Console.WriteLine(string.Join(" ", numbersList));

            }
        }





    }
}

