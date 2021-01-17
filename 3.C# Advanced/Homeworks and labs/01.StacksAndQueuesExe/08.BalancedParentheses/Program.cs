using System;
using System.Collections.Generic;

namespace _08.BalancedParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> open = new Stack<char>();

            bool flag = true;

            foreach (char item in input)
            {
                if (input.Length % 2 != 0)
                {
                    flag = false;
                    break;
                }

                if (item == '[' || item == '{' || item == '(')
                {
                    open.Push(item);
                }
                else
                {
                    if (item == ']' && open.Pop() != '[')
                    {
                        flag = false;
                    }
                    else if (item == ')' && open.Pop() != '(')
                    {
                        flag = false;
                    }
                    else if (item == '}' && open.Pop() != '{')
                    {
                        flag = false;
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
