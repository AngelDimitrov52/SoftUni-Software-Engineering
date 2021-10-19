using System;
using System.Collections.Generic;

namespace _04.MatchingBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string brackets = Console.ReadLine();

            Stack<int> index = new Stack<int>();

            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == '(')
                {
                    index.Push(i);
                }
                else if (brackets[i] == ')')
                {
                    int startIndex = index.Pop();
                    Console.WriteLine(brackets.Substring(startIndex, i - startIndex + 1));
                }
            }
        }
    }
}
