using System;
using System.Text.RegularExpressions;

namespace _02.Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(.+)(>)(\d+)\|([a-z]{2,})\|([A-Z]{2,})\|([ -;=?-}]{2,})(<)(\1)$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string comand = Console.ReadLine();

                Match match = regex.Match(comand);
                if (match.Success)
                {
                    Console.WriteLine("Password: "+ match.Groups[3]+match.Groups[4]+match.Groups[5]+match.Groups[6]);
                }
                else
                {
                    Console.WriteLine("Try another password!");
                }
            }
        }
    }
}
