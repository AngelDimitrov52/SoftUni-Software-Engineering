using System;
using System.Numerics;

namespace _11.SnowBalls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int bigSnowballSnow = 0;
            int bigsnowballTime = 0;
            int bigsnowballQuality = 0;
            BigInteger bigsnowballValue = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue >= bigsnowballValue)
                {
                    bigSnowballSnow = snowballSnow;
                    bigsnowballTime = snowballTime;
                    bigsnowballQuality = snowballQuality;
                    bigsnowballValue = snowballValue;

                }
            }
            Console.WriteLine($"{bigSnowballSnow} : {bigsnowballTime}" +
                $" = {bigsnowballValue} ({bigsnowballQuality})");
        }
    }
}
