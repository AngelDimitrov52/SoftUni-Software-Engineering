using System;
using System.Text;

namespace _04.CeaserCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder cript = new StringBuilder();


            for (int i = 0; i < text.Length; i++)
            {
                char a = (char)(text[i] + 3);
                cript.Append(a);
            }
            Console.WriteLine(cript.ToString());
        }
    }
}
