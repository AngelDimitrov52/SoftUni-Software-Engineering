using System;

namespace _06.StrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int n = number;
            int sum = 0;
            
            while (number != 0 )
            {
                int medicalsum = 1;
                int edinica = number % 10;
                for (int i = 1; i <= edinica; i++)
                {
                    medicalsum *= i;
                }
                sum += medicalsum;
                number /= 10;
            }
            if (sum == n)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            


        }
    }
}
