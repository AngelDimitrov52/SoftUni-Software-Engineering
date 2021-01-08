using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _02.FencyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\@\#+([A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match matchBarcode = regex.Match(barcode);

                if (matchBarcode.Success)
                {
                    string patternNum = @"\d";
                    Regex regexNum = new Regex(patternNum);

                    string midBar = matchBarcode.Groups[1].ToString();
                    MatchCollection numbers = regexNum.Matches(midBar);
                    midBar = "";
                    foreach (var item in numbers)
                    {
                        midBar += item;
                    }
                    if (midBar == "")
                    {
                        midBar = "00";
                    }
                        Console.WriteLine($"Product group: {midBar}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
