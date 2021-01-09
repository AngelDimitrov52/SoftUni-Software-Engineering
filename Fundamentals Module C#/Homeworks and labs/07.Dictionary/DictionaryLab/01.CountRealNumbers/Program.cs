using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.WordFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            SortedDictionary<int, int> numDic = new SortedDictionary<int, int>();

            for (int i = 0; i < numArr.Length; i++)
            {
                if (!numDic.ContainsKey(numArr[i]))
                {
                    numDic.Add(numArr[i], 0);

                }
                numDic[numArr[i]]++;


            }
            foreach (var item in numDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }






        }
    }
}
