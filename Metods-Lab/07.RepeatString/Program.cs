using System;
using System.Text;

namespace _07.RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
           
            Console.WriteLine(RepeatText(text, n));



        }

        static string RepeatText(string text, int n)
        {
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                newText.Append (text);
            }
            return newText.ToString();
        }
    }
}
