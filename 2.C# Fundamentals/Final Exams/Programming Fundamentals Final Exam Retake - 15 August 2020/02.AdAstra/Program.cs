using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(\#|\|)([a-zA-z ]+)\1([0-9]{2}\/[0-9]{2}\/[0-9]{2})\1(\d+)\1";
            Regex regex = new Regex(pattern);

            string text = Console.ReadLine();

            MatchCollection maches = regex.Matches(text);

            int caloriesSum = 0;
            foreach (Match item in maches)
            {
                 caloriesSum += int.Parse(item.Groups[4].ToString());   
            }
            
            caloriesSum /= 2000;
            Console.WriteLine($"You have food to last you for: {caloriesSum} days!");

            foreach (Match item in maches)
            {
                Console.WriteLine($"Item: {item.Groups[2]}, Best before: {item.Groups[3]}, Nutrition: {item.Groups[4]}");
            }
        }
    }
}
