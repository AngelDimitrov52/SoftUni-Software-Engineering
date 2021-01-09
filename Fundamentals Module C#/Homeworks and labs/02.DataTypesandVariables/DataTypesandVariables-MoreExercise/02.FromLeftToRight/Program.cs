using System;

namespace _02.FromLeftToRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string numbers = Console.ReadLine();
                string[] words = numbers.Split();

                long numerOne = long.Parse(words[0]);
                long numberTwo = long.Parse(words[1]);

                long bigestNum = 0L;
                if (numerOne > numberTwo)
                {
                    bigestNum = numerOne;
                }
                else
                {
                    bigestNum = numberTwo;
                }
                long sum = 0;
                while (bigestNum != 0)
                {
                    sum += bigestNum % 10;
                    
                    bigestNum /= 10;
                }
                Console.WriteLine(Math.Abs(sum));
            }
        }
    }
}
