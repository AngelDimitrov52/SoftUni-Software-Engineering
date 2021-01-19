using System;

namespace _05.AddSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int seconNum = int.Parse(Console.ReadLine());
            int thurtNum = int.Parse(Console.ReadLine());

            int sum = SumMetod(firstNum,seconNum,thurtNum);

            Console.WriteLine(sum);


        }

        private static int SumMetod(int firstNum, int seconNum, int thurtNum)
        {
            int sum = firstNum + seconNum;
            return SubstractMetod(sum,thurtNum);
        }

        private static int SubstractMetod(int sum, int thurtNum)
        {
            return sum - thurtNum;
        }
    }
}
