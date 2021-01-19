using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArr = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

            double medicalSum = 0;
            for (int i = 0; i < numberArr.Length; i++)
            {
                medicalSum += numberArr[i];
            }
            medicalSum /= (numberArr.Length - 1);


            List<int> sortList = new List<int>(5);
        
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] >= medicalSum)
                {
                    sortList.Add(numberArr[i]);
                    
                }
            }
            if (sortList.Count == 0)
            {
                Console.WriteLine("No");
                return;
            }
            sortList.Sort();
            sortList.Reverse();

            int count = 0;


            for (int i = 0; i < sortList.Count; i++)
            {
                Console.Write($"{sortList[i]} ");
                count++;
                if (count == 5)
                {
                    break;
                }
            }


        }
    }
}
