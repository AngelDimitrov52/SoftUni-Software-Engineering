using System;

namespace _10.LowerOrUp
{
    class Program
    {
        static void Main(string[] args)
        {
            char simbyl = char.Parse(Console.ReadLine());

            if (char.IsLower(simbyl))
            {
                Console.WriteLine("lower-case");
            }
            else
            {
                Console.WriteLine("upper-case");
            }


        }
    }
}
