using System;
using System.Linq;

namespace _03.CountUppercaseWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, bool> filter = x => x[0] == x.ToUpper()[0];

            string[] upperWords = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Where(filter)
                 .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine,upperWords));
                
        }
    }
}
