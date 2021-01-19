using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\+([359]+)([-| ])2(\2)(\d{3})(\2)(\d{4})\b";

            string text = Console.ReadLine();

            MatchCollection regTect = Regex.Matches(text, pattern);

            var machReg = regTect.Cast<Match>().Select(v => v.Value).ToArray();

            Console.WriteLine(string.Join(", ",machReg));
       


        }
    }
}
