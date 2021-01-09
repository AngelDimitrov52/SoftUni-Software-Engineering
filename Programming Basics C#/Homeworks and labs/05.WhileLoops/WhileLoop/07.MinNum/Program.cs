using System;

namespace _06.MaxNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxNum = int.MaxValue;
            for (int i = 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (maxNum > a)
                {
                    maxNum = a;
                }
            }
            Console.WriteLine(maxNum);




        }
    }
}
