using System;

namespace _10.MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int startNum = int.Parse(Console.ReadLine());

            if (startNum > 10)
            {
                int sum = startNum * n;
                Console.WriteLine($"{n} X {startNum} = {sum}");
            }
            else
            {

                for (int i = startNum; i <= 10; i++)
                {
                    int sum = i * n;
                    Console.WriteLine($"{n} X {i} = {sum}");
                }
            }


        }
    }
}
