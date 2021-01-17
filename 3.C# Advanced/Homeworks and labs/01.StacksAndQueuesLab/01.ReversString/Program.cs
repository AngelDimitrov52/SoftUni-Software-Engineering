using System;
using System.Collections.Generic;

namespace _01.ReversString
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Stack<char> reversText = new Stack<char>();
            for (int i = 0; i <= text.Length-1; i++)
            {
                reversText.Push(text[i]);
            }
            while (reversText.Count!=0)
            {
                Console.Write(reversText.Pop());
            }
        }
    }
}
