using System;

namespace _03.SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string a = Console.ReadLine();
            while (a!= "Stop")
            {
                sum += int.Parse(a);
                a = Console.ReadLine();

            }
            Console.WriteLine(sum);
        }
    }
}
