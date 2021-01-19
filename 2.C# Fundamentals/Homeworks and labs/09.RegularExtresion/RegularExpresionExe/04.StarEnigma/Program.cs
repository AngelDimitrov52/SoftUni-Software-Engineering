using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Dictionary<string, List<string>> planes = new Dictionary<string, List<string>>();

            List<string> attacNames = new List<string>();
            List<string> destroedNames = new List<string>();
            planes.Add("Attacked", attacNames);
            planes.Add("Destroyed", destroedNames);


            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();
                string comandForForech = comand.ToLower();
                int counter = 0;
                foreach (var item in comandForForech)
                {
                    if (item == 's'|| item == 't'|| item == 'a'|| item == 'r')
                    {
                        counter++;
                    }
                }
                StringBuilder originalComand = new StringBuilder();
                foreach (var item in comand)
                {
                    char decriptChar = (char)(item - counter);
                    originalComand.Append(decriptChar);
                }
                string decript = originalComand.ToString();

                string pattern = @"@([A-Za-z]+)[^@\-!:>]*:([0-9]+)[^@\-!:>]*!(A?D?)!([^@\-!:>])*->([0-9]+)";
                Regex regex = new Regex(pattern);

                Match match = regex.Match(decript);
                if (match.Success)
                {
                    
                    if (match.Groups[3].Value == "A")
                    {
                        planes["Attacked"].Add(match.Groups[1].Value);
                    }
                    else
                    {
                        planes["Destroyed"].Add(match.Groups[1].Value);
                    }
                }

            }
            attacNames.Sort();
            destroedNames.Sort();
            foreach (var item in planes)
            {
                Console.WriteLine($"{item.Key} planets: {item.Value.Count}");

                foreach (var val in item.Value)
                {
                    Console.WriteLine($"-> {val}");
                }
            }
        }
    }
}
