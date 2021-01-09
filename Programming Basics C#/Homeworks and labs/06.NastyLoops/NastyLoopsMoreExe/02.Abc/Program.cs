using System;

namespace _02.Abc
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            int counter = 0;
            for (char i = a; i <= b; i++)
            {
                for (char j = a;  j <= b;  j++)
                {
                    for (char h = a; h <= b; h++)
                    {
                        if (i != c && j!= c && h != c)
                        {
                            counter++;
                        Console.Write($"{i}{j}{h} ");
                        }

                    }

                }

            }
            Console.Write(counter);


        }
    }
}
