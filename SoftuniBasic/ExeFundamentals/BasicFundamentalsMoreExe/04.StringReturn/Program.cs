using System;

namespace _04.StringReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = text.Length-1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }


        }
    }
}
