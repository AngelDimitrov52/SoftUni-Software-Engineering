using System;
using System.Text.RegularExpressions;

namespace _03.SoftUniBar
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%([A-z][a-z]+)%[^|$%\.]*?<(\w+)>[^|$%\.]*?\|(\d+)\|[^|$%\.]*?(\d+\.?\d*)\$";
            Regex regex = new Regex(pattern);

            double totamPrice = 0;

            string comand;
            while ((comand = Console.ReadLine()) != "end of shift")
            {
                Match match = regex.Match(comand);
                if (match.Success)
                {
                    string costumer = match.Groups[1].Value;
                    string product = match.Groups[2].Value;
                    int quntity = int.Parse(match.Groups[3].Value.ToString());
                    double price = double.Parse(match.Groups[4].Value.ToString());
                    double sumPrice = quntity * price;
                    totamPrice += sumPrice;
                    Console.WriteLine($"{costumer}: {product} - {sumPrice:F2}");

                }


            }
            Console.WriteLine($"Total income: {totamPrice:f2}");


        }
    }
}
