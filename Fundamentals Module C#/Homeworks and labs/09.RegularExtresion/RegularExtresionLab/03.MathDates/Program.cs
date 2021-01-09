using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.MathDates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(?<day>\d{2})([-.\/])(?<mount>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string dates = Console.ReadLine();

            var matchDates = Regex.Matches(dates, pattern);

            foreach (Match item in matchDates)
            {
                var day = item.Groups["day"].Value;
                var mount = item.Groups["mount"].Value;
                var year = item.Groups["year"].Value;
                Console.WriteLine($"Day: {day}, Month: {mount}, Year: {year}");
            }

        }
    }
}
