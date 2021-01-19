using System;
using System.Collections.Generic;

namespace _01.CountCharsInSting
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] texts = Console.ReadLine().Split();

            Dictionary<char, int> textDic = new Dictionary<char, int>(); 

            foreach (var item in texts)
            {

                foreach (char digit in item)
                {
                    if (!textDic.ContainsKey(digit))
                    {
                        textDic.Add(digit, 0);
                    }
                    textDic[digit]++;
                }


            }
            foreach (var item in textDic)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
