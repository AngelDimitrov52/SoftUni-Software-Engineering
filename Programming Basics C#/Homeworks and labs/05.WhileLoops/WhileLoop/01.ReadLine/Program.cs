using System;

namespace _01.ReadLine
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = 0;

            while (a != "Stop")
            {n++;
                a = Console.ReadLine();
                
            }
            Console.WriteLine(n);
        }
    }
}
