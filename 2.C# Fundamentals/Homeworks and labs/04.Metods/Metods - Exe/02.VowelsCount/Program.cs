using System;

namespace _02.VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();

            PrintHowMuchIs(text);


        }

        private static void PrintHowMuchIs(string text)
        {
            int counter = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] =='a' || text[i] == 'u' || text[i] == 'o' || text[i] == 'y'|| text[i] == 'e' || text[i] == 'i')
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
