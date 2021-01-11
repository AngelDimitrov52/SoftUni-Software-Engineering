using System;
using System.Text.RegularExpressions;

namespace _06.ExtractEmail
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>([A-Z][A-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regex = new Regex(pattern);

            string comand = comand = Console.ReadLine();

            double sum = 0;

            Console.WriteLine("Bought furniture:");
            while (comand != "Purchase")
            {
                Match match = regex.Match(comand);

                if (match.Success)
                {
                    Console.WriteLine(match.Groups[1].Value);
                    double price = double.Parse(match.Groups[2].Value.ToString());
                    int quntity = int.Parse(match.Groups[3].Value.ToString());
                    sum += price * quntity;
                }


                comand = comand = Console.ReadLine();
            }
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
