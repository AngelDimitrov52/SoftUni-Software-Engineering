using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = @"(\@|\#)([A-Za-z]{3,})\1\1([A-Za-z]{3,})\1";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(text);

            List<string> mirros = new List<string>();

            foreach (Match item in matches)
            {
                string secondWord = item.Groups[3].ToString();
                string rever = item.Groups[2].ToString();
                string reversWord = string.Empty;
                for (int i = rever.Length - 1; i >= 0; i--)
                {
                    reversWord += rever[i];
                }
                if (reversWord == secondWord)
                {
                    string addWord = rever + " " + "<=>" + " " + secondWord;
                    mirros.Add(addWord);
                }
            }
            if (matches.Count == 0)
            {
                Console.WriteLine("No word pairs found!");

            }
            else if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");

            }
            if (mirros.Count == 0)
            {
                Console.WriteLine("No mirror words!");
            }
            else
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", mirros));
            }

        }
    }
}
