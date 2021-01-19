using System;
using System.Text;

namespace _06.ReplceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder doneTect = new StringBuilder();

            for (int i = 0; i < text.Length-1 ; i++)
            {
                if (text[i] != text[i + 1])
                {
                    doneTect.Append(text[i]);
                }
            }
            doneTect.Append(text[text.Length - 1]);
           
            Console.WriteLine(doneTect.ToString());
        }
    }
}
