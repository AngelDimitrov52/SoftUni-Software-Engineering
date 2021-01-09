using System;

namespace _03.EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double evenMax = int.MinValue;
            double evenMin = int.MaxValue;
            double evenSum = 0;
            double oddMax = int.MinValue;
            double oddMin = int.MaxValue;
            double oddSum = 0;

            for (int i = 1; i <= n; i += 2)
            {
                double oddnum = double.Parse(Console.ReadLine());
                if (oddnum > oddMax)
                {
                    oddMax = oddnum;
                }
                if (oddnum < oddMin)
                {
                    oddMin = oddnum;
                }
                oddSum += oddnum;

                if (i != n)
                {



                    for (int j = 2; j <= n; j += 2)
                    {
                        double evennum = double.Parse(Console.ReadLine());
                        if (evennum > evenMax)
                        {
                            evenMax = evennum;
                        }
                        if (evennum < evenMin)
                        {
                            evenMin = evennum;
                        }
                        evenSum += evennum;
                        break;
                    }
                }

            }

            
                Console.WriteLine($"OddSum={oddSum:f2},");
                if (oddMin == int.MaxValue)
                {
                    Console.WriteLine("OddMin=No,");
                }
                else
                {
                    Console.WriteLine($"OddMin={oddMin:f2},");
                }
                if (oddMax == int.MinValue)
                {
                    Console.WriteLine("OddMax=No,");
                }
                else
                {
                    Console.WriteLine($"OddMax={oddMax:f2},");
                }
                Console.WriteLine($"EvenSum={evenSum:f2},");
                if (evenMin == int.MaxValue)
                {
                    Console.WriteLine("EvenMin=No,");
                }
                else
                {
                    Console.WriteLine($"EvenMin={evenMin:f2},");
                }
                if (evenMax == int.MinValue)
                {
                    Console.WriteLine("EvenMax=No");
                }
                else
                {
                    Console.WriteLine($"EvenMax={evenMax:f2}");
                }


        }
    }
}
