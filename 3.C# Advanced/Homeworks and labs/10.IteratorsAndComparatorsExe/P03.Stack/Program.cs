using System;
using System.Linq;

namespace P03.Stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int[] elements = comand.Split(new string[] { " ", ", " },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).Skip(1).ToArray();
            MyStack<int> stack = new MyStack<int>(elements);

            while ((comand = Console.ReadLine()) != "END" )
            {
                string[] comandArgs = comand.Split();
                if (comandArgs[0] == "Pop")
                {
                    stack.Pop();
                }
                else if (comandArgs[0] == "Push")
                {
                    int element = int.Parse(comandArgs[1]);
                    stack.Push(element);
                }
            }
            Console.WriteLine(string.Join(Environment.NewLine , stack));
            Console.WriteLine(string.Join(Environment.NewLine , stack));
        }
    }
}
