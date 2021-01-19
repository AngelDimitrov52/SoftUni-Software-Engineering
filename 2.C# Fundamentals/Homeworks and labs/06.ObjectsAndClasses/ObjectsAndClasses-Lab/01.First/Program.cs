using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.First
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> textList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Random rnd = new Random();
            int textCount = textList.Count;

            for (int i = 0; i < textCount; i++)
            {
                
               int j = rnd.Next(0, textList.Count);
                if (i != j)
                {
                    var old = textList[i];
                    textList[i] = textList[j];
                    textList[j] = old;
                }

               
                
            }
            Console.WriteLine(string.Join(Environment.NewLine, textList));
            
        }
    }
}
