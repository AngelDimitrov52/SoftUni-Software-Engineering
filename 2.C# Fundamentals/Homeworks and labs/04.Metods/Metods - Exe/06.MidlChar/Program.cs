using System;

namespace _06.MidlChar
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = string.Empty;
            if (text.Length % 2 == 0)
            {
                result = GetMidlChars(text);

            }
            else
            {
                result = GetMidlOneChar(text);
            }
             
            Console.WriteLine(result);



        }

        private static string GetMidlOneChar(string text)
        {
            int index = text.Length / 2;
            string result = text.Substring(index, 1);
            return result;
        }

        private static string GetMidlChars(string text)
        {
            int index = text.Length / 2;
            string result = text.Substring(index - 1, 2);
            return result;
        }

        
        
    }
}
