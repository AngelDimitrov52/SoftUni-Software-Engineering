using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _02.DestnationMapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(=|\/)([A-Z][A-Za-z]{2,})(\1)";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection matches = regex.Matches(text);

            int count = 0;
            List<string> destinations = new List<string>();
            foreach (Match item in matches)
            {
                destinations.Add(item.Groups[2].ToString());
                count += item.Groups[2].Length;
            }
            Console.Write("Destinations: ");
            Console.WriteLine(string.Join(", ",destinations));
            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
