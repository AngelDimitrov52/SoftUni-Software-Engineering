using System;
using System.Text;

namespace _02.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            StringBuilder conkatenatoinWords = new StringBuilder();

            foreach (var item in words)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    conkatenatoinWords.Append(item);
                }

            }
            Console.WriteLine(conkatenatoinWords);



        }
    }
}
