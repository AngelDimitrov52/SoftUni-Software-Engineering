using System;

namespace NumberOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            string a = "";
            if (operation == '+')
            { double sum = n1 + n2;
                if (sum % 2 == 0)
                {
                    a = "even";
                }
                else
                {
                    a = "odd";
                }

                Console.WriteLine($"{n1} + {n2} = {sum} - {a}");
            }
            else if (operation == '-')
            {
                double sum = n1 - n2;
                if (sum % 2 == 0)
                {
                    a = "even";
                }
                else
                {
                    a = "odd";
                }

                Console.WriteLine($"{n1} - {n2} = {sum} - {a}");
            }
            else if (operation == '*')
            {
                double sum = n1 * n2;
                if (sum % 2 == 0)
                {
                    a = "even";
                }
                else
                {
                    a = "odd";
                }

                Console.WriteLine($"{n1} * {n2} = {sum} - {a}");
            }
            if (operation == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double sum = n1 * 1.0 / n2;
                    Console.WriteLine($"{n1} / {n2} = {sum:f2}");
                }
            }
            if (operation == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    double sum = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {sum}");
                }
            }
        }
    }
}
