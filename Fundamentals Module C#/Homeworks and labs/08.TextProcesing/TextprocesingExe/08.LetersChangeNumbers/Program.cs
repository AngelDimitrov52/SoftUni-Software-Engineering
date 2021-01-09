using System;
using System.Linq;

namespace _08.LetersChangeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in words)
            {
                bool isValid = item.Length >= 3 && item.Length <= 16 &&
                    item.All(x => char.IsLetterOrDigit(x)) ||
                    item.Contains("-") || item.Contains("_");
                if (isValid)
                {
                    Console.WriteLine(item);
                }



            }


        }
    }
}
