using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))";
            Regex rgex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection match = rgex.Matches(text);


            foreach (Match item in match)
            { 
                    Console.WriteLine(item);
                
            }
        }
    }
}
