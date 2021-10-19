using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _03.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] calc = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Stack<string> calculator = new Stack<string>(calc.Reverse());


            while (calculator.Count != 1)
            {
                int first = int.Parse(calculator.Pop());
                string sing = calculator.Pop();
                int second = int.Parse(calculator.Pop());
                if (sing == "+")
                {
                    first += second;
                }
                else
                {
                    first -= second;
                }
                calculator.Push(first.ToString());
            }
            Console.WriteLine(calculator.Peek());


        }
    }
}
