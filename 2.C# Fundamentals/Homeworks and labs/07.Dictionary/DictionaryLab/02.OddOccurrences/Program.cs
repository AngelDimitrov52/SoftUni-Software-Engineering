using System;
using System.Collections.Generic;

namespace _02.OddOccurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] wordsArr = Console.ReadLine()
                .Split();


            Dictionary<string, int> wordsDic = new Dictionary<string, int>();

            foreach (var item in wordsArr)
            {
                string toLower = item.ToLower();

                if (!wordsDic.ContainsKey(toLower))
                {
                    wordsDic.Add(toLower, 0);
                }
                wordsDic[toLower]++;
            }

            foreach (var item in wordsDic)
            {
                if (item.Value % 2 != 0)
                {
                    Console.Write($"{item.Key} ");
                }
            }



        }
    }
}
