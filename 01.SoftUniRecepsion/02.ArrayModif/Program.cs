using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ArrayModif
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            string[] comandArgs = Console.ReadLine().Split();

            while (comandArgs[0] != "end")
            {

                string comand = comandArgs[0];

                if (comand == "swap")
                {
                    int index1 = int.Parse(comandArgs[1]);
                    int index2 = int.Parse(comandArgs[2]);

                    int first = numberList[index1];
                    int two = numberList[index2];



                    numberList.Insert(index1, two);
                    numberList.RemoveAt(index1 + 1);

                    numberList.Insert(index2, first);
                    numberList.RemoveAt(index2 + 1);

                }
                else if (comand == "multiply")
                {
                    int index1 = int.Parse(comandArgs[1]);
                    int index2 = int.Parse(comandArgs[2]);

                    int sum = numberList[index1] * numberList[index2];

                    numberList.Insert(index1, sum);
                    numberList.RemoveAt(index1 +1);

                }
                else if (comand == "decrease")
                {
                    for (int i = 0; i < numberList.Count; i++)
                    {
                        numberList[i] -= 1;
                    }
                }
                comandArgs = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(", ", numberList));
        }
    }
}
