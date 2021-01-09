using System;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+\b \b[A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchnames = Regex.Matches(names, pattern);

            foreach (var item in matchnames)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
