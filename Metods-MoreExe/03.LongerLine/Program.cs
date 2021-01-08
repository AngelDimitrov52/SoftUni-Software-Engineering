using System;

namespace _03.LongerLine
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal oneOne = decimal.Parse(Console.ReadLine());
            decimal oneTwo = decimal.Parse(Console.ReadLine());

            decimal twoOne = decimal.Parse(Console.ReadLine());
            decimal twoTwo = decimal.Parse(Console.ReadLine());

            decimal trreOne = decimal.Parse(Console.ReadLine());
            decimal trreTwo = decimal.Parse(Console.ReadLine());

            decimal fourOne = decimal.Parse(Console.ReadLine());
            decimal fourTwo = decimal.Parse(Console.ReadLine());

            decimal first = HowITheBigLine(oneOne, oneTwo, twoOne, twoTwo);
            decimal second = HowITheBigLine(trreOne, trreTwo, fourOne, fourTwo);

            if (first >= second)
            {
                if (twoOne + twoTwo >= oneOne + oneTwo)
                {
                    Console.WriteLine($"({twoOne}, {twoTwo})({oneOne}, {oneTwo})");

                }
                else
                {
                    Console.WriteLine($"({oneOne}, {oneTwo})({twoOne}, {twoTwo})");
                }


            }
            else
            {
                if (fourOne + fourTwo >= trreOne + trreTwo)
                {
                    Console.WriteLine($"({fourOne}, {fourTwo})({trreOne}, {trreTwo})");

                }
                else
                {
                    Console.WriteLine($"({trreOne}, {trreTwo})({fourOne}, {fourTwo})");
                }
                
            }



        }

        private static decimal HowITheBigLine(decimal oneOne, decimal oneTwo, decimal twoOne, decimal twoTwo)
        {
            decimal firstSum = Math.Abs(oneOne) + Math.Abs(oneTwo);
            decimal secondSum = Math.Abs(twoOne) + Math.Abs(twoTwo);

            decimal sum = firstSum + secondSum;
            return sum;


        }
    }
}
