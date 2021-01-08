using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02.EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string patternnum = @"[0-9]";
            Regex nuRegex = new Regex(patternnum);
            var nums = nuRegex.Matches(text);
            int sumNums = 1;
            foreach (var item in nums)
            {
                sumNums *= int.Parse(item.ToString());
            }
            Console.WriteLine($"Cool threshold: {sumNums}");

            string pattern = @"(:{2}|\*{2})([A-Z][a-z]{2,})(\1)";
            Regex emojiregex = new Regex(pattern);

            MatchCollection emojis = emojiregex.Matches(text);
            Console.WriteLine($"{emojis.Count} emojis found in the text. The cool ones are:");

            List<string> coolEmojis = new List<string>();

            foreach (Match emoji in emojis)
            {
                int sum = 0;

                string patternEmoji = @"\w+";
                Regex emojiFiltRegex = new Regex(patternEmoji);
                Match emojiFilt = emojiFiltRegex.Match(emoji.ToString());

                string digit = emojiFilt.ToString();
                var digits = digit.ToCharArray().Sum(x => (char)x);
                
              
                if (digits >= sumNums)
                {
                    coolEmojis.Add(emoji.ToString());
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, coolEmojis));




        }
    }
}
