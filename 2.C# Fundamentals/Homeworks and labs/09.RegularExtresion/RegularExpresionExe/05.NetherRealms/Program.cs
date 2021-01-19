using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] demons = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"[\+,\-\*\/0-9\.]";
            Regex regexHelt = new Regex(pattern);
            string patternpower = @"(\-|\+)*([0-9]+\.)*[0-9]+";
            Regex regexPower = new Regex(patternpower);

            Dictionary<string, List<double>> demonsDic = new Dictionary<string, List<double>>();

            foreach (var demonName in demons)
            {
                var matchDemon = regexHelt.Replace(demonName, "");
                int helt = 0;
                foreach (var digit in matchDemon)
                {
                    helt += digit;
                }
                List<double> valueList = new List<double>();
                valueList.Add(helt);
                demonsDic.Add(demonName, valueList);

                double dimige = 0;
                MatchCollection matchnums = regexPower.Matches(demonName);
                foreach (Match item in matchnums)
                {
                    dimige += double.Parse(item.ToString());
                }
                string pattern1 = @"\*";
                Regex regex1 = new Regex(pattern1);
                MatchCollection poilideleno = regex1.Matches(demonName);

                foreach (Match item in poilideleno)
                {
                    dimige *= 2;
                }

                string pattern2 = @"\/";
                Regex regex2 = new Regex(pattern2);
                MatchCollection poilideleno2 = regex2.Matches(demonName);

                foreach (Match item in poilideleno2)
                {
                    dimige /= 2;
                }
                demonsDic[demonName].Add(dimige);
            }
            foreach (var item in demonsDic.OrderBy(k => k.Key))
            {
                Console.WriteLine($"{item.Key} - {item.Value[0]} health, {item.Value[1]:f2} damage");
            }

        }
    }
}
