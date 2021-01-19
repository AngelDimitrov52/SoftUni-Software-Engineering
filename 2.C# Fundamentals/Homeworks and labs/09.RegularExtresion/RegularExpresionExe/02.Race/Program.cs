using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;

namespace _02.Race
{
    class Program
    {
        private static SerializationInfo patternName;

        static void Main(string[] args)
        {
            string[] racers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> racersDic = new Dictionary<string, int>();

            foreach (var item in racers)
            {
                racersDic.Add(item, 0);
            }

            string patterName = @"\d|\W";
            string patternDigit = @"\D";
            Regex regexName = new Regex(patterName);
            Regex regexDigit = new Regex(patternDigit);


            string comand = Console.ReadLine();

            while (comand != "end of race")
            {
                var nameRace = regexName.Replace(comand, "");

                if (racersDic.ContainsKey(nameRace))
                {
                    int sum = 0;
                    var distans = regexDigit.Replace(comand, "");
                    foreach (var item in distans)
                    {
                        sum += int.Parse(item.ToString());
                    }
                    racersDic[nameRace] += sum;
                }
                comand = Console.ReadLine();
            }
            int count = 1;
            foreach (var item in racersDic.OrderByDescending(x => x.Value))
            {
                string pleace = "";
                if (count == 1)
                {
                    pleace = "1st";
                }
                else if (count == 2)
                {
                    pleace = "2nd";
                }
                else if (count == 3)
                {
                    pleace = "3rd";
                }
                else
                {
                    break;
                }
                Console.WriteLine($"{pleace} place: {item.Key}");

                count++;

            }

        }
    }
}
