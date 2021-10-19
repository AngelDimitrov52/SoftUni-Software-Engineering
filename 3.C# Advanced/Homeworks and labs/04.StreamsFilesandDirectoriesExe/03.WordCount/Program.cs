using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = File.ReadAllLines("../../../words.txt");
            Dictionary<string, int> wordsDic = new Dictionary<string, int>();

            foreach (var item in words)
            {
                wordsDic.Add(item, 0);
            }

            string[] text = File.ReadAllText("../../../text.txt").ToLower()
                .Split(new string[] { " ", ",", ".", "!", "?", "-",Environment.NewLine },
                StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in text)
            {
                if (wordsDic.ContainsKey(item))
                {
                    wordsDic[item]++;
                }
            }
            foreach (var item in wordsDic)
            {
                string output = $"{item.Key} - {item.Value}";
                File.AppendAllText("../../../actualResult.txt", output + Environment.NewLine);
            }
            foreach (var item in wordsDic.OrderByDescending(x => x.Value))
            {
                string output = $"{item.Key} - {item.Value}";
                File.AppendAllText("../../../expectedResult.txt", output + Environment.NewLine);
            }

        }
    }
}
