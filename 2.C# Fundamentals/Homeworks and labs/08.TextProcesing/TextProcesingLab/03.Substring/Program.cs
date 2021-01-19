using System;
using System.Linq;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string firsWord = Console.ReadLine();
            string secondString = Console.ReadLine();

            int index = secondString.IndexOf(firsWord);

            while (index != -1)
            {
                secondString = secondString.Remove(index, firsWord.Length);
                index = secondString.IndexOf(firsWord);

            }
           
            Console.WriteLine(secondString);



        }
    }
}
